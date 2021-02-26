using MusicPlayerClassLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    static class Program
    {
        //Music player
        //Units:
        //File explorer - Get all audio files in given directory
        //Playback handler - Handles play, pause, stop, skip, time slider
        //Audio handler - Control volume, audio output etc


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PlayerSession playerSession = new PlayerSession();
            Application.Run(new musicPlayerMainForm(playerSession));
        }
    }
}
