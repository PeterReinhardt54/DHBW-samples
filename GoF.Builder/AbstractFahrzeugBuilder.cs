using System;
namespace GoF.Builder
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    abstract class AbstractFahrzeugBuilder
    {
        protected Fahrzeug fahrzeug;

        // Gets vehicle instance
        public Fahrzeug Fahrzeug
        {
            get { return fahrzeug; }
        }

        // Abstract build methods
        public abstract void BuildRahmen();
        public abstract void BuildMotor();
        public abstract void BuildRaeder();
        public abstract void BuildTueren();
    }
}
