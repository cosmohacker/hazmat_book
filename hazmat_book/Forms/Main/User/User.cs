using hazmat_book.Classes;
using hazmat_book.Forms.Main.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hazmat_book.Main.User
{
    public partial class User : Form
    {

        private string usernameHolder, nameHolder, surnameHolder, phoneHolder, phone1Holder, identityHolder, emailHolder, addressHolder, birthdayHolder, postCodeHolder, genderHolder, searchHolder, type = "insert";

        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            this.hazmatDataSet2.EnforceConstraints = false;

            this.usersTableAdapter.Fill(this.hazmatDataSet2.Users);
        }

        #region Strip Menu

        private void strpAdmin_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Show();
            this.Hide();
        }

        private void strpDeposit_Click(object sender, EventArgs e)
        {
            Deposit.Deposit deposit = new Deposit.Deposit();
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
            Book.Book book = new Book.Book();
            book.Show();
            this.Hide();
        }

        #endregion

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            holderUtils();
            Connection.searchUser(searchHolder, dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Connection.deleteUser(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), this);
                }
            }
            this.usersTableAdapter.Fill(this.hazmatDataSet2.Users);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            type = "update";
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    txtUsername.Text = row.Cells[1].Value.ToString();
                    txtName.Text = row.Cells[2].Value.ToString();
                    txtSurname.Text = row.Cells[3].Value.ToString();
                    txtPhone.Text = row.Cells[4].Value.ToString();
                    txtPhone2.Text = row.Cells[5].Value.ToString();
                    txtTC.Text = row.Cells[6].Value.ToString();
                    txtEmail.Text = row.Cells[7].Value.ToString();
                    txtAddress.Text = row.Cells[8].Value.ToString();
                    txtBirthday.Value = DateTime.Parse(row.Cells[9].Value.ToString());
                    txtPostCode.Text = row.Cells[10].Value.ToString();
                    switch (row.Cells[11].Value.ToString())
                    {
                        case "Atak Helikopteri":
                            radioAttackChopper.Checked = true;
                            break;
                        case "Erkek":
                            radioMale.Checked = true;
                            break;
                        case "Kadın":
                            radioFemale.Checked = true;
                            break;
                        case "Diğer":
                            radioOther.Checked = true;
                            break;
                        case "Kadin":
                            radioFemale.Checked = true;
                            break;
                        case "Diger":
                            radioOther.Checked = true;
                            break;
                    }

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTexts();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "insert":
                    holderUtils();
                    Connection.addUser(usernameHolder, nameHolder, surnameHolder, phoneHolder, phone1Holder, identityHolder, emailHolder, addressHolder, birthdayHolder, postCodeHolder, genderHolder);
                    this.usersTableAdapter.Fill(this.hazmatDataSet2.Users);
                    clearTexts();
                    break;

                case "update":
                    holderUtils();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        Connection.updateUser(row.Cells[0].Value.ToString(), usernameHolder, nameHolder, surnameHolder, phoneHolder, phone1Holder, identityHolder, emailHolder, addressHolder, birthdayHolder, postCodeHolder, genderHolder);
                    }
                    this.usersTableAdapter.Fill(this.hazmatDataSet2.Users);
                    clearTexts();
                    break;

            }
        }

        #region Utils

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAttackChopper.Checked)
            {
                genderHolder = "Atak Helikopteri";
            }
            else if (radioFemale.Checked)
            {
                genderHolder = "Kadın";
            }
            else if (radioOther.Checked)
            {
                genderHolder = "Diğer";
            }
            else if (radioMale.Checked)
            {
                genderHolder = "Erkek";
            }

        }

        private void holderUtils()
        {
            usernameHolder = txtUsername.Text.ToString();
            postCodeHolder = txtPostCode.Text.ToString();
            birthdayHolder = txtBirthday.Text.ToString();
            surnameHolder = txtSurname.Text.ToString();
            addressHolder = txtAddress.Text.ToString();
            phone1Holder = txtPhone2.Text.ToString();
            searchHolder = txtUser.Text.ToString();
            phoneHolder = txtPhone.Text.ToString();
            identityHolder = txtTC.Text.ToString();
            emailHolder = txtEmail.Text.ToString();
            nameHolder = txtName.Text.ToString();
        }

        private void clearTexts()
        {
            type = "insert";

            radioAttackChopper.Checked = false;
            radioFemale.Checked = false;
            radioOther.Checked = false;
            radioMale.Checked = false;
            txtUsername.Text = "";
            txtBirthday.Text = "";
            txtPostCode.Text = "";
            txtSurname.Text = "";
            txtAddress.Text = "";
            txtPhone2.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtTC.Text = "";
        }

        #endregion

    }
}
