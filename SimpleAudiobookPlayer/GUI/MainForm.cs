using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
//using AudioSwitcher.AudioApi.CoreAudio;
using SimpleAudiobookPlayer.Model;
using SimpleAudiobookPlayer.GUI;

namespace SimpleAudiobookPlayer
{
    public partial class MainForm : Form
    {
        List<Book> readBooks = new List<Book>();
        //Book currentlyReadBook = ne
        //Book lastReadBook = new Book();
        MemoryManager mm = new MemoryManager();
        public MainForm()
        {
            InitializeComponent();
            InitializeElements();
            
            //memoryManager.ReadBooksFromCache();
            //memoryManager.testBooks();
            test();
        }

        private void InitializeElements()
        {
            readBooks = mm.ReadBooksFromCache();
            readBooks.ForEach(book => selectBookComboBox.Items.Add(book.Author + " \"" + book.Title + "\""));
        }

        private void InitializeBooks()
        {

        }

        private void test()
        {
            //Console.WriteLine("The path for the executable file that started the application is: " + Application.StartupPath);
            //CoreAudioDevice coreAudioDevice = new CoreAudioController().DefaultPlaybackDevice;
            //Console.WriteLine(coreAudioDevice.Volume);
            mm.testBooks();
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

        //private void PrintStartupPath()
        //{
        //    textBox1.Text = "The path for the executable file that " +
        //       "started the application is: " +
        //       Application.StartupPath;
        //}
    }
}
