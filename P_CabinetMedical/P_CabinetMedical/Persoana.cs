using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_CabinetMedical
{
    public abstract class Persoana
    {
        readonly string id;
        string nume;
        string cnp;
        string adresa;

        public Persoana(string v_id,string v_nume, string v_cnp, string v_adresa)
        {
            this.id = v_id;
            this.nume = v_nume;
            this.cnp = v_cnp;
            this.adresa = v_adresa;
        }

        public string Id{
            get { return id; }
        }
        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }
        public string CNP
        {
            get { return cnp; }
            set { if (value != null) cnp = value; }
        }
        public string Adresa
        {
            get { return adresa; }
            set { if (value != null) adresa = value; }
        }

        public override string ToString()
        {
            return id + ", " + nume + ", " + cnp + ", " + adresa ;
        }
    }
}
