using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.IteratorIntegerArray
{
    /// <summary>
    /// The 'IntegerArray' class
    /// </summary>
    class IntegerArray : Aggregate
    {
        private int[] _items;
        public override Iterator CreateIterator()
        {
            return new IntegerArrayIterator(this);
        }

        // Constructor
        public IntegerArray(int num)
        {
            _items = new int[num];
        }

        // Gets item count
        public int Count
        {
            get { return _items.Length; }
        }
        
        // Indexer
        public int this[int index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }
    }
}
