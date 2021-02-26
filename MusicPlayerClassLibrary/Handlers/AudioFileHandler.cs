using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using NAudio.Wave;


namespace MusicPlayerClassLibrary.Handlers
{
    public class AudioFileHandler
    {
        private string _audioFileDirectory;
        private List<string> _audioFiles;
        private SoundPlayer _player;
        private string inputAudioFilePath;
        private string outputAudioFilePath = @"C:\Temp\TempAudioFiles\convertedSong.wav";

        public SoundPlayer Player
        {
            get { return _player; }
            private set { _player = value; }
        }

        public List<string> AudioFiles
        {
            get { return _audioFiles; }
            private set { _audioFiles = value; }
        }
        public string AudioFileDirectory
        {
            get { return _audioFileDirectory; }
            private set { _audioFileDirectory = value; }
        }

        public AudioFileHandler()
        {
            AudioFiles = new List<string>();
            Player = new SoundPlayer();
        }

        public void SetDirectory(string directory)
        {
            AudioFileDirectory = directory;
        }

        public List<string> GetAudioFiles()
        {
            //Look in directory and find all files
            string[] tempArray = Directory.GetFiles(AudioFileDirectory);

            foreach (var file in tempArray)
            {
                AudioFiles.Add(file);
            }
            return AudioFiles;
        }

        public void Play(string audioFilePath)
        {
            inputAudioFilePath = audioFilePath;
            ConvertToWav();
            Player.SoundLocation = outputAudioFilePath;
            Player.Play();
        }

        public void Stop()
        {
            Player.Stop();
        }

        private void  ConvertToWav()
        {
            using(Mp3FileReader reader = new Mp3FileReader(inputAudioFilePath))
            {
                WaveFileWriter.CreateWaveFile(outputAudioFilePath, reader);
            }
        }
    }
}
