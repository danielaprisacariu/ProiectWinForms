
namespace P_CabinetMedical
{
    partial class FormPacienti
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
            this.lvPacienti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.userControl11 = new P_CabinetMedical.UserControl1();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPacienti
            // 
            this.lvPacienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvPacienti.ContextMenuStrip = this.contextMenuStrip1;
            this.lvPacienti.FullRowSelect = true;
            this.lvPacienti.GridLines = true;
            this.lvPacienti.HideSelection = false;
            this.lvPacienti.Location = new System.Drawing.Point(35, 44);
            this.lvPacienti.MultiSelect = false;
            this.lvPacienti.Name = "lvPacienti";
            this.lvPacienti.Size = new System.Drawing.Size(491, 213);
            this.lvPacienti.TabIndex = 0;
            this.lvPacienti.UseCompatibleStateImageBehavior = false;
            this.lvPacienti.View = System.Windows.Forms.View.Details;
            this.lvPacienti.SelectedIndexChanged += new System.EventHandler(this.lvPacienti_SelectedIndexChanged);
            this.lvPacienti.DoubleClick += new System.EventHandler(this.lvPacienti_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CNP";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adresa";
            this.columnHeader4.Width = 122;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Varsta";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(35, 12);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(34, 26);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "+";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // userControl11
            // 
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl11.Location = new System.Drawing.Point(387, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(164, 19);
            this.userControl11.TabIndex = 3;
            // 
            // FormPacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 280);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lvPacienti);
            this.Name = "FormPacienti";
            this.Text = "FormPacienti";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPacienti_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPacienti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private UserControl1 userControl11;
    }
}