namespace SweetMate
{
    partial class frmCommande
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
            this.lblComNom = new System.Windows.Forms.Label();
            this.lblComPrenom = new System.Windows.Forms.Label();
            this.lblComMail = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblComProduits = new System.Windows.Forms.Label();
            this.lblComTotal = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblComQTotal = new System.Windows.Forms.Label();
            this.lblComPTotal = new System.Windows.Forms.Label();
            this.lblComP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComNom
            // 
            this.lblComNom.AutoSize = true;
            this.lblComNom.Location = new System.Drawing.Point(25, 35);
            this.lblComNom.Name = "lblComNom";
            this.lblComNom.Size = new System.Drawing.Size(35, 13);
            this.lblComNom.TabIndex = 0;
            this.lblComNom.Text = "Nom: ";
            // 
            // lblComPrenom
            // 
            this.lblComPrenom.AutoSize = true;
            this.lblComPrenom.Location = new System.Drawing.Point(25, 62);
            this.lblComPrenom.Name = "lblComPrenom";
            this.lblComPrenom.Size = new System.Drawing.Size(46, 13);
            this.lblComPrenom.TabIndex = 1;
            this.lblComPrenom.Text = "Prénom:";
            // 
            // lblComMail
            // 
            this.lblComMail.AutoSize = true;
            this.lblComMail.Location = new System.Drawing.Point(25, 92);
            this.lblComMail.Name = "lblComMail";
            this.lblComMail.Size = new System.Drawing.Size(38, 13);
            this.lblComMail.TabIndex = 2;
            this.lblComMail.Text = "E-mail:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 116);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblComProduits
            // 
            this.lblComProduits.AutoSize = true;
            this.lblComProduits.Location = new System.Drawing.Point(25, 123);
            this.lblComProduits.Name = "lblComProduits";
            this.lblComProduits.Size = new System.Drawing.Size(108, 13);
            this.lblComProduits.TabIndex = 4;
            this.lblComProduits.Text = "Produits commandés:";
            // 
            // lblComTotal
            // 
            this.lblComTotal.AutoSize = true;
            this.lblComTotal.Location = new System.Drawing.Point(25, 268);
            this.lblComTotal.Name = "lblComTotal";
            this.lblComTotal.Size = new System.Drawing.Size(34, 13);
            this.lblComTotal.TabIndex = 5;
            this.lblComTotal.Text = "Total:";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(191, 292);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(82, 20);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblComQTotal
            // 
            this.lblComQTotal.AutoSize = true;
            this.lblComQTotal.Location = new System.Drawing.Point(188, 268);
            this.lblComQTotal.Name = "lblComQTotal";
            this.lblComQTotal.Size = new System.Drawing.Size(19, 13);
            this.lblComQTotal.TabIndex = 7;
            this.lblComQTotal.Text = "....";
            // 
            // lblComPTotal
            // 
            this.lblComPTotal.AutoSize = true;
            this.lblComPTotal.Location = new System.Drawing.Point(213, 268);
            this.lblComPTotal.Name = "lblComPTotal";
            this.lblComPTotal.Size = new System.Drawing.Size(22, 13);
            this.lblComPTotal.TabIndex = 8;
            this.lblComPTotal.Text = ".....";
            // 
            // lblComP
            // 
            this.lblComP.AutoSize = true;
            this.lblComP.Location = new System.Drawing.Point(246, 268);
            this.lblComP.Name = "lblComP";
            this.lblComP.Size = new System.Drawing.Size(28, 13);
            this.lblComP.TabIndex = 9;
            this.lblComP.Text = "CHF";
            // 
            // frmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 327);
            this.Controls.Add(this.lblComP);
            this.Controls.Add(this.lblComPTotal);
            this.Controls.Add(this.lblComQTotal);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblComTotal);
            this.Controls.Add(this.lblComProduits);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblComMail);
            this.Controls.Add(this.lblComPrenom);
            this.Controls.Add(this.lblComNom);
            this.Name = "frmCommande";
            this.Text = "Commander";
            this.Load += new System.EventHandler(this.frmCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComNom;
        private System.Windows.Forms.Label lblComPrenom;
        private System.Windows.Forms.Label lblComMail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblComProduits;
        private System.Windows.Forms.Label lblComTotal;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblComQTotal;
        private System.Windows.Forms.Label lblComPTotal;
        private System.Windows.Forms.Label lblComP;
    }
}

