﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Resources;
using System.Security.Principal;
using System.Windows.Forms;

namespace EspionSpotify
{
    internal static class Administrator
    {
        public static bool EnsureAdmin()
        {
            if (!IsNotAdmin()) return true;
            if (MetroFramework.MetroMessageBox.Show(
                FrmEspionSpotify.Instance,
                FrmEspionSpotify.Rm.GetString($"msgEnsureAdminContent"),
                FrmEspionSpotify.Rm.GetString($"msgEnsureAdminTitle"),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes) return false;

            var exe = Process.GetCurrentProcess().MainModule.FileName;
            var info = new ProcessStartInfo(exe)
            {
                Verb = "runas",
                UseShellExecute = true
            };

            try
            {
                Process.Start(info);
                Application.Exit();
            }
            catch
            {
                return false;
            }

            return false;
        }

        private static bool IsNotAdmin()
        {
            var principalIdentity = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            return !principalIdentity.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
