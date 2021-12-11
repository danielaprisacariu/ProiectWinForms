using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_CabinetMedical
{
    public partial class FormAdaugaPacient : Form
    {
        List<Pacient> pacienti;
        Pacient pacient;
        public FormAdaugaPacient(List<Pacient> lista, Pacient p)
        {
            InitializeComponent();
            pacienti = lista;
            this.pacient = p;

            if (pacient != null)
            {
                lbTitlu.Text = "Modifica pacient";
                tbId.ReadOnly = true;
                btnAdauga.Text = "Modifica";

                tbId.Text = pacient.Id;
                tbNume.Text = pacient.Nume;
                tbCNP.Text = pacient.CNP;
                tbAdresa.Text = pacient.Adresa;
                tbVarsta.Text = pacient.Varsta.ToString();
            }
            else
            {
                tbId.Clear();
                tbNume.Clear();
                tbCNP.Clear();
                tbAdresa.Clear();
                tbVarsta.Clear();
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (tbId.Text.Equals(""))
            {
                errorProvider1.SetError(tbId, "Camp obligatoriu!");
            }
            else
            {
                if (tbNume.Text.Equals(""))
                {
                    errorProvider1.SetError(tbNume, "Camp obligatoriu!");
                }
                else
                {
                    if (tbCNP.Text.Equals(""))
                    {
                        errorProvider1.SetError(tbCNP, "Camp obligatoriu!");
                    }
                    else
                    {
                        if (tbVarsta.Text.Equals(""))
                        {
                            errorProvider1.SetError(tbVarsta, "Camp obligatoriu!");
                        }
                        else
                        {
                            if (pacient == null)
                            {
                                string id = tbId.Text;
                                string nume = tbNume.Text;
                                string cnp = tbCNP.Text;
                                string adresa = tbAdresa.Text;
                                int varsta = Convert.ToInt32(tbVarsta.Text);

                                pacient = new Pacient(id, nume, cnp, adresa, varsta);
                                pacienti.Add(pacient);

                                Close();
                            }
                            else
                            {
                                pacient.Nume = tbNume.Text;
                                pacient.CNP = tbCNP.Text;
                                pacient.Adresa = tbAdresa.Text;
                                pacient.Varsta = Convert.ToInt32(tbVarsta.Text);

                                Close();
                            }
                        }
                    }
                }
            }
        }

    }
}

