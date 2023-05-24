using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMS.Pages;
using EMS.AddPages;
using System.Data.Entity.Migrations;

namespace EMS.AddPages
{
    public partial class LoginPage : DevExpress.XtraEditors.XtraForm
    {
        // DataBase And Tables
        DBEMSEntities db;
        TB_Users tbAdd;
        public VacationsPage page = new VacationsPage();

        // Other Var
        public int id;

        public LoginPage()
        {
            InitializeComponent();

            FixPlace();
        }

        // Add Function
        private void LoginFunc()
        {
            // Check If empty values
            if(txtUsername.Text == "" && txtPassowrd.Text == "")
            {
                MessageBox.Show("برجى ملئ جميع الحقول التي تحتوي على علامة * ثم اعد المحاولة", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Login
            else
            {
                Login();
            }
        }

        private void Login()
        {
            Main main = new Main();
            try
            {
                db = new DBEMSEntities();
                tbAdd = db.TB_Users.Where(x => x.Username == txtUsername.Text && x.Passowrd == txtPassowrd.Text).FirstOrDefault();

                main.txtUsername.Caption = tbAdd.FullName;
                main.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Button Save
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LoginFunc();
        }

        // Button Save And Close
        private void buttonAddAndClose_Click(object sender, EventArgs e)
        {
            AddUserPage addPage = new AddUserPage();
            addPage.id = 0;
            addPage.buttonAdd.Text = "اضافة";
            addPage.buttonAddAndClose.Text = "اضافة + غلق";
            addPage.Show();
        }

        private void FixPlace()
        {
            #region TextBoxs
            // Size
            txtUsername.Size = new System.Drawing.Size(379, 33);
            txtUsername.Location = new System.Drawing.Point(12, 34);

            txtPassowrd.Size = new System.Drawing.Size(379, 33);
            txtPassowrd.Location = new System.Drawing.Point(12, 113);

            #endregion

            #region Buttons
            // Button Save
            buttonLogin.Size = new System.Drawing.Size(106, 68);
            buttonLogin.Location = new System.Drawing.Point(294, 10);

            // Button Save And close
            buttonSignIn.Size = new System.Drawing.Size(106, 68);
            buttonSignIn.Location = new System.Drawing.Point(3, 10);
            #endregion
        }

        private void AddVacationPage_Activated(object sender, EventArgs e)
        {
            
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}