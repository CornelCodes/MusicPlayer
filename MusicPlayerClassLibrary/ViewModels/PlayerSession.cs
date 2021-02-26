using MusicPlayerClassLibrary.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerClassLibrary.ViewModels
{
    public class PlayerSession
    {
        private AudioFileHandler audioHandler;
        public List<string> AudioFiles { get; private set; }

        public PlayerSession()
        {
            audioHandler = new AudioFileHandler();
        }

        public void SetDirectory(string directory)
        {
            audioHandler.SetDirectory(directory);
        }

        public List<string> GetAudioFiles()
        {
            AudioFiles = audioHandler.GetAudioFiles();
            return AudioFiles;
        }

        public void PlaySong(string audioFilePath)
        {
            audioHandler.Play(audioFilePath);
        }

        public void StopSong()
        {
            audioHandler.Stop();
        }
    }
}
