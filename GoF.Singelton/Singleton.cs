using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Singelton
{
    public sealed class Singleton
    {
        private static Singleton _instance = new Singleton(); // thread safe

        // verhindert Instanziierung
        private Singleton()
        {
        }

        static Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
