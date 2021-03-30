using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            // This sample demonstrates the Interpreter pattern 
            // which is used to convert a Roman numeral to a decimal. 

            string roman = "MCCXLIX";

            Context context = new Context(roman);

            // Build the 'parse tree'
            List<Expression> tree = new List<Expression>();

            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}", roman, context.Output);

            // Wait for user
            Console.ReadKey();
        }
    }
}
