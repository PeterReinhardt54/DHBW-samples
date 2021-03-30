using System;
namespace GoF.Builder
{
    /// <summary>
    /// The 'RollerBuilder' class
    /// </summary>
    class AutoBuilder : AbstractFahrzeugBuilder
    {
        public AutoBuilder()
        {
            fahrzeug = new Fahrzeug("Auto");
        }

        public override void BuildRahmen()
        {
            fahrzeug["Rahmen"] = "Auto Rahmen";
        }

        public override void BuildMotor()
        {
            fahrzeug["Motor"] = "2500 ccm";
        }

        public override void BuildRaeder()
        {
            fahrzeug["Räder"] = "4";
        }

        public override void BuildTueren()
        {
            fahrzeug["Türen"] = "4";
        }
    }
}
