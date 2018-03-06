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
    public partial class frmGestionCatalogue : Form
    {
        public frmGestionCatalogue()
        {
            InitializeComponent();
        }

        private void btnGscAjoutProd_Click(object sender, EventArgs e)
        {
            new frmAjoutProduit();
        }
    }
}
