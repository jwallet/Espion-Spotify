﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using TagLib;
using File = System.IO.File;

namespace EspionSpotify
{
    internal class Mp3TagsInfo
    {
        public string CurrentFile { get; set; }
        public int Compteur { get; set; }
        public bool BCdTrack { get; set; }
        public Song Song { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }


        private readonly string[] _apiKey = { "c117eb33c9d44d34734dfdcafa7a162d", "01a049d30c4e17c1586707acf5d0fb17", "82eb5ead8c6ece5c162b461615495b18" };

        public void SetTagLibDataToMp3()
        {
            if (!SetTagLibDataToMp3WithSpotiry())
            {
                SetTagLibDataToMp3WithAudioScrobbler();
            }
        }

        private void SetTagLibDataToMp3WithAudioScrobbler()
        {
            var mp3 = TagLib.File.Create(CurrentFile);

            var numTrackAlbum = -1;
            string albumTitle = null;
            var style = "";

            // add known tags
            if (BCdTrack) mp3.Tag.Track = (uint)Compteur;
            mp3.Tag.Title = Song.Title;
            mp3.Tag.AlbumArtists = new[] { Song.Artist };
            mp3.Tag.Performers = new[] { Song.Artist };
#pragma warning disable 618
            mp3.Tag.Artists = new[] { Song.Artist };
#pragma warning restore 618

            // call api to get other tags
            var api = new XmlDocument();
            var artist = PCLWebUtility.WebUtility.UrlEncode(Song.Artist);
            var title = PCLWebUtility.WebUtility.UrlEncode(Song.Title);
            var apiKey = _apiKey[FrmEspionSpotify.Rnd.Next(3)];

            try
            {
                api.Load(
                    $"http://ws.audioscrobbler.com/2.0/?method=track.getInfo&api_key={apiKey}&artist={artist}&track={title}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var apiReturn = api.DocumentElement;

            if (apiReturn != null)
            {
                var xmlNumTrackAlbum = apiReturn.SelectNodes("/lfm/track/album/@position");
                if (xmlNumTrackAlbum != null && xmlNumTrackAlbum.Count != 0)
                    numTrackAlbum = Convert.ToInt32(xmlNumTrackAlbum[0].InnerXml);
                var xmlAlbumTitle = apiReturn.SelectNodes("/lfm/track/album/title");
                if (xmlAlbumTitle != null && xmlAlbumTitle.Count != 0)
                    albumTitle = xmlAlbumTitle[0].InnerXml;
                var xmlStyle = apiReturn.SelectNodes("/lfm/track/toptags/tag/name");
                if (xmlStyle != null && xmlStyle.Count != 0)
                    style = xmlStyle[0].InnerXml;
            }

            if (numTrackAlbum != -1) mp3.Tag.Track = (uint)numTrackAlbum;
            mp3.Tag.Album = albumTitle ?? Song.Album;
            mp3.Tag.Genres = new[] { style };

            if (File.Exists(CurrentFile)) mp3.Save();

            Picture extraLargePicture = null;
            Picture largePicture = null;
            var mediumPicture = new Picture();
            var smallPicture = new Picture();

            if (apiReturn != null)
            {
                var xmlAlbumArt = apiReturn.SelectNodes("/lfm/track/album/image[@size='extralarge']");
                if (xmlAlbumArt != null && xmlAlbumArt.Count != 0)
                {
                    var x = GetAlbumCover(xmlAlbumArt[0].InnerXml);
                    extraLargePicture = x;
                }
                xmlAlbumArt = apiReturn.SelectNodes("/lfm/track/album/image[@size='large']");
                if (xmlAlbumArt != null && xmlAlbumArt.Count != 0)
                {
                    var x = GetAlbumCover(xmlAlbumArt[0].InnerXml);
                    largePicture = x;

                }
                xmlAlbumArt = apiReturn.SelectNodes("/lfm/track/album/image[@size='medium']");
                if (xmlAlbumArt != null && xmlAlbumArt.Count != 0)
                {
                    var x = GetAlbumCover(xmlAlbumArt[0].InnerXml);
                    if (x != null) mediumPicture = x;
                }
                xmlAlbumArt = apiReturn.SelectNodes("/lfm/track/album/image[@size='small']");
                if (xmlAlbumArt != null && xmlAlbumArt.Count != 0)
                {
                    var x = GetAlbumCover(xmlAlbumArt[0].InnerXml);
                    if (x != null) smallPicture = x;
                }
            }

            if (extraLargePicture == null)
            {
                extraLargePicture = Song.GetArtExtraLarge() ?? new Picture();
            }
            if (largePicture == null)
            {
                largePicture = Song.GetArtLarge() ?? new Picture();
            }

            mp3.Tag.Pictures = new IPicture[4] { extraLargePicture, largePicture, mediumPicture, smallPicture };

            if (File.Exists(CurrentFile)) mp3.Save();

            mp3.Dispose();
        }

        internal bool SetTagLibDataToMp3WithSpotiry()
        {
            if (string.IsNullOrEmpty(ClientId) || string.IsNullOrEmpty(ClientSecret)) return false;

            using (var mp3 = TagLib.File.Create(CurrentFile))
            {
                var tag = mp3.Tag;
                var webApi = CreateSpotifyWebApi();

                if (!string.IsNullOrEmpty(Song.TrackId))
                {
                    var track = GetFullTrack(webApi);

                    if (track == null) return false;

                    // track settings
                    tag.Title = track.Name;
                    tag.Track = (uint) track.TrackNumber;
                    tag.Performers = track.Artists.Select(a => a.Name).ToArray();
                    tag.Disc = (uint) track.DiscNumber;
                    tag.Comment = track.Uri;

                    // album settings - optional
                    var album = GetFullAlbum(webApi, track.Album.Id);
                    if (album != null)
                    {
                        tag.AlbumArtists = album.Artists.Select(a => a.Name).ToArray();
                        tag.Album = album.Name;
                        tag.Genres = album.Genres.ToArray();
                        if (uint.TryParse(album.ReleaseDate?.Substring(0, 4), out var year))
                        {
                            tag.Year = year;
                        }

                        if (album.Images.Count > 0)
                        {
                            var pictures = new List<IPicture>();
                            foreach (var albumImage in album.Images)
                            {
                                pictures.Add(GetAlbumCover(albumImage.Url));
                            }

                            tag.Pictures = pictures.ToArray();
                        }
                    }

                    if (File.Exists(CurrentFile)) mp3.Save();

                    return true;
                }
            }

            return false;
        }

        private FullTrack GetFullTrack(SpotifyWebAPI spotifyWebApi)
        {
            var track = spotifyWebApi.GetTrack(Song.TrackId);
            return track.HasError() ? null : track;
        }

        private FullAlbum GetFullAlbum(SpotifyWebAPI spotifyWebApi, string albumId)
        {
            var album = spotifyWebApi.GetAlbum(albumId);
            return album.HasError() ? null : album;
        }

        private SpotifyWebAPI CreateSpotifyWebApi()
        {
            var auth = new ClientCredentialsAuth()
            {
                ClientId = ClientId,
                ClientSecret = ClientSecret,
                Scope = Scope.None,
            };
            //With this token object, we now can make calls
            var token = auth.DoAuth();
            return new SpotifyWebAPI()
            {
                TokenType = token.TokenType,
                AccessToken = token.AccessToken,
                UseAuth = true
            };
        }

        private static Picture GetAlbumCover(string link)
        {
            if (link == "") return null;
            var request = WebRequest.Create(link);
            using (var response = request.GetResponse().GetResponseStream())
            {
                if (response == null) return null;
                using (var reader = new BinaryReader(response))
                {
                    using (var memory = new MemoryStream())
                    {
                        var buffer = reader.ReadBytes(4096);
                        while (buffer.Length > 0)
                        {
                            memory.Write(buffer, 0, buffer.Length);
                            buffer = reader.ReadBytes(4096);
                        }
                        return new Picture
                        {
                            Type = PictureType.FrontCover,
                            MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg,
                            Description = "Cover",
                            Data = memory.ToArray()
                        };
                    }
                }
            }
        }
    }
}
