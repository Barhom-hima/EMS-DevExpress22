﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EMS.Pages;
using EMS.AddPages;

namespace EMS
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Main()
        {
            InitializeComponent();
            LoadHomePage();
        }

        #region Methods
        // Load Home Page
        private void buttonHome_Click(object sender, EventArgs e)
        {
            LoadHomePage();
        }

        // Load Employees Page
        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            EmployeesPage page = new EmployeesPage();
            LoadPage(page);
        }

        // Load Salaries Page
        private void buttonSalary_Click(object sender, EventArgs e)
        {
            SalariesPage page = new SalariesPage();
            LoadPage(page);
        }

        // Load Vacations Page
        private void buttonVacations_Click(object sender, EventArgs e)
        {
            VacationsPage page = new VacationsPage();
            LoadPage(page);
        }

        // Load Mandate Page
        private void buttonMandate_Click(object sender, EventArgs e)
        {
            MandatesPage page = new MandatesPage();
            LoadPage(page);
        }

        // Load Project Page
        private void buttonProjects_Click(object sender, EventArgs e)
        {
            ProjectsPage page = new ProjectsPage();
            LoadPage(page);
        }

        // Load Task Page
        private void buttonTasks_Click(object sender, EventArgs e)
        {
            TasksPage page = new TasksPage();
            LoadPage(page);
        }

        // Load Users Page
        private void buttonUsers_Click(object sender, EventArgs e)
        {
            UsersPage page = new UsersPage();
            LoadPage(page);
        }

        // About Page
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutPage page = new AboutPage();
            page.Show();
        }

        // Load Home Page
        private void LoadHomePage()
        {
            HomePage page = new HomePage();
            LoadPage(page);
        }

        // Load Page
        private void LoadPage(DevExpress.XtraEditors.XtraUserControl Page)
        {
            try
            {
                panelContainer.Controls.Clear();
                Page.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(Page);
            }
            catch
            {

            }
        }

        // Logout Button
        private void buttonLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            Hide();
        }
        #endregion

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}