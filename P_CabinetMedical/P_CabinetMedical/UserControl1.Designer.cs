
namespace P_CabinetMedical
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbData = new System.Windows.Forms.Label();
            this.lbOra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(3, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(35, 13);
            this.lbData.TabIndex = 0;
            this.lbData.Text = "label1";
            // 
            // lbOra
            // 
            this.lbOra.AutoSize = true;
            this.lbOra.Location = new System.Drawing.Point(102, 0);
            this.lbOra.Name = "lbOra";
            this.lbOra.Size = new System.Drawing.Size(35, 13);
            this.lbOra.TabIndex = 1;
            this.lbOra.Text = "label2";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbOra);
            this.Controls.Add(this.lbData);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(192, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbOra;
    }
}
