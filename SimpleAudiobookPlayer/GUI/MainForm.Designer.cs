
namespace SimpleAudiobookPlayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.chaptersListBox = new System.Windows.Forms.ListBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.audioPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.selectBookComboBox = new System.Windows.Forms.ComboBox();
            this.testplayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coverPictureBox.BackgroundImage")));
            this.coverPictureBox.Location = new System.Drawing.Point(13, 56);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(512, 512);
            this.coverPictureBox.TabIndex = 0;
            this.coverPictureBox.TabStop = false;
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.Transparent;
            this.pauseButton.BackgroundImage = global::SimpleAudiobookPlayer.Properties.Resources.pause_button;
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pauseButton.Location = new System.Drawing.Point(13, 574);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(64, 64);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = global::SimpleAudiobookPlayer.Properties.Resources.settings;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.Location = new System.Drawing.Point(153, 574);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(64, 64);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::SimpleAudiobookPlayer.Properties.Resources.play_buttton;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButton.Location = new System.Drawing.Point(83, 574);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(64, 64);
            this.playButton.TabIndex = 3;
            this.playButton.UseVisualStyleBackColor = false;
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Location = new System.Drawing.Point(530, 583);
            this.volumeTrackBar.Maximum = 25;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(512, 45);
            this.volumeTrackBar.TabIndex = 4;
            this.volumeTrackBar.Scroll += new System.EventHandler(this.volumeTrackBar_Scroll);
            // 
            // chaptersListBox
            // 
            this.chaptersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chaptersListBox.FormattingEnabled = true;
            this.chaptersListBox.ItemHeight = 24;
            this.chaptersListBox.Location = new System.Drawing.Point(531, 56);
            this.chaptersListBox.Name = "chaptersListBox";
            this.chaptersListBox.Size = new System.Drawing.Size(512, 508);
            this.chaptersListBox.TabIndex = 5;
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(223, 574);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(302, 64);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "00:00 / 00:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // audioPlayer
            // 
            this.audioPlayer.Enabled = true;
            this.audioPlayer.Location = new System.Drawing.Point(1156, 310);
            this.audioPlayer.Name = "audioPlayer";
            this.audioPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("audioPlayer.OcxState")));
            this.audioPlayer.Size = new System.Drawing.Size(170, 157);
            this.audioPlayer.TabIndex = 7;
            this.audioPlayer.Visible = false;
            // 
            // selectBookComboBox
            // 
            this.selectBookComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectBookComboBox.FormattingEnabled = true;
            this.selectBookComboBox.Location = new System.Drawing.Point(13, 13);
            this.selectBookComboBox.Name = "selectBookComboBox";
            this.selectBookComboBox.Size = new System.Drawing.Size(1029, 37);
            this.selectBookComboBox.TabIndex = 8;
            this.selectBookComboBox.Text = "Wybierz książkę";
            // 
            // testplayer
            // 
            this.testplayer.Enabled = true;
            this.testplayer.Location = new System.Drawing.Point(725, 634);
            this.testplayer.Name = "testplayer";
            this.testplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("testplayer.OcxState")));
            this.testplayer.Size = new System.Drawing.Size(307, 85);
            this.testplayer.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 767);
            this.Controls.Add(this.testplayer);
            this.Controls.Add(this.selectBookComboBox);
            this.Controls.Add(this.audioPlayer);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.chaptersListBox);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.coverPictureBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.ListBox chaptersListBox;
        private System.Windows.Forms.Label timeLabel;
        private AxWMPLib.AxWindowsMediaPlayer audioPlayer;
        private System.Windows.Forms.ComboBox selectBookComboBox;
        private AxWMPLib.AxWindowsMediaPlayer testplayer;
    }
}

