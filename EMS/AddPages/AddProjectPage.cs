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
    public partial class AddProjectPage : DevExpress.XtraEditors.XtraForm
    {
        // DataBase And Tables
        DBEMSEntities db;
        TB_Projects tbAdd;
        public ProjectsPage page = new ProjectsPage();

        // Other Var
        public int id;

        public AddProjectPage()
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
            if (txtProjectName.Text == "" && txtRequireds.Text == "" && txtCost.Text == "")
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
                tbAdd = new TB_Projects
                {
                    ProjectName = txtProjectName.Text,
                    AdminName = txtAdminName.Text,
                    ProjectStatus = txtProjectStatus.Text,
                    Requireds = txtRequireds.Text,
                    Cost = txtCost.Text,
                    StartDate = txtStartDate.Value,
                    EndDate = txtEndDate.Value,
                    Details = txtDetails.Text
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
                tbAdd = new TB_Projects
                {
                    Id = id,
                    ProjectName = txtProjectName.Text,
                    AdminName = txtAdminName.Text,
                    ProjectStatus = txtProjectStatus.Text,
                    Requireds = txtRequireds.Text,
                    Cost = txtCost.Text,
                    StartDate = txtStartDate.Value,
                    EndDate = txtEndDate.Value,
                    Details = txtDetails.Text
                };
                db.Set<TB_Projects>().AddOrUpdate(tbAdd);
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
            txtProjectName.Text = "";
            txtRequireds.Text = "";
            txtCost.Text = "";
            txtDetails.Text = "";
            txtStartDate.Value = DateTime.Now;
        }

        private void FixPlace()
        {
            #region TextBoxs
            // Size
            txtProjectName.Size = new System.Drawing.Size(217, 33);
            txtAdminName.Size = new System.Drawing.Size(217, 33);
            txtProjectStatus.Size = new System.Drawing.Size(217, 33);
            txtRequireds.Size = new System.Drawing.Size(217, 33);
            txtCost.Size = new System.Drawing.Size(217, 33);
            txtStartDate.Size = new System.Drawing.Size(217, 29);
            txtEndDate.Size = new System.Drawing.Size(217, 29);
            txtDetails.Size = new System.Drawing.Size(218, 96);

            // txtProjectName
            txtProjectName.Location = new System.Drawing.Point(317, 43);

            // txtAdminName
            txtAdminName.Location = new System.Drawing.Point(317, 120);

            // txtProjectStatus
            txtProjectStatus.Location = new System.Drawing.Point(316, 189);

            // txtRequireds
            txtRequireds.Location = new System.Drawing.Point(316, 259);

            // txtCost
            txtCost.Location = new System.Drawing.Point(30, 43);

            // txtStartDate
            txtStartDate.Location = new System.Drawing.Point(30, 119);

            // txtEndDate
            txtEndDate.Location = new System.Drawing.Point(30, 196);

            // txtDetails
            txtDetails.Location = new System.Drawing.Point(30, 256);

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

            txtAdminName.DataSource = db.TB_Employees.Select(x => x.Name).ToList();
        }
    }
}