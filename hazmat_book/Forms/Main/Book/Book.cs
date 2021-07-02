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

namespace hazmat_book.Main.Book
{
    public partial class Book : Form
    {

        private string nameHolder, publisherHolder, pageHolder, languageHolder, descriptionHolder, barcodeHolder, sinceHolder, writerHolder, searchHolder, type = "insert";

        public Book()
        {
            InitializeComponent();
        }

        private void Book_Load(object sender, EventArgs e)
        {
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

        private void strpHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        #endregion

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
                    Connection.addBook(nameHolder, publisherHolder, pageHolder, languageHolder, descriptionHolder, barcodeHolder, sinceHolder, writerHolder);
                    this.booksTableAdapter.Fill(this.hazmatDataSet.Books);
                    clearTexts();
                    break;

                case "update":
                    holderUtils();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        Connection.updateBooks(nameHolder, row.Cells[0].Value.ToString(), publisherHolder, pageHolder, languageHolder, descriptionHolder, barcodeHolder, sinceHolder, writerHolder);
                    }
                    this.booksTableAdapter.Fill(this.hazmatDataSet.Books);
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
                    txtName.Text = row.Cells[1].Value.ToString();
                    txtPublisher.Text = row.Cells[2].Value.ToString();
                    txtPage.Text = row.Cells[3].Value.ToString();
                    txtLanguage.Text = row.Cells[4].Value.ToString();
                    txtDescription.Text = row.Cells[5].Value.ToString();
                    txtBarcode.Text = row.Cells[6].Value.ToString();
                    txtSince.Text = row.Cells[7].Value.ToString();
                    txtWriter.Text = row.Cells[8].Value.ToString();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            holderUtils();
            Connection.searchBooks(searchHolder, dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Connection.deleteBook(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), this);
                }
            }
            this.booksTableAdapter.Fill(this.hazmatDataSet.Books);
        }

        #region Utils

        private void holderUtils()
        {
            descriptionHolder = txtDescription.Text.ToString();
            publisherHolder = txtPublisher.Text.ToString();
            languageHolder = txtLanguage.Text.ToString();
            barcodeHolder = txtBarcode.Text.ToString();
            writerHolder = txtWriter.Text.ToString();
            searchHolder = txtSearch.Text.ToString();
            sinceHolder = txtSince.Text.ToString();
            nameHolder = txtName.Text.ToString();
            pageHolder = txtPage.Text.ToString();
        }

        private void clearTexts()
        {
            type = "insert";

            txtDescription.Text = "";
            txtPublisher.Text = "";
            txtLanguage.Text = "";
            txtBarcode.Text = "";
            txtWriter.Text = "";
            txtSince.Text = "";
            txtName.Text = "";
            txtPage.Text = "";
        }

        #endregion

    }
}
