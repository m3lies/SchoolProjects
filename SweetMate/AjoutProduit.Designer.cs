namespace SweetMate
{
    partial class frmAjoutProduit
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
            this.lblAjProdNom = new System.Windows.Forms.Label();
            this.lblAjProdDescr = new System.Windows.Forms.Label();
            this.lblAjProdIngredients = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAjProdPrix = new System.Windows.Forms.Label();
            this.btnAjoutProdValider = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAjProdPrixCHF = new System.Windows.Forms.Label();
            this.lblAjProdPhoto = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAjProdAjPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAjProdNom
            // 
            this.lblAjProdNom.AutoSize = true;
            this.lblAjProdNom.Location = new System.Drawing.Point(9, 47);
            this.lblAjProdNom.Name = "lblAjProdNom";
            this.lblAjProdNom.Size = new System.Drawing.Size(85, 13);
            this.lblAjProdNom.TabIndex = 0;
            this.lblAjProdNom.Text = "Nom du produit :";
            // 
            // lblAjProdDescr
            // 
            this.lblAjProdDescr.AutoSize = true;
            this.lblAjProdDescr.Location = new System.Drawing.Point(9, 69);
            this.lblAjProdDescr.Name = "lblAjProdDescr";
            this.lblAjProdDescr.Size = new System.Drawing.Size(116, 13);
            this.lblAjProdDescr.TabIndex = 1;
            this.lblAjProdDescr.Text = "Description du produit :";
            // 
            // lblAjProdIngredients
            // 
            this.lblAjProdIngredients.AutoSize = true;
            this.lblAjProdIngredients.Location = new System.Drawing.Point(9, 150);
            this.lblAjProdIngredients.Name = "lblAjProdIngredients";
            this.lblAjProdIngredients.Size = new System.Drawing.Size(200, 13);
            this.lblAjProdIngredients.TabIndex = 2;
            this.lblAjProdIngredients.Text = "Ingrédients nécessaires à la préparation :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(323, 79);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblAjProdPrix
            // 
            this.lblAjProdPrix.AutoSize = true;
            this.lblAjProdPrix.Location = new System.Drawing.Point(9, 254);
            this.lblAjProdPrix.Name = "lblAjProdPrix";
            this.lblAjProdPrix.Size = new System.Drawing.Size(24, 13);
            this.lblAjProdPrix.TabIndex = 4;
            this.lblAjProdPrix.Text = "Prix";
            this.lblAjProdPrix.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAjoutProdValider
            // 
            this.btnAjoutProdValider.Location = new System.Drawing.Point(247, 319);
            this.btnAjoutProdValider.Name = "btnAjoutProdValider";
            this.btnAjoutProdValider.Size = new System.Drawing.Size(88, 23);
            this.btnAjoutProdValider.TabIndex = 5;
            this.btnAjoutProdValider.Text = "Valider";
            this.btnAjoutProdValider.UseVisualStyleBackColor = true;
            this.btnAjoutProdValider.Click += new System.EventHandler(this.btnAjoutProdValider_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 7;
            // 
            // lblAjProdPrixCHF
            // 
            this.lblAjProdPrixCHF.AutoSize = true;
            this.lblAjProdPrixCHF.Location = new System.Drawing.Point(307, 254);
            this.lblAjProdPrixCHF.Name = "lblAjProdPrixCHF";
            this.lblAjProdPrixCHF.Size = new System.Drawing.Size(28, 13);
            this.lblAjProdPrixCHF.TabIndex = 10;
            this.lblAjProdPrixCHF.Text = "CHF";
            // 
            // lblAjProdPhoto
            // 
            this.lblAjProdPhoto.AutoSize = true;
            this.lblAjProdPhoto.Location = new System.Drawing.Point(9, 295);
            this.lblAjProdPhoto.Name = "lblAjProdPhoto";
            this.lblAjProdPhoto.Size = new System.Drawing.Size(35, 13);
            this.lblAjProdPhoto.TabIndex = 11;
            this.lblAjProdPhoto.Text = "Photo";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 69);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 69);
            this.textBox3.TabIndex = 12;
            // 
            // btnAjProdAjPhoto
            // 
            this.btnAjProdAjPhoto.Location = new System.Drawing.Point(226, 285);
            this.btnAjProdAjPhoto.Name = "btnAjProdAjPhoto";
            this.btnAjProdAjPhoto.Size = new System.Drawing.Size(109, 23);
            this.btnAjProdAjPhoto.TabIndex = 13;
            this.btnAjProdAjPhoto.Text = "Ajouter une photo";
            this.btnAjProdAjPhoto.UseVisualStyleBackColor = true;
            // 
            // frmAjoutProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 354);
            this.Controls.Add(this.btnAjProdAjPhoto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblAjProdPhoto);
            this.Controls.Add(this.lblAjProdPrixCHF);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAjoutProdValider);
            this.Controls.Add(this.lblAjProdPrix);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAjProdIngredients);
            this.Controls.Add(this.lblAjProdDescr);
            this.Controls.Add(this.lblAjProdNom);
            this.Name = "frmAjoutProduit";
            this.Text = "Ajouter un produit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAjProdNom;
        private System.Windows.Forms.Label lblAjProdDescr;
        private System.Windows.Forms.Label lblAjProdIngredients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAjProdPrix;
        private System.Windows.Forms.Button btnAjoutProdValider;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAjProdPrixCHF;
        private System.Windows.Forms.Label lblAjProdPhoto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnAjProdAjPhoto;
    }
}