
namespace P_CabinetMedical
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mediciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reteteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUnitate = new System.Windows.Forms.Label();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.userControl11 = new P_CabinetMedical.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediciToolStripMenuItem,
            this.pacientiToolStripMenuItem,
            this.reteteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mediciToolStripMenuItem
            // 
            this.mediciToolStripMenuItem.Name = "mediciToolStripMenuItem";
            this.mediciToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.mediciToolStripMenuItem.Text = "&Medici";
            this.mediciToolStripMenuItem.Click += new System.EventHandler(this.mediciToolStripMenuItem_Click);
            // 
            // pacientiToolStripMenuItem
            // 
            this.pacientiToolStripMenuItem.Name = "pacientiToolStripMenuItem";
            this.pacientiToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pacientiToolStripMenuItem.Text = "&Pacienti";
            this.pacientiToolStripMenuItem.Click += new System.EventHandler(this.pacientiToolStripMenuItem_Click);
            // 
            // reteteToolStripMenuItem
            // 
            this.reteteToolStripMenuItem.Name = "reteteToolStripMenuItem";
            this.reteteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.reteteToolStripMenuItem.Text = "&Retete";
            this.reteteToolStripMenuItem.Click += new System.EventHandler(this.reteteToolStripMenuItem_Click);
            // 
            // labelUnitate
            // 
            this.labelUnitate.AutoSize = true;
            this.labelUnitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitate.Location = new System.Drawing.Point(292, 86);
            this.labelUnitate.Name = "labelUnitate";
            this.labelUnitate.Size = new System.Drawing.Size(103, 13);
            this.labelUnitate.TabIndex = 2;
            this.labelUnitate.Text = "Unitate Medicala";
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresa.Location = new System.Drawing.Point(292, 113);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(46, 13);
            this.labelAdresa.TabIndex = 3;
            this.labelAdresa.Text = "Adresa";
            // 
            // userControl11
            // 
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl11.Location = new System.Drawing.Point(340, 277);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(162, 19);
            this.userControl11.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 297);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.labelUnitate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mediciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reteteToolStripMenuItem;
        private System.Windows.Forms.Label labelUnitate;
        private System.Windows.Forms.Label labelAdresa;
        private UserControl1 userControl11;
    }
}

