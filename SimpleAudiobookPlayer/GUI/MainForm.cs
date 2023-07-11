using SimpleAudiobookPlayer.GUI;
using SimpleAudiobookPlayer.Model;
using SimpleAudiobookPlayer.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


/*
 # TODO
* autosave cache
* ODTWARZANIE: play, pasue, next, prev, load, handle events (end of track, error)
* MainForm:101 - reloading cache'u podczas działania programu
 */

namespace SimpleAudiobookPlayer
{
    public partial class MainForm : Form
    {
        Book current_book;

        public MainForm()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcesExit);
            initialize_components();
        }

        private void OnProcesExit(object sender, EventArgs e)
        {
            Cache.Instance.LastReadBook = current_book;
            CacheManager.SaveCache();
        }

        #region Helper functions

        private void initialize_components()
        {
            current_book = Cache.Instance.LastReadBook;
            SelectBook_ComboBox.Items.AddRange(Cache.Instance.Books.ToArray());
            refresh_displayed_book();
        }

        private List<string> generate_list_of_chapters()
        {
            List<string> filenames = new List<string>();
            List<string> titles = new List<string>();

            current_book.ChapterPaths.ForEach(path => filenames.Add(Path.GetFileNameWithoutExtension(path)));
            current_book.ChapterPaths.ForEach(path => titles.Add(CacheManager.GetChapterTitleByPath(path)));

            for (int i = 0; i < current_book.ChapterPaths.Count; i++)
                if (filenames[i] == titles[i])
                    return filenames;
            return titles;
        }

        private void refresh_displayed_book()
        {
            if (current_book == null)
                return;
            SelectBook_ComboBox.Text = current_book.ToString();
            Chapters_ListBox.Items.Clear();
            Chapters_ListBox.Items.AddRange(generate_list_of_chapters().ToArray());
        }

        #endregion


        #region Event handlers

        // Shows Settings
        private void Settings_Button_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();

        }

        // Loses focus
        private void SelectBook_ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        // Sets new current book
        private void SelectBook_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_book = (Book)SelectBook_ComboBox.SelectedItem;
            refresh_displayed_book();
        }

        // Drops down ComboBox when focued
        private void SelectChapter_ComboBox_Enter(object sender, EventArgs e)
        {
            SelectBook_ComboBox.DroppedDown = true;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            //CacheManager.LoadCache(); TODO: do it mądrze, realoading cache
            SelectBook_ComboBox.Items.Clear();
            SelectBook_ComboBox.Items.AddRange(Cache.Instance.Books.ToArray());
        }

        private void Bottom_TableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        #endregion

    }
}
