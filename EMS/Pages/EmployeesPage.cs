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
using System.Data.Entity;
using EMS.AddPages;

namespace EMS.Pages
{
    public partial class EmployeesPage : DevExpress.XtraEditors.XtraUserControl
    {
        // DataBase And Tables
        DBEMSEntities db;
        TB_Employees tbAdd;

        // Other Var
        int id;

        public EmployeesPage()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            EMS.DBEMSEntities dbContext = new EMS.DBEMSEntities();
            dbContext.TB_Employees.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TB_Employees.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        #region Events
        // button Add
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEmployeePage addPage = new AddEmployeePage();
            addPage.id = 0;
            addPage.buttonAdd.Text = "اضافة";
            addPage.buttonAddAndClose.Text = "اضافة + غلق";
            addPage.page = this;
            addPage.Show();
        }

        // button Edit
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                if(id > 0)
                {
                    AddEmployeePage addPage = new AddEmployeePage();
                    db = new DBEMSEntities();
                    tbAdd = db.TB_Employees.Where(x => x.Id == id).FirstOrDefault();

                    addPage.id = id;
                    addPage.buttonAdd.Text = "تعديل";
                    addPage.buttonAddAndClose.Text = "تعديل + غلق";
                    addPage.txtName.Text = tbAdd.Name;
                    addPage.txtDob.Value = tbAdd.Dob.Value;
                    addPage.txtGender.Text = tbAdd.Gender;
                    addPage.txtPhone.Text = tbAdd.Phone;
                    addPage.txtIdNum.Text = tbAdd.IdNum;
                    addPage.txtDateEndId.Value = tbAdd.DateEndId.Value;
                    addPage.txtPassportNum.Text = tbAdd.PassportNum;
                    addPage.txtDateEndPassport.Value = tbAdd.DateEndPassport.Value;
                    addPage.txtEmail.Text = tbAdd.Email;
                    addPage.txtJobName.Text = tbAdd.JobName;
                    addPage.txtJobId.Text = tbAdd.JobId;
                    addPage.txtRank.Text = tbAdd.Rank;
                    addPage.txtDoj.Value = tbAdd.Doj.Value;
                    addPage.txtContractStatus.Text = tbAdd.ContractStatus;
                    addPage.txtWorkTime.Text = tbAdd.WorkTime;
                    addPage.txtWorkTimeInWeak.Text = tbAdd.WorkTimeInWeak;
                    addPage.txtSalary.Text = tbAdd.Salary;
                    addPage.txtVacationTime.Text = tbAdd.VacationTime;
                    addPage.txtDetails.Text = tbAdd.Details;
                    addPage.page = this;
                    addPage.Show();
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها", "خطأ", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // button Delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء, لن تتمكن من استعادة البيانات", "اجراء حذف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(rs == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                    if (id > 0)
                    {
                        AddEmployeePage addPage = new AddEmployeePage();
                        db = new DBEMSEntities();
                        tbAdd = db.TB_Employees.Where(x => x.Id == id).FirstOrDefault();
                        db.Entry(tbAdd).State = EntityState.Deleted;
                        db.SaveChanges();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("لا يوجد بيانات لحذفها", "خطأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // button Refresh
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // button Print
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
        #endregion
    }
}