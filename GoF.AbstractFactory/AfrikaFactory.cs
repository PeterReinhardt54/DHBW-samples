using System;
namespace GoF.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory' class AfrikaFactory
    /// </summary>
    class AfricaFactory : AbstractContinentFactory
    {
        public override AbstractPflanzenfresser CreatePflanzenfresser()
        {
            return new Gnu();
        }
        public override AbstractFleischfresser CreateFleischfresser()
        {
            return new Loewe();
        }
    }
}
