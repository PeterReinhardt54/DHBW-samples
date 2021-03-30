using System;
namespace GoF.AbstractFactory
{
    /// <summary>
    /// The 'Wolf' class
    /// </summary>
    class Wolf : AbstractFleischfresser
    {
        public override void Frisst(AbstractPflanzenfresser h)
        {
            // frisst Bison
            Console.WriteLine(this.GetType().Name + " frisst " + h.GetType().Name);
        }
    }
}
