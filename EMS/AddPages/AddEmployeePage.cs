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
            if(txtName.Text == "" && txtGender.Text == "" && txtPhone.Text == "" && txtIdNum.Text == "" && txtPassportNum.Text == ""
                && txtJobName.Text == "" && txtContractStatus.Text == "" && txtWorkTime.Text == "" && txtWorkTimeInWeak.Text == ""
                && txtSalary.Text == "" && txtVacationTime.Text == "")
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
                    Dob = txtDob.Value,
                    Gender = txtGender.Text,
                    Phone = txtPhone.Text,
                    IdNum = txtIdNum.Text,
                    DateEndId = txtDateEndId.Value,
                    PassportNum = txtPassportNum.Text,
                    DateEndPassport = txtDateEndPassport.Value,
                    Email = txtEmail.Text,
                    JobName = txtJobName.Text,
                    JobId = txtJobId.Text,
                    Rank = txtRank.Text,
                    Doj = txtDoj.Value,
                    ContractStatus = txtContractStatus.Text,
                    WorkTime = txtWorkTime.Text,
                    WorkTimeInWeak = txtWorkTimeInWeak.Text,
                    Salary = txtSalary.Text,
                    VacationTime = txtVacationTime.Text,
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
                    Dob = txtDob.Value,
                    Gender = txtGender.Text,
                    Phone = txtPhone.Text,
                    IdNum = txtIdNum.Text,
                    DateEndId = txtDateEndId.Value,
                    PassportNum = txtPassportNum.Text,
                    DateEndPassport = txtDateEndPassport.Value,
                    Email = txtEmail.Text,
                    JobName = txtJobName.Text,
                    JobId = txtJobId.Text,
                    Rank = txtRank.Text,
                    Doj = txtDoj.Value,
                    ContractStatus = txtContractStatus.Text,
                    WorkTime = txtWorkTime.Text,
                    WorkTimeInWeak = txtWorkTimeInWeak.Text,
                    Salary = txtSalary.Text,
                    VacationTime = txtVacationTime.Text,
                    Details = txtDetails.Text
                };
                db.Set<TB_Employees>().AddOrUpdate(tbAdd);
                db.SaveChanges();

                MessageBox.Show("تم تعديل بيانات الموظف بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtDob.Value = DateTime.Now;
            txtGender.Text = "";
            txtPhone.Text = "";
            txtIdNum.Text = "";
            txtDateEndId.Value = DateTime.Now;
            txtPassportNum.Text = "";
            txtDateEndPassport.Value = DateTime.Now;
            txtEmail.Text = "";
            txtJobName.Text = "";
            txtJobId.Text = "";
            txtRank.Text = "";
            txtDoj.Value = DateTime.Now;
            txtContractStatus.Text = "";
            txtWorkTime.Text = "";
            txtWorkTimeInWeak.Text = "";
            txtSalary.Text = "";
            txtVacationTime.Text = "";
            txtDetails.Text = "";
        }

        private void FixPlace()
        {
            #region TextBoxs
            // Size
            txtName.Size = new System.Drawing.Size(217, 33);
            txtDob.Size = new System.Drawing.Size(217, 29);
            txtGender.Size = new System.Drawing.Size(217, 29);
            txtPhone.Size = new System.Drawing.Size(217, 33);
            txtIdNum.Size = new System.Drawing.Size(217, 33);
            txtDateEndId.Size = new System.Drawing.Size(217, 29);
            txtPassportNum.Size = new System.Drawing.Size(217, 33);
            txtDateEndPassport.Size = new System.Drawing.Size(217, 29);
            txtEmail.Size = new System.Drawing.Size(217, 33);
            txtJobName.Size = new System.Drawing.Size(217, 33);
            txtJobId.Size = new System.Drawing.Size(217, 33);
            txtRank.Size = new System.Drawing.Size(217, 33);
            txtDoj.Size = new System.Drawing.Size(217, 29);
            txtContractStatus.Size = new System.Drawing.Size(217, 33);
            txtWorkTime.Size = new System.Drawing.Size(217, 33);
            txtWorkTimeInWeak.Size = new System.Drawing.Size(217, 33);
            txtSalary.Size = new System.Drawing.Size(217, 33);
            txtVacationTime.Size = new System.Drawing.Size(217, 33);
            txtDetails.Size = new System.Drawing.Size(215, 96);

            // txtName
            txtName.Location = new System.Drawing.Point(11, 54);

            // txtDob
            txtDob.Location = new System.Drawing.Point(11, 135);

            // txtGender
            txtGender.Location = new System.Drawing.Point(11, 203);

            // txtPhone
            txtPhone.Location = new System.Drawing.Point(11, 279);

            // txtIdNum
            txtIdNum.Location = new System.Drawing.Point(11, 357);

            // txtDateEndId
            txtDateEndId.Location = new System.Drawing.Point(8, 431);

            // txtPassportNum
            txtPassportNum.Location = new System.Drawing.Point(11, 497);

            // txtDateEndPassport
            txtDateEndPassport.Location = new System.Drawing.Point(11, 573);

            // txtEmail
            txtEmail.Location = new System.Drawing.Point(256, 54);

            // txtJobName
            txtJobName.Location = new System.Drawing.Point(256, 127);

            // txtJobId
            txtJobId.Location = new System.Drawing.Point(254, 201);

            // txtRank
            txtRank.Location = new System.Drawing.Point(254, 277);

            // txtDoj
            txtDoj.Location = new System.Drawing.Point(251, 349);

            // txtContractStatus
            txtContractStatus.Location = new System.Drawing.Point(251, 420);

            // txtWorkTime
            txtWorkTime.Location = new System.Drawing.Point(17, 55);

            // txtWorkTimeInWeak
            txtWorkTimeInWeak.Location = new System.Drawing.Point(20, 127);

            // txtSalary
            txtSalary.Location = new System.Drawing.Point(17, 193);

            // txtVacationTime
            txtVacationTime.Location = new System.Drawing.Point(15, 265);

            // txtDetails
            txtDetails.Location = new System.Drawing.Point(15, 341);
            #endregion

            #region Buttons
            // Button Size
            buttonAdd.Size = new System.Drawing.Size(130, 68);
            buttonAddAndClose.Size = new System.Drawing.Size(130, 68);

            // Button Location
            buttonAdd.Location = new System.Drawing.Point(629, 6);
            buttonAddAndClose.Location = new System.Drawing.Point(12, 6);
            #endregion
        }
    }
}