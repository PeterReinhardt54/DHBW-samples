using System;
namespace GoF.AbstractFactory
{
    /// <summary>
    /// The 'Loewe' class
    /// </summary>
    class Loewe : AbstractFleischfresser
    {
        public override void Frisst(AbstractPflanzenfresser h)
        {
            // Frisst Gnu
            Console.WriteLine(this.GetType().Name + " frisst " + h.GetType().Name);
        }
    }
}
