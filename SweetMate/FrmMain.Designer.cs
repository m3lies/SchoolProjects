namespace SweetMate
{
    partial class frmMain
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
            this.btnMainClient = new System.Windows.Forms.Button();
            this.btnMainAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainClient
            // 
            this.btnMainClient.Location = new System.Drawing.Point(25, 172);
            this.btnMainClient.Name = "btnMainClient";
            this.btnMainClient.Size = new System.Drawing.Size(75, 23);
            this.btnMainClient.TabIndex = 0;
            this.btnMainClient.Text = "Client";
            this.btnMainClient.UseVisualStyleBackColor = true;
            this.btnMainClient.Click += new System.EventHandler(this.btnMainClient_Click);
            // 
            // btnMainAdmin
            // 
            this.btnMainAdmin.Location = new System.Drawing.Point(162, 172);
            this.btnMainAdmin.Name = "btnMainAdmin";
            this.btnMainAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnMainAdmin.TabIndex = 1;
            this.btnMainAdmin.Text = "Admin";
            this.btnMainAdmin.UseVisualStyleBackColor = true;
            this.btnMainAdmin.Click += new System.EventHandler(this.btnMainAdmin_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMainAdmin);
            this.Controls.Add(this.btnMainClient);
            this.Name = "frmMain";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainClient;
        private System.Windows.Forms.Button btnMainAdmin;
    }
}