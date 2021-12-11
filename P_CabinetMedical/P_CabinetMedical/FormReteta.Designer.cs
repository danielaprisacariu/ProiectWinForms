
namespace P_CabinetMedical
{
    partial class FormReteta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDiagnostic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricReteteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbUnitate = new System.Windows.Forms.TextBox();
            this.tbLocalitate = new System.Windows.Forms.TextBox();
            this.tbJudet = new System.Windows.Forms.TextBox();
            this.tbNr = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.cbPacienti = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbMedici = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.tbProspect = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(19, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "CNP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reteta Medicala";
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(107, 165);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.ReadOnly = true;
            this.tbCNP.Size = new System.Drawing.Size(235, 20);
            this.tbCNP.TabIndex = 10;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(107, 191);
            this.tbAdresa.Multiline = true;
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.ReadOnly = true;
            this.tbAdresa.Size = new System.Drawing.Size(235, 42);
            this.tbAdresa.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(242, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 67);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Semnatura medic:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Diagnostic:";
            // 
            // tbDiagnostic
            // 
            this.tbDiagnostic.Location = new System.Drawing.Point(107, 239);
            this.tbDiagnostic.Name = "tbDiagnostic";
            this.tbDiagnostic.Size = new System.Drawing.Size(235, 20);
            this.tbDiagnostic.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Unitate medicala:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.istoricReteteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // istoricReteteToolStripMenuItem
            // 
            this.istoricReteteToolStripMenuItem.Name = "istoricReteteToolStripMenuItem";
            this.istoricReteteToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.istoricReteteToolStripMenuItem.Text = "Istoric retete";
            this.istoricReteteToolStripMenuItem.Click += new System.EventHandler(this.istoricReteteToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Localitate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Judet:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(268, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Nr.:";
            // 
            // tbUnitate
            // 
            this.tbUnitate.Location = new System.Drawing.Point(107, 29);
            this.tbUnitate.Name = "tbUnitate";
            this.tbUnitate.ReadOnly = true;
            this.tbUnitate.Size = new System.Drawing.Size(140, 20);
            this.tbUnitate.TabIndex = 25;
            // 
            // tbLocalitate
            // 
            this.tbLocalitate.Location = new System.Drawing.Point(107, 53);
            this.tbLocalitate.Name = "tbLocalitate";
            this.tbLocalitate.ReadOnly = true;
            this.tbLocalitate.Size = new System.Drawing.Size(139, 20);
            this.tbLocalitate.TabIndex = 25;
            // 
            // tbJudet
            // 
            this.tbJudet.Location = new System.Drawing.Point(107, 77);
            this.tbJudet.Name = "tbJudet";
            this.tbJudet.ReadOnly = true;
            this.tbJudet.Size = new System.Drawing.Size(139, 20);
            this.tbJudet.TabIndex = 25;
            // 
            // tbNr
            // 
            this.tbNr.Location = new System.Drawing.Point(299, 28);
            this.tbNr.Name = "tbNr";
            this.tbNr.ReadOnly = true;
            this.tbNr.Size = new System.Drawing.Size(88, 20);
            this.tbNr.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(252, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Varsta:";
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(299, 140);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.ReadOnly = true;
            this.tbVarsta.Size = new System.Drawing.Size(44, 20);
            this.tbVarsta.TabIndex = 28;
            // 
            // cbPacienti
            // 
            this.cbPacienti.FormattingEnabled = true;
            this.cbPacienti.Location = new System.Drawing.Point(107, 138);
            this.cbPacienti.Name = "cbPacienti";
            this.cbPacienti.Size = new System.Drawing.Size(140, 21);
            this.cbPacienti.TabIndex = 29;
            this.cbPacienti.SelectedIndexChanged += new System.EventHandler(this.cbPacienti_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 345);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // cbMedici
            // 
            this.cbMedici.FormattingEnabled = true;
            this.cbMedici.Location = new System.Drawing.Point(74, 371);
            this.cbMedici.Name = "cbMedici";
            this.cbMedici.Size = new System.Drawing.Size(146, 21);
            this.cbMedici.TabIndex = 31;
            this.cbMedici.SelectedIndexChanged += new System.EventHandler(this.cbMedici_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(19, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Medic:";
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(145, 415);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(75, 23);
            this.btnSalveaza.TabIndex = 33;
            this.btnSalveaza.Text = "Creaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(19, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "Prospect:";
            // 
            // tbProspect
            // 
            this.tbProspect.Location = new System.Drawing.Point(107, 265);
            this.tbProspect.Multiline = true;
            this.tbProspect.Name = "tbProspect";
            this.tbProspect.Size = new System.Drawing.Size(235, 43);
            this.tbProspect.TabIndex = 35;
            // 
            // FormReteta
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.tbProspect);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbMedici);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbPacienti);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbNr);
            this.Controls.Add(this.tbJudet);
            this.Controls.Add(this.tbLocalitate);
            this.Controls.Add(this.tbUnitate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDiagnostic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormReteta";
            this.Text = "FormReteta";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormReteta_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormReteta_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDiagnostic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbUnitate;
        private System.Windows.Forms.TextBox tbLocalitate;
        private System.Windows.Forms.TextBox tbJudet;
        private System.Windows.Forms.TextBox tbNr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.ComboBox cbPacienti;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbMedici;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbProspect;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem istoricReteteToolStripMenuItem;
    }
}