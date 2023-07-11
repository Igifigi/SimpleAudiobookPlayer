using Newtonsoft.Json.Bson;
using SimpleAudiobookPlayer.Utils;
using System.Collections.Generic;

namespace SimpleAudiobookPlayer.Model
{
    internal class Cache
    {
        // SINGLETON of CACHE

        private static Cache instance; // class instance
        private static readonly object lock_object = new object(); // object to use with DCL pattern

        public List<Book> Books { get; set; }
        public Book LastReadBook { get; set; }

        private Cache()
        {
            var tuple = CacheManager.LoadCache();
            Books = tuple.Item1;
            LastReadBook = tuple.Item2;
        }

        public static Cache Instance
        {
            get
            {
                if (instance == null)
                    lock (lock_object)
                    {
                        if (instance == null)
                            instance = new Cache();
                    }
                return instance;
            }
        }
    }
}
