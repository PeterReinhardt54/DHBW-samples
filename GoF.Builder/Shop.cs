using System;

namespace GoF.Builder
{
    /// <summary>
    /// The 'Shop' class
    /// </summary>
    class Shop
    {
        // Builder uses a complex series of steps
        public void Construct(AbstractFahrzeugBuilder fahrzeugBuilder)
        {
            fahrzeugBuilder.BuildRahmen();
            fahrzeugBuilder.BuildMotor();
            fahrzeugBuilder.BuildRaeder();
            fahrzeugBuilder.BuildTueren();
        }
    }
}
