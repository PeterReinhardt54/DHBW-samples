using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // This sample demonstrates the Factory method offering flexibility 
            // in creating different documents. The derived Document classes Report and Resume 
            // instantiate extended versions of the Document class. 
            // Here, the Factory Method is called in the constructor of the Document base class. 

            // Note: constructors call Factory Method
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}
