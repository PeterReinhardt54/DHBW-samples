using System;
namespace GoF.AbstractFactory
{
    /// <summary>
    /// The 'AbstractFleischfresser' abstract class
    /// </summary>
    abstract class AbstractFleischfresser
    {
        public abstract void Frisst(AbstractPflanzenfresser h);
    }
}
