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
using System.Data.Entity.Migrations;

namespace EMS.AddPages
{
    public partial class AddUserPage : DevExpress.XtraEditors.XtraForm
    {
        // DataBase And Tables
        DBEMSEntities db;
        TB_Users tbAdd;
        public UsersPage page = new UsersPage();

        // Other Var
        public int id;

        public AddUserPage()
        {
            InitializeComponent();

            FixPlace();
        }

        // Add Function
        private void Add()
        {
            // Check If empty values
            if(txtFullName.Text == "" && txtUsername.Text == "")
            {
                MessageBox.Show("برجى ملئ جميع الحقول التي تحتوي على علامة * ثم اعد المحاولة", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Add
            else
            {
                // Check If Add or Edit
                if(id == 0)
                {
                    // Add
                    AddData();
                    ClearData();
                }
                else
                {
                    // Edit
                    EditData();
                }

                // Update Data
                page.LoadData();
            }
        }

        // Add Data
        private void AddData()
        {
            try
            {
                db = new DBEMSEntities();
                tbAdd = new TB_Users
                {
                    FullName = txtFullName.Text,
                    Username = txtUsername.Text,
                    Passowrd = txtPassowrd.Text,
                    DateAdd = DateTime.Now
                };
                db.Entry(tbAdd).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

                MessageBox.Show("تمت اضافة موظف جديد بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                page.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Edit Data
        private void EditData()
        {
            try
            {
                db = new DBEMSEntities();
                tbAdd = new TB_Users
                {
                    Id = id,
                    FullName = txtFullName.Text,
                    Username = txtUsername.Text,
                    Passowrd = txtPassowrd.Text,
                    DateAdd = DateTime.Now
                };
                db.Set<TB_Users>().AddOrUpdate(tbAdd);
                db.SaveChanges();

                MessageBox.Show("تم تعديل بيانات الموظف بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Button Save
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        // Button Save And Close
        private void buttonAddAndClose_Click(object sender, EventArgs e)
        {
            Add();
            Close();
        }

        private void ClearData()
        {
            txtFullName.Text = "";
            txtUsername.Text = "";
            txtPassowrd.Text = "";
        }

        private void FixPlace()
        {
            #region TextBoxs
            // Size
            txtFullName.Size = new System.Drawing.Size(379, 33);
            txtUsername.Size = new System.Drawing.Size(379, 33);
            txtPassowrd.Size = new System.Drawing.Size(379, 33);

            // txtFullName
            txtFullName.Location = new System.Drawing.Point(12, 38);

            // txtUsername
            txtUsername.Location = new System.Drawing.Point(12, 122);

            // txtPassowrd
            txtPassowrd.Location = new System.Drawing.Point(12, 201);

            #endregion

            #region Buttons
            // Button Save
            buttonAdd.Size = new System.Drawing.Size(130, 68);
            buttonAdd.Location = new System.Drawing.Point(294, 10);

            // Button Save And close
            buttonAddAndClose.Size = new System.Drawing.Size(130, 68);
            buttonAddAndClose.Location = new System.Drawing.Point(3, 10);
            #endregion
        }

        private void AddVacationPage_Activated(object sender, EventArgs e)
        {
            
        }
    }
}