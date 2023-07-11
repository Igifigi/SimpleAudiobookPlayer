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
            this.Main_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Bottom_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Forward_Button = new System.Windows.Forms.Button();
            this.Play_Button = new System.Windows.Forms.Button();
            this.Pasue_Button = new System.Windows.Forms.Button();
            this.Rewind_Button = new System.Windows.Forms.Button();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.TimeStamp_Label = new System.Windows.Forms.Label();
            this.Middle_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ChapterCover_PictureBox = new System.Windows.Forms.PictureBox();
            this.Chapters_ListBox = new System.Windows.Forms.ListBox();
            this.SelectBook_ComboBox = new System.Windows.Forms.ComboBox();
            this.Main_TableLayoutPanel.SuspendLayout();
            this.Bottom_TableLayoutPanel.SuspendLayout();
            this.Middle_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChapterCover_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_TableLayoutPanel
            // 
            this.Main_TableLayoutPanel.ColumnCount = 1;
            this.Main_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_TableLayoutPanel.Controls.Add(this.Bottom_TableLayoutPanel, 0, 2);
            this.Main_TableLayoutPanel.Controls.Add(this.Middle_TableLayoutPanel, 0, 1);
            this.Main_TableLayoutPanel.Controls.Add(this.SelectBook_ComboBox, 0, 0);
            this.Main_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Main_TableLayoutPanel.Name = "Main_TableLayoutPanel";
            this.Main_TableLayoutPanel.RowCount = 3;
            this.Main_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.Main_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.35294F));
            this.Main_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.Main_TableLayoutPanel.Size = new System.Drawing.Size(1295, 681);
            this.Main_TableLayoutPanel.TabIndex = 0;
            // 
            // Bottom_TableLayoutPanel
            // 
            this.Bottom_TableLayoutPanel.ColumnCount = 6;
            this.Bottom_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Bottom_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Bottom_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Bottom_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Bottom_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Bottom_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Bottom_TableLayoutPanel.Controls.Add(this.Forward_Button, 4, 0);
            this.Bottom_TableLayoutPanel.Controls.Add(this.Play_Button, 3, 0);
            this.Bottom_TableLayoutPanel.Controls.Add(this.Pasue_Button, 2, 0);
            this.Bottom_TableLayoutPanel.Controls.Add(this.Rewind_Button, 1, 0);
            this.Bottom_TableLayoutPanel.Controls.Add(this.Settings_Button, 0, 0);
            this.Bottom_TableLayoutPanel.Controls.Add(this.TimeStamp_Label, 5, 0);
            this.Bottom_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bottom_TableLayoutPanel.Location = new System.Drawing.Point(3, 572);
            this.Bottom_TableLayoutPanel.Name = "Bottom_TableLayoutPanel";
            this.Bottom_TableLayoutPanel.RowCount = 1;
            this.Bottom_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Bottom_TableLayoutPanel.Size = new System.Drawing.Size(1289, 106);
            this.Bottom_TableLayoutPanel.TabIndex = 1;
            this.Bottom_TableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Bottom_TableLayoutPanel_Paint);
            // 
            // Forward_Button
            // 
            this.Forward_Button.BackgroundImage = global::SimpleAudiobookPlayer.Properties.Resources.forward_button;
            this.Forward_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Forward_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Forward_Button.Location = new System.Drawing.Point(515, 3);
            this.Forward_Button.Name = "Forward_Button";
            this.Forward_Button.Size = new System.Drawing.Size(122, 100);
            this.Forward_Button.TabIndex = 4;
            this.Forward_Button.UseVisualStyleBackColor = true;
            // 
            // Play_Button
            // 
            this.Play_Button.BackgroundImage = global::SimpleAudiobookPlayer.Properties.Resources.play_buttton;
            this.Play_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Play_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Play_Button.Location = new System.Drawing.Point(387, 3);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(122, 100);
            this.Play_Button.TabIndex = 3;
            this.Play_Button.UseVisualStyleBackColor = true;
            // 
            // Pasue_Button
            // 
            this.Pasue_Button.BackgroundImage = global::SimpleAudiobookPlayer.Properties.Resources.pause_button;
            this.Pasue_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pasue_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pasue_Button.Location = new System.Drawing.Point(259, 3);
            this.Pasue_Button.Name = "Pasue_Button";
            this.Pasue_Button.Size = new System.Drawing.Size(122, 100);
            this.Pasue_Button.TabIndex = 2;
            this.Pasue_Button.UseVisualStyleBackColor = true;
            // 
            // Rewind_Button
            // 
            this.Rewind_Button.BackgroundImage = global::SimpleAudiobookPlayer.Properties.Resources.rewind_button;
            this.Rewind_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rewind_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rewind_Button.Location = new System.Drawing.Point(131, 3);
            this.Rewind_Button.Name = "Rewind_Button";
            this.Rewind_Button.Size = new System.Drawing.Size(122, 100);
            this.Rewind_Button.TabIndex = 1;
            this.Rewind_Button.UseVisualStyleBackColor = true;
            // 
            // Settings_Button
            // 
            this.Settings_Button.BackgroundImage = global::SimpleAudiobookPlayer.Properties.Resources.settings_button;
            this.Settings_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_Button.Location = new System.Drawing.Point(3, 3);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Size = new System.Drawing.Size(122, 100);
            this.Settings_Button.TabIndex = 0;
            this.Settings_Button.UseVisualStyleBackColor = true;
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Button_Click);
            // 
            // TimeStamp_Label
            // 
            this.TimeStamp_Label.AutoSize = true;
            this.TimeStamp_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.TimeStamp_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeStamp_Label.Location = new System.Drawing.Point(643, 0);
            this.TimeStamp_Label.Name = "TimeStamp_Label";
            this.TimeStamp_Label.Size = new System.Drawing.Size(318, 106);
            this.TimeStamp_Label.TabIndex = 5;
            this.TimeStamp_Label.Text = "00:00 / 00:00";
            this.TimeStamp_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Middle_TableLayoutPanel
            // 
            this.Middle_TableLayoutPanel.ColumnCount = 2;
            this.Middle_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Middle_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.Middle_TableLayoutPanel.Controls.Add(this.ChapterCover_PictureBox, 0, 0);
            this.Middle_TableLayoutPanel.Controls.Add(this.Chapters_ListBox, 1, 0);
            this.Middle_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Middle_TableLayoutPanel.Location = new System.Drawing.Point(3, 50);
            this.Middle_TableLayoutPanel.Name = "Middle_TableLayoutPanel";
            this.Middle_TableLayoutPanel.RowCount = 1;
            this.Middle_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Middle_TableLayoutPanel.Size = new System.Drawing.Size(1289, 516);
            this.Middle_TableLayoutPanel.TabIndex = 1;
            // 
            // ChapterCover_PictureBox
            // 
            this.ChapterCover_PictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChapterCover_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChapterCover_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ChapterCover_PictureBox.Image")));
            this.ChapterCover_PictureBox.Location = new System.Drawing.Point(3, 3);
            this.ChapterCover_PictureBox.Name = "ChapterCover_PictureBox";
            this.ChapterCover_PictureBox.Size = new System.Drawing.Size(509, 510);
            this.ChapterCover_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChapterCover_PictureBox.TabIndex = 0;
            this.ChapterCover_PictureBox.TabStop = false;
            // 
            // Chapters_ListBox
            // 
            this.Chapters_ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chapters_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Chapters_ListBox.FormattingEnabled = true;
            this.Chapters_ListBox.ItemHeight = 24;
            this.Chapters_ListBox.Location = new System.Drawing.Point(518, 3);
            this.Chapters_ListBox.Name = "Chapters_ListBox";
            this.Chapters_ListBox.Size = new System.Drawing.Size(768, 510);
            this.Chapters_ListBox.TabIndex = 0;
            // 
            // SelectBook_ComboBox
            // 
            this.SelectBook_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectBook_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectBook_ComboBox.FormattingEnabled = true;
            this.SelectBook_ComboBox.Location = new System.Drawing.Point(3, 3);
            this.SelectBook_ComboBox.Name = "SelectBook_ComboBox";
            this.SelectBook_ComboBox.Size = new System.Drawing.Size(1289, 41);
            this.SelectBook_ComboBox.TabIndex = 9;
            this.SelectBook_ComboBox.Text = "Wybierz książkę";
            this.SelectBook_ComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectBook_ComboBox_SelectedIndexChanged);
            this.SelectBook_ComboBox.DropDownClosed += new System.EventHandler(this.SelectBook_ComboBox_DropDownClosed);
            this.SelectBook_ComboBox.Enter += new System.EventHandler(this.SelectChapter_ComboBox_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 681);
            this.Controls.Add(this.Main_TableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Text = "Odtwarzacz audiobooków";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Main_TableLayoutPanel.ResumeLayout(false);
            this.Bottom_TableLayoutPanel.ResumeLayout(false);
            this.Bottom_TableLayoutPanel.PerformLayout();
            this.Middle_TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChapterCover_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Main_TableLayoutPanel;
        private System.Windows.Forms.ComboBox SelectBook_ComboBox;
        private System.Windows.Forms.TableLayoutPanel Bottom_TableLayoutPanel;
        private System.Windows.Forms.Button Forward_Button;
        private System.Windows.Forms.Button Play_Button;
        private System.Windows.Forms.Button Pasue_Button;
        private System.Windows.Forms.Button Rewind_Button;
        private System.Windows.Forms.Button Settings_Button;
        private System.Windows.Forms.Label TimeStamp_Label;
        private System.Windows.Forms.TableLayoutPanel Middle_TableLayoutPanel;
        private System.Windows.Forms.PictureBox ChapterCover_PictureBox;
        private System.Windows.Forms.ListBox Chapters_ListBox;
    }
}

