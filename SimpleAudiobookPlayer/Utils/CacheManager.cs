using Id3;
using Newtonsoft.Json;
using SimpleAudiobookPlayer.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace SimpleAudiobookPlayer.Utils
{
    internal class CacheManager
    {
        private static readonly string cache_dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + @"\SimpleAudioBookPlayer";
        private static readonly string cache_file_dir = $@"{cache_dir}\cache.json";
        private static readonly Tuple<List<Book>, Book> empty_tuple = new Tuple<List<Book>, Book>(new List<Book>(), null);

        private static void prepare_dir()
        {
            if (!Directory.Exists(cache_dir))
                Directory.CreateDirectory(cache_dir);
            if (!File.Exists(cache_file_dir))
                File.Create(cache_file_dir).Close();
        }

        // DO NOT USE
        public static Tuple<List<Book>, Book> LoadCache()
        {
            prepare_dir();
            try
            {
                var read = JsonConvert.DeserializeObject<Tuple<List<Book>, Book>>(File.ReadAllText(cache_file_dir));
                if (read == null)
                    read = empty_tuple;
                return read;
            }
            catch (Exception ex)
            {
                MessageBoxes.ShowErrorBox(ex.Message);
                return empty_tuple;
            }
        }

        public static void SaveCache()
        {
            prepare_dir();
            try
            {
                File.WriteAllText(cache_file_dir, JsonConvert.SerializeObject(new Tuple<List<Book>, Book>(Cache.Instance.Books, Cache.Instance.LastReadBook)));
            }
            catch (Exception ex)
            {
                MessageBoxes.ShowErrorBox(ex.Message);
            }
        }

        public static string GetCoverPathByBookPath(string book_path)
        {
            return null; // TODO
        }

        public static string GetChapterTitleByPath(string chapter_path)
        {
            try
            {
                Mp3 chapter = new Mp3(chapter_path);
                Id3Tag tag = chapter.GetTag(Id3TagFamily.Version2X);
                if (tag != null)
                    return tag.Title.ToString();
            }
            catch (Exception ex)
            {
                MessageBoxes.ShowErrorBox(ex.Message);
            }
            return Path.GetFileNameWithoutExtension(chapter_path);
        }
    }
}
