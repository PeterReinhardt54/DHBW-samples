using System;
namespace GoF.AbstractFactory
{
        /// <summary>
        /// The 'AbstractContinentFactory' abstract class
        /// </summary>
        abstract class AbstractContinentFactory
        {
            public abstract AbstractPflanzenfresser CreatePflanzenfresser();
            public abstract AbstractFleischfresser CreateFleischfresser();
        }
}