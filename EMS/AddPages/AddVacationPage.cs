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
    public partial class AddVacationPage : DevExpress.XtraEditors.XtraForm
    {
        // DataBase And Tables
        DBEMSEntities db;
        TB_Vacations tbAdd;
        public VacationsPage page = new VacationsPage();

        // Other Var
        public int id;

        public AddVacationPage()
        {
            InitializeComponent();

            FixPlace();
        }

        // Add Function
        private void Add()
        {
            // Check If empty values
            if(txtAboutVacation.Text == "" && txtVacationAmount.Text == "")
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
                    EmpName = txtEmpName.Text,
                    AboutVacation = txtAboutVacation.Text,
                    VacationAmount = txtVacationAmount.Text,
                    VacationStartDate = txtVacationStartDate.Value,
                    VacationEndDate = txtVacationEndDate.Value
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
                    EmpName = txtEmpName.Text,
                    AboutVacation = txtAboutVacation.Text,
                    VacationAmount = txtVacationAmount.Text,
                    VacationStartDate = txtVacationStartDate.Value,
                    VacationEndDate = txtVacationEndDate.Value
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
            txtAboutVacation.Text = "";
            txtVacationAmount.Text = "";
            txtVacationStartDate.Value = DateTime.Now;
            txtVacationEndDate.Value = DateTime.Now;
        }

        private void FixPlace()
        {
            #region TextBoxs
            // Size
            txtEmpName.Size = new System.Drawing.Size(217, 33);
            txtAboutVacation.Size = new System.Drawing.Size(217, 33);
            txtVacationAmount.Size = new System.Drawing.Size(217, 33);
            txtVacationStartDate.Size = new System.Drawing.Size(217, 29);

            // txtEmpName
            txtEmpName.Location = new System.Drawing.Point(323, 43);

            // txtAboutVacation
            txtAboutVacation.Location = new System.Drawing.Point(323, 112);

            // txtVacationAmount
            txtVacationAmount.Location = new System.Drawing.Point(323, 196);

            // txtVacationStartDate
            txtVacationStartDate.Location = new System.Drawing.Point(33, 50);

            // txtVacationEndtDate
            txtVacationEndDate.Location = new System.Drawing.Point(33, 119);

            #endregion

            #region Buttons
            // Button Save
            buttonAdd.Size = new System.Drawing.Size(130, 68);
            buttonAdd.Location = new System.Drawing.Point(420, 6);

            // Button Save And close
            buttonAddAndClose.Size = new System.Drawing.Size(130, 68);
            buttonAddAndClose.Location = new System.Drawing.Point(10, 6);
            #endregion
        }

        private void AddVacationPage_Activated(object sender, EventArgs e)
        {
            db = new DBEMSEntities();

            txtEmpName.DataSource = db.TB_Employees.Select(x => x.Name).ToList();
        }
    }
}