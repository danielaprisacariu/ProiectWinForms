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
    public partial class FormPacienti : Form
    {
        List<Pacient> pacienti;
        Pacient pacientSelectat = null;

        public FormPacienti(List<Pacient> lista)
        {
            InitializeComponent();
            pacienti = lista;
            initializareLV(pacienti);
        }

        private void initializareLV(List<Pacient> lista)
        {
            lvPacienti.Items.Clear();
            foreach (Pacient p in lista)
            {
                ListViewItem itm = new ListViewItem(p.Id);
                itm.SubItems.Add(p.Nume);
                itm.SubItems.Add(p.CNP);
                itm.SubItems.Add(p.Adresa);
                itm.SubItems.Add(p.Varsta.ToString());
                itm.Tag = p;

                lvPacienti.Items.Add(itm);
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            FormAdaugaPacient frm = new FormAdaugaPacient(pacienti, null);
            frm.ShowDialog();
            initializareLV(pacienti);
        }

        private void lvPacienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in lvPacienti.SelectedItems)
            {
                pacientSelectat = (Pacient)itm.Tag;
            }
        }

        private void lvPacienti_DoubleClick(object sender, EventArgs e)
        {
            if(pacientSelectat != null)
            {
                FormAdaugaPacient frm = new FormAdaugaPacient(pacienti, pacientSelectat);
                frm.ShowDialog();
                initializareLV(pacienti);
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pacientSelectat != null)
            {
                var result = MessageBox.Show("Doriti sa stergeti pacientul " + pacientSelectat.Nume + "?", "Stergere Inregistrare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    pacienti.Remove(pacientSelectat);
                }
                initializareLV(pacienti);
            }
        }

        private void FormPacienti_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("pacienti.txt");
            foreach (Pacient p in pacienti)
            {
                sw.Write(p.ToString()+ Environment.NewLine);
            }
            sw.Close();
        }
    }
}
