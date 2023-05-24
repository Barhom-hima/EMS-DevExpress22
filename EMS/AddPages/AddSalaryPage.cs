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
using System.Data.Entity;

namespace EMS.AddPages
{
    public partial class AddSalaryPage : DevExpress.XtraEditors.XtraForm
    {
        // DataBase And Tables
        DBEMSEntities db;
        TB_Salaries tbAdd;
        public SalariesPage page = new SalariesPage();

        // Other Var
        public int id;

        public AddSalaryPage()
        {
            InitializeComponent();

            FixPlace();

            EMS.DBEMSEntities dbContext = new EMS.DBEMSEntities();
            dbContext.TB_Employees.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TB_Employees.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        // Add Function
        private void Add()
        {
            // Check If empty values
            if (txtSalaries.Text == "")
            {
                MessageBox.Show("برجى ملئ جميع الحقول التي تحتوي على علامة * ثم اعد المحاولة", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Add
            else
            {
                // Check If Add or Edit
                if (id == 0)
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
                tbAdd = new TB_Salaries
                {
                    EmpName = txtEmpName.Text,
                    MainSalary = txtMainSalary.Text,
                    ContractStatus = txtContractStatus.Text,
                    Salaries = txtSalaries.Text,
                    CashingDate = txtCashingDate.Value
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
                tbAdd = new TB_Salaries
                {
                    Id = id,
                    EmpName = txtEmpName.Text,
                    MainSalary = txtMainSalary.Text,
                    ContractStatus = txtContractStatus.Text,
                    Salaries = txtSalaries.Text,
                    CashingDate = txtCashingDate.Value
                };
                db.Set<TB_Salaries>().AddOrUpdate(tbAdd);
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
            txtSalaries.Text = "";
            txtCashingDate.Value = DateTime.Now;
        }

        private void FixPlace()
        {
            #region TextBoxs
            // Size
            txtEmpName.Size = new System.Drawing.Size(217, 33);
            txtMainSalary.Size = new System.Drawing.Size(217, 33);
            txtContractStatus.Size = new System.Drawing.Size(217, 33);
            txtSalaries.Size = new System.Drawing.Size(217, 33);
            txtCashingDate.Size = new System.Drawing.Size(217, 29);

            // txtEmpName
            txtEmpName.Location = new System.Drawing.Point(323, 43);

            // txtMainSalary
            txtMainSalary.Location = new System.Drawing.Point(323, 115);

            // txtEmpName
            txtContractStatus.Location = new System.Drawing.Point(318, 196);

            // txtAboutVacation
            txtSalaries.Location = new System.Drawing.Point(30, 43);

            // txtVacationStartDate
            txtCashingDate.Location = new System.Drawing.Point(30, 119);

            #endregion

            #region Buttons
            // Button Save
            buttonAdd.Size = new System.Drawing.Size(130, 68);
            buttonAdd.Location = new System.Drawing.Point(787, 6);

            // Button Save And close
            buttonAddAndClose.Size = new System.Drawing.Size(130, 68);
            buttonAddAndClose.Location = new System.Drawing.Point(10, 6);
            #endregion
        }

        private void AddVacationPage_Activated(object sender, EventArgs e)
        {
            db = new DBEMSEntities();

            txtEmpName.DataSource = db.TB_Employees.Select(x => x.Name).ToList();

            txtMainSalary.DataSource = db.TB_Employees.Select(x => x.Salary).ToList();

            txtContractStatus.DataSource = db.TB_Employees.Select(x => x.ContractStatus).ToList();
        }
    }
}