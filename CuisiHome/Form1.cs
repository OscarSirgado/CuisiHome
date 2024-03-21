using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuisiHome
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViderChamp_Click(object sender, EventArgs e)
        {
            txtBoxUtilisateur.Clear();
            txtBoxMotDePasse.Clear();
        }
    }
}
