using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Iterator
{
    /// <summary>
    /// The 'IAbstractCollection' interface
    /// </summary>
    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
