namespace SweetMate
{
    partial class frmCatalogueClients
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
            this.btnCatClientValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCatClientValider
            // 
            this.btnCatClientValider.Location = new System.Drawing.Point(444, 308);
            this.btnCatClientValider.Name = "btnCatClientValider";
            this.btnCatClientValider.Size = new System.Drawing.Size(113, 30);
            this.btnCatClientValider.TabIndex = 1;
            this.btnCatClientValider.Text = "Valider mon panier";
            this.btnCatClientValider.UseVisualStyleBackColor = true;
            this.btnCatClientValider.Click += new System.EventHandler(this.btnCatClientValider_Click);
            // 
            // frmCatalogueClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 359);
            this.Controls.Add(this.btnCatClientValider);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCatalogueClients";
            this.Text = "Catalogue";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCatClientValider;
    }
}