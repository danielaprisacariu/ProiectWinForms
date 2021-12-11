using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_CabinetMedical
{
    public partial class FormReteta : Form
    {
        List<Pacient> pacienti;
        List<Medic> medici;
        Pacient pacientSelectat = null;
        Medic medicSelectat = null;

        Bitmap img;
        Graphics context;
        ArrayList listaPct;
        bool mouseApasat;

        Reteta reteta = null;
        string provider;
        List<Reteta> listaR;

        public FormReteta(List<Pacient> listaP, List<Medic> listaM)
        {
            InitializeComponent();
            provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = spital.accdb";

            listaPct = new ArrayList();
            pacienti = listaP;
            medici = listaM;

            cbPacienti.Text = "-Selecteaza pacient-";
            foreach (Pacient p in pacienti)
            {
                cbPacienti.Items.Add(p.Id + " - " + p.Nume);
            }

            cbMedici.Text = "-Selecteaza medic-";
            foreach (Medic m in medici)
            {
                cbMedici.Items.Add(m.Id + " - " + m.Nume);
            }

            listaR = citireDinBD(provider);

            tbUnitate.Text = Reteta.UnitateSanitara;
            tbLocalitate.Text = Reteta.Localitate;
            tbJudet.Text = Reteta.Judet;
            int nr = listaR.Count + 1;
            tbNr.Text = nr.ToString();

            img = new Bitmap(panel1.Width, panel1.Height);
            context = Graphics.FromImage(img);

            
        }

        private List<Reteta> citireDinBD(string strConexiune)
        {
            OleDbConnection conexiune = new OleDbConnection(strConexiune);
            string sqlSelect = "Select * from retete";
            OleDbCommand comandaSelect = new OleDbCommand(sqlSelect, conexiune);
            List<Reteta> lista = new List<Reteta>(); 
            try
            {
                conexiune.Open(); 
                OleDbDataReader reader = comandaSelect.ExecuteReader();
                while (reader.Read())
                {
                    
                    int nr = Convert.ToInt32(reader["Nr"]);
                    DateTime data = Convert.ToDateTime(reader["Data"]);
                    string idPacient = reader["IdPacient"].ToString();
                    string diagnostic = reader["Diagnostic"].ToString();
                    string prospect = reader["Prospect"].ToString();
                    string idMedic = reader["IdMedic"].ToString();
                    Pacient pacient = null;
                    
                    foreach (Pacient p in pacienti)
                    {
                        if(idPacient == p.Id)
                        {
                            pacient = p;
                        }
                    }
                    
                    Reteta r = new Reteta(nr, data, pacient, diagnostic, prospect, idMedic);
                    lista.Add(r);
                }
                return lista;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conexiune.Close();             
            }
        }

        private void cbPacienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPacienti.SelectedItem != null)
            {
                string[] tokens = cbPacienti.SelectedItem.ToString().Trim().Split('-');
                foreach(Pacient p in pacienti)
                {
                    if (p.Id.Equals(tokens[0].Trim()))
                    {
                        tbCNP.Text = p.CNP.Trim();
                        tbAdresa.Text = p.Adresa.Trim();
                        tbVarsta.Text = p.Varsta.ToString();

                        pacientSelectat = p;
                    }
                }
                 
            }
        }

        private void cbMedici_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tokens = cbMedici.SelectedItem.ToString().Trim().Split('-');
            foreach (Medic m in medici)
            {
                if (m.Id.Equals(tokens[0].Trim()))
                {
                    medicSelectat = m;
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                listaPct.Add(p);
                mouseApasat = true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                listaPct.Add(p);
                Pen pen = new Pen(this.ForeColor);
                if(mouseApasat == true)
                {
                    context.DrawLine(pen, (Point)listaPct[listaPct.Count - 2], (Point)listaPct[listaPct.Count - 1]);
                    panel1.Invalidate();
                }
            }
        }

        private void salvareRetetaInBD(Reteta r)
        {
            OleDbConnection conexiune = new OleDbConnection(provider);
            string sqlInsert = "Insert into retete(nr, data, idPacient, numePacient, diagnostic, prospect, idMedic) values(?, ?, ?, ?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(sqlInsert, conexiune);
            try
            {
                conexiune.Open();
                cmd.Parameters.Add("Nr", OleDbType.Numeric).Value = r.NrReteta;
                cmd.Parameters.Add("Data", OleDbType.Date).Value = r.Data;
                cmd.Parameters.Add("IdPacient", OleDbType.VarChar).Value = r.Pacient.Id;
                cmd.Parameters.Add("NumePacient", OleDbType.VarChar).Value = r.Pacient.Nume;
                cmd.Parameters.Add("Diagnostic", OleDbType.VarChar).Value = r.Diagnostic;
                cmd.Parameters.Add("Prospect", OleDbType.VarChar).Value = r.Prospect;
                cmd.Parameters.Add("IdMedic", OleDbType.VarChar).Value = r.IdMedic;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Salvare realizata cu succes!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }
        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if(pacientSelectat == null)
            {
                errorProvider1.SetError(cbPacienti, "Selectati pacientul!");
            }
            else
            {
                if (tbDiagnostic.Text.Equals(""))
                {
                    errorProvider1.SetError(tbDiagnostic, "Camp obligatoriu!");
                }
                else
                {
                    if (tbProspect.Text.Equals(""))
                    {
                        errorProvider1.SetError(tbProspect, "Camp obligatoriu!");
                    }
                    else
                    {
                        if(medicSelectat == null)
                        {
                            errorProvider1.SetError(cbMedici, "Selecati medic!");
                        }
                        else
                        {
                            if(listaPct.Count < 2)
                            {
                                errorProvider1.SetError(panel1, "Semnatura este obligatorie!");
                            }
                            else
                            {
                                int nr = 0;
                                try
                                {
                                    nr = Convert.ToInt32(tbNr.Text);
                                    string diagnostic = tbDiagnostic.Text;
                                    string prospect = tbProspect.Text;
                                    DateTime data = dateTimePicker1.Value;

                                    reteta = new Reteta(nr, data, pacientSelectat, diagnostic, prospect, medicSelectat.Id);
                                    salvareRetetaInBD(reteta);
                                    listaR.Add(reteta);
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                {
                                    nr++;
                                    tbNr.Text = nr.ToString();
                                    cbPacienti.Text = "-Selecteaza pacient-";
                                    tbVarsta.Clear();
                                    tbCNP.Clear();
                                    tbAdresa.Clear();
                                    tbDiagnostic.Clear();
                                    tbProspect.Clear();
                                    dateTimePicker1.Value = DateTime.Now;
                                    cbMedici.Text = "-Selecteaza medic-";
                                    panel1.Controls.Clear();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void printReteta(object sender, PrintPageEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen pen = new Pen(Color.Black, 12);
            Brush brush = new SolidBrush(Color.Black);
            Font font1 = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            Font font2 = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            Font fontTitlu = new Font(FontFamily.GenericSansSerif, 30, FontStyle.Bold);

            int margine = 40;

            if(reteta != null)
            {
                gr.DrawString("Unitate sanitar: ", font1, brush, new Point(margine, margine));
                gr.DrawString(Reteta.UnitateSanitara, font2, brush, new Point(margine + 8 * ("Unitate sanitar: ").Length, margine));

                gr.DrawString("Nr: ", font1, brush, new Point(e.PageBounds.Width - 2 * margine - 8 * 8, margine));
                gr.DrawString(reteta.NrReteta.ToString(), font2, brush, new Point(e.PageBounds.Width - 2 * margine - 8 * 8 + 8 * ("Nr: ").Length, margine));

                gr.DrawString("Localitate: ", font1, brush, new Point(margine, margine + font1.Height));
                gr.DrawString(Reteta.Localitate, font2, brush, new Point(margine + 8 * ("Localitate: ").Length, margine + font1.Height));

                gr.DrawString("Judet: ", font1, brush, new Point(margine, margine + 2 * font1.Height));
                gr.DrawString(Reteta.Judet, font2, brush, new Point(margine + 8 * ("Judet: ").Length, margine + 2 * font1.Height));

                gr.DrawString("Reteta medicala", fontTitlu, brush, new Point((e.PageBounds.Width - 2 * margine) / 2 - 8 * ("Reteta medicala").Length, margine + 3 * font1.Height + 10));

                gr.DrawString("Nume: ", font1, brush, new Point(margine, margine + 3 * font1.Height + 10 * 2 + fontTitlu.Height));
                gr.DrawString(reteta.Pacient.Nume, font2, brush, new Point(margine + 8 * (("Nume: ").Length + 2), margine + 3 * font1.Height + 10 * 2 + fontTitlu.Height));
                gr.DrawString(" CNP: ", font1, brush, new Point(margine + 8 * (("Nume: ").Length + reteta.Pacient.Nume.Length + 2 * 2), margine + 3 * font1.Height + 10 * 2 + fontTitlu.Height));
                gr.DrawString(reteta.Pacient.CNP, font2, brush, new Point(margine + 8 * (("Nume: ").Length + reteta.Pacient.Nume.Length + (" CNP: ").Length + 2 * 3), margine + 3 * font1.Height + 10 * 2 + fontTitlu.Height));
                gr.DrawString(" Varsta: ", font1, brush, new Point(margine + 8 * (("Nume: ").Length + reteta.Pacient.Nume.Length + (" CNP: ").Length + reteta.Pacient.CNP.Length + 2 * 4), margine + 3 * font1.Height + 10 * 2 + fontTitlu.Height));
                gr.DrawString(reteta.Pacient.Varsta.ToString(), font2, brush, new Point(margine + 8 * (("Nume: ").Length + reteta.Pacient.Nume.Length + (" CNP: ").Length + reteta.Pacient.CNP.Length + (" Varsta: ").Length + 2 * 5), margine + 3 * font1.Height + 10 * 2 + fontTitlu.Height));
                gr.DrawString(" Adresa: ", font1, brush, new Point(margine + 8 * (("Nume: ").Length + reteta.Pacient.Nume.Length + (" CNP: ").Length + reteta.Pacient.CNP.Length + +(" Varsta: ").Length + 2 + 2 * 6), margine + 3 * font1.Height + 10 * 2 + fontTitlu.Height));
                gr.DrawString(reteta.Pacient.Adresa.ToString(), font2, brush, new Point(margine + 8 * (("Nume: ").Length + reteta.Pacient.Nume.Length + (" CNP: ").Length + reteta.Pacient.CNP.Length + (" Varsta: ").Length + (" Adresa: ").Length + 2 * 7), margine + 3 * font1.Height + 10 * 2 + fontTitlu.Height));

                gr.DrawString("Diagnostic: ", font1, brush, new Point(margine, margine + 4 * font1.Height + 10 * 2 + fontTitlu.Height));
                gr.DrawString(reteta.Diagnostic, font2, brush, new Point(margine + 8 * (("Diagnostic: ").Length + 2), margine + 4 * font1.Height + 10 * 2 + fontTitlu.Height));

                gr.DrawString("Prospect: ", font1, brush, new Point(margine, margine + 5 * font1.Height + 10 * 2 + fontTitlu.Height));
                gr.DrawString(reteta.Prospect, font2, brush, new Point(margine + 8 * (("Prospect: ").Length + 2), margine + 5 * font1.Height + 10 * 2 + fontTitlu.Height));

                gr.DrawString("Data: ", font1, brush, new Point(margine, margine + 10 * font1.Height + 10 * 2 + fontTitlu.Height));
                gr.DrawString(reteta.Data.ToString("MM/dd/yyyy"), font2, brush, new Point(margine + 8 * (("Data: ").Length + 2), margine + 10 * font1.Height + 10 * 2 + fontTitlu.Height));
                
                gr.DrawString("Semnatura medic: ", font1, brush, new Point(e.PageBounds.Width - 2 * margine - 8 * ("Semnatura medic: ").Length, margine + 10 * font1.Height + 10 * 2 + fontTitlu.Height));
                gr.DrawImage(img, new Point(e.PageBounds.Width - 2 * margine - 8 * ("Semnatura medic: ").Length, margine + 11 * font1.Height + 10 * 2 + fontTitlu.Height));
            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printReteta);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
            context.Clear(Color.White);
        }

        private void istoricReteteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIstoricRetete frm = new FormIstoricRetete(listaR, medici, pacienti);
            frm.ShowDialog();
        }

        private void FormReteta_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FormReteta_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop);

            string[] linii = File.ReadAllLines(fileList[0]);
            foreach(string linie in linii)
            {
                string[] tokens = linie.Trim().Split(',');
                tbNr.Text = tokens[0];
                DateTime data = Convert.ToDateTime(tokens[1]);
                dateTimePicker1.Value = data;

                string idPacient = tokens[2];
                Pacient pacient = null;
                foreach (Pacient p in pacienti)
                {
                    if (p.Id.Equals(idPacient.Trim()))
                    {
                        pacient = p;
                    }
                }
                cbPacienti.Text = pacient.Id + " - " + pacient.Nume;
                tbVarsta.Text = pacient.Varsta.ToString();
                tbCNP.Text = pacient.CNP;
                tbAdresa.Text = pacient.Adresa;

                tbDiagnostic.Text = tokens[3];
                tbProspect.Text = tokens[4];

                string idMedic = tokens[5];
                Medic medic = null;
                foreach (Medic m in medici)
                {
                    if (m.Id.Equals(idMedic.Trim()))
                    {
                        medic = m;
                    }
                }
                cbMedici.SelectedItem = medic.Id + " - " + medic.Nume;

                btnSalveaza.Enabled = false;
            }
        }
    }
}

