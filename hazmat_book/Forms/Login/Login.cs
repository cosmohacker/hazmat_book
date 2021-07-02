using hazmat_book.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hazmat_book.Login
{
    public partial class Login : Form
    {

        private string usernameEmailHolder, passwordHolder;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            holderUtils();
            Connection.login(usernameEmailHolder, usernameEmailHolder, passwordHolder, this);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void holderUtils()
        {
            usernameEmailHolder = txtUsername.Text.ToString();
            passwordHolder = txtPassword.Text.ToString();
        }
    }
}
