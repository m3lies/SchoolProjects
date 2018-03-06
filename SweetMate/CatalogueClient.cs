using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SweetMate
{
    public partial class frmCatalogueClients : Form
    {
      
        public frmCatalogueClients()
        {
            InitializeComponent();
        }

        private void btnCatClientValider_Click(object sender, EventArgs e)
        {
            frmCommande f= frmCommande.getInstance();
            if (f != null)
            {
                f.Show();
            }
        }
    }
}
