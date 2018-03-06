namespace SweetMate
{
    partial class login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblLoginMail = new System.Windows.Forms.Label();
            this.lblLoginMdp = new System.Windows.Forms.Label();
            this.btnLoginCo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 1;
            // 
            // lblLoginMail
            // 
            this.lblLoginMail.AutoSize = true;
            this.lblLoginMail.Location = new System.Drawing.Point(23, 25);
            this.lblLoginMail.Name = "lblLoginMail";
            this.lblLoginMail.Size = new System.Drawing.Size(32, 13);
            this.lblLoginMail.TabIndex = 2;
            this.lblLoginMail.Text = "Mail :";
            // 
            // lblLoginMdp
            // 
            this.lblLoginMdp.AutoSize = true;
            this.lblLoginMdp.Location = new System.Drawing.Point(23, 54);
            this.lblLoginMdp.Name = "lblLoginMdp";
            this.lblLoginMdp.Size = new System.Drawing.Size(77, 13);
            this.lblLoginMdp.TabIndex = 3;
            this.lblLoginMdp.Text = "Mot de passe :";
            // 
            // btnLoginCo
            // 
            this.btnLoginCo.Location = new System.Drawing.Point(234, 80);
            this.btnLoginCo.Name = "btnLoginCo";
            this.btnLoginCo.Size = new System.Drawing.Size(107, 23);
            this.btnLoginCo.TabIndex = 4;
            this.btnLoginCo.Text = "se connecter";
            this.btnLoginCo.UseVisualStyleBackColor = true;
            this.btnLoginCo.Click += new System.EventHandler(this.btnLoginCo_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 115);
            this.Controls.Add(this.btnLoginCo);
            this.Controls.Add(this.lblLoginMdp);
            this.Controls.Add(this.lblLoginMail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblLoginMail;
        private System.Windows.Forms.Label lblLoginMdp;
        private System.Windows.Forms.Button btnLoginCo;
    }
}