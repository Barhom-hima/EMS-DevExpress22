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
    public partial class VacationsPage : DevExpress.XtraEditors.XtraUserControl
    {
        // DataBase And Tables
        DBEMSEntities db;
        TB_Vacations tbAdd;

        // Other Var
        int id;

        public VacationsPage()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            EMS.DBEMSEntities dbContext = new EMS.DBEMSEntities();
            dbContext.TB_Vacations.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TB_Vacations.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        #region Events
        // button Add
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddVacationPage addPage = new AddVacationPage();
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
                if (id > 0)
                {
                    AddVacationPage addPage = new AddVacationPage();
                    db = new DBEMSEntities();
                    tbAdd = db.TB_Vacations.Where(x => x.Id == id).FirstOrDefault();

                    addPage.id = id;
                    addPage.buttonAdd.Text = "تعديل";
                    addPage.buttonAddAndClose.Text = "تعديل + غلق";
                    addPage.txtEmpName.Text = tbAdd.EmpName;
                    addPage.txtAboutVacation.Text = tbAdd.AboutVacation;
                    addPage.txtVacationAmount.Text = tbAdd.VacationAmount;
                    addPage.txtVacationStartDate.Value = tbAdd.VacationStartDate.Value;
                    addPage.txtVacationEndDate.Value = tbAdd.VacationEndDate.Value;

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
            if (rs == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                    if (id > 0)
                    {
                        AddVacationPage addPage = new AddVacationPage();
                        db = new DBEMSEntities();
                        tbAdd = db.TB_Vacations.Where(x => x.Id == id).FirstOrDefault();
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