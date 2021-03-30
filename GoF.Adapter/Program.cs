using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // This structural sample demonstrates the Adapter pattern 
            // which maps the interface of one class onto another so that they can work together.
            // These incompatible classes may come from different libraries or frameworks. 

            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();
            
            // Wait for user
            Console.ReadKey();

            // This sample demonstrates the use of a legacy chemical database.
            // Chemical compound objects access the database through an Adapter interface. 

            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
            
            // Wait for user
            Console.ReadKey();
        }
    }
}
