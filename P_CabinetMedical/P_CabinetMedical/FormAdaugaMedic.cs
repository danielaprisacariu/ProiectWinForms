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
    public partial class FormAdaugaMedic : Form
    {
        List<Medic> medici;
        Medic medic;
        public FormAdaugaMedic(List<Medic> lista, Medic medic)
        {
            InitializeComponent();
            medici = lista;
            this.medic = medic;

            if(medic != null)
            {
                lbTitlu.Text = "Modifica medic";
                tbId.ReadOnly = true;
                btnAdauga.Text = "Modifica";

                tbId.Text = medic.Id;
                tbNume.Text = medic.Nume;
                tbCNP.Text = medic.CNP;
                tbAdresa.Text = medic.Adresa;
                tbSpecializare.Text = medic.Specializare;
                tbTarif.Text = medic.Tarif.ToString();
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
                        if (tbSpecializare.Text.Equals(""))
                        {
                            errorProvider1.SetError(tbSpecializare, "Camp obligatoriu!");
                        }
                        else
                        {
                            if (tbTarif.Text.Equals(""))
                            {
                                errorProvider1.SetError(tbTarif, "Camp obligatoriu!");
                            }
                            else
                            {
                                if (medic == null)
                                {
                                    string id = tbId.Text;
                                    string nume = tbNume.Text;
                                    string cnp = tbCNP.Text;
                                    string adresa = tbAdresa.Text;
                                    string specializare = tbSpecializare.Text;
                                    float tarif = float.Parse(tbTarif.Text);

                                    medic = new Medic(id, nume, cnp, adresa, specializare, tarif);
                                    medici.Add(medic);

                                    Close();
                                }
                                else
                                {
                                    medic.Nume = tbNume.Text;
                                    medic.CNP = tbCNP.Text;
                                    medic.Adresa = tbAdresa.Text;
                                    medic.Specializare = tbSpecializare.Text;
                                    medic.Tarif = float.Parse(tbTarif.Text);

                                    Close();
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }
}
