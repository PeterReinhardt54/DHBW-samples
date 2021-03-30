using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.IteratorMP3
{
    class Program
    {
        static void Main(string[] args)
        {
            MP3Player player = new MP3Player();
            player.PlayAllTitlesRandom();

            Console.ReadKey();
        }
    }
}
