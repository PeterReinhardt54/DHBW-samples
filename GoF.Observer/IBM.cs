using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Observer
{
    /// <summary>
    /// The 'ConcreteSubject' IBM class
    /// </summary>
    class IBM : Stock
    {

        // Constructor
        public IBM(string symbol, double price) : base(symbol, price)
        {
        }
    }
}
