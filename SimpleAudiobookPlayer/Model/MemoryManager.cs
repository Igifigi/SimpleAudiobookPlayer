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

namespace SimpleAudiobookPlayer.Model
{
    class MemoryManager
    {
        readonly string books_cache_path = Application.StartupPath.ToString() + @"\books.json";
        readonly string last_read_book_path = Application.StartupPath.ToString() + @"\last_read_book.json";
        UserCommunication uc = new UserCommunication();

        #region Technical functions

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
            if (File.Exists(last_read_book_path))
            {
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
            return null;
        }

        public string GetCoverPathByBookPath(string bookPath)
        {
            return null;
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
