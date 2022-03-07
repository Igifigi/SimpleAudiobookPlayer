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

namespace SimpleAudiobookPlayer.Model
{
    class Book
    {
        public string Title
        {
            get; set;
        }
        public string Author
        {
            get; set;
        }
        public int Chapters
        {
            get; set;
        }
        public string Path
        {
            get; set;
        }
        public int LastReadChapter
        {
            get; set;
        }
        public TimeSpan EndTime
        {
            get; set;
        }
        public List<string> ChaptersPaths
        {
            get; set;
        }

        public Book(string title, string author, int chapters, string path, int lastReadChapter, TimeSpan endTime, List<string> chaptersPaths)
        {
            this.Title = title;
            this.Author = author;
            this.Chapters = chapters;
            this.Path = path;
            this.LastReadChapter = lastReadChapter;
            this.EndTime = endTime;
            this.ChaptersPaths = chaptersPaths;
        }
    }
}
