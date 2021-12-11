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
    public partial class FormMedici : Form
    {
        List<Medic> medici;
        Medic medicSelectat = null;

        public FormMedici(List<Medic> lista)
        {
            InitializeComponent();
            medici = lista;
            initializareLV(medici);
        }

        private void initializareLV(List<Medic> lista)
        {
            lvMedici.Items.Clear();
            foreach(Medic m in lista)
            {
                ListViewItem itm = new ListViewItem(m.Id);
                itm.SubItems.Add(m.Nume);
                itm.SubItems.Add(m.CNP);
                itm.SubItems.Add(m.Adresa);
                itm.SubItems.Add(m.Specializare);
                itm.SubItems.Add(m.Tarif.ToString());
                itm.Tag = m;

                lvMedici.Items.Add(itm);
            }
        }

        private void lvMedici_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in lvMedici.SelectedItems)
            {
                medicSelectat = (Medic)itm.Tag;
            }
        }

        private void lvMedici_DoubleClick(object sender, EventArgs e)
        {
            FormAdaugaMedic frm = new FormAdaugaMedic(medici, medicSelectat);
            frm.ShowDialog();
            initializareLV(medici);
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            FormAdaugaMedic frm = new FormAdaugaMedic(medici, null);
            frm.ShowDialog();
            initializareLV(medici);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(medicSelectat != null)
            {
                var result = MessageBox.Show("Doriti sa stergeti medicul " + medicSelectat.Nume + "?", "Stergere Inregistrare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    medici.Remove(medicSelectat);
                }
                initializareLV(medici);
            }
        }

        private void FormMedici_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("medici.txt");
            foreach (Medic m in medici)
            {
                sw.Write(m.ToString() + Environment.NewLine);
            }
            sw.Close();
        }
    }
}
