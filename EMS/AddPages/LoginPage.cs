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
    public partial class LoginPage : DevExpress.XtraEditors.XtraForm
    {
        // DataBase And Tables
        DBEMSEntities db;
        TB_Vacations tbAdd;
        public VacationsPage page = new VacationsPage();

        // Other Var
        public int id;

        public LoginPage()
        {
            InitializeComponent();

            FixPlace();
        }

        // Add Function
        private void Add()
        {
            // Check If empty values
            if(txtUsername.Text == "" && txtPassowrd.Text == "")
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
                tbAdd = new TB_Vacations
                {
                    VacationAmount = txtUsername.Text,
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
                tbAdd = new TB_Vacations
                {
                    Id = id,
                    VacationAmount = txtUsername.Text
                };
                db.Set<TB_Vacations>().AddOrUpdate(tbAdd);
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
            
        }

        private void FixPlace()
        {
            #region TextBoxs
            // Size
            txtUsername.Size = new System.Drawing.Size(217, 33);

            #endregion

            #region Buttons
            // Button Save
            buttonLogin.Size = new System.Drawing.Size(130, 68);
            buttonLogin.Location = new System.Drawing.Point(420, 6);

            // Button Save And close
            buttonSignIn.Size = new System.Drawing.Size(130, 68);
            buttonSignIn.Location = new System.Drawing.Point(10, 6);
            #endregion
        }

        private void AddVacationPage_Activated(object sender, EventArgs e)
        {
            
        }
    }
}