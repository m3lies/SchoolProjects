namespace SweetMate
{
    partial class frmGestionCatalogue
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
            this.btnGscAjoutProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGscAjoutProd
            // 
            this.btnGscAjoutProd.Location = new System.Drawing.Point(710, 364);
            this.btnGscAjoutProd.Name = "btnGscAjoutProd";
            this.btnGscAjoutProd.Size = new System.Drawing.Size(197, 29);
            this.btnGscAjoutProd.TabIndex = 1;
            this.btnGscAjoutProd.Text = "Ajouter un nouveau produit";
            this.btnGscAjoutProd.UseVisualStyleBackColor = true;
            this.btnGscAjoutProd.Click += new System.EventHandler(this.btnGscAjoutProd_Click);
            // 
            // frmGestionCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 405);
            this.Controls.Add(this.btnGscAjoutProd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmGestionCatalogue";
            this.Text = "Gestion du catalogue";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGscAjoutProd;
    }
}