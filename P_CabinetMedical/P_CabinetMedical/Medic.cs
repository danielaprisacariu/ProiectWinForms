using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_CabinetMedical
{
    public class Medic: Persoana
    {
        string specializare;
        float tarifConsult;

        public Medic(string id, string nume, string cnp, string adresa, string specializare, float tarif):base(id, nume, cnp, adresa)
        {
            this.specializare = specializare;
            this.tarifConsult = tarif;
        }

        public string Specializare
        {
            get { return specializare; }
            set { if (value != null) specializare = value; }
        }
        public float Tarif
        {
            get { return tarifConsult; }
            set { if (value > 0) tarifConsult = value; }
        }

        public override string ToString()
        {
            return base.ToString() + ", " + specializare + ", " + tarifConsult;
        }
    }
}
