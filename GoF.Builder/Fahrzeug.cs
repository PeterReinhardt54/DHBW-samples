using System;
using System.Collections.Generic;

namespace GoF.Builder
{
    /// <summary>
    /// The 'Fahrzeug' class
    /// </summary>
    class Fahrzeug
    {
        private string _fahrzeugTyp;
        private Dictionary<string, string> _teile = new Dictionary<string, string>();

        // Constructor
        public Fahrzeug(string fahrzeugTyp)
        {
            this._fahrzeugTyp = fahrzeugTyp;
        }

        // Indexer
        public string this[string key]
        {
            get { return _teile[key]; }
            set { _teile[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _fahrzeugTyp);
            Console.WriteLine(" Frame : {0}", _teile["Rahmen"]);
            Console.WriteLine(" Engine : {0}", _teile["Motor"]);
            Console.WriteLine(" #Wheels: {0}", _teile["Räder"]);
            Console.WriteLine(" #Doors : {0}", _teile["Türen"]);
        }
    }
}
