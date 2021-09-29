using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TjossSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        public void Login()
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
