using System;
namespace GoF.AbstractFactory
{
    /// <summary>
    /// The 'Klient' class 
    /// </summary>
    class Tierwelt
    {
        private AbstractPflanzenfresser _pflanzenfresser;
        private AbstractFleischfresser _fleischfresser;

        // Constructor
        public Tierwelt(AbstractContinentFactory factory)
        {
            _pflanzenfresser = factory.CreatePflanzenfresser();
            _fleischfresser = factory.CreateFleischfresser();
        }

        public void RunFoodChain()
        {
            _fleischfresser.Frisst(_pflanzenfresser);
        }
    }
}
