
namespace hazmat_book.Main.Deposit
{
    partial class Deposit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDepositNote = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.strpHome = new System.Windows.Forms.ToolStripMenuItem();
            this.strpBook = new System.Windows.Forms.ToolStripMenuItem();
            this.strpUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.strpUser = new System.Windows.Forms.ToolStripMenuItem();
            this.strpAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hazmatDataSet = new hazmat_book.hazmatDataSet();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hazmatDataSet2 = new hazmat_book.hazmatDataSet2();
            this.txtDepositDate = new System.Windows.Forms.DateTimePicker();
            this.txtDepositDate2 = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.depositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hazmatDataSet1 = new hazmat_book.hazmatDataSet1();
            this.depositTableAdapter = new hazmat_book.hazmatDataSet1TableAdapters.DepositTableAdapter();
            this.usersTableAdapter = new hazmat_book.hazmatDataSet2TableAdapters.UsersTableAdapter();
            this.booksTableAdapter = new hazmat_book.hazmatDataSetTableAdapters.BooksTableAdapter();
            this.emanetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazmatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazmatDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazmatDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(729, 36);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(203, 20);
            this.txtDeposit.TabIndex = 21;
            this.txtDeposit.TextChanged += new System.EventHandler(this.txtDeposit_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(661, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Emanet Ara";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(189, 36);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 20);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(259, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 20);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(40, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 26);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDepositNote
            // 
            this.txtDepositNote.Location = new System.Drawing.Point(5, 237);
            this.txtDepositNote.Name = "txtDepositNote";
            this.txtDepositNote.Size = new System.Drawing.Size(164, 183);
            this.txtDepositNote.TabIndex = 11;
            this.txtDepositNote.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(189, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(742, 425);
            this.dataGridView1.TabIndex = 17;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpHome,
            this.strpBook,
            this.emanetToolStripMenuItem,
            this.strpUsers});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(952, 24);
            this.mainMenu.TabIndex = 15;
            this.mainMenu.Text = "mainMenu";
            // 
            // strpHome
            // 
            this.strpHome.Name = "strpHome";
            this.strpHome.Size = new System.Drawing.Size(67, 20);
            this.strpHome.Text = "Anasayfa";
            this.strpHome.Click += new System.EventHandler(this.strpHome_Click);
            // 
            // strpBook
            // 
            this.strpBook.Name = "strpBook";
            this.strpBook.Size = new System.Drawing.Size(46, 20);
            this.strpBook.Text = "Kitap";
            this.strpBook.Click += new System.EventHandler(this.strpBook_Click);
            // 
            // strpUsers
            // 
            this.strpUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpUser,
            this.strpAdmin});
            this.strpUsers.Name = "strpUsers";
            this.strpUsers.Size = new System.Drawing.Size(64, 20);
            this.strpUsers.Text = "Kullanıcı";
            // 
            // strpUser
            // 
            this.strpUser.Name = "strpUser";
            this.strpUser.Size = new System.Drawing.Size(180, 22);
            this.strpUser.Text = "Kullanıcı";
            this.strpUser.Click += new System.EventHandler(this.strpUser_Click);
            // 
            // strpAdmin
            // 
            this.strpAdmin.Name = "strpAdmin";
            this.strpAdmin.Size = new System.Drawing.Size(180, 22);
            this.strpAdmin.Text = "Admin";
            this.strpAdmin.Click += new System.EventHandler(this.strpAdmin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Emanet Notu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Emanet Alınan Kitap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Emanet Alma Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emanet Verme Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emanet Alan Kişi (Kullanıcı Adı)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBook);
            this.groupBox1.Controls.Add(this.cmbUser);
            this.groupBox1.Controls.Add(this.txtDepositDate);
            this.groupBox1.Controls.Add(this.txtDepositDate2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtDepositNote);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 460);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Ekle / Düzenle";
            // 
            // cmbBook
            // 
            this.cmbBook.DataSource = this.booksBindingSource;
            this.cmbBook.DisplayMember = "Name";
            this.cmbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(5, 95);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(164, 21);
            this.cmbBook.TabIndex = 19;
            this.cmbBook.ValueMember = "Book_Id";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.hazmatDataSet;
            // 
            // hazmatDataSet
            // 
            this.hazmatDataSet.DataSetName = "hazmatDataSet";
            this.hazmatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbUser
            // 
            this.cmbUser.DataSource = this.usersBindingSource;
            this.cmbUser.DisplayMember = "Username";
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(5, 52);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(164, 21);
            this.cmbUser.TabIndex = 18;
            this.cmbUser.ValueMember = "User_Id";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.hazmatDataSet2;
            // 
            // hazmatDataSet2
            // 
            this.hazmatDataSet2.DataSetName = "hazmatDataSet2";
            this.hazmatDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDepositDate
            // 
            this.txtDepositDate.Location = new System.Drawing.Point(5, 141);
            this.txtDepositDate.Name = "txtDepositDate";
            this.txtDepositDate.Size = new System.Drawing.Size(164, 20);
            this.txtDepositDate.TabIndex = 17;
            // 
            // txtDepositDate2
            // 
            this.txtDepositDate2.Location = new System.Drawing.Point(5, 190);
            this.txtDepositDate2.Name = "txtDepositDate2";
            this.txtDepositDate2.Size = new System.Drawing.Size(164, 20);
            this.txtDepositDate2.TabIndex = 16;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(329, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 20);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // depositBindingSource
            // 
            this.depositBindingSource.DataMember = "Deposit";
            this.depositBindingSource.DataSource = this.hazmatDataSet1;
            // 
            // hazmatDataSet1
            // 
            this.hazmatDataSet1.DataSetName = "hazmatDataSet1";
            this.hazmatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depositTableAdapter
            // 
            this.depositTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // emanetToolStripMenuItem
            // 
            this.emanetToolStripMenuItem.Name = "emanetToolStripMenuItem";
            this.emanetToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.emanetToolStripMenuItem.Text = "Emanet";
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 511);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hazmat Book - Emanetler";
            this.Load += new System.EventHandler(this.Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazmatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazmatDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazmatDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtDepositNote;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem strpHome;
        private System.Windows.Forms.ToolStripMenuItem strpBook;
        private System.Windows.Forms.ToolStripMenuItem strpUsers;
        private System.Windows.Forms.ToolStripMenuItem strpUser;
        private System.Windows.Forms.ToolStripMenuItem strpAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtDepositDate;
        private System.Windows.Forms.DateTimePicker txtDepositDate2;
        private hazmatDataSet1 hazmatDataSet1;
        private System.Windows.Forms.BindingSource depositBindingSource;
        private hazmatDataSet1TableAdapters.DepositTableAdapter depositTableAdapter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.ComboBox cmbUser;
        private hazmatDataSet2 hazmatDataSet2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private hazmatDataSet2TableAdapters.UsersTableAdapter usersTableAdapter;
        private hazmatDataSet hazmatDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private hazmatDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem emanetToolStripMenuItem;
    }
}