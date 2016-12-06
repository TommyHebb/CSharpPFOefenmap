using System;

namespace CSharpPFOefenmap
{
    public class Stookketel : IVervuiler // implementatie interface IVervuiler
    {
        private float cONormValue;
        public float CONorm // Property
        {
            get
            {
                return cONormValue;
            }
            set
            {
                if (value > 0)
                    cONormValue = value;
            }
        }
        public Stookketel(float cONorm) // Constructor
        {
            this.CONorm = cONorm;
        }
        public double GeefVervuiling() // Implementatie interface IVervuiler
        {
            return CONorm * 100;
        }
    }
}
