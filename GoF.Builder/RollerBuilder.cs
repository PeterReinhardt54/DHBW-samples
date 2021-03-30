using System;
namespace GoF.Builder
{
    /// <summary>
    /// The 'RollerBuilder' class
    /// </summary>
    class RollerBuilder : AbstractFahrzeugBuilder
    {
        public RollerBuilder()
        {
            fahrzeug = new Fahrzeug("Roller");
        }

        public override void BuildRahmen()
        {
            fahrzeug["Rahmen"] = "Roller Rahmen";
        }

        public override void BuildMotor()
        {
            fahrzeug["Motor"] = "50 ccm";
        }

        public override void BuildRaeder()
        {
            fahrzeug["Räder"] = "2";
        }

        public override void BuildTueren()
        {
            fahrzeug["Türen"] = "0";
        }
    }
}
