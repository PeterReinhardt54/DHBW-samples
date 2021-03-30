using System;
namespace GoF.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory' class AmerikaFactory
    /// </summary>
    class AmericaFactory : AbstractContinentFactory
    {
        public override AbstractPflanzenfresser CreatePflanzenfresser()
        {
            return new Bison();
        }
        public override AbstractFleischfresser CreateFleischfresser()
        {
            return new Wolf();
        }
    }
}
