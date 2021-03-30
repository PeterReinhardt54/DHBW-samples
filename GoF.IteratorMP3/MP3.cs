using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.IteratorMP3
{
    public class MP3
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }

        public override string ToString()
        {
            return Title + " - " + Artist + " - " + Album;
        }
    }
}
