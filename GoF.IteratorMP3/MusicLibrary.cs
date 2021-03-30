using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.IteratorMP3
{
    public class MusicLibrary<T> : Playlist<T>
    {
        List<T> title;

        public MusicLibrary()
        {
            title = new List<T>();
        }

        public List<T> GetTitle()
        {
            return title;
        }

        public Iterator<T> CreateIterator()
        {
            RandomIterator<T> iterator = new RandomIterator<T>(title);
            return iterator;
        }

        public void Play(T title)
        {
            Console.WriteLine("Playing title: " + title);
            //Play title ....
        }
    }
}
