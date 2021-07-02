using hazmat_book.Classes;
using hazmat_book.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hazmat_book.Forms.Main.User
{
    public partial class AdminForm : Form
    {

        private string usernameHolder, nameHolder, surnameHolder, emailHolder, passwordHolder, confirmPasswordHolder, idHolder, searchHolder, type = "insert";

        public AdminForm()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.adminTableAdapter.Fill(this.hazmatDataSet31.Admin);
            this.hazmatDataSet3.EnforceConstraints = false;
            this.adminTableAdapter.Fill(this.hazmatDataSet3.Admin);
        }

        #region Strip Menu

        private void strpDeposit_Click(object sender, EventArgs e)
        {
            hazmat_book.Main.Deposit.Deposit deposit = new hazmat_book.Main.Deposit.Deposit();
            deposit.Show();
            this.Hide();
        }

        private void strpHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void strpBook_Click(object sender, EventArgs e)
        {
            hazmat_book.Main.Book.Book book = new hazmat_book.Main.Book.Book();
            book.Show();
            this.Hide();
        }

        private void strpUser_Click(object sender, EventArgs e)
        {
            hazmat_book.Main.User.User user = new hazmat_book.Main.User.User();
            user.Show();
            this.Hide();
        }

        #endregion

        private void txtAdmin_TextChanged(object sender, EventArgs e)
        {
            holderUtils();
            Connection.searchAdmin(searchHolder, dataGridView1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "insert":
                    holderUtils();
                    Connection.addAdmin(usernameHolder, emailHolder, nameHolder, surnameHolder, passwordHolder, confirmPasswordHolder);
                    this.adminTableAdapter.Fill(this.hazmatDataSet3.Admin);
                    clearTexts();
                    break;

                case "update":
                    holderUtils();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        Connection.updateAdmin(row.Cells[0].Value.ToString(), usernameHolder, emailHolder, nameHolder, surnameHolder, passwordHolder, confirmPasswordHolder);
                    }
                    this.adminTableAdapter.Fill(this.hazmatDataSet3.Admin);
                    clearTexts();
                    break;

            }
            holderUtils();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            type = "update";
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    txtUsername.Text = row.Cells[1].Value.ToString();
                    txtEmail.Text = row.Cells[2].Value.ToString();
                    txtName.Text = row.Cells[3].Value.ToString();
                    txtSurname.Text = row.Cells[4].Value.ToString();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Connection.deleteAdmin(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                }
            }
            this.adminTableAdapter.Fill(this.hazmatDataSet3.Admin);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTexts();
        }

        private void holderUtils()
        {
            confirmPasswordHolder = txtConfirmPassword.Text.ToString();
            usernameHolder = txtUsername.Text.ToString();
            passwordHolder = txtPassword.Text.ToString();
            surnameHolder = txtSurname.Text.ToString();
            searchHolder = txtAdmin.Text.ToString();
            emailHolder = txtEmail.Text.ToString();
            nameHolder = txtName.Text.ToString();
        }

        private void clearTexts()
        {
            type = "insert";

            txtConfirmPassword.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtSurname.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
        }
    }
}
