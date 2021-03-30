using System;

namespace GoF.AbstractFactory
{
    class MainClass
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            // Create and run the African animal world
            AbstractContinentFactory africa = new AfricaFactory();
            Tierwelt world = new Tierwelt(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            AbstractContinentFactory america = new AmericaFactory();
            world = new Tierwelt(america);
            world.RunFoodChain();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
