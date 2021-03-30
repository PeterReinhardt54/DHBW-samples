using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Singelton
{
    class Program
    {
        // This sample demonstrates the Singleton pattern as a LoadBalancing object. 
        // Only a single instance (the singleton) of the class can be created 
        // because servers may dynamically come on- or off-line and every request 
        // must go throught the one object that has knowledge about the state of the (web) farm. 

        static void Main(string[] args)
        {
            // Constructor is private -- cannot use new
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
 //           Singleton s3 = new Singleton();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            // Wait for user
            Console.ReadKey();

            LoadBalancer b1 = LoadBalancer.Instance;
            LoadBalancer b2 = LoadBalancer.Instance;
            LoadBalancer b3 = LoadBalancer.Instance;
            LoadBalancer b4 = LoadBalancer.Instance;

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }
        
            // Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.Instance;

            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }

            // Wait for user
            Console.ReadKey();

            // This sample shows the use of the Singleton pattern for a configuration instance.
            Configuration config = Configuration.Instance;
            foreach (var val in config.Values())
            {
                Console.WriteLine("Key : {0} - Value : {1}", val.Key, val.Value);
            }
            config["vier"] = "vier";
            config.Save();

            Configuration config1 = Configuration.Instance;

            if (config == config1)
                Console.WriteLine("gleiche Instanz");

            foreach (var val in config.Values())
            {
                Console.WriteLine("Key : {0} - Value : {1}", val.Key, val.Value);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}
