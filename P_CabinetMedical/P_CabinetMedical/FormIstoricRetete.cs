using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_CabinetMedical
{
    public partial class FormIstoricRetete : Form
    {
        List<Reteta> retete;
        List<Medic> medici;
        List<Pacient> pacienti;
        public FormIstoricRetete(List<Reteta> listaR, List<Medic> listaM, List<Pacient> listaP)
        {
            InitializeComponent();
            retete = listaR;
            medici = listaM;
            pacienti = listaP;
            initializareDG(retete);
        }

        private void initializareDG(List<Reteta> lista)
        {
            foreach(Reteta r in lista)
            {
                DataGridViewRow rand = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                rand.Cells[0].Value = r.NrReteta;
                rand.Cells[1].Value = r.Data.ToString("MM/dd/yyyy");
                rand.Cells[2].Value = r.Pacient.Id;
                rand.Cells[3].Value = r.Pacient.Nume;
                rand.Cells[4].Value = r.Diagnostic;
                rand.Cells[5].Value = r.Prospect;
                rand.Cells[6].Value = r.IdMedic;

                dataGridView1.Rows.Add(rand);
            }
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            double[] vectNrRetete = new double[medici.Count];
            int i = 0;
            int max = 0;
            foreach (Medic m in medici)
            {
                int nr = 0;
                foreach (Reteta r in retete)
                {
                    if (m.Id == r.IdMedic)
                    {
                        nr++;
                    }
                }
                if (nr > max)
                {
                    max = nr;
                }
                vectNrRetete[i] = nr;
                i++;
            }

            generareGrafic(vectNrRetete, max);
            
        }

        private void generareGrafic(double[] vectNrRetete, int max)
        {
            Graphics gr = Graphics.FromHwnd(panel1.Handle);
            Pen pen = new Pen(Color.Black, 3);
            int margine = 5;
            Rectangle rec = new Rectangle(panel1.ClientRectangle.X + margine, panel1.ClientRectangle.Y + 2 * margine, panel1.ClientRectangle.Width - 2 * margine, panel1.ClientRectangle.Height - 3 * margine);
            gr.DrawRectangle(pen, rec);

            double latime = rec.Width / medici.Count / 3;
            double distanta = (rec.Width - medici.Count * latime) / medici.Count / 3;
            Brush brush = new SolidBrush(Color.Blue);
            Font font = new Font(FontFamily.GenericSansSerif, 5, FontStyle.Bold);

            Rectangle[] recs = new Rectangle[medici.Count];
            for (int j = 0; j < medici.Count; j++)
            {
                recs[j] = new Rectangle((int)(margine + rec.Location.X + (j + 1) * distanta + j * latime), (int)(rec.Location.Y + rec.Height - vectNrRetete[j] / max * rec.Height), (int)latime, (int)(vectNrRetete[j] / max * rec.Height));
                gr.DrawString(medici[j].Id, font, new SolidBrush(Color.Black), new Point((int)(recs[j].Location.X), (int)(recs[j].Location.Y - font.Height)));
            }
            gr.DrawRectangles(pen, recs);
            gr.FillRectangles(brush, recs);
        }
    }
}
