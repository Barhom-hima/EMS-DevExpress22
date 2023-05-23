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
    public partial class AddEmployeePage : DevExpress.XtraEditors.XtraForm
    {
        // DataBase And Tables
        DBEMSEntities db;
        TB_Employees tbAdd;
        public EmployeesPage page = new EmployeesPage();

        // Other Var
        public int id;

        public AddEmployeePage()
        {
            InitializeComponent();

            FixPlace();
        }

        // Add Function
        private void Add()
        {
            // Check If empty values
            if(txtName.Text == "" && txtJobId.Text == "" && txtJobName.Text == "" && txtPhone.Text == "" && txtEmail.Text == ""
                && txtSalary.Text == "" && txtSalaries.Text == "" && txtWorkTime.Text == "" && txtVacationTime.Text == "" && txtIdNum.Text == ""
                && txtPassportNum.Text == "")
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
                tbAdd = new TB_Employees
                {
                    Name = txtName.Text,
                    JobId = txtJobId.Text,
                    JobName = txtJobName.Text,
                    Dob = txtDob.Value,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Salary = txtSalary.Text,
                    Salaries = txtSalaries.Text,
                    WorkTime = txtWorkTime.Text,
                    VacationTime = txtVacationTime.Text,
                    IdNum = txtIdNum.Text,
                    PassportNum = txtPassportNum.Text,
                    Doj = txtDoj.Value,
                    DateEndId = txtDateEndId.Value,
                    DateEndPassport = txtDateEndPassport.Value,
                    Details = txtDetails.Text
                };
                db.Entry(tbAdd).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

                MessageBox.Show("تمت اضافة موظف جديد بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                tbAdd = new TB_Employees
                {
                    Id = id,
                    Name = txtName.Text,
                    JobId = txtJobId.Text,
                    JobName = txtJobName.Text,
                    Dob = txtDob.Value,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Salary = txtSalary.Text,
                    Salaries = txtSalaries.Text,
                    WorkTime = txtWorkTime.Text,
                    VacationTime = txtVacationTime.Text,
                    IdNum = txtIdNum.Text,
                    PassportNum = txtPassportNum.Text,
                    Doj = txtDoj.Value,
                    DateEndId = txtDateEndId.Value,
                    DateEndPassport = txtDateEndPassport.Value,
                    Details = txtDetails.Text
                };
                db.Set<TB_Employees>().AddOrUpdate(tbAdd);
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
            txtName.Text = "";
            txtJobId.Text = "";
            txtJobName.Text = "";
            txtDob.Value = DateTime.Now;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtSalary.Text = "";
            txtSalaries.Text = "";
            txtWorkTime.Text = "";
            txtVacationTime.Text = "";
            txtIdNum.Text = "";
            txtPassportNum.Text = "";
            txtDoj.Value = DateTime.Now;
            txtDateEndId.Value = DateTime.Now;
            txtDateEndPassport.Value = DateTime.Now;
            txtDetails.Text = "";
        }

        private void FixPlace()
        {
            #region TextBoxs
            // Size
            txtName.Size = new System.Drawing.Size(217, 33);
            txtJobId.Size = new System.Drawing.Size(217, 33);
            txtJobName.Size = new System.Drawing.Size(217, 33);
            txtDob.Size = new System.Drawing.Size(217, 29);
            txtPhone.Size = new System.Drawing.Size(217, 33);
            txtEmail.Size = new System.Drawing.Size(217, 33);
            txtSalary.Size = new System.Drawing.Size(217, 33);
            txtSalaries.Size = new System.Drawing.Size(217, 33);
            txtWorkTime.Size = new System.Drawing.Size(217, 33);
            txtVacationTime.Size = new System.Drawing.Size(217, 33);
            txtIdNum.Size = new System.Drawing.Size(217, 33);
            txtPassportNum.Size = new System.Drawing.Size(217, 33);
            txtDoj.Size = new System.Drawing.Size(217, 29);
            txtDateEndId.Size = new System.Drawing.Size(217, 29);
            txtDateEndPassport.Size = new System.Drawing.Size(217, 29);
            txtDetails.Size = new System.Drawing.Size(215, 96);

            // txtName
            txtName.Location = new System.Drawing.Point(323, 43);

            // txtJobId
            txtJobId.Location = new System.Drawing.Point(323, 112);

            // txtJobName
            txtJobName.Location = new System.Drawing.Point(323, 182);

            // txtDob
            txtDob.Location = new System.Drawing.Point(323, 259);

            // txtPhone
            txtPhone.Location = new System.Drawing.Point(323, 323);

            // txtEmail
            txtEmail.Location = new System.Drawing.Point(323, 396);

            // txtSalary
            txtSalary.Location = new System.Drawing.Point(323, 470);

            // txtSalaries
            txtSalaries.Location = new System.Drawing.Point(323, 542);

            // txtWorkTime
            txtWorkTime.Location = new System.Drawing.Point(10, 43);

            // txtVacationTime
            txtVacationTime.Location = new System.Drawing.Point(10, 112);

            // txtIdNum
            txtIdNum.Location = new System.Drawing.Point(10, 182);

            // txtPassportNum
            txtPassportNum.Location = new System.Drawing.Point(10, 252);

            // txtDoj
            txtDoj.Location = new System.Drawing.Point(10, 322);

            // txtDateEndId
            txtDateEndId.Location = new System.Drawing.Point(10, 396);

            // txtDateEndPassport
            txtDateEndPassport.Location = new System.Drawing.Point(10, 468);

            // txtDetails
            txtDetails.Location = new System.Drawing.Point(14, 542);
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
    }
}