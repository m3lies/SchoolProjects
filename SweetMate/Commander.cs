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
    public partial class frmCommande : Form
    {
        private static frmCommande instance = null;

        private frmCommande()
        {
            InitializeComponent();
        }

        public static frmCommande getInstance(){
                if (instance == null) {
                    instance = new frmCommande();
                }
                return instance;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmCommande_Load(object sender, EventArgs e)
        {

        }
    }
}
