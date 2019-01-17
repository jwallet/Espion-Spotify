﻿using MetroFramework.Controls;
using MetroFramework.Forms;

namespace EspionSpotify
{
    sealed partial class FrmEspionSpotify
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEspionSpotify));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tcMenu = new MetroFramework.Controls.MetroTabControl();
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.lnkDirectory = new MetroFramework.Controls.MetroLink();
            this.lnkClear = new MetroFramework.Controls.MetroLink();
            this.lblSoundCard = new MetroFramework.Controls.MetroLabel();
            this.lblVolume = new MetroFramework.Controls.MetroLabel();
            this.iconVolume = new MetroFramework.Controls.MetroPanel();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlayingTitle = new MetroFramework.Controls.MetroLabel();
            this.iconSpotify = new System.Windows.Forms.Panel();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tlSettings = new System.Windows.Forms.TableLayoutPanel();
            this.lblLanguage = new MetroFramework.Controls.MetroLabel();
            this.lblBitRate = new MetroFramework.Controls.MetroLabel();
            this.lblPath = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lnkPath = new MetroFramework.Controls.MetroLink();
            this.txtPath = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMinTime = new MetroFramework.Controls.MetroLabel();
            this.lblFormat = new MetroFramework.Controls.MetroLabel();
            this.lblMinLength = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.rbWav = new MetroFramework.Controls.MetroRadioButton();
            this.rbMp3 = new MetroFramework.Controls.MetroRadioButton();
            this.lblAds = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tgDisableAds = new MetroFramework.Controls.MetroToggle();
            this.lblDisableAds = new MetroFramework.Controls.MetroLabel();
            this.lblMuteAds = new MetroFramework.Controls.MetroLabel();
            this.tgMuteAds = new MetroFramework.Controls.MetroToggle();
            this.lblAudioDevice = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.tlAdvanced = new System.Windows.Forms.TableLayoutPanel();
            this.lblSpy = new MetroFramework.Controls.MetroLabel();
            this.lblRecorder = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tgRecordUnkownTrackType = new MetroFramework.Controls.MetroToggle();
            this.lblEndingSongDelay = new MetroFramework.Controls.MetroLabel();
            this.lblRecordUnknownTrackType = new MetroFramework.Controls.MetroLabel();
            this.tgEndingSongDelay = new MetroFramework.Controls.MetroToggle();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecordingNum = new MetroFramework.Controls.MetroLabel();
            this.tgAddSeparators = new MetroFramework.Controls.MetroToggle();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lnkNumPlus = new MetroFramework.Controls.MetroLink();
            this.lnkNumMinus = new MetroFramework.Controls.MetroLink();
            this.lblNum = new MetroFramework.Controls.MetroLabel();
            this.tgNumFiles = new MetroFramework.Controls.MetroToggle();
            this.lblAddSeparators = new MetroFramework.Controls.MetroLabel();
            this.tgNumTracks = new MetroFramework.Controls.MetroToggle();
            this.tgAddFolders = new MetroFramework.Controls.MetroToggle();
            this.lblNumFiles = new MetroFramework.Controls.MetroLabel();
            this.lblAddFolders = new MetroFramework.Controls.MetroLabel();
            this.lblNumTracks = new MetroFramework.Controls.MetroLabel();
            this.lblDuplicateAlreadyRecordedTrack = new MetroFramework.Controls.MetroLabel();
            this.tgDuplicateAlreadyRecordedTrack = new MetroFramework.Controls.MetroToggle();
            this.lblRecordingTimer = new MetroFramework.Controls.MetroLabel();
            this.txtRecordingTimer = new System.Windows.Forms.MaskedTextBox();
            this.tabFAQ = new System.Windows.Forms.TabPage();
            this.tlFAQ = new System.Windows.Forms.TableLayoutPanel();
            this.lblTrackDetectedAsAd = new System.Windows.Forms.Label();
            this.lblBackgroundNoiceRecordedOnTrack = new System.Windows.Forms.Label();
            this.lblAdAndTrackOverlapOnRecordedTrack = new System.Windows.Forms.Label();
            this.lblAdsPlayAndStop = new System.Windows.Forms.Label();
            this.lblSpotifyTrackCut = new System.Windows.Forms.Label();
            this.lblSpotifyLostFeatures = new System.Windows.Forms.Label();
            this.lnkSpy = new MetroFramework.Controls.MetroLink();
            this.tip = new MetroFramework.Components.MetroToolTip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lnkRelease = new MetroFramework.Controls.MetroLink();
            this.tbVolumeWin = new EspionSpotify.Controls.MetroTrackBar();
            this.cbBitRate = new EspionSpotify.Controls.MetroComboBox();
            this.cbLanguage = new EspionSpotify.Controls.MetroComboBox();
            this.tbMinTime = new EspionSpotify.Controls.MetroTrackBar();
            this.cbAudioDevices = new EspionSpotify.Controls.MetroComboBox();
            this.tlSpotifyTrackCut = new EspionSpotify.Controls.MetroTile();
            this.tlAdsPlayAndStop = new EspionSpotify.Controls.MetroTile();
            this.tlAdAndTrackOverlapOnRecordedTrack = new EspionSpotify.Controls.MetroTile();
            this.tlBackgroundNoiceRecordedOnTrack = new EspionSpotify.Controls.MetroTile();
            this.tlTrackDetectedAsAd = new EspionSpotify.Controls.MetroTile();
            this.tlSpotifyLostFeatures = new EspionSpotify.Controls.MetroTile();
            this.tcMenu.SuspendLayout();
            this.tabRecord.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tlSettings.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.tlAdvanced.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabFAQ.SuspendLayout();
            this.tlFAQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Veuillez sélectionner l\'emplacement où vous souhaitez sauvegarder les fichiers au" +
    "dio.";
            // 
            // tcMenu
            // 
            this.tcMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcMenu.Controls.Add(this.tabRecord);
            this.tcMenu.Controls.Add(this.tabSettings);
            this.tcMenu.Controls.Add(this.tabAdvanced);
            this.tcMenu.Controls.Add(this.tabFAQ);
            this.tcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMenu.HotTrack = true;
            this.tcMenu.ItemSize = new System.Drawing.Size(100, 34);
            this.tcMenu.Location = new System.Drawing.Point(20, 60);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 3;
            this.tcMenu.Size = new System.Drawing.Size(740, 340);
            this.tcMenu.Style = MetroFramework.MetroColorStyle.Green;
            this.tcMenu.TabIndex = 30;
            this.tcMenu.UseSelectable = true;
            this.tcMenu.SelectedIndexChanged += new System.EventHandler(this.TcMenu_SelectedIndexChanged);
            this.tcMenu.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // tabRecord
            // 
            this.tabRecord.BackColor = System.Drawing.Color.White;
            this.tabRecord.Controls.Add(this.tableLayoutPanel4);
            this.tabRecord.Location = new System.Drawing.Point(4, 38);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.Padding = new System.Windows.Forms.Padding(1);
            this.tabRecord.Size = new System.Drawing.Size(732, 298);
            this.tabRecord.TabIndex = 0;
            this.tabRecord.Text = "TAB_SPY";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel10, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.rtbLog, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(730, 296);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 6;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel10.Controls.Add(this.lnkDirectory, 5, 0);
            this.tableLayoutPanel10.Controls.Add(this.lnkClear, 4, 0);
            this.tableLayoutPanel10.Controls.Add(this.lblSoundCard, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.lblVolume, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.tbVolumeWin, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.iconVolume, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 264);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(724, 29);
            this.tableLayoutPanel10.TabIndex = 35;
            // 
            // lnkDirectory
            // 
            this.lnkDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lnkDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkDirectory.Image = global::EspionSpotify.Properties.Resources.folder;
            this.lnkDirectory.ImageSize = 32;
            this.lnkDirectory.Location = new System.Drawing.Point(676, 0);
            this.lnkDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.lnkDirectory.Name = "lnkDirectory";
            this.lnkDirectory.Size = new System.Drawing.Size(48, 29);
            this.lnkDirectory.TabIndex = 38;
            this.lnkDirectory.UseSelectable = true;
            this.lnkDirectory.Click += new System.EventHandler(this.LnkDirectory_Click);
            this.lnkDirectory.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // lnkClear
            // 
            this.lnkClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkClear.Image = global::EspionSpotify.Properties.Resources.clear;
            this.lnkClear.ImageSize = 32;
            this.lnkClear.Location = new System.Drawing.Point(636, 0);
            this.lnkClear.Margin = new System.Windows.Forms.Padding(0);
            this.lnkClear.Name = "lnkClear";
            this.lnkClear.Size = new System.Drawing.Size(40, 29);
            this.lnkClear.TabIndex = 36;
            this.lnkClear.UseSelectable = true;
            this.lnkClear.Click += new System.EventHandler(this.LnkClear_Click);
            this.lnkClear.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // lblSoundCard
            // 
            this.lblSoundCard.AutoSize = true;
            this.lblSoundCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoundCard.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblSoundCard.Location = new System.Drawing.Point(222, 3);
            this.lblSoundCard.Margin = new System.Windows.Forms.Padding(3);
            this.lblSoundCard.Name = "lblSoundCard";
            this.lblSoundCard.Size = new System.Drawing.Size(411, 23);
            this.lblSoundCard.TabIndex = 28;
            this.lblSoundCard.Text = "LBL_SOUND_COMPONENT";
            this.lblSoundCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVolume.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblVolume.Location = new System.Drawing.Point(43, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(34, 29);
            this.lblVolume.TabIndex = 9;
            this.lblVolume.Text = "000%";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconVolume
            // 
            this.iconVolume.BackgroundImage = global::EspionSpotify.Properties.Resources.volmute;
            this.iconVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconVolume.HorizontalScrollbarBarColor = true;
            this.iconVolume.HorizontalScrollbarHighlightOnWheel = false;
            this.iconVolume.HorizontalScrollbarSize = 10;
            this.iconVolume.Location = new System.Drawing.Point(3, 3);
            this.iconVolume.Name = "iconVolume";
            this.iconVolume.Size = new System.Drawing.Size(34, 23);
            this.iconVolume.TabIndex = 33;
            this.iconVolume.VerticalScrollbarBarColor = true;
            this.iconVolume.VerticalScrollbarHighlightOnWheel = false;
            this.iconVolume.VerticalScrollbarSize = 10;
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.Black;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLog.ForeColor = System.Drawing.Color.Silver;
            this.rtbLog.Location = new System.Drawing.Point(0, 35);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(730, 226);
            this.rtbLog.TabIndex = 32;
            this.rtbLog.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel3.Controls.Add(this.lblPlayingTitle, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.iconSpotify, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(730, 35);
            this.tableLayoutPanel3.TabIndex = 34;
            // 
            // lblPlayingTitle
            // 
            this.lblPlayingTitle.AutoSize = true;
            this.lblPlayingTitle.BackColor = System.Drawing.Color.Black;
            this.lblPlayingTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayingTitle.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblPlayingTitle.Location = new System.Drawing.Point(345, 0);
            this.lblPlayingTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlayingTitle.Name = "lblPlayingTitle";
            this.lblPlayingTitle.Size = new System.Drawing.Size(49, 35);
            this.lblPlayingTitle.TabIndex = 34;
            this.lblPlayingTitle.Text = "Spotify";
            this.lblPlayingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayingTitle.UseCustomBackColor = true;
            this.lblPlayingTitle.UseCustomForeColor = true;
            // 
            // iconSpotify
            // 
            this.iconSpotify.BackColor = System.Drawing.Color.Black;
            this.iconSpotify.BackgroundImage = global::EspionSpotify.Properties.Resources.pause;
            this.iconSpotify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconSpotify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconSpotify.Location = new System.Drawing.Point(310, 6);
            this.iconSpotify.Margin = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.iconSpotify.Name = "iconSpotify";
            this.iconSpotify.Size = new System.Drawing.Size(29, 23);
            this.iconSpotify.TabIndex = 35;
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.White;
            this.tabSettings.Controls.Add(this.tlSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 38);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(1);
            this.tabSettings.Size = new System.Drawing.Size(732, 298);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "TAB_SETTINGS";
            // 
            // tlSettings
            // 
            this.tlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlSettings.AutoScroll = true;
            this.tlSettings.ColumnCount = 3;
            this.tlSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlSettings.Controls.Add(this.lblLanguage, 0, 5);
            this.tlSettings.Controls.Add(this.lblBitRate, 0, 2);
            this.tlSettings.Controls.Add(this.lblPath, 0, 0);
            this.tlSettings.Controls.Add(this.tableLayoutPanel8, 2, 0);
            this.tlSettings.Controls.Add(this.tableLayoutPanel12, 2, 2);
            this.tlSettings.Controls.Add(this.cbLanguage, 2, 5);
            this.tlSettings.Controls.Add(this.tableLayoutPanel9, 2, 3);
            this.tlSettings.Controls.Add(this.lblFormat, 0, 4);
            this.tlSettings.Controls.Add(this.lblMinLength, 0, 3);
            this.tlSettings.Controls.Add(this.tableLayoutPanel13, 2, 4);
            this.tlSettings.Controls.Add(this.lblAds, 0, 6);
            this.tlSettings.Controls.Add(this.tableLayoutPanel1, 2, 6);
            this.tlSettings.Controls.Add(this.lblAudioDevice, 0, 1);
            this.tlSettings.Controls.Add(this.tableLayoutPanel5, 2, 1);
            this.tlSettings.Location = new System.Drawing.Point(1, 1);
            this.tlSettings.Name = "tlSettings";
            this.tlSettings.Padding = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.tlSettings.RowCount = 8;
            this.tlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlSettings.Size = new System.Drawing.Size(731, 295);
            this.tlSettings.TabIndex = 2;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLanguage.Location = new System.Drawing.Point(3, 196);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(125, 29);
            this.lblLanguage.TabIndex = 43;
            this.lblLanguage.Text = "LBL_LANGUAGE";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBitRate
            // 
            this.lblBitRate.AutoSize = true;
            this.lblBitRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBitRate.Location = new System.Drawing.Point(3, 85);
            this.lblBitRate.Name = "lblBitRate";
            this.lblBitRate.Size = new System.Drawing.Size(125, 35);
            this.lblBitRate.TabIndex = 6;
            this.lblBitRate.Text = "LBL_BITRATE";
            this.lblBitRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPath.Location = new System.Drawing.Point(3, 15);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(125, 35);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "LBL_PATH";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.Controls.Add(this.lnkPath, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtPath, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(141, 15);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(580, 35);
            this.tableLayoutPanel8.TabIndex = 35;
            // 
            // lnkPath
            // 
            this.lnkPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkPath.Image = global::EspionSpotify.Properties.Resources.folder;
            this.lnkPath.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkPath.ImageSize = 28;
            this.lnkPath.Location = new System.Drawing.Point(543, 3);
            this.lnkPath.Name = "lnkPath";
            this.lnkPath.Size = new System.Drawing.Size(34, 29);
            this.lnkPath.TabIndex = 46;
            this.lnkPath.UseSelectable = true;
            this.lnkPath.Click += new System.EventHandler(this.LnkPath_Click);
            this.lnkPath.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // txtPath
            // 
            // 
            // 
            // 
            this.txtPath.CustomButton.Image = null;
            this.txtPath.CustomButton.Location = new System.Drawing.Point(506, 1);
            this.txtPath.CustomButton.Name = "";
            this.txtPath.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPath.CustomButton.TabIndex = 1;
            this.txtPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPath.CustomButton.UseSelectable = true;
            this.txtPath.CustomButton.Visible = false;
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPath.Lines = new string[0];
            this.txtPath.Location = new System.Drawing.Point(3, 3);
            this.txtPath.MaxLength = 32767;
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPath.SelectedText = "";
            this.txtPath.SelectionLength = 0;
            this.txtPath.SelectionStart = 0;
            this.txtPath.ShortcutsEnabled = true;
            this.txtPath.Size = new System.Drawing.Size(534, 29);
            this.txtPath.Style = MetroFramework.MetroColorStyle.Green;
            this.txtPath.TabIndex = 34;
            this.txtPath.UseSelectable = true;
            this.txtPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPath.TextChanged += new System.EventHandler(this.TxtPath_TextChanged);
            this.txtPath.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.cbBitRate, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(144, 88);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(574, 29);
            this.tableLayoutPanel12.TabIndex = 37;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.tbMinTime, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblMinTime, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(144, 123);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(574, 29);
            this.tableLayoutPanel9.TabIndex = 11;
            // 
            // lblMinTime
            // 
            this.lblMinTime.AutoSize = true;
            this.lblMinTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinTime.Location = new System.Drawing.Point(3, 0);
            this.lblMinTime.Name = "lblMinTime";
            this.lblMinTime.Size = new System.Drawing.Size(33, 29);
            this.lblMinTime.TabIndex = 16;
            this.lblMinTime.Text = "0:30";
            this.lblMinTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormat.Location = new System.Drawing.Point(3, 155);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(125, 35);
            this.lblFormat.TabIndex = 9;
            this.lblFormat.Text = "LBL_FORMAT";
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMinLength
            // 
            this.lblMinLength.AutoSize = true;
            this.lblMinLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinLength.Location = new System.Drawing.Point(3, 120);
            this.lblMinLength.Name = "lblMinLength";
            this.lblMinLength.Size = new System.Drawing.Size(125, 35);
            this.lblMinLength.TabIndex = 10;
            this.lblMinLength.Text = "LBL_MIN_LENGTH";
            this.lblMinLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 4;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Controls.Add(this.rbWav, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.rbMp3, 1, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(144, 158);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(574, 29);
            this.tableLayoutPanel13.TabIndex = 40;
            // 
            // rbWav
            // 
            this.rbWav.AutoSize = true;
            this.rbWav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbWav.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbWav.Location = new System.Drawing.Point(63, 3);
            this.rbWav.Name = "rbWav";
            this.rbWav.Size = new System.Drawing.Size(54, 23);
            this.rbWav.Style = MetroFramework.MetroColorStyle.Green;
            this.rbWav.TabIndex = 40;
            this.rbWav.Tag = "wav";
            this.rbWav.Text = "WAV";
            this.rbWav.UseSelectable = true;
            this.rbWav.CheckedChanged += new System.EventHandler(this.RbFormat_CheckedChanged);
            // 
            // rbMp3
            // 
            this.rbMp3.AutoSize = true;
            this.rbMp3.Checked = true;
            this.rbMp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbMp3.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbMp3.Location = new System.Drawing.Point(3, 3);
            this.rbMp3.Name = "rbMp3";
            this.rbMp3.Size = new System.Drawing.Size(54, 23);
            this.rbMp3.Style = MetroFramework.MetroColorStyle.Green;
            this.rbMp3.TabIndex = 39;
            this.rbMp3.TabStop = true;
            this.rbMp3.Tag = "mp3";
            this.rbMp3.Text = "MP3";
            this.rbMp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMp3.UseSelectable = true;
            this.rbMp3.CheckedChanged += new System.EventHandler(this.RbFormat_CheckedChanged);
            // 
            // lblAds
            // 
            this.lblAds.AutoSize = true;
            this.lblAds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAds.Location = new System.Drawing.Point(3, 231);
            this.lblAds.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblAds.Name = "lblAds";
            this.lblAds.Size = new System.Drawing.Size(125, 56);
            this.lblAds.TabIndex = 46;
            this.lblAds.Text = "LBL_ADS";
            this.lblAds.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tgDisableAds, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDisableAds, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMuteAds, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tgMuteAds, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(144, 228);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 56);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // tgDisableAds
            // 
            this.tgDisableAds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgDisableAds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgDisableAds.Location = new System.Drawing.Point(477, 3);
            this.tgDisableAds.Name = "tgDisableAds";
            this.tgDisableAds.Size = new System.Drawing.Size(94, 22);
            this.tgDisableAds.Style = MetroFramework.MetroColorStyle.Green;
            this.tgDisableAds.TabIndex = 41;
            this.tgDisableAds.Text = "Off";
            this.tgDisableAds.UseSelectable = true;
            this.tgDisableAds.CheckedChanged += new System.EventHandler(this.TgDisableAds_CheckedChanged);
            this.tgDisableAds.Click += new System.EventHandler(this.TgDisableAds_Click);
            // 
            // lblDisableAds
            // 
            this.lblDisableAds.AutoSize = true;
            this.lblDisableAds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisableAds.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDisableAds.Location = new System.Drawing.Point(3, 0);
            this.lblDisableAds.Name = "lblDisableAds";
            this.lblDisableAds.Size = new System.Drawing.Size(468, 28);
            this.lblDisableAds.TabIndex = 42;
            this.lblDisableAds.Text = "LBL_DISABLE_ADS";
            this.lblDisableAds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMuteAds
            // 
            this.lblMuteAds.AutoSize = true;
            this.lblMuteAds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMuteAds.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblMuteAds.Location = new System.Drawing.Point(3, 28);
            this.lblMuteAds.Name = "lblMuteAds";
            this.lblMuteAds.Size = new System.Drawing.Size(468, 28);
            this.lblMuteAds.TabIndex = 43;
            this.lblMuteAds.Text = "LBL_MUTE_ADS";
            this.lblMuteAds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tgMuteAds
            // 
            this.tgMuteAds.AutoSize = true;
            this.tgMuteAds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgMuteAds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgMuteAds.Location = new System.Drawing.Point(477, 31);
            this.tgMuteAds.Name = "tgMuteAds";
            this.tgMuteAds.Size = new System.Drawing.Size(94, 22);
            this.tgMuteAds.Style = MetroFramework.MetroColorStyle.Green;
            this.tgMuteAds.TabIndex = 44;
            this.tgMuteAds.Text = "Off";
            this.tgMuteAds.UseSelectable = true;
            this.tgMuteAds.CheckedChanged += new System.EventHandler(this.TgMuteAds_CheckedChanged);
            // 
            // lblAudioDevice
            // 
            this.lblAudioDevice.AutoSize = true;
            this.lblAudioDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAudioDevice.Location = new System.Drawing.Point(3, 50);
            this.lblAudioDevice.Name = "lblAudioDevice";
            this.lblAudioDevice.Size = new System.Drawing.Size(125, 35);
            this.lblAudioDevice.TabIndex = 48;
            this.lblAudioDevice.Text = "LBL_AUDIO_DEVICE";
            this.lblAudioDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.cbAudioDevices, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(144, 53);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(574, 29);
            this.tableLayoutPanel5.TabIndex = 49;
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.BackColor = System.Drawing.Color.White;
            this.tabAdvanced.Controls.Add(this.tlAdvanced);
            this.tabAdvanced.Location = new System.Drawing.Point(4, 38);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(1);
            this.tabAdvanced.Size = new System.Drawing.Size(732, 298);
            this.tabAdvanced.TabIndex = 1;
            this.tabAdvanced.Text = "TAB_ADVANCED";
            // 
            // tlAdvanced
            // 
            this.tlAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlAdvanced.AutoScroll = true;
            this.tlAdvanced.BackColor = System.Drawing.Color.White;
            this.tlAdvanced.ColumnCount = 3;
            this.tlAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAdvanced.Controls.Add(this.lblSpy, 0, 1);
            this.tlAdvanced.Controls.Add(this.lblRecorder, 0, 0);
            this.tlAdvanced.Controls.Add(this.tableLayoutPanel11, 2, 1);
            this.tlAdvanced.Controls.Add(this.tableLayoutPanel14, 2, 0);
            this.tlAdvanced.Location = new System.Drawing.Point(1, 1);
            this.tlAdvanced.Name = "tlAdvanced";
            this.tlAdvanced.Padding = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.tlAdvanced.RowCount = 3;
            this.tlAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlAdvanced.Size = new System.Drawing.Size(731, 295);
            this.tlAdvanced.TabIndex = 2;
            // 
            // lblSpy
            // 
            this.lblSpy.AutoSize = true;
            this.lblSpy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpy.Location = new System.Drawing.Point(3, 223);
            this.lblSpy.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblSpy.Name = "lblSpy";
            this.lblSpy.Size = new System.Drawing.Size(102, 56);
            this.lblSpy.TabIndex = 0;
            this.lblSpy.Text = "LBL_SPY";
            this.lblSpy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRecorder
            // 
            this.lblRecorder.AutoSize = true;
            this.lblRecorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecorder.Location = new System.Drawing.Point(3, 21);
            this.lblRecorder.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblRecorder.Name = "lblRecorder";
            this.lblRecorder.Size = new System.Drawing.Size(102, 196);
            this.lblRecorder.TabIndex = 1;
            this.lblRecorder.Text = "LBL_RECORDER";
            this.lblRecorder.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.AutoSize = true;
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel11.Controls.Add(this.tgRecordUnkownTrackType, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.lblEndingSongDelay, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.lblRecordUnknownTrackType, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.tgEndingSongDelay, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(121, 220);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(592, 56);
            this.tableLayoutPanel11.TabIndex = 6;
            // 
            // tgRecordUnkownTrackType
            // 
            this.tgRecordUnkownTrackType.AutoSize = true;
            this.tgRecordUnkownTrackType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgRecordUnkownTrackType.Location = new System.Drawing.Point(495, 31);
            this.tgRecordUnkownTrackType.Name = "tgRecordUnkownTrackType";
            this.tgRecordUnkownTrackType.Size = new System.Drawing.Size(94, 22);
            this.tgRecordUnkownTrackType.Style = MetroFramework.MetroColorStyle.Green;
            this.tgRecordUnkownTrackType.TabIndex = 44;
            this.tgRecordUnkownTrackType.Text = "Off";
            this.tgRecordUnkownTrackType.UseSelectable = true;
            this.tgRecordUnkownTrackType.CheckedChanged += new System.EventHandler(this.TgRecordUnkownTrackType_CheckedChanged);
            // 
            // lblEndingSongDelay
            // 
            this.lblEndingSongDelay.AutoSize = true;
            this.lblEndingSongDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEndingSongDelay.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblEndingSongDelay.Location = new System.Drawing.Point(3, 0);
            this.lblEndingSongDelay.Name = "lblEndingSongDelay";
            this.lblEndingSongDelay.Size = new System.Drawing.Size(486, 28);
            this.lblEndingSongDelay.TabIndex = 48;
            this.lblEndingSongDelay.Text = "LBL_ENDING_SONG_DELAY";
            this.lblEndingSongDelay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecordUnknownTrackType
            // 
            this.lblRecordUnknownTrackType.AutoSize = true;
            this.lblRecordUnknownTrackType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecordUnknownTrackType.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblRecordUnknownTrackType.Location = new System.Drawing.Point(3, 28);
            this.lblRecordUnknownTrackType.Name = "lblRecordUnknownTrackType";
            this.lblRecordUnknownTrackType.Size = new System.Drawing.Size(486, 28);
            this.lblRecordUnknownTrackType.TabIndex = 43;
            this.lblRecordUnknownTrackType.Text = "LBL_RECORD_UNKOWN_TRACK_TYPE";
            this.lblRecordUnknownTrackType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tgEndingSongDelay
            // 
            this.tgEndingSongDelay.AutoSize = true;
            this.tgEndingSongDelay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgEndingSongDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgEndingSongDelay.Location = new System.Drawing.Point(495, 3);
            this.tgEndingSongDelay.Name = "tgEndingSongDelay";
            this.tgEndingSongDelay.Size = new System.Drawing.Size(94, 22);
            this.tgEndingSongDelay.Style = MetroFramework.MetroColorStyle.Green;
            this.tgEndingSongDelay.TabIndex = 0;
            this.tgEndingSongDelay.Text = "Off";
            this.tgEndingSongDelay.UseSelectable = true;
            this.tgEndingSongDelay.CheckedChanged += new System.EventHandler(this.TgEndingSongDelay_CheckedChanged);
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.AutoSize = true;
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel14.Controls.Add(this.lblRecordingNum, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.tgAddSeparators, 1, 5);
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tableLayoutPanel14.Controls.Add(this.tgNumFiles, 1, 3);
            this.tableLayoutPanel14.Controls.Add(this.lblAddSeparators, 0, 5);
            this.tableLayoutPanel14.Controls.Add(this.tgNumTracks, 1, 2);
            this.tableLayoutPanel14.Controls.Add(this.tgAddFolders, 1, 4);
            this.tableLayoutPanel14.Controls.Add(this.lblNumFiles, 0, 3);
            this.tableLayoutPanel14.Controls.Add(this.lblAddFolders, 0, 4);
            this.tableLayoutPanel14.Controls.Add(this.lblNumTracks, 0, 2);
            this.tableLayoutPanel14.Controls.Add(this.lblDuplicateAlreadyRecordedTrack, 0, 6);
            this.tableLayoutPanel14.Controls.Add(this.tgDuplicateAlreadyRecordedTrack, 1, 6);
            this.tableLayoutPanel14.Controls.Add(this.lblRecordingTimer, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.txtRecordingTimer, 1, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(121, 18);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 7;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(592, 196);
            this.tableLayoutPanel14.TabIndex = 7;
            // 
            // lblRecordingNum
            // 
            this.lblRecordingNum.AutoSize = true;
            this.lblRecordingNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecordingNum.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblRecordingNum.Location = new System.Drawing.Point(3, 28);
            this.lblRecordingNum.Name = "lblRecordingNum";
            this.lblRecordingNum.Size = new System.Drawing.Size(486, 28);
            this.lblRecordingNum.TabIndex = 50;
            this.lblRecordingNum.Text = "LBL_RECORDING_NUMBER";
            this.lblRecordingNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tgAddSeparators
            // 
            this.tgAddSeparators.AutoSize = true;
            this.tgAddSeparators.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgAddSeparators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgAddSeparators.Location = new System.Drawing.Point(495, 143);
            this.tgAddSeparators.Name = "tgAddSeparators";
            this.tgAddSeparators.Size = new System.Drawing.Size(94, 22);
            this.tgAddSeparators.Style = MetroFramework.MetroColorStyle.Green;
            this.tgAddSeparators.TabIndex = 45;
            this.tgAddSeparators.Text = "Off";
            this.tgAddSeparators.UseSelectable = true;
            this.tgAddSeparators.CheckedChanged += new System.EventHandler(this.TgAddSeparators_CheckedChanged);
            this.tgAddSeparators.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.lnkNumPlus, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.lnkNumMinus, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblNum, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(495, 31);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(94, 22);
            this.tableLayoutPanel7.TabIndex = 51;
            // 
            // lnkNumPlus
            // 
            this.lnkNumPlus.AutoSize = true;
            this.lnkNumPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkNumPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkNumPlus.Image = global::EspionSpotify.Properties.Resources.plus;
            this.lnkNumPlus.ImageSize = 18;
            this.lnkNumPlus.Location = new System.Drawing.Point(74, 0);
            this.lnkNumPlus.Margin = new System.Windows.Forms.Padding(0);
            this.lnkNumPlus.Name = "lnkNumPlus";
            this.lnkNumPlus.Size = new System.Drawing.Size(20, 22);
            this.lnkNumPlus.TabIndex = 45;
            this.lnkNumPlus.UseSelectable = true;
            this.lnkNumPlus.Click += new System.EventHandler(this.LnkNumPlus_Click);
            this.lnkNumPlus.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // lnkNumMinus
            // 
            this.lnkNumMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkNumMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkNumMinus.Image = global::EspionSpotify.Properties.Resources.minus;
            this.lnkNumMinus.ImageSize = 18;
            this.lnkNumMinus.Location = new System.Drawing.Point(0, 0);
            this.lnkNumMinus.Margin = new System.Windows.Forms.Padding(0);
            this.lnkNumMinus.Name = "lnkNumMinus";
            this.lnkNumMinus.Size = new System.Drawing.Size(20, 22);
            this.lnkNumMinus.TabIndex = 44;
            this.lnkNumMinus.UseSelectable = true;
            this.lnkNumMinus.Click += new System.EventHandler(this.LnkNumMinus_Click);
            this.lnkNumMinus.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNum.Location = new System.Drawing.Point(23, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(48, 22);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "001";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tgNumFiles
            // 
            this.tgNumFiles.AutoSize = true;
            this.tgNumFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgNumFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgNumFiles.Location = new System.Drawing.Point(495, 87);
            this.tgNumFiles.Name = "tgNumFiles";
            this.tgNumFiles.Size = new System.Drawing.Size(94, 22);
            this.tgNumFiles.Style = MetroFramework.MetroColorStyle.Green;
            this.tgNumFiles.TabIndex = 47;
            this.tgNumFiles.Text = "Off";
            this.tgNumFiles.UseSelectable = true;
            this.tgNumFiles.CheckedChanged += new System.EventHandler(this.TgNumFiles_CheckedChanged);
            this.tgNumFiles.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // lblAddSeparators
            // 
            this.lblAddSeparators.AutoSize = true;
            this.lblAddSeparators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddSeparators.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblAddSeparators.Location = new System.Drawing.Point(3, 140);
            this.lblAddSeparators.Name = "lblAddSeparators";
            this.lblAddSeparators.Size = new System.Drawing.Size(486, 28);
            this.lblAddSeparators.TabIndex = 44;
            this.lblAddSeparators.Text = "LBL_ADD_SEPARATORS";
            this.lblAddSeparators.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tgNumTracks
            // 
            this.tgNumTracks.AutoSize = true;
            this.tgNumTracks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgNumTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgNumTracks.Location = new System.Drawing.Point(495, 59);
            this.tgNumTracks.Name = "tgNumTracks";
            this.tgNumTracks.Size = new System.Drawing.Size(94, 22);
            this.tgNumTracks.Style = MetroFramework.MetroColorStyle.Green;
            this.tgNumTracks.TabIndex = 49;
            this.tgNumTracks.Text = "Off";
            this.tgNumTracks.UseSelectable = true;
            this.tgNumTracks.CheckedChanged += new System.EventHandler(this.TgNumTracks_CheckedChanged);
            this.tgNumTracks.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // tgAddFolders
            // 
            this.tgAddFolders.AutoSize = true;
            this.tgAddFolders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgAddFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgAddFolders.Location = new System.Drawing.Point(495, 115);
            this.tgAddFolders.Name = "tgAddFolders";
            this.tgAddFolders.Size = new System.Drawing.Size(94, 22);
            this.tgAddFolders.Style = MetroFramework.MetroColorStyle.Green;
            this.tgAddFolders.TabIndex = 43;
            this.tgAddFolders.Text = "Off";
            this.tgAddFolders.UseSelectable = true;
            this.tgAddFolders.CheckedChanged += new System.EventHandler(this.TgAddFolders_CheckedChanged);
            this.tgAddFolders.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // lblNumFiles
            // 
            this.lblNumFiles.AutoSize = true;
            this.lblNumFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumFiles.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblNumFiles.Location = new System.Drawing.Point(3, 84);
            this.lblNumFiles.Name = "lblNumFiles";
            this.lblNumFiles.Size = new System.Drawing.Size(486, 28);
            this.lblNumFiles.TabIndex = 46;
            this.lblNumFiles.Text = "LBL_ADD_NUMBERS_TO_FILES";
            this.lblNumFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddFolders
            // 
            this.lblAddFolders.AutoSize = true;
            this.lblAddFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddFolders.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblAddFolders.Location = new System.Drawing.Point(3, 112);
            this.lblAddFolders.Name = "lblAddFolders";
            this.lblAddFolders.Size = new System.Drawing.Size(486, 28);
            this.lblAddFolders.TabIndex = 42;
            this.lblAddFolders.Text = "LBL_ADD_FOLDERS";
            this.lblAddFolders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumTracks
            // 
            this.lblNumTracks.AutoSize = true;
            this.lblNumTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumTracks.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblNumTracks.Location = new System.Drawing.Point(3, 56);
            this.lblNumTracks.Name = "lblNumTracks";
            this.lblNumTracks.Size = new System.Drawing.Size(486, 28);
            this.lblNumTracks.TabIndex = 48;
            this.lblNumTracks.Text = "LBL_ADD_NUMBERS_AS_TRACK";
            this.lblNumTracks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDuplicateAlreadyRecordedTrack
            // 
            this.lblDuplicateAlreadyRecordedTrack.AutoSize = true;
            this.lblDuplicateAlreadyRecordedTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDuplicateAlreadyRecordedTrack.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDuplicateAlreadyRecordedTrack.Location = new System.Drawing.Point(3, 168);
            this.lblDuplicateAlreadyRecordedTrack.Name = "lblDuplicateAlreadyRecordedTrack";
            this.lblDuplicateAlreadyRecordedTrack.Size = new System.Drawing.Size(486, 28);
            this.lblDuplicateAlreadyRecordedTrack.TabIndex = 44;
            this.lblDuplicateAlreadyRecordedTrack.Text = "LBL_DUPLICATE_ALREADY_RECORDED_TRACK";
            this.lblDuplicateAlreadyRecordedTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tgDuplicateAlreadyRecordedTrack
            // 
            this.tgDuplicateAlreadyRecordedTrack.AutoSize = true;
            this.tgDuplicateAlreadyRecordedTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgDuplicateAlreadyRecordedTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgDuplicateAlreadyRecordedTrack.Location = new System.Drawing.Point(495, 171);
            this.tgDuplicateAlreadyRecordedTrack.Name = "tgDuplicateAlreadyRecordedTrack";
            this.tgDuplicateAlreadyRecordedTrack.Size = new System.Drawing.Size(94, 22);
            this.tgDuplicateAlreadyRecordedTrack.Style = MetroFramework.MetroColorStyle.Green;
            this.tgDuplicateAlreadyRecordedTrack.TabIndex = 45;
            this.tgDuplicateAlreadyRecordedTrack.Text = "Off";
            this.tgDuplicateAlreadyRecordedTrack.UseSelectable = true;
            this.tgDuplicateAlreadyRecordedTrack.CheckedChanged += new System.EventHandler(this.TgDuplicateAlreadyRecordedTrack_CheckedChanged);
            this.tgDuplicateAlreadyRecordedTrack.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // lblRecordingTimer
            // 
            this.lblRecordingTimer.AutoSize = true;
            this.lblRecordingTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecordingTimer.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblRecordingTimer.Location = new System.Drawing.Point(3, 0);
            this.lblRecordingTimer.Name = "lblRecordingTimer";
            this.lblRecordingTimer.Size = new System.Drawing.Size(486, 28);
            this.lblRecordingTimer.TabIndex = 50;
            this.lblRecordingTimer.Text = "LBL_RECORDING_TIMER";
            this.lblRecordingTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecordingTimer
            // 
            this.txtRecordingTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecordingTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecordingTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecordingTimer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRecordingTimer.Location = new System.Drawing.Point(495, 3);
            this.txtRecordingTimer.Mask = "00h00m00s";
            this.txtRecordingTimer.Name = "txtRecordingTimer";
            this.txtRecordingTimer.PromptChar = '0';
            this.txtRecordingTimer.Size = new System.Drawing.Size(94, 25);
            this.txtRecordingTimer.TabIndex = 52;
            this.txtRecordingTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecordingTimer.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtRecordingTimer.Leave += new System.EventHandler(this.TxtRecordingTimer_Leave);
            // 
            // tabFAQ
            // 
            this.tabFAQ.BackColor = System.Drawing.Color.White;
            this.tabFAQ.Controls.Add(this.tlFAQ);
            this.tabFAQ.Location = new System.Drawing.Point(4, 38);
            this.tabFAQ.Name = "tabFAQ";
            this.tabFAQ.Padding = new System.Windows.Forms.Padding(1);
            this.tabFAQ.Size = new System.Drawing.Size(732, 298);
            this.tabFAQ.TabIndex = 3;
            this.tabFAQ.Text = "TAB_FAQ";
            // 
            // tlFAQ
            // 
            this.tlFAQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlFAQ.AutoScroll = true;
            this.tlFAQ.BackColor = System.Drawing.Color.White;
            this.tlFAQ.ColumnCount = 1;
            this.tlFAQ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlFAQ.Controls.Add(this.tlSpotifyTrackCut, 0, 0);
            this.tlFAQ.Controls.Add(this.tlAdsPlayAndStop, 0, 2);
            this.tlFAQ.Controls.Add(this.tlAdAndTrackOverlapOnRecordedTrack, 0, 4);
            this.tlFAQ.Controls.Add(this.tlBackgroundNoiceRecordedOnTrack, 0, 6);
            this.tlFAQ.Controls.Add(this.tlTrackDetectedAsAd, 0, 8);
            this.tlFAQ.Controls.Add(this.lblTrackDetectedAsAd, 0, 9);
            this.tlFAQ.Controls.Add(this.lblBackgroundNoiceRecordedOnTrack, 0, 7);
            this.tlFAQ.Controls.Add(this.lblAdAndTrackOverlapOnRecordedTrack, 0, 5);
            this.tlFAQ.Controls.Add(this.lblAdsPlayAndStop, 0, 3);
            this.tlFAQ.Controls.Add(this.lblSpotifyTrackCut, 0, 1);
            this.tlFAQ.Controls.Add(this.tlSpotifyLostFeatures, 0, 10);
            this.tlFAQ.Controls.Add(this.lblSpotifyLostFeatures, 0, 11);
            this.tlFAQ.Location = new System.Drawing.Point(1, 1);
            this.tlFAQ.Name = "tlFAQ";
            this.tlFAQ.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tlFAQ.RowCount = 13;
            this.tlFAQ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlFAQ.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlFAQ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlFAQ.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlFAQ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlFAQ.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlFAQ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlFAQ.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlFAQ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlFAQ.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlFAQ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlFAQ.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlFAQ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlFAQ.Size = new System.Drawing.Size(730, 295);
            this.tlFAQ.TabIndex = 1;
            // 
            // lblTrackDetectedAsAd
            // 
            this.lblTrackDetectedAsAd.AutoSize = true;
            this.lblTrackDetectedAsAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblTrackDetectedAsAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrackDetectedAsAd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackDetectedAsAd.ForeColor = System.Drawing.Color.White;
            this.lblTrackDetectedAsAd.Location = new System.Drawing.Point(10, 352);
            this.lblTrackDetectedAsAd.Margin = new System.Windows.Forms.Padding(0);
            this.lblTrackDetectedAsAd.Name = "lblTrackDetectedAsAd";
            this.lblTrackDetectedAsAd.Padding = new System.Windows.Forms.Padding(5, 5, 5, 20);
            this.lblTrackDetectedAsAd.Size = new System.Drawing.Size(693, 38);
            this.lblTrackDetectedAsAd.TabIndex = 5;
            this.lblTrackDetectedAsAd.Text = "TRACK_DETECTED_AS_AN_AD";
            this.lblTrackDetectedAsAd.Visible = false;
            // 
            // lblBackgroundNoiceRecordedOnTrack
            // 
            this.lblBackgroundNoiceRecordedOnTrack.AutoSize = true;
            this.lblBackgroundNoiceRecordedOnTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblBackgroundNoiceRecordedOnTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBackgroundNoiceRecordedOnTrack.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackgroundNoiceRecordedOnTrack.ForeColor = System.Drawing.Color.White;
            this.lblBackgroundNoiceRecordedOnTrack.Location = new System.Drawing.Point(10, 274);
            this.lblBackgroundNoiceRecordedOnTrack.Margin = new System.Windows.Forms.Padding(0);
            this.lblBackgroundNoiceRecordedOnTrack.Name = "lblBackgroundNoiceRecordedOnTrack";
            this.lblBackgroundNoiceRecordedOnTrack.Padding = new System.Windows.Forms.Padding(5, 5, 5, 20);
            this.lblBackgroundNoiceRecordedOnTrack.Size = new System.Drawing.Size(693, 38);
            this.lblBackgroundNoiceRecordedOnTrack.TabIndex = 5;
            this.lblBackgroundNoiceRecordedOnTrack.Text = "BACKGROUND_NOICE_RECORDED_ON_TRACK";
            this.lblBackgroundNoiceRecordedOnTrack.Visible = false;
            // 
            // lblAdAndTrackOverlapOnRecordedTrack
            // 
            this.lblAdAndTrackOverlapOnRecordedTrack.AutoSize = true;
            this.lblAdAndTrackOverlapOnRecordedTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblAdAndTrackOverlapOnRecordedTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdAndTrackOverlapOnRecordedTrack.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdAndTrackOverlapOnRecordedTrack.ForeColor = System.Drawing.Color.White;
            this.lblAdAndTrackOverlapOnRecordedTrack.Location = new System.Drawing.Point(10, 196);
            this.lblAdAndTrackOverlapOnRecordedTrack.Margin = new System.Windows.Forms.Padding(0);
            this.lblAdAndTrackOverlapOnRecordedTrack.Name = "lblAdAndTrackOverlapOnRecordedTrack";
            this.lblAdAndTrackOverlapOnRecordedTrack.Padding = new System.Windows.Forms.Padding(5, 5, 5, 20);
            this.lblAdAndTrackOverlapOnRecordedTrack.Size = new System.Drawing.Size(693, 38);
            this.lblAdAndTrackOverlapOnRecordedTrack.TabIndex = 5;
            this.lblAdAndTrackOverlapOnRecordedTrack.Text = "AD_AND_TRACK_OVERLAP_ON_RECORDED_TRACK";
            this.lblAdAndTrackOverlapOnRecordedTrack.Visible = false;
            // 
            // lblAdsPlayAndStop
            // 
            this.lblAdsPlayAndStop.AutoSize = true;
            this.lblAdsPlayAndStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblAdsPlayAndStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdsPlayAndStop.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdsPlayAndStop.ForeColor = System.Drawing.Color.White;
            this.lblAdsPlayAndStop.Location = new System.Drawing.Point(10, 118);
            this.lblAdsPlayAndStop.Margin = new System.Windows.Forms.Padding(0);
            this.lblAdsPlayAndStop.Name = "lblAdsPlayAndStop";
            this.lblAdsPlayAndStop.Padding = new System.Windows.Forms.Padding(5, 5, 5, 20);
            this.lblAdsPlayAndStop.Size = new System.Drawing.Size(693, 38);
            this.lblAdsPlayAndStop.TabIndex = 5;
            this.lblAdsPlayAndStop.Text = "ADS_PLAY_AND_STOP";
            this.lblAdsPlayAndStop.Visible = false;
            // 
            // lblSpotifyTrackCut
            // 
            this.lblSpotifyTrackCut.AutoSize = true;
            this.lblSpotifyTrackCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblSpotifyTrackCut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpotifyTrackCut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpotifyTrackCut.ForeColor = System.Drawing.Color.White;
            this.lblSpotifyTrackCut.Location = new System.Drawing.Point(10, 40);
            this.lblSpotifyTrackCut.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpotifyTrackCut.Name = "lblSpotifyTrackCut";
            this.lblSpotifyTrackCut.Padding = new System.Windows.Forms.Padding(5, 5, 5, 20);
            this.lblSpotifyTrackCut.Size = new System.Drawing.Size(693, 38);
            this.lblSpotifyTrackCut.TabIndex = 5;
            this.lblSpotifyTrackCut.Text = "TRACKS_ARE_CUT_ON_SPOTIFY";
            this.lblSpotifyTrackCut.Visible = false;
            // 
            // lblSpotifyLostFeatures
            // 
            this.lblSpotifyLostFeatures.AutoSize = true;
            this.lblSpotifyLostFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblSpotifyLostFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpotifyLostFeatures.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpotifyLostFeatures.ForeColor = System.Drawing.Color.White;
            this.lblSpotifyLostFeatures.Location = new System.Drawing.Point(10, 430);
            this.lblSpotifyLostFeatures.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpotifyLostFeatures.Name = "lblSpotifyLostFeatures";
            this.lblSpotifyLostFeatures.Padding = new System.Windows.Forms.Padding(5, 5, 5, 20);
            this.lblSpotifyLostFeatures.Size = new System.Drawing.Size(693, 38);
            this.lblSpotifyLostFeatures.TabIndex = 5;
            this.lblSpotifyLostFeatures.Text = "SPOTIFY_LOST_FEATURES";
            this.lblSpotifyLostFeatures.Visible = false;
            // 
            // lnkSpy
            // 
            this.lnkSpy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSpy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lnkSpy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkSpy.Image = global::EspionSpotify.Properties.Resources.on;
            this.lnkSpy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkSpy.ImageSize = 0;
            this.lnkSpy.Location = new System.Drawing.Point(616, 39);
            this.lnkSpy.Margin = new System.Windows.Forms.Padding(0);
            this.lnkSpy.Name = "lnkSpy";
            this.lnkSpy.Size = new System.Drawing.Size(136, 44);
            this.lnkSpy.TabIndex = 39;
            this.lnkSpy.UseSelectable = true;
            this.lnkSpy.Click += new System.EventHandler(this.LnkSpy_Click);
            this.lnkSpy.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // tip
            // 
            this.tip.Style = MetroFramework.MetroColorStyle.Default;
            this.tip.StyleManager = null;
            this.tip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lnkRelease
            // 
            this.lnkRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkRelease.Image = ((System.Drawing.Image)(resources.GetObject("lnkRelease.Image")));
            this.lnkRelease.ImageSize = 18;
            this.lnkRelease.Location = new System.Drawing.Point(680, 5);
            this.lnkRelease.Margin = new System.Windows.Forms.Padding(0);
            this.lnkRelease.Name = "lnkRelease";
            this.lnkRelease.Size = new System.Drawing.Size(20, 20);
            this.lnkRelease.TabIndex = 40;
            this.lnkRelease.UseSelectable = true;
            this.lnkRelease.Visible = false;
            this.lnkRelease.Click += new System.EventHandler(this.LnkRelease_Click);
            // 
            // tbVolumeWin
            // 
            this.tbVolumeWin.BackColor = System.Drawing.Color.Transparent;
            this.tbVolumeWin.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbVolumeWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbVolumeWin.Location = new System.Drawing.Point(83, 3);
            this.tbVolumeWin.Name = "tbVolumeWin";
            this.tbVolumeWin.Size = new System.Drawing.Size(133, 23);
            this.tbVolumeWin.TabIndex = 11;
            this.tbVolumeWin.Value = 0;
            this.tbVolumeWin.ValueChanged += new System.EventHandler(this.TbVolumeWin_ValueChanged);
            this.tbVolumeWin.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // cbBitRate
            // 
            this.cbBitRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBitRate.FormattingEnabled = true;
            this.cbBitRate.ItemHeight = 23;
            this.cbBitRate.Location = new System.Drawing.Point(0, 0);
            this.cbBitRate.Margin = new System.Windows.Forms.Padding(0);
            this.cbBitRate.Name = "cbBitRate";
            this.cbBitRate.Size = new System.Drawing.Size(574, 29);
            this.cbBitRate.Style = MetroFramework.MetroColorStyle.Green;
            this.cbBitRate.TabIndex = 37;
            this.cbBitRate.UseSelectable = true;
            this.cbBitRate.SelectedIndexChanged += new System.EventHandler(this.CbBitRate_SelectedIndexChanged);
            this.cbBitRate.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // cbLanguage
            // 
            this.cbLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.ItemHeight = 23;
            this.cbLanguage.Location = new System.Drawing.Point(144, 193);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(574, 29);
            this.cbLanguage.TabIndex = 44;
            this.cbLanguage.UseSelectable = true;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.CbLanguage_SelectedIndexChanged);
            // 
            // tbMinTime
            // 
            this.tbMinTime.BackColor = System.Drawing.Color.Transparent;
            this.tbMinTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbMinTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMinTime.Location = new System.Drawing.Point(42, 3);
            this.tbMinTime.Maximum = 24;
            this.tbMinTime.Name = "tbMinTime";
            this.tbMinTime.Size = new System.Drawing.Size(529, 23);
            this.tbMinTime.TabIndex = 17;
            this.tbMinTime.Text = "metroTrackBar1";
            this.tbMinTime.Value = 6;
            this.tbMinTime.ValueChanged += new System.EventHandler(this.TbMinTime_ValueChanged);
            this.tbMinTime.MouseHover += new System.EventHandler(this.Focus_Hover);
            // 
            // cbAudioDevices
            // 
            this.cbAudioDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAudioDevices.FormattingEnabled = true;
            this.cbAudioDevices.ItemHeight = 23;
            this.cbAudioDevices.Location = new System.Drawing.Point(0, 0);
            this.cbAudioDevices.Margin = new System.Windows.Forms.Padding(0);
            this.cbAudioDevices.Name = "cbAudioDevices";
            this.cbAudioDevices.Size = new System.Drawing.Size(574, 29);
            this.cbAudioDevices.Style = MetroFramework.MetroColorStyle.Green;
            this.cbAudioDevices.TabIndex = 37;
            this.cbAudioDevices.UseSelectable = true;
            this.cbAudioDevices.SelectedIndexChanged += new System.EventHandler(this.cbAudioDevices_SelectedIndexChanged);
            // 
            // tlSpotifyTrackCut
            // 
            this.tlSpotifyTrackCut.ActiveControl = null;
            this.tlSpotifyTrackCut.BackColor = System.Drawing.Color.White;
            this.tlSpotifyTrackCut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlSpotifyTrackCut.Location = new System.Drawing.Point(10, 2);
            this.tlSpotifyTrackCut.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tlSpotifyTrackCut.Name = "tlSpotifyTrackCut";
            this.tlSpotifyTrackCut.PaintTileCount = false;
            this.tlSpotifyTrackCut.Size = new System.Drawing.Size(693, 38);
            this.tlSpotifyTrackCut.Style = MetroFramework.MetroColorStyle.Green;
            this.tlSpotifyTrackCut.TabIndex = 0;
            this.tlSpotifyTrackCut.Text = "TRACKS_ARE_CUT_ON_SPOTIFY";
            this.tlSpotifyTrackCut.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tlSpotifyTrackCut.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tlSpotifyTrackCut.UseCustomBackColor = true;
            this.tlSpotifyTrackCut.UseCustomForeColor = true;
            this.tlSpotifyTrackCut.UseSelectable = true;
            this.tlSpotifyTrackCut.Click += new System.EventHandler(this.TlSpotifyTrackCut_Click);
            this.tlSpotifyTrackCut.Leave += new System.EventHandler(this.TlSpotifyTrackCut_Leave);
            // 
            // tlAdsPlayAndStop
            // 
            this.tlAdsPlayAndStop.ActiveControl = null;
            this.tlAdsPlayAndStop.BackColor = System.Drawing.Color.White;
            this.tlAdsPlayAndStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlAdsPlayAndStop.Location = new System.Drawing.Point(10, 80);
            this.tlAdsPlayAndStop.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tlAdsPlayAndStop.Name = "tlAdsPlayAndStop";
            this.tlAdsPlayAndStop.PaintTileCount = false;
            this.tlAdsPlayAndStop.Size = new System.Drawing.Size(693, 38);
            this.tlAdsPlayAndStop.Style = MetroFramework.MetroColorStyle.Green;
            this.tlAdsPlayAndStop.TabIndex = 1;
            this.tlAdsPlayAndStop.Text = "ADS_PLAY_AND_STOP";
            this.tlAdsPlayAndStop.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tlAdsPlayAndStop.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tlAdsPlayAndStop.UseCustomBackColor = true;
            this.tlAdsPlayAndStop.UseCustomForeColor = true;
            this.tlAdsPlayAndStop.UseSelectable = true;
            this.tlAdsPlayAndStop.Click += new System.EventHandler(this.TlAdsPlayAndStop_Click);
            this.tlAdsPlayAndStop.Leave += new System.EventHandler(this.TlAdsPlayAndStop_Leave);
            // 
            // tlAdAndTrackOverlapOnRecordedTrack
            // 
            this.tlAdAndTrackOverlapOnRecordedTrack.ActiveControl = null;
            this.tlAdAndTrackOverlapOnRecordedTrack.BackColor = System.Drawing.Color.White;
            this.tlAdAndTrackOverlapOnRecordedTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlAdAndTrackOverlapOnRecordedTrack.Location = new System.Drawing.Point(10, 158);
            this.tlAdAndTrackOverlapOnRecordedTrack.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tlAdAndTrackOverlapOnRecordedTrack.Name = "tlAdAndTrackOverlapOnRecordedTrack";
            this.tlAdAndTrackOverlapOnRecordedTrack.PaintTileCount = false;
            this.tlAdAndTrackOverlapOnRecordedTrack.Size = new System.Drawing.Size(693, 38);
            this.tlAdAndTrackOverlapOnRecordedTrack.Style = MetroFramework.MetroColorStyle.Green;
            this.tlAdAndTrackOverlapOnRecordedTrack.TabIndex = 2;
            this.tlAdAndTrackOverlapOnRecordedTrack.Tag = "test test test";
            this.tlAdAndTrackOverlapOnRecordedTrack.Text = "AD_AND_TRACK_OVERLAP_ON_RECORDED_TRACK";
            this.tlAdAndTrackOverlapOnRecordedTrack.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tlAdAndTrackOverlapOnRecordedTrack.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tlAdAndTrackOverlapOnRecordedTrack.UseCustomBackColor = true;
            this.tlAdAndTrackOverlapOnRecordedTrack.UseCustomForeColor = true;
            this.tlAdAndTrackOverlapOnRecordedTrack.UseSelectable = true;
            this.tlAdAndTrackOverlapOnRecordedTrack.Click += new System.EventHandler(this.TlAdAndTrackOverlapOnRecordedTrack_Click);
            this.tlAdAndTrackOverlapOnRecordedTrack.Leave += new System.EventHandler(this.TlAdAndTrackOverlapOnRecordedTrack_Leave);
            // 
            // tlBackgroundNoiceRecordedOnTrack
            // 
            this.tlBackgroundNoiceRecordedOnTrack.ActiveControl = null;
            this.tlBackgroundNoiceRecordedOnTrack.BackColor = System.Drawing.Color.White;
            this.tlBackgroundNoiceRecordedOnTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBackgroundNoiceRecordedOnTrack.Location = new System.Drawing.Point(10, 236);
            this.tlBackgroundNoiceRecordedOnTrack.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tlBackgroundNoiceRecordedOnTrack.Name = "tlBackgroundNoiceRecordedOnTrack";
            this.tlBackgroundNoiceRecordedOnTrack.PaintTileCount = false;
            this.tlBackgroundNoiceRecordedOnTrack.Size = new System.Drawing.Size(693, 38);
            this.tlBackgroundNoiceRecordedOnTrack.Style = MetroFramework.MetroColorStyle.Green;
            this.tlBackgroundNoiceRecordedOnTrack.TabIndex = 3;
            this.tlBackgroundNoiceRecordedOnTrack.Text = "BACKGROUND_NOICE_RECORDED_ON_TRACK";
            this.tlBackgroundNoiceRecordedOnTrack.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tlBackgroundNoiceRecordedOnTrack.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tlBackgroundNoiceRecordedOnTrack.UseCustomBackColor = true;
            this.tlBackgroundNoiceRecordedOnTrack.UseCustomForeColor = true;
            this.tlBackgroundNoiceRecordedOnTrack.UseSelectable = true;
            this.tlBackgroundNoiceRecordedOnTrack.Click += new System.EventHandler(this.TlBackgroundNoiceRecordedOnTrack_Click);
            this.tlBackgroundNoiceRecordedOnTrack.Leave += new System.EventHandler(this.TlBackgroundNoiceRecordedOnTrack_Leave);
            // 
            // tlTrackDetectedAsAd
            // 
            this.tlTrackDetectedAsAd.ActiveControl = null;
            this.tlTrackDetectedAsAd.BackColor = System.Drawing.Color.White;
            this.tlTrackDetectedAsAd.CausesValidation = false;
            this.tlTrackDetectedAsAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlTrackDetectedAsAd.Location = new System.Drawing.Point(10, 314);
            this.tlTrackDetectedAsAd.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tlTrackDetectedAsAd.Name = "tlTrackDetectedAsAd";
            this.tlTrackDetectedAsAd.PaintTileCount = false;
            this.tlTrackDetectedAsAd.Size = new System.Drawing.Size(693, 38);
            this.tlTrackDetectedAsAd.Style = MetroFramework.MetroColorStyle.Green;
            this.tlTrackDetectedAsAd.TabIndex = 4;
            this.tlTrackDetectedAsAd.Text = "TRACK_DETECTED_AS_AN_AD";
            this.tlTrackDetectedAsAd.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tlTrackDetectedAsAd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tlTrackDetectedAsAd.UseCustomBackColor = true;
            this.tlTrackDetectedAsAd.UseCustomForeColor = true;
            this.tlTrackDetectedAsAd.UseSelectable = true;
            this.tlTrackDetectedAsAd.Click += new System.EventHandler(this.TlTrackDetectedAsAd_Click);
            this.tlTrackDetectedAsAd.Leave += new System.EventHandler(this.TlTrackDetectedAsAd_Leave);
            // 
            // tlSpotifyLostFeatures
            // 
            this.tlSpotifyLostFeatures.ActiveControl = null;
            this.tlSpotifyLostFeatures.BackColor = System.Drawing.Color.White;
            this.tlSpotifyLostFeatures.CausesValidation = false;
            this.tlSpotifyLostFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlSpotifyLostFeatures.Location = new System.Drawing.Point(10, 392);
            this.tlSpotifyLostFeatures.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tlSpotifyLostFeatures.Name = "tlSpotifyLostFeatures";
            this.tlSpotifyLostFeatures.PaintTileCount = false;
            this.tlSpotifyLostFeatures.Size = new System.Drawing.Size(693, 38);
            this.tlSpotifyLostFeatures.Style = MetroFramework.MetroColorStyle.Green;
            this.tlSpotifyLostFeatures.TabIndex = 4;
            this.tlSpotifyLostFeatures.Text = "SPOTIFY_LOST_FEATURES";
            this.tlSpotifyLostFeatures.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tlSpotifyLostFeatures.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tlSpotifyLostFeatures.UseCustomBackColor = true;
            this.tlSpotifyLostFeatures.UseCustomForeColor = true;
            this.tlSpotifyLostFeatures.UseSelectable = true;
            this.tlSpotifyLostFeatures.Click += new System.EventHandler(this.TlSpotifyLostFeatures_Click);
            this.tlSpotifyLostFeatures.Leave += new System.EventHandler(this.TlSpotifyLostFeatures_Leave);
            // 
            // FrmEspionSpotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackImage = global::EspionSpotify.Properties.Resources.spytify_logo;
            this.BackImagePadding = new System.Windows.Forms.Padding(24, 12, 0, 0);
            this.BackMaxSize = 250;
            this.ClientSize = new System.Drawing.Size(780, 420);
            this.Controls.Add(this.lnkRelease);
            this.Controls.Add(this.lnkSpy);
            this.Controls.Add(this.tcMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(780, 420);
            this.Name = "FrmEspionSpotify";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEspionSpotify_FormClosing);
            this.tcMenu.ResumeLayout(false);
            this.tabRecord.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tlSettings.ResumeLayout(false);
            this.tlSettings.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tabAdvanced.ResumeLayout(false);
            this.tlAdvanced.ResumeLayout(false);
            this.tlAdvanced.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabFAQ.ResumeLayout(false);
            this.tlFAQ.ResumeLayout(false);
            this.tlFAQ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private MetroTabControl tcMenu;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TableLayoutPanel tlSettings;
        private MetroLabel lblPath;
        private MetroLabel lblMinLength;
        private MetroLabel lblFormat;
        private MetroLabel lblBitRate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private EspionSpotify.Controls.MetroTrackBar tbMinTime;
        private MetroLabel lblMinTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private MetroTextBox txtPath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private EspionSpotify.Controls.MetroComboBox cbBitRate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private MetroRadioButton rbWav;
        private MetroRadioButton rbMp3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private MetroLabel lblSoundCard;
        private MetroLabel lblVolume;
        private EspionSpotify.Controls.MetroTrackBar tbVolumeWin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroPanel iconVolume;
        private MetroLink lnkDirectory;
        private MetroLink lnkClear;
        private MetroLink lnkPath;
        private MetroLink lnkSpy;
        private MetroFramework.Components.MetroToolTip tip;
        private MetroLabel lblPlayingTitle;
        private System.Windows.Forms.Panel iconSpotify;
        private MetroLabel lblLanguage;
        private EspionSpotify.Controls.MetroComboBox cbLanguage;
        private MetroToggle tgDisableAds;
        private MetroLabel lblAds;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroLabel lblDisableAds;
        private System.Windows.Forms.Timer timer1;
        private MetroToggle tgEndingSongDelay;
        private MetroLabel lblEndingSongDelay;
        private MetroLabel lblRecordUnknownTrackType;
        private MetroToggle tgRecordUnkownTrackType;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.TableLayoutPanel tlAdvanced;
        private MetroLabel lblSpy;
        private MetroLabel lblRecorder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private MetroLabel lblMuteAds;
        private MetroToggle tgMuteAds;
        private System.Windows.Forms.TabPage tabFAQ;
        private System.Windows.Forms.TableLayoutPanel tlFAQ;
        private EspionSpotify.Controls.MetroTile tlAdsPlayAndStop;
        private EspionSpotify.Controls.MetroTile tlAdAndTrackOverlapOnRecordedTrack;
        private EspionSpotify.Controls.MetroTile tlBackgroundNoiceRecordedOnTrack;
        private Controls.MetroTile tlSpotifyTrackCut;
        private Controls.MetroTile tlTrackDetectedAsAd;
        private System.Windows.Forms.Label lblTrackDetectedAsAd;
        private System.Windows.Forms.Label lblBackgroundNoiceRecordedOnTrack;
        private System.Windows.Forms.Label lblAdAndTrackOverlapOnRecordedTrack;
        private System.Windows.Forms.Label lblAdsPlayAndStop;
        private System.Windows.Forms.Label lblSpotifyTrackCut;
        private Controls.MetroTile tlSpotifyLostFeatures;
        private System.Windows.Forms.Label lblSpotifyLostFeatures;
        private MetroLink lnkRelease;
        private MetroLabel lblAudioDevice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Controls.MetroComboBox cbAudioDevices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private MetroLabel lblRecordingNum;
        private MetroToggle tgAddSeparators;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private MetroLink lnkNumPlus;
        private MetroLink lnkNumMinus;
        private MetroLabel lblNum;
        private MetroToggle tgNumFiles;
        private MetroLabel lblAddSeparators;
        private MetroToggle tgNumTracks;
        private MetroToggle tgAddFolders;
        private MetroLabel lblNumFiles;
        private MetroLabel lblAddFolders;
        private MetroLabel lblNumTracks;
        private MetroLabel lblDuplicateAlreadyRecordedTrack;
        private MetroToggle tgDuplicateAlreadyRecordedTrack;
        private MetroLabel lblRecordingTimer;
        private System.Windows.Forms.MaskedTextBox txtRecordingTimer;
    }
}

