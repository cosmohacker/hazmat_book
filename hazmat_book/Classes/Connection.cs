using hazmat_book.hazmatDataSetTableAdapters;
using hazmat_book.Main;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static hazmat_book.hazmatDataSet;

namespace hazmat_book.Classes
{
    class Connection
    {

        static SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=hazmat;Integrated Security=True");

        #region Book

        public static void addBook(string nameHolder, string publisherHolder, string pageHolder, string languageHolder, string descriptionholder, string barcodeHolder, string sinceHolder, string writerHolder)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Books(Name, Publisher, Page, Language, Description, Barcode, Since, Writer) VALUES ('" + nameHolder + "', '" + publisherHolder + "','" + pageHolder + "','" + languageHolder + "','" + descriptionholder + "','" + barcodeHolder + "','" + sinceHolder + "','" + writerHolder + "')", connection);

                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Kitap başarılı bir şekilde kayıt edilmiştir");

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. \n" + hata.Message);
                connection.Close();
            }
        }

        public static void deleteBook(string idHolder, string nameHolder, Form form)
        {
            string message = "Bu kitabı silmek istediğinizden '" + nameHolder + "' emin misiniz?";
            string title = "Kitabı Silmek Üzeresiniz";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM Books WHERE Book_Id = " + idHolder + "", connection);

                    command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Kitap başarılı bir şekilde silinmiştir.");

                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu. \n" + hata.Message);
                    connection.Close();
                }
            }
            else
            {

            }

        }

        public static void updateBooks(string nameHolder, string idHolder, string publisherHolder, string pageHolder, string languageHolder, string descriptionHolder, string barcodeHolder, string sinceHolder, string writerHolder)
        {

            String timestamp = GetTimestamp(DateTime.Now);

            string message = "Bu kitabı güncellemek istediğinizden '" + nameHolder + "' emin misiniz?";
            string title = "Kitabı Güncellemek Üzeresiniz";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UPDATE Books SET Name = '" + nameHolder + "', Publisher = '" + publisherHolder + "', Page = '" + pageHolder + "', Language = '" + languageHolder + "', Description = '" + descriptionHolder + "', Barcode = '" + barcodeHolder + "', Since = '" + sinceHolder + "', Writer = '" + writerHolder + "', Updated_At = '" + timestamp + "'   WHERE Book_Id = " + idHolder + "", connection);

                    command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Kitap başarılı bir şekilde güncellenmiştir.");

                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu. \n" + hata.Message);
                    connection.Close();
                }
            }
            else
            {

            }
        }

        public static void searchBooks(string searchHolder, DataGridView dataGridView)
        {

            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE Book_Id LIKE '%" + searchHolder + "%' or Name LIKE '%" + searchHolder + "%' or Publisher LIKE '%" + searchHolder + "%' or Page LIKE '%" + searchHolder + "%' or Language LIKE '%" + searchHolder + "%' or Description LIKE '%" + searchHolder + "%' or Barcode LIKE '%" + searchHolder + "%' or Since LIKE '%" + searchHolder + "%' or Writer LIKE '%" + searchHolder + "%' or Created_At LIKE '%" + searchHolder + "%' or Updated_At LIKE '%" + searchHolder + "%'", connection);

            var dataAdapter = new SqlDataAdapter(command);

            var ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridView.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];

            command.ExecuteNonQuery();

            connection.Close();
        }

        #endregion

        #region User

        public static void addUser(string usernameHolder, string nameHolder, string surnameHolder, string phoneHolder, string phone1Holder, string identityHolder, string emailHolder, string addressHolder, string birthdayHolder, string postCodeHolder, string genderHolder)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Users(Username, Name, Surname, Phone_1, Phone_2, Identity_Number, Email, Address, Birthday, Post_Code, Gender) VALUES ('" + usernameHolder + "','" + nameHolder + "','" + surnameHolder + "','" + phoneHolder + "','" + phone1Holder + "','" + identityHolder + "','" + emailHolder + "','" + addressHolder + "','" + birthdayHolder + "','" + postCodeHolder + "','" + genderHolder + "')", connection);

                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Kullanıcı başarılı bir şekilde kayıt edilmiştir");

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. \n" + hata.Message);
                connection.Close();
            }
        }

        public static void deleteUser(string idHolder, string usernameHolder, Form form)
        {
            string message = "Bu kullanıcıyı silmek istediğinizden '" + usernameHolder + "' emin misiniz?";
            string title = "Kullanıcıyı Silmek Üzeresiniz";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM Users WHERE User_Id = " + idHolder + "", connection);

                    command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Kullanıcı başarılı bir şekilde silinmiştir.");

                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu. \n" + hata.Message);
                    connection.Close();
                }
            }
            else
            {

            }
        }

        public static void updateUser(string idHolder, string usernameHolder, string nameHolder, string surnameHolder, string phoneHolder, string phone1Holder, string identityHolder, string emailHolder, string addressHolder, string birthdayHolder, string postCodeHolder, string genderHolder)
        {
            String timestamp = GetTimestamp(DateTime.Now);

            string message = "Bu kullanıcıyı güncellemek istediğinizden '" + usernameHolder + "' emin misiniz?";
            string title = "Kullanıcıyı Güncellemek Üzeresiniz";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UPDATE Users SET Username = '" + usernameHolder + "', Name = '" + nameHolder + "', Surname = '" + surnameHolder + "', Phone_1 = '" + phoneHolder + "', Phone_2 = '" + phone1Holder + "', Identity_Number = '" + identityHolder + "', Email = '" + emailHolder + "', Address = '" + addressHolder + "', Birthday = '" + birthdayHolder + "', Post_Code = '" + postCodeHolder + "', Gender = '" + genderHolder + "', Updated_At = '" + timestamp + "' WHERE User_Id = " + idHolder + "", connection);

                    command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Kullanıcı başarılı bir şekilde güncellenmiştir.");

                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu. \n" + hata.Message);
                    connection.Close();
                }
            }
            else
            {

            }
        }

        public static void searchUser(string searchHolder, DataGridView dataGridView)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE User_Id LIKE '%" + searchHolder + "%' or Username LIKE '%" + searchHolder + "%' or Name LIKE '%" + searchHolder + "%' or Surname LIKE '%" + searchHolder + "%' or Phone_1 LIKE '%" + searchHolder + "%' or Phone_2 LIKE '%" + searchHolder + "%' or Identity_Number LIKE '%" + searchHolder + "%' or Email LIKE '%" + searchHolder + "%' or Address LIKE '%" + searchHolder + "%' or Created_At LIKE '%" + searchHolder + "%' or Updated_At LIKE '%" + searchHolder + "%' or Birthday LIKE '%" + searchHolder + "%' or Post_Code LIKE '%" + searchHolder + "%' or Gender LIKE '%" + searchHolder + "%'", connection);

            var dataAdapter = new SqlDataAdapter(command);

            var ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridView.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];

            command.ExecuteNonQuery();

            connection.Close();
        }

        #endregion

        #region Deposit

        public static void getAllBooks(ComboBox comboBox)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Name FROM Books", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox.Items.Add(dt.Rows[i]["Name"].ToString());
            }
        }

        public static void getAllUsers(ComboBox comboBox)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Username FROM Users", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox.Items.Add(dt.Rows[i]["Username"].ToString());
            }
        }

        public static void listDeposits(DataGridView dataGridView)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT Deposit.Deposit_Id AS 'Sıra No', Users.Username AS 'Kullanıcı Adı', Books.Name AS 'Kitap Adı',Deposit_Given_Date AS 'Emanet Veriliş Tarihi', Deposit_Taken_Date AS 'Emanet Son Alım Tarihi', Deposit.Description AS 'Açıklama',Deposit.Created_At AS 'Oluşturulma Tarihi', Deposit.Updated_At AS 'Güncelleme Tarihi' FROM Deposit INNER JOIN Users ON Deposit.User_Id = Users.User_Id INNER JOIN Books ON Deposit.Book_Id = Books.Book_Id", connection);

            var dataAdapter = new SqlDataAdapter(command);

            var ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridView.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];

            command.ExecuteNonQuery();

            connection.Close();

        }

        public static void addDeposit(string userId, string bookId, string depositGivenDate, string depositTakenDate, string descriptionHolder)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Deposit(User_Id,Book_Id,Deposit_Given_Date,Deposit_Taken_Date,Description) VALUES ('" + userId + "','" + bookId + "','" + depositGivenDate + "','" + depositTakenDate + "','" + descriptionHolder + "')", connection);

                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Emanet başarılı bir şekilde kayıt edilmiştir");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. \n" + hata.Message);
                connection.Close();
            }
        }

        public static void deleteDeposit(string idHolder)
        {
            string message = "Bu emaneti silmek istediğinizden emin misiniz?";
            string title = "Emaneti Silmek Üzeresiniz";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM Deposit WHERE Deposit_Id = " + idHolder + "", connection);

                    command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Emanet başarılı bir şekilde silinmiştir.");

                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu. \n" + hata.Message);
                    connection.Close();
                }
            }
            else
            {

            }
        }

        public static void updateDeposit(string idHolder, string userId, string bookId, string depositGivenDate, string depositTakenDate, string descriptionHolder)
        {
            String timestamp = GetTimestamp(DateTime.Now);

            string message = "Bu emaneti güncellemek istediğinizden emin misiniz?";
            string title = "Emaneti Güncellemek Üzeresiniz";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UPDATE Deposit SET User_Id = '" + userId + "', Book_Id = '" + bookId + "', Deposit_Given_Date = '" + depositGivenDate + "', Deposit_Taken_Date = '" + depositTakenDate + "', Description = '" + descriptionHolder + "', Updated_At = '" + timestamp + "' WHERE Deposit_Id = " + idHolder + "", connection);

                    command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Emanet başarılı bir şekilde güncellenmiştir.");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu. \n" + hata.Message);
                    connection.Close();
                }
            }
            else
            {

            }
        }

        public static void searchDeposit(string searchHolder, DataGridView dataGridView)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Deposit WHERE User_Id LIKE '%" + searchHolder + "%' or Book_Id LIKE '%" + searchHolder + "%' or Deposit_Given_Date LIKE '%" + searchHolder + "%' or Deposit_Taken_Date LIKE '%" + searchHolder + "%' or Description LIKE '%" + searchHolder + "%' or Created_At LIKE '%" + searchHolder + "%' or Updated_At LIKE '%" + searchHolder + "%'", connection);

            var dataAdapter = new SqlDataAdapter(command);

            var ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridView.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];

            command.ExecuteNonQuery();

            connection.Close();
        }

        #endregion

        #region Admin

        public static void login(string usernameHolder, string emailHolder, string passwordHolder, Form form)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Admin WHERE (Username ='" + usernameHolder + "' OR Email = '" + emailHolder + "') AND Password = '" + passwordHolder + "'", connection);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    connection.Close();
                    Home home = new Home();
                    home.Show();
                    form.Hide();
                }
                else
                {
                    MessageBox.Show("Girilen değerler yanlış tekrardan kontrol ediniz.");
                }
                connection.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. \n" + hata.Message);
                connection.Close();
            }
        }

        public static void addAdmin(string usernameHolder, string emailHolder, string nameHolder, string surnameHolder, string passwordHolder, string confirmPasswordHolder)
        {

            if (passwordHolder != confirmPasswordHolder)
            {
                MessageBox.Show("Şifreler eşleşmiyor");
            }
            else
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("INSERT INTO Admin(Username, Name, Surname, Email, Password) VALUES ('" + usernameHolder + "','" + nameHolder + "','" + surnameHolder + "','" + emailHolder + "','" + passwordHolder + "')", connection);

                    command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Admin başarılı bir şekilde kayıt edilmiştir");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu. \n" + hata.Message);
                    connection.Close();
                }
            }
        }

        public static void updateAdmin(string idHolder, string usernameHolder, string emailHolder, string nameHolder, string surnameHolder, string passwordHolder, string confirmPasswordHolder)
        {
            String timestamp = GetTimestamp(DateTime.Now);

            string message = "Bu admini güncellemek istediğinizden '" + usernameHolder + "' emin misiniz?";
            string title = "Admin Güncellemek Üzeresiniz";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (passwordHolder != confirmPasswordHolder)
                {
                    MessageBox.Show("Şifreler eşleşmiyor");
                }
                else
                {
                    try
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand("UPDATE Admin SET Username = '" + usernameHolder + "', Name = '" + nameHolder + "', Surname = '" + surnameHolder + "', Email = '" + emailHolder + "', Updated_At = '" + timestamp + "' WHERE Admin_Id = " + idHolder + "", connection);

                        command.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Admin başarılı bir şekilde güncellenmiştir.");

                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("İşlem Sırasında Hata Oluştu. \n" + hata.Message);
                        connection.Close();
                    }
                }
            }
            else
            {

            }
        }

        public static void deleteAdmin(string idHolder, string usernameHolder)
        {
            string message = "Bu admini silmek istediğinizden '" + usernameHolder + "' emin misiniz?";
            string title = "Admini Silmek Üzeresiniz";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM Admin WHERE Admin_Id = " + idHolder + "", connection);

                    command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Admin başarılı bir şekilde silinmiştir.");

                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu. \n" + hata.Message);
                    connection.Close();
                }
            }
            else
            {

            }
        }

        public static void searchAdmin(string searchHolder, DataGridView dataGridView)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Admin WHERE Admin_Id LIKE '%" + searchHolder + "%' or Username LIKE '%" + searchHolder + "%' or Name LIKE '%" + searchHolder + "%' or Surname LIKE '%" + searchHolder + "%' or Created_At LIKE '%" + searchHolder + "%' or Updated_At LIKE '%" + searchHolder + "%'", connection);

            var dataAdapter = new SqlDataAdapter(command);

            var ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridView.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];

            command.ExecuteNonQuery();

            connection.Close();
        }

        #endregion

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("dd/MM/yyyy HH:mm:ss:ffff");
        }

    }
}
