using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hazmat_book.Classes;
using hazmat_book.Forms.Main.User;
using hazmat_book.Main.Book;

namespace hazmat_book.Main
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.hazmatDataSet2.EnforceConstraints = false;

            Connection.listDeposits(dataGridView2);

            this.usersTableAdapter.Fill(this.hazmatDataSet2.Users);
            this.booksTableAdapter.Fill(this.hazmatDataSet.Books);
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

        private void strpDeposit_Click(object sender, EventArgs e)
        {
            Deposit.Deposit deposit = new Deposit.Deposit();
            deposit.Show();
            this.Hide();
        }

        private void strpBook_Click(object sender, EventArgs e)
        {
            Book.Book book = new Book.Book();
            book.Show();
            this.Hide();
        }

        #endregion

        private void txtBook_TextChanged(object sender, EventArgs e)
        {
            Connection.searchBooks(txtBook.Text.ToString(), dataGridView1);
        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {
            Connection.searchDeposit(txtDeposit.Text.ToString(), dataGridView2);
        }

        private void txtUsers_TextChanged(object sender, EventArgs e)
        {
            Connection.searchUser(txtUsers.Text.ToString(), dataGridView3);
        }
    }
}
