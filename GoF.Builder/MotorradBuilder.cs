using System;
namespace GoF.Builder
{
    /// <summary>
    /// The 'MotorradBuilder' class
    /// </summary>
    class MotorradBuilder : AbstractFahrzeugBuilder
    {
        public MotorradBuilder()
        {
            fahrzeug = new Fahrzeug("Motorrad");
        }

        public override void BuildRahmen()
        {
            fahrzeug["Rahmen"] = "Motorrad Rahmen";
        }

        public override void BuildMotor()
        {
            fahrzeug["Motor"] = "500 ccm";
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
