using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.IteratorMP3
{
    public class MP3Player
    {
        public void PlayAllTitlesRandom()
        {
            MusicLibrary<MP3> MP3library = new MusicLibrary<MP3>();

            MP3library.GetTitle().Add(new MP3()
            {
                Title = "Ghost",
                Artist = "Ella Henderson",
                Album = "Chapter One"
            });

            MP3library.GetTitle().Add(new MP3()
            {
                Title = "When the Beat Drops Out",
                Artist = "Marlon Roudette",
                Album = "Electric Soul"
            });

            MP3library.GetTitle().Add(new MP3()
            {
                Title = "Auf uns",
                Artist = "Andreas Bourani",
                Album = "Hey"
            });

            Iterator<MP3> iterator = MP3library.CreateIterator();
            while (!iterator.isFinished())
            {
                iterator.next();
                MP3library.Play(iterator.actual());
            }
        }

        public void PlayAllTitlesRandomIntern()
        {
            MusicLibrary<MP3> MP3library = new MusicLibrary<MP3>();

            MP3library.GetTitle().Add(new MP3()
            {
                Title = "Ghost",
                Artist = "Ella Henderson",
                Album = "Chapter One"
            });

            MP3library.GetTitle().Add(new MP3()
            {
                Title = "When the Beat Drops Out",
                Artist = "Marlon Roudette",
                Album = "Electric Soul"
            });

            MP3library.GetTitle().Add(new MP3()
            {
                Title = "Auf uns",
                Artist = "Andreas Bourani",
                Album = "Hey"
            });

            Iterator<MP3> iterator = MP3library.CreateIterator();
            iterator.iterate(x => MP3library.Play(x));
        }
    }
}
