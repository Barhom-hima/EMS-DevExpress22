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
using EMS.AddPages;

namespace EMS.Pages
{
    public partial class HomePage : DevExpress.XtraEditors.XtraUserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDateTime.Text = DateTime.Now.ToString();
        }

        // Add Employee Page
        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeePage addPage = new AddEmployeePage();
            addPage.id = 0;
            addPage.buttonAdd.Text = "اضافة";
            addPage.buttonAddAndClose.Text = "اضافة + غلق";
            addPage.Show();
        }

        private void buttonVacations_Click(object sender, EventArgs e)
        {
            AddVacationPage addPage = new AddVacationPage();
            addPage.id = 0;
            addPage.buttonAdd.Text = "اضافة";
            addPage.buttonAddAndClose.Text = "اضافة + غلق";
            addPage.Show();
        }
    }
}
