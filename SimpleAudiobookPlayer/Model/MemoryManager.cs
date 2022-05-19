using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SimpleAudiobookPlayer.GUI;
using SimpleAudiobookPlayer.Model;
using SimpleAudiobookPlayer;
using Newtonsoft.Json;
using Id3;

namespace SimpleAudiobookPlayer.Model
{
    class MemoryManager
    {
        static readonly string cache_directory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + @"\SimpleAudioBookPlayer";
        readonly string books_cache_path = cache_directory + @"\books.json";
        readonly string last_read_book_path = cache_directory + @"\last_read_book.json";
        UserCommunication uc = new UserCommunication();

        #region Technical functions

        private void GenerateEmptyDirectory()
        {
            if(!Directory.Exists(cache_directory))
                Directory.CreateDirectory(cache_directory);
        }

        private void GenerateEmptyBooksCacheFile()
        {
            File.Create(books_cache_path);
            File.WriteAllText(books_cache_path, JsonConvert.SerializeObject(new List<Book>()));
        }
        private void GenerateEmptyLastReadBookCacheFile()
        {
            File.Create(last_read_book_path);
            File.WriteAllText(last_read_book_path, string.Empty);
        }

        #endregion

        #region Books cache managment

        public List<Book> ReadBooksFromCache()
        {
            GenerateEmptyDirectory();
            if (File.Exists(books_cache_path))
            {
                try
                {
                    return JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(books_cache_path)).ToList<Book>();
                }
                catch (Exception)
                {
                    uc.ShowErrorBox("Nie udało się odczytyać zawartości pamięci cache!");
                    return new List<Book>();
                }
            }
            else
            {
                GenerateEmptyBooksCacheFile();
                return ReadBooksFromCache();
            }
        }

        public void WriteBooksToCache(List<Book> books)
        {
            File.WriteAllText(books_cache_path, JsonConvert.SerializeObject(books));
        }

        public void ExpandBooksCache(Book book)
        {
            var books = ReadBooksFromCache();
            books.Add(book);
            WriteBooksToCache(books);
        }

        #endregion

        #region Last read book cache managent

        public Book ReadLastReadBookFromCache()
        {
            GenerateEmptyDirectory();
            
            if (File.Exists(last_read_book_path))
            {
                if (File.ReadAllText(last_read_book_path).ToString() == string.Empty)
                    return new Book("", "", 0, "", 0, TimeSpan.Zero, new List<string>());
                try
                {
                    return JsonConvert.DeserializeObject<Book>(File.ReadAllText(last_read_book_path));
                }
                catch (Exception)
                {
                    uc.ShowErrorBox("Nie udało się odczytyać zawartości pamięci cache!");
                    return null;
                }
            }
            else
            {
                GenerateEmptyLastReadBookCacheFile();
                return ReadLastReadBookFromCache();
            }
        }

        public void WriteLastReadBookToCache(Book book)
        {
            File.WriteAllText(last_read_book_path, JsonConvert.SerializeObject(book));
        }

        #endregion

        public List<string> GetChaptersPathsByBookPath(string bookPath)
        {
            return Directory.GetFiles(bookPath, "*.mp3", SearchOption.TopDirectoryOnly).ToList();
        }

        public string GetCoverPathByBookPath(string bookPath)
        {
            return null;
        }

        public string GetChapterTitleByPath(string chpaterPath)
        {
            var chapter = new Mp3(chpaterPath);
            Id3Tag tag = chapter.GetTag(Id3TagFamily.Version2X);
            return tag.Title.ToString();
        }

        public bool AreEqual(Book b1, Book b2)
        {
            if(b1.Author == b2.Author && b1.Title == b2.Title)
                return true;
            return false;
        }


        public void testBooks()
        {
            //Book book = new Book("Księgi Jakubowe", "Ogla Tokarczuk",1, @"R:\POBRANE\Olga Tokarczuk - Księgi Jakubowe (audiobook)",1, TimeSpan.Zero);
            //////var inp = Directory.GetFiles(book.Path, "*.mp3", SearchOption.TopDirectoryOnly);
            //////foreach(var x in inp)
            //////{
            //////    Console.WriteLine(x);
            //////}


            //Book book = new Book("Księgi Jakubowe", "Ogla Tokarczuk", TimeSpan.Zero, 2137);
            //Book book4 = new Book("KsięgiIIIIIIIIIIIII Jakubowe", "Ogla Tokarczuk", TimeSpan.Zero, 2137);
            //List<Book> books = new List<Book>() { book, book4 };
            //File.WriteAllText(books_cache_path, JsonConvert.SerializeObject(books));

            //Console.WriteLine(JsonConvert.SerializeObject(books));

            //string json = JsonConvert.SerializeObject(book, Formatting.Indented);
            //Console.WriteLine(json);
            //Book book2 = JsonConvert.DeserializeObject<Book>(json);
            //Console.WriteLine(book2.Author + " " + book2.Duration);
            //Console.WriteLine();
            //string fromFile = "";
            //if(File.Exists(books_cache_path))
            //{
            //    fromFile = File.ReadAllText(books_cache_path);
            //    File.WriteAllText(books_cache_path, json);
            //}
            //else
            //{
            //    File.Create(books_cache_path);
            //    File.WriteAllText(books_cache_path, json);
            //}
            //Console.WriteLine(fromFile);
        }
    }
}
