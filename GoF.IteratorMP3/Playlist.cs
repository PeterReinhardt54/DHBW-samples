using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.IteratorMP3
{
    public interface Playlist<T>
    {
        Iterator<T> CreateIterator();
    }
}
