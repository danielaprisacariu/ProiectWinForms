using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_CabinetMedical
{
    public class Pacient: Persoana, ICloneable
    {
        int varsta;

        public Pacient(string id, string nume, string cnp, string adresa, int varsta):base(id, nume, cnp, adresa)
        {
            this.varsta = varsta;
        }

        public int Varsta
        {
            get { return varsta; }
            set { if (value > 0) varsta = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return base.ToString() + ", " + varsta;
        }
    }
}
