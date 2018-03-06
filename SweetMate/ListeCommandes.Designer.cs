namespace SweetMate
{
    partial class frmLstCommandes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblLstCommandes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblLstCommandes
            // 
            this.lblLstCommandes.AutoSize = true;
            this.lblLstCommandes.Location = new System.Drawing.Point(28, 20);
            this.lblLstCommandes.Name = "lblLstCommandes";
            this.lblLstCommandes.Size = new System.Drawing.Size(109, 13);
            this.lblLstCommandes.TabIndex = 1;
            this.lblLstCommandes.Text = "Liste des commandes";
            // 
            // frmLstCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 365);
            this.Controls.Add(this.lblLstCommandes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmLstCommandes";
            this.Text = "Liste des commandes";
            this.Load += new System.EventHandler(this.frmLstCommandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblLstCommandes;
    }
}