using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.IteratorIntegerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerArray a = new IntegerArray(10);
            a[0] = 0;
            a[1] = 1;
            a[2] = 2;
            a[3] = 3;
            a[4] = 4;
            a[5] = 5;
            a[6] = 6;
            a[7] = 7;
            a[8] = 8;
            a[9] = 9;

            // Create Iterator and provide aggregate
            Iterator i = a.CreateIterator();
            Console.WriteLine("Iterating over integer array:");
            object item = i.First();

            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
            
            // Wait for user
            Console.ReadKey();
        }
    }
}
