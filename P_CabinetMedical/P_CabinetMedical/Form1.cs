using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_CabinetMedical
{
    public partial class Form1 : Form
    {
        List<Medic> lisatMedici;
        List<Pacient> listaPacienti;
        const string caleFisierMedici = "medici.txt";
        const string caleFisierPacienti = "pacienti.txt";
        public Form1()
        {
            InitializeComponent();

            labelUnitate.Text = Reteta.UnitateSanitara;
            labelAdresa.Text = Reteta.Localitate + ", " + Reteta.Judet;

            lisatMedici = citireMediciDinFisier(caleFisierMedici);
            listaPacienti = citirePacientiDinFisier(caleFisierPacienti);
        }

        private List<Medic> citireMediciDinFisier(string denFisier)
        {
            string[] linii = File.ReadAllLines(denFisier);
            List<Medic> listaM = new List<Medic>();

            foreach (string linie in linii)
            {
                string[] tokens = linie.Trim().Split(',');
                string id = tokens[0].Trim();
                string nume = tokens[1].Trim();
                string cnp = tokens[2].Trim();
                string adresa = tokens[3].Trim();
                string specializare = tokens[4].Trim();
                float tarif = float.Parse(tokens[5]);

                Medic m = new Medic(id, nume, cnp, adresa, specializare, tarif);
                listaM.Add(m);
            }

            return listaM;
        }

        private List<Pacient> citirePacientiDinFisier(string denFisier)
        {
            string[] linii = File.ReadAllLines(denFisier);
            List<Pacient> listaP = new List<Pacient>();

            foreach (string linie in linii)
            {
                string[] tokens = linie.Trim().Split(',');
                string id = tokens[0].Trim();
                string nume = tokens[1].Trim();
                string cnp = tokens[2].Trim();
                string adresa = tokens[3].Trim();
                int varsta = Convert.ToInt32(tokens[4]);

                Pacient p = new Pacient(id, nume, cnp, adresa, varsta);
                listaP.Add(p);
            }

            return listaP;
        }

        private void mediciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedici frm = new FormMedici(lisatMedici);
            frm.ShowDialog();
        }

        private void pacientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPacienti frm = new FormPacienti(listaPacienti);
            frm.ShowDialog();
        }

        private void reteteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReteta frm = new FormReteta(listaPacienti, lisatMedici);
            frm.ShowDialog();
        }
    }
}
