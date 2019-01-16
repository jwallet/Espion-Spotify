﻿using EspionSpotify.AudioSessions;
using EspionSpotify.Models;
using EspionSpotify.Spotify;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EspionSpotify
{
    public class SpotifyProcess: ISpotifyProcess
    {
        private const string Spotify = "Spotify";

        private readonly int? _spotifyProcessId;
        private readonly ISpotifyAudioSession _spotifyAudioSession;

        public SpotifyProcess(ISpotifyAudioSession spotifyAudioSession)
        {
            _spotifyAudioSession = spotifyAudioSession;
            _spotifyProcessId = GetSpotifyProcesses().FirstOrDefault(x => !string.IsNullOrEmpty(x.MainWindowTitle))?.Id;
        }

        public ISpotifyStatus GetSpotifyStatus()
        {
            var isSpotifyPlaying = _spotifyAudioSession.IsSpotifyCurrentlyPlaying();
            var processTitle = GetSpotifyTitle();

            if (string.IsNullOrWhiteSpace(processTitle))
            {
                return null;
            }

            var spotifyWindowInfo = new SpotifyWindowInfo
            {
                WindowTitle = processTitle,
                IsPlaying = isSpotifyPlaying
            };

            return new SpotifyStatus(spotifyWindowInfo);
        }

        private string GetSpotifyTitle()
        {
            if (!_spotifyProcessId.HasValue)
            {
                return null;
            }

            string mainWindowTitle = null;

            try
            {
                var process = Process.GetProcessById(_spotifyProcessId.Value);
                mainWindowTitle = process.MainWindowTitle;
            }
            catch (Exception) { }

            return mainWindowTitle;
        }

        public static ICollection<Process> GetSpotifyProcesses()
        {
            var spotifyProcesses = new List<Process>();

            foreach (var process in Process.GetProcesses())
            {
                if (process.ProcessName.ToLowerInvariant().Equals(Spotify.ToLowerInvariant()))
                {
                    spotifyProcesses.Add(process);
                }
            }

            return spotifyProcesses;
        }
    }
}
