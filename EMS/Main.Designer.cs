﻿
namespace EMS
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.buttonHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.buttonEmployees = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.buttonSalaries = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.buttonVacations = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.buttonMandate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.buttonProjects = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.buttonTasks = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.buttonUsers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.buttonAbout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.buttonLogout = new DevExpress.XtraBars.BarButtonItem();
            this.txtUsername = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Appearance.BackColor = System.Drawing.Color.White;
            this.panelContainer.Appearance.Options.UseBackColor = true;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.panelContainer.Location = new System.Drawing.Point(0, 36);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1019, 690);
            this.panelContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.buttonHome,
            this.buttonEmployees,
            this.buttonSalaries,
            this.buttonVacations,
            this.buttonMandate,
            this.buttonProjects,
            this.buttonTasks,
            this.buttonUsers,
            this.buttonAbout});
            this.accordionControl1.Location = new System.Drawing.Point(1019, 36);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(250, 690);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // buttonHome
            // 
            this.buttonHome.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonHome.Appearance.Default.Options.UseFont = true;
            this.buttonHome.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.buttonHome.ImageOptions.Image = global::EMS.Properties.Resources.Home;
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.buttonHome.Text = "الرئيسة";
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonEmployees.Appearance.Default.Options.UseFont = true;
            this.buttonEmployees.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.buttonEmployees.ImageOptions.Image = global::EMS.Properties.Resources.AddEmployee;
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.buttonEmployees.Text = "الموظفين";
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // buttonSalaries
            // 
            this.buttonSalaries.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonSalaries.Appearance.Default.Options.UseFont = true;
            this.buttonSalaries.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.buttonSalaries.ImageOptions.Image = global::EMS.Properties.Resources.Salary;
            this.buttonSalaries.Name = "buttonSalaries";
            this.buttonSalaries.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.buttonSalaries.Text = "الرواتب";
            this.buttonSalaries.Click += new System.EventHandler(this.buttonSalary_Click);
            // 
            // buttonVacations
            // 
            this.buttonVacations.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonVacations.Appearance.Default.Options.UseFont = true;
            this.buttonVacations.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.buttonVacations.ImageOptions.Image = global::EMS.Properties.Resources.Vacations;
            this.buttonVacations.Name = "buttonVacations";
            this.buttonVacations.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.buttonVacations.Text = "الإجازات";
            this.buttonVacations.Click += new System.EventHandler(this.buttonVacations_Click);
            // 
            // buttonMandate
            // 
            this.buttonMandate.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonMandate.Appearance.Default.Options.UseFont = true;
            this.buttonMandate.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.buttonMandate.ImageOptions.Image = global::EMS.Properties.Resources.Mandates;
            this.buttonMandate.Name = "buttonMandate";
            this.buttonMandate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.buttonMandate.Text = "الإنتداب";
            this.buttonMandate.Click += new System.EventHandler(this.buttonMandate_Click);
            // 
            // buttonProjects
            // 
            this.buttonProjects.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonProjects.Appearance.Default.Options.UseFont = true;
            this.buttonProjects.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.buttonProjects.ImageOptions.Image = global::EMS.Properties.Resources.Projects;
            this.buttonProjects.Name = "buttonProjects";
            this.buttonProjects.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.buttonProjects.Text = "المشاريع";
            this.buttonProjects.Click += new System.EventHandler(this.buttonProjects_Click);
            // 
            // buttonTasks
            // 
            this.buttonTasks.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonTasks.Appearance.Default.Options.UseFont = true;
            this.buttonTasks.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.buttonTasks.ImageOptions.Image = global::EMS.Properties.Resources.Tasks;
            this.buttonTasks.Name = "buttonTasks";
            this.buttonTasks.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.buttonTasks.Text = "المهام";
            this.buttonTasks.Click += new System.EventHandler(this.buttonTasks_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonUsers.Appearance.Default.Options.UseFont = true;
            this.buttonUsers.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.buttonUsers.ImageOptions.Image = global::EMS.Properties.Resources.Users;
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.buttonUsers.Text = "المستخدمين";
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonAbout.Appearance.Default.Options.UseFont = true;
            this.buttonAbout.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.buttonAbout.ImageOptions.Image = global::EMS.Properties.Resources.About;
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.buttonAbout.Text = "حول";
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.buttonLogout,
            this.txtUsername,
            this.barStaticItem2});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1269, 36);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.buttonLogout);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.txtUsername);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Caption = "تسجيل الخروج";
            this.buttonLogout.Id = 0;
            this.buttonLogout.ItemAppearance.Disabled.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ItemAppearance.Disabled.Options.UseFont = true;
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonLogout_ItemClick);
            // 
            // txtUsername
            // 
            this.txtUsername.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtUsername.Id = 1;
            this.txtUsername.Name = "txtUsername";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem2.Caption = "مستخدم";
            this.barStaticItem2.Id = 2;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.buttonLogout,
            this.txtUsername,
            this.barStaticItem2});
            this.fluentFormDefaultManager1.MaxItemId = 3;
            // 
            // Main
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 726);
            this.ControlContainer = this.panelContainer;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Main.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Main";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer panelContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement buttonHome;
        private DevExpress.XtraBars.Navigation.AccordionControlElement buttonEmployees;
        private DevExpress.XtraBars.Navigation.AccordionControlElement buttonVacations;
        private DevExpress.XtraBars.Navigation.AccordionControlElement buttonProjects;
        private DevExpress.XtraBars.Navigation.AccordionControlElement buttonTasks;
        private DevExpress.XtraBars.BarButtonItem buttonLogout;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement buttonSalaries;
        private DevExpress.XtraBars.Navigation.AccordionControlElement buttonUsers;
        public DevExpress.XtraBars.BarStaticItem txtUsername;
        private DevExpress.XtraBars.Navigation.AccordionControlElement buttonMandate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement buttonAbout;
    }
}

