using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Book(string title, string author, int chapters, string path)
        {
            this.Title = title;
            this.Author = author;
            this.Chapters = chapters;
            this.Path = path;
        }
    }
}
