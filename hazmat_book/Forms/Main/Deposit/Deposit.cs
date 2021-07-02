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

namespace hazmat_book.Main.Deposit
{
    public partial class Deposit : Form
    {

        private string userIdHolder, bookIdHolder, depositGivenDate, depositTakenDate, descriptionHolder, searchHolder, type = "insert";

        public Deposit()
        {
            InitializeComponent();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            this.hazmatDataSet.EnforceConstraints = false;
            this.hazmatDataSet2.EnforceConstraints = false;
            this.booksTableAdapter.Fill(this.hazmatDataSet.Books);
            this.usersTableAdapter.Fill(this.hazmatDataSet2.Users);
            Connection.listDeposits(dataGridView1);
            //Connection.getAllBooks(cmbBook);
            //Connection.getAllUsers(cmbUser);
        }

        #region Strip Menu

        private void strpAdmin_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Show();
            this.Hide();
        }

        private void strpUser_Click(object sender, EventArgs e)
        {
            User.User user = new User.User();
            user.Show();
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

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {
            holderUtils();
            Connection.searchDeposit(searchHolder, dataGridView1);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.depositTableAdapter.FillBy(this.hazmatDataSet1.Deposit);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.depositTableAdapter.FillBy(this.hazmatDataSet1.Deposit);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "insert":
                    holderUtils();
                    Connection.addDeposit(userIdHolder, bookIdHolder, depositGivenDate, depositTakenDate, descriptionHolder);
                    Connection.listDeposits(dataGridView1);
                    clearTexts();
                    break;

                case "update":
                    holderUtils();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        Connection.updateDeposit(row.Cells[0].Value.ToString(), userIdHolder, bookIdHolder, depositGivenDate, depositTakenDate, descriptionHolder);
                    }
                    Connection.listDeposits(dataGridView1);
                    clearTexts();
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            type = "update";
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    cmbUser.SelectedIndex = cmbUser.FindStringExact(row.Cells[1].Value.ToString());
                    cmbBook.SelectedIndex = cmbBook.FindStringExact(row.Cells[2].Value.ToString());
                    txtDepositDate.Text = row.Cells[3].Value.ToString();
                    txtDepositDate2.Text = row.Cells[4].Value.ToString();
                    txtDepositNote.Text = row.Cells[5].Value.ToString();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Connection.deleteDeposit(row.Cells[0].Value.ToString());
                }
            }
            Connection.listDeposits(dataGridView1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTexts();
        }

        private void holderUtils()
        {
            descriptionHolder = txtDepositNote.Text.ToString();
            depositTakenDate = txtDepositDate2.Text.ToString();
            depositGivenDate = txtDepositDate.Text.ToString();
            bookIdHolder = cmbBook.SelectedValue.ToString();
            userIdHolder = cmbUser.SelectedValue.ToString();
            searchHolder = txtDeposit.Text.ToString();
        }

        private void clearTexts()
        {
            type = "insert";

            txtDepositDate2.Text = "";
            txtDepositDate.Text = "";
            txtDepositNote.Text = "";
        }

    }
}
