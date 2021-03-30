using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // This sample demonstrates the Facade pattern as a MortgageApplication object 
            // (= Hypothekendarlehen)
            // which provides a simplified interface to a large subsystem of classes 
            // measuring the creditworthyness of an applicant. 

            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);
            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user
            Console.ReadKey();
        }
    }
}
