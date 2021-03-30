using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // This sample demonstrates the Command pattern used in a simple calculator
            // with unlimited number of undo's and redo's. 
            // Note that in C#  the word 'operator' is a keyword. 
            // Prefixing it with '@' allows using it as an identifier. 

            // Create user and let her compute
            User user = new User();

            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            // Wait for user
            Console.ReadKey();
        }
    }
}

