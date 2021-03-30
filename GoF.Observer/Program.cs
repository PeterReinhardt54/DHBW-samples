using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // This sample demonstrates the Observer pattern in which registered investors 
            // are notified every time a stock changes value. 
            Investor sorros = new Investor("Sorros");
            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(sorros);
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Detach(sorros);
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            ibm.Price = 120.10;

            // Wait for user
            Console.ReadKey();
        }
    }
}
