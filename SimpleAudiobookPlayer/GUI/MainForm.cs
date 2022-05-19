using System;
using System.Collections.Generic;
using System.Media;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using WMPLib;
using Id3;
//using AudioSwitcher.AudioApi.CoreAudio;
using SimpleAudiobookPlayer.Model;
using SimpleAudiobookPlayer.GUI;

namespace SimpleAudiobookPlayer
{

    public partial class MainForm : Form
    {
        MemoryManager mm = new MemoryManager();
        List<Book> readBooks;
        Book selectedBook;
        Book lastReadBook;
        string actualChapterPath;
        string nextChapterPath;

        SoundPlayer player = new SoundPlayer();

        #region Media player functions

        private void PlayFile(string path)
        {
            player.SoundLocation = path;
            if (player.IsLoadCompleted)
            {
                player.PlaySync();
                if(selectedBook.ChaptersPaths.FindIndex(x => actualChapterPath))
                //play next chapter here
            }
            player.Play();
        }

        private void Stop()
        {
            player.Stop();
        }




        #endregion


        public MainForm()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            InitializeComponent();
            readBooks = mm.ReadBooksFromCache();
            lastReadBook = mm.ReadLastReadBookFromCache();
            InitializeElements();
            RefreshChapters(lastReadBook);
        }
        private void OnProcessExit(object sender, EventArgs e)
        {
            mm.WriteLastReadBookToCache(selectedBook);
        }

        private void InitializeElements()
        {
            readBooks.ForEach(book => selectBookComboBox.Items.Add(book.Author + " \"" + book.Title + "\""));
            for (int i = 0; i < readBooks.Count; i++)
                if (mm.AreEqual(readBooks[i], lastReadBook))
                    selectBookComboBox.SelectedIndex = i;
        }

        private void RefreshChapters(Book book)
        {
            book.ChaptersPaths.ForEach(x => chaptersListBox.Items.Add(mm.GetChapterTitleByPath(x)));
        }

        private void test()
        {
            foreach(var x in readBooks)
            {
                Console.WriteLine(x.Author + " " + x.Chapters + " " + x.EndTime + " " + x.LastReadChapter + " " + x.Path + " " + x.Title);
                foreach(var pth in x.ChaptersPaths)
                {
                    Console.WriteLine(pth);
                }
            }
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            //Console.WriteLine("The path for the executable file that started the application is: " + Application.StartupPath);
            //CoreAudioDevice coreAudioDevice = new CoreAudioController().DefaultPlaybackDevice;
            //Console.WriteLine(coreAudioDevice.Volume);
            //mm.testBooks();
            
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm sF = new SettingsForm();
            sF.ShowDialog();
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            //TODO: Volume control

            //CoreAudioDevice coreAudioDevice = new CoreAudioController().DefaultPlaybackDevice;
            //Console.WriteLine(coreAudioDevice.Volume);
            //CoreAudioDevice cad = new CoreAudioController().DefaultPlaybackDevice;
            //cad.Volume = 80;
            
            //Console.WriteLine("Current volume: " + );
        }

        private void selectBookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBook = readBooks[selectBookComboBox.SelectedIndex];
            RefreshChapters(selectedBook);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int chapIndex = chaptersListBox.SelectedIndex;
            string nextchappath = selectedBook.ChaptersPaths[chaptersListBox.SelectedIndex];
            //Directory.GetFiles(selectedBook., "*.mp3", SearchOption.TopDirectoryOnly).ToList();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {

        }

        private void chaptersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualChapterPath = selectedBook.ChaptersPaths[chaptersListBox.SelectedIndex];
        }

        //private void PrintStartupPath()
        //{
        //    textBox1.Text = "The path for the executable file that " +
        //       "started the application is: " +
        //       Application.StartupPath;
        //}
    }

    
}
