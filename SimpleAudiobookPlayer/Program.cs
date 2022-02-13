using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleAudiobookPlayer.Model;

namespace SimpleAudiobookPlayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //TODO                                                                                \/ - tutaj dajesz ostatnio odtwarzaną książkę
            //AppDomain.CurrentDomain.ProcessExit += new EventHandler(new MemoryManager().WriteLastReadBookToCache());
        }




    }
}
