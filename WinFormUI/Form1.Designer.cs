
namespace WinFormUI
{
    partial class musicPlayerMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileExplorerGroupBox = new System.Windows.Forms.GroupBox();
            this.audioFileListBox = new System.Windows.Forms.ListBox();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.directoryTextBoxLabel = new System.Windows.Forms.Label();
            this.directoryButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.fileExplorerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileExplorerGroupBox
            // 
            this.fileExplorerGroupBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.fileExplorerGroupBox.Controls.Add(this.directoryButton);
            this.fileExplorerGroupBox.Controls.Add(this.directoryTextBoxLabel);
            this.fileExplorerGroupBox.Controls.Add(this.directoryTextBox);
            this.fileExplorerGroupBox.Controls.Add(this.audioFileListBox);
            this.fileExplorerGroupBox.Location = new System.Drawing.Point(2, 2);
            this.fileExplorerGroupBox.Name = "fileExplorerGroupBox";
            this.fileExplorerGroupBox.Size = new System.Drawing.Size(780, 274);
            this.fileExplorerGroupBox.TabIndex = 0;
            this.fileExplorerGroupBox.TabStop = false;
            this.fileExplorerGroupBox.Text = "File Explorer";
            // 
            // audioFileListBox
            // 
            this.audioFileListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.audioFileListBox.FormattingEnabled = true;
            this.audioFileListBox.Location = new System.Drawing.Point(3, 46);
            this.audioFileListBox.Name = "audioFileListBox";
            this.audioFileListBox.Size = new System.Drawing.Size(774, 225);
            this.audioFileListBox.TabIndex = 0;
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(499, 19);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.ReadOnly = true;
            this.directoryTextBox.Size = new System.Drawing.Size(238, 20);
            this.directoryTextBox.TabIndex = 1;
            // 
            // directoryTextBoxLabel
            // 
            this.directoryTextBoxLabel.AutoSize = true;
            this.directoryTextBoxLabel.Location = new System.Drawing.Point(496, 3);
            this.directoryTextBoxLabel.Name = "directoryTextBoxLabel";
            this.directoryTextBoxLabel.Size = new System.Drawing.Size(49, 13);
            this.directoryTextBoxLabel.TabIndex = 2;
            this.directoryTextBoxLabel.Text = "Directory";
            // 
            // directoryButton
            // 
            this.directoryButton.Location = new System.Drawing.Point(743, 19);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(26, 20);
            this.directoryButton.TabIndex = 3;
            this.directoryButton.Text = "...";
            this.directoryButton.UseVisualStyleBackColor = true;
            this.directoryButton.Click += new System.EventHandler(this.directoryButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(13, 283);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(94, 283);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(175, 283);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // musicPlayerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 313);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.fileExplorerGroupBox);
            this.Name = "musicPlayerMainForm";
            this.Text = "Music Player";
            this.fileExplorerGroupBox.ResumeLayout(false);
            this.fileExplorerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fileExplorerGroupBox;
        private System.Windows.Forms.Button directoryButton;
        private System.Windows.Forms.Label directoryTextBoxLabel;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.ListBox audioFileListBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
    }
}

