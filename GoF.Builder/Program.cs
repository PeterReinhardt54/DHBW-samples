using System;

namespace GoF.Builder
{
    class MainClass
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            AbstractFahrzeugBuilder builder;

            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicles
            builder = new RollerBuilder();
            shop.Construct(builder);
            builder.Fahrzeug.Show();

            builder = new AutoBuilder();
            shop.Construct(builder);
            builder.Fahrzeug.Show();

            builder = new MotorradBuilder();
            shop.Construct(builder);
            builder.Fahrzeug.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
