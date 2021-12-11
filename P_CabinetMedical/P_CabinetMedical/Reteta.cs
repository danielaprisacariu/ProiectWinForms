using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_CabinetMedical
{
    public class Reteta : ICloneable
    {
        public int NrReteta;
        public DateTime Data;
        public Pacient Pacient;
        public string Diagnostic;
        public string Prospect;
        public string IdMedic;

        public static string UnitateSanitara = "Spitalul Nicolae Paulescu";
        public static string Localitate = "Alexandria";
        public static string Judet = "Teleorman";

        public Reteta(int nr, DateTime data, Pacient pacient, string diagnostic, string prospeact, string idMed)
        {
            NrReteta = nr;
            Data = data;
            Pacient = pacient;
            Diagnostic = diagnostic;
            Prospect = prospeact;
            IdMedic = idMed;  
        }

        public object Clone()
        {
            Reteta clona = (Reteta)this.MemberwiseClone();
            Pacient p = clona.Pacient;
            clona.Pacient = p;
            return clona;
        }

        public override string ToString()
        {
            return NrReteta + ", " + Data + ", " + Pacient.ToString() + ", " + Diagnostic + ", " + Prospect + ", " + IdMedic;
        }
    }
}
