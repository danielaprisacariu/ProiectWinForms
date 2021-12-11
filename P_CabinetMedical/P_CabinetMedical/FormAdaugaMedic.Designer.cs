
namespace P_CabinetMedical
{
    partial class FormAdaugaMedic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbSpecializare = new System.Windows.Forms.TextBox();
            this.tbTarif = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lbTitlu = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CNP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Specializare:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tarif:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(141, 74);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 1;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(141, 101);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 20);
            this.tbNume.TabIndex = 1;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(141, 126);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(100, 20);
            this.tbCNP.TabIndex = 1;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(141, 150);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(100, 20);
            this.tbAdresa.TabIndex = 1;
            // 
            // tbSpecializare
            // 
            this.tbSpecializare.Location = new System.Drawing.Point(141, 177);
            this.tbSpecializare.Name = "tbSpecializare";
            this.tbSpecializare.Size = new System.Drawing.Size(100, 20);
            this.tbSpecializare.TabIndex = 1;
            // 
            // tbTarif
            // 
            this.tbTarif.Location = new System.Drawing.Point(141, 203);
            this.tbTarif.Name = "tbTarif";
            this.tbTarif.Size = new System.Drawing.Size(100, 20);
            this.tbTarif.TabIndex = 1;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(152, 270);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lbTitlu
            // 
            this.lbTitlu.AutoSize = true;
            this.lbTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitlu.Location = new System.Drawing.Point(149, 28);
            this.lbTitlu.Name = "lbTitlu";
            this.lbTitlu.Size = new System.Drawing.Size(87, 13);
            this.lbTitlu.TabIndex = 3;
            this.lbTitlu.Text = "Adauga medic";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAdaugaMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 316);
            this.Controls.Add(this.lbTitlu);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbTarif);
            this.Controls.Add(this.tbSpecializare);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAdaugaMedic";
            this.Text = "FormAdaugaMedic";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbSpecializare;
        private System.Windows.Forms.TextBox tbTarif;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lbTitlu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}