namespace SimpleAudiobookPlayer.GUI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.DeleteBook_Button = new System.Windows.Forms.Button();
            this.SelectBook_ComboBox = new System.Windows.Forms.ComboBox();
            this.SelectPath_Button = new System.Windows.Forms.Button();
            this.AddBook_Button = new System.Windows.Forms.Button();
            this.PathGuide_Label = new System.Windows.Forms.Label();
            this.Path_Label = new System.Windows.Forms.Label();
            this.AuthorGuide_Label = new System.Windows.Forms.Label();
            this.Author_TextBox = new System.Windows.Forms.TextBox();
            this.TitleGuide_Label = new System.Windows.Forms.Label();
            this.Title_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeleteBook_Button
            // 
            this.DeleteBook_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteBook_Button.Location = new System.Drawing.Point(16, 181);
            this.DeleteBook_Button.Name = "DeleteBook_Button";
            this.DeleteBook_Button.Size = new System.Drawing.Size(377, 39);
            this.DeleteBook_Button.TabIndex = 5;
            this.DeleteBook_Button.Text = "Usuń książkę";
            this.DeleteBook_Button.UseVisualStyleBackColor = true;
            this.DeleteBook_Button.Click += new System.EventHandler(this.DeleteBook_Button_Click);
            // 
            // SelectBook_ComboBox
            // 
            this.SelectBook_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectBook_ComboBox.FormattingEnabled = true;
            this.SelectBook_ComboBox.Location = new System.Drawing.Point(16, 147);
            this.SelectBook_ComboBox.Name = "SelectBook_ComboBox";
            this.SelectBook_ComboBox.Size = new System.Drawing.Size(377, 28);
            this.SelectBook_ComboBox.TabIndex = 4;
            // 
            // SelectPath_Button
            // 
            this.SelectPath_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectPath_Button.Location = new System.Drawing.Point(16, 102);
            this.SelectPath_Button.Name = "SelectPath_Button";
            this.SelectPath_Button.Size = new System.Drawing.Size(185, 39);
            this.SelectPath_Button.TabIndex = 2;
            this.SelectPath_Button.Text = "Wybierz folder";
            this.SelectPath_Button.UseVisualStyleBackColor = true;
            this.SelectPath_Button.Click += new System.EventHandler(this.SelectPath_Button_Click);
            // 
            // AddBook_Button
            // 
            this.AddBook_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddBook_Button.Location = new System.Drawing.Point(207, 102);
            this.AddBook_Button.Name = "AddBook_Button";
            this.AddBook_Button.Size = new System.Drawing.Size(186, 39);
            this.AddBook_Button.TabIndex = 3;
            this.AddBook_Button.Text = "Dodaj książkę";
            this.AddBook_Button.UseVisualStyleBackColor = true;
            this.AddBook_Button.Click += new System.EventHandler(this.AddBook_Button_Click);
            // 
            // PathGuide_Label
            // 
            this.PathGuide_Label.AutoSize = true;
            this.PathGuide_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PathGuide_Label.Location = new System.Drawing.Point(12, 76);
            this.PathGuide_Label.Name = "PathGuide_Label";
            this.PathGuide_Label.Size = new System.Drawing.Size(65, 20);
            this.PathGuide_Label.TabIndex = 16;
            this.PathGuide_Label.Text = "Ścieżka";
            // 
            // Path_Label
            // 
            this.Path_Label.BackColor = System.Drawing.SystemColors.Control;
            this.Path_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Path_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Path_Label.Location = new System.Drawing.Point(83, 73);
            this.Path_Label.Name = "Path_Label";
            this.Path_Label.Size = new System.Drawing.Size(310, 26);
            this.Path_Label.TabIndex = 15;
            this.Path_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AuthorGuide_Label
            // 
            this.AuthorGuide_Label.AutoSize = true;
            this.AuthorGuide_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AuthorGuide_Label.Location = new System.Drawing.Point(12, 47);
            this.AuthorGuide_Label.Name = "AuthorGuide_Label";
            this.AuthorGuide_Label.Size = new System.Drawing.Size(48, 20);
            this.AuthorGuide_Label.TabIndex = 14;
            this.AuthorGuide_Label.Text = "Autor";
            // 
            // Author_TextBox
            // 
            this.Author_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_TextBox.Location = new System.Drawing.Point(66, 44);
            this.Author_TextBox.Name = "Author_TextBox";
            this.Author_TextBox.Size = new System.Drawing.Size(327, 26);
            this.Author_TextBox.TabIndex = 1;
            // 
            // TitleGuide_Label
            // 
            this.TitleGuide_Label.AutoSize = true;
            this.TitleGuide_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleGuide_Label.Location = new System.Drawing.Point(12, 15);
            this.TitleGuide_Label.Name = "TitleGuide_Label";
            this.TitleGuide_Label.Size = new System.Drawing.Size(43, 20);
            this.TitleGuide_Label.TabIndex = 12;
            this.TitleGuide_Label.Text = "Tytuł";
            // 
            // Title_TextBox
            // 
            this.Title_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title_TextBox.Location = new System.Drawing.Point(61, 12);
            this.Title_TextBox.Name = "Title_TextBox";
            this.Title_TextBox.Size = new System.Drawing.Size(332, 26);
            this.Title_TextBox.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 234);
            this.Controls.Add(this.DeleteBook_Button);
            this.Controls.Add(this.SelectBook_ComboBox);
            this.Controls.Add(this.SelectPath_Button);
            this.Controls.Add(this.AddBook_Button);
            this.Controls.Add(this.PathGuide_Label);
            this.Controls.Add(this.Path_Label);
            this.Controls.Add(this.AuthorGuide_Label);
            this.Controls.Add(this.Author_TextBox);
            this.Controls.Add(this.TitleGuide_Label);
            this.Controls.Add(this.Title_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(421, 273);
            this.MinimumSize = new System.Drawing.Size(421, 273);
            this.Name = "SettingsForm";
            this.Text = "Ustawienia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBook_Button;
        private System.Windows.Forms.ComboBox SelectBook_ComboBox;
        private System.Windows.Forms.Button SelectPath_Button;
        private System.Windows.Forms.Button AddBook_Button;
        private System.Windows.Forms.Label PathGuide_Label;
        private System.Windows.Forms.Label Path_Label;
        private System.Windows.Forms.Label AuthorGuide_Label;
        private System.Windows.Forms.TextBox Author_TextBox;
        private System.Windows.Forms.Label TitleGuide_Label;
        private System.Windows.Forms.TextBox Title_TextBox;
    }
}