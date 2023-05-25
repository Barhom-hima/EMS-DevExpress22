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
    public partial class AddMandatePage : DevExpress.XtraEditors.XtraForm
    {
        // DataBase And Tables
        DBEMSEntities db;
        TB_Mandate tbAdd;
        public MandatesPage page = new MandatesPage();

        // Other Var
        public int id;

        public AddMandatePage()
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
            if (txtMandatesEmp.Text == "" && txtAboutMandate.Text == "" && txtMandareDestination.Text == "" && txtMandateTime.Text == ""
                 && txtMandateReward.Text == "" && txtMandateResult.Text == "")
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
                tbAdd = new TB_Mandate
                {
                    ManedateAdmin = txtManedateAdmin.Text,
                    MandatesEmp = txtMandatesEmp.Text,
                    AboutMandate = txtAboutMandate.Text,
                    MandareDestination = txtMandareDestination.Text,
                    MandateTime = txtMandateTime.Text,
                    MandateDate = txtMandateDate.Value,
                    MandateReward = txtMandateReward.Text,
                    MandateResult = txtMandateResult.Text,
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
                tbAdd = new TB_Mandate
                {
                    Id = id,
                    ManedateAdmin = txtManedateAdmin.Text,
                    MandatesEmp = txtMandatesEmp.Text,
                    AboutMandate = txtAboutMandate.Text,
                    MandareDestination = txtMandareDestination.Text,
                    MandateTime = txtMandateTime.Text,
                    MandateDate = txtMandateDate.Value,
                    MandateReward = txtMandateReward.Text,
                    MandateResult = txtMandateResult.Text,
                    Details = txtDetails.Text
                };
                db.Set<TB_Mandate>().AddOrUpdate(tbAdd);
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
            txtMandatesEmp.Text = "";
            txtAboutMandate.Text = "";
            txtMandareDestination.Text = "";
            txtMandateTime.Text = "";
            txtMandateDate.Value = DateTime.Now;
            txtMandateReward.Text = "";
            txtMandateResult.Text = "";
            txtDetails.Text = "";
        }

        private void FixPlace()
        {
            #region TextBoxs
            // Size
            txtManedateAdmin.Size = new System.Drawing.Size(217, 29);
            txtMandatesEmp.Size = new System.Drawing.Size(217, 29);
            txtAboutMandate.Size = new System.Drawing.Size(217, 29);
            txtMandareDestination.Size = new System.Drawing.Size(217, 29);
            txtMandateTime.Size = new System.Drawing.Size(217, 29);
            txtMandateDate.Size = new System.Drawing.Size(217, 29);
            txtMandateReward.Size = new System.Drawing.Size(217, 29);
            txtMandateResult.Size = new System.Drawing.Size(217, 29);
            txtDetails.Size = new System.Drawing.Size(218, 74);

            // txtManedateAdmin
            txtManedateAdmin.Location = new System.Drawing.Point(313, 43);

            // txtMandatesEmp
            txtMandatesEmp.Location = new System.Drawing.Point(313, 115);

            // txtAboutMandate
            txtAboutMandate.Location = new System.Drawing.Point(313, 189);

            // txtMandareDestination
            txtMandareDestination.Location = new System.Drawing.Point(313, 259);

            // txtCost
            txtMandateTime.Location = new System.Drawing.Point(30, 43);

            // txtStartDate
            txtMandateDate.Location = new System.Drawing.Point(30, 119);

            // txtMandateReward
            txtMandateReward.Location = new System.Drawing.Point(31, 189);

            // txtMandateResult
            txtMandateResult.Location = new System.Drawing.Point(30, 253);

            // txtDetails
            txtDetails.Location = new System.Drawing.Point(29, 317);

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

            txtManedateAdmin.DataSource = db.TB_Employees.Select(x => x.Name).ToList();
        }
    }
}