using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Adapter
{
    class RichCompound : Compound
    {
        private ChemicalDatabase _db;

        // Constructor
        public RichCompound(string name) : base(name)
        {
        }

        public override void Display()
        {
            // The Adaptee
            _db = new ChemicalDatabase();
            _boilingPoint = _db.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _db.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _db.GetMolecularWeight(_chemical);
            _molecularFormula = _db.GetMolecularStructure(_chemical);
            base.Display();
            Console.WriteLine(" Formula: {0}", _molecularFormula);
            Console.WriteLine(" Weight : {0}", _molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", _boilingPoint);
        }
    }
}
