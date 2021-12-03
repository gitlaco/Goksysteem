using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goksysteem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void xz_Click(object sender, EventArgs e)
        {
            var homeform = new HomeForm();
            this.Hide();
            homeform.Show(this);
        }

        private void lbLogo_Click(object sender, EventArgs e)
        {
            var homeForm = new HomeForm();
            this.Hide();
            homeForm.Show(this);
        }
    }
}
