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
    public partial class MandatesPage : DevExpress.XtraEditors.XtraUserControl
    {
        // DataBase And Tables
        DBEMSEntities db;
        TB_Mandate tbAdd;

        // Other Var
        int id;

        public MandatesPage()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            EMS.DBEMSEntities dbContext = new EMS.DBEMSEntities();
            dbContext.TB_Mandate.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TB_Mandate.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        #region Events
        // button Add
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddMandatePage addPage = new AddMandatePage();
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
                    AddMandatePage addPage = new AddMandatePage();
                    db = new DBEMSEntities();
                    tbAdd = db.TB_Mandate.Where(x => x.Id == id).FirstOrDefault();

                    addPage.id = id;
                    addPage.buttonAdd.Text = "تعديل";
                    addPage.buttonAddAndClose.Text = "تعديل + غلق";
                    addPage.txtManedateAdmin.Text = tbAdd.ManedateAdmin;
                    addPage.txtMandatesEmp.Text = tbAdd.MandatesEmp;
                    addPage.txtAboutMandate.Text = tbAdd.AboutMandate;
                    addPage.txtMandareDestination.Text = tbAdd.MandareDestination;
                    addPage.txtMandateTime.Text = tbAdd.MandateTime;
                    addPage.txtMandateDate.Value = tbAdd.MandateDate.Value;
                    addPage.txtMandateReward.Text = tbAdd.MandateReward;
                    addPage.txtMandateResult.Text = tbAdd.MandateResult;
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
            if (rs == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                    if (id > 0)
                    {
                        AddMandatePage addPage = new AddMandatePage();
                        db = new DBEMSEntities();
                        tbAdd = db.TB_Mandate.Where(x => x.Id == id).FirstOrDefault();
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