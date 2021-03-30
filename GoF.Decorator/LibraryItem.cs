using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Decorator
{
    /// <summary>
    /// The 'LibraryItem' abstract class
    /// </summary>
    abstract class LibraryItem
    {
        private int _numCopies;

        // Property Setter/Getter
        public int NumCopies
        {
            get
            {
                return _numCopies;
            }
            set
            {
                _numCopies = value;
            }
        }
        public abstract void Display();
    }
}
