using MusicPlayerClassLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormUI
{
    public partial class musicPlayerMainForm : Form
    {
        private PlayerSession CurrentPlayerSession { get; set; }
        FolderBrowserDialog browserDialog = new FolderBrowserDialog();

        public musicPlayerMainForm(PlayerSession currentPlayerSession)
        {
            InitializeComponent();
            CurrentPlayerSession = currentPlayerSession;
        }

        private void directoryButton_Click(object sender, EventArgs e)
        {
            browserDialog.ShowDialog();
            string tempText = browserDialog.SelectedPath;
            if(directoryTextBox.Text != null)
            {
                directoryTextBox.Text = tempText;
                CurrentPlayerSession.SetDirectory(directoryTextBox.Text);
                DisplayAudioFiles();
            }
        }

        private void DisplayAudioFiles()
        {
            foreach (var file in CurrentPlayerSession.GetAudioFiles())
            {
                audioFileListBox.Items.Add(file);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            CurrentPlayerSession.PlaySong(audioFileListBox.SelectedItem.ToString());
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            CurrentPlayerSession.StopSong();
        }
    }
}
