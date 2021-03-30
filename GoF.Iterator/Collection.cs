using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Iterator
{
    /// <summary>
    /// The concrete 'Collection' class
    /// </summary>
    class Collection : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        // Gets item count
        public int Count
        {
            get
            {
                return _items.Count;
            }
        }

        // Indexer
        public object this[int index]
        {
            get
            {
                return _items[index];
            }

            set
            {
                _items.Add(value);
            }
        }
    }
}
