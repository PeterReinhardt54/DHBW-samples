using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.IteratorIntegerArray
{
    /// <summary>
    /// The 'IntegerArrayIterator' class
    /// </summary>
    class IntegerArrayIterator : Iterator
    {
        private IntegerArray _iarr;
        private int _current = 0;

        // Constructor
        public IntegerArrayIterator(IntegerArray iarr)
        {
            this._iarr = iarr;
        }

        // Gets first iteration item
        public override object First()
        {
            return _iarr[0];
        }

        // Gets next iteration item
        public override object Next()
        {
            object ret = null;
            if (_current<_iarr.Count - 1)
            {
                ret = _iarr[++_current];
            }
            return ret;
        }

        // Gets current iteration item
        public override object CurrentItem()
        {
            return _iarr[_current];
        }

        // Gets whether iterations are complete
        public override bool IsDone()
        {
            return _current >= _iarr.Count;
        }
    }
}
