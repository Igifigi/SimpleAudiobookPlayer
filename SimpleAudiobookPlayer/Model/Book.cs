using System;
using System.Collections.Generic;

namespace SimpleAudiobookPlayer.Model
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Chapters { get; set; }
        public string Path { get; set; }
        public int LastReadChapter { get; set; }
        public TimeSpan EndTime { get; set; }
        public List<string> ChapterPaths { get; set; }

        public Book(string title, string author, int chapters, string path, int lastReadChapter, TimeSpan endTime, List<string> chapterPaths)
        {
            Title = title;
            Author = author;
            Chapters = chapters;
            Path = path;
            LastReadChapter = lastReadChapter;
            EndTime = endTime;
            ChapterPaths = chapterPaths;
        }

        public override string ToString()
        {
            return $"{Author} \"{Title}\"";
        }
    }
}
