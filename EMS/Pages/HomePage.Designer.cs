
namespace EMS.Pages
{
    partial class HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtDateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.buttonUsers = new DevExpress.XtraEditors.SimpleButton();
            this.buttonTasks = new DevExpress.XtraEditors.SimpleButton();
            this.buttonVacations = new DevExpress.XtraEditors.SimpleButton();
            this.buttonProjects = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSalary = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDateTime
            // 
            this.txtDateTime.AutoSize = true;
            this.txtDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTime.Location = new System.Drawing.Point(4, 0);
            this.txtDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(0, 37);
            this.txtDateTime.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(528, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "ادارة شؤن الموظفين";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1269, 137);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.buttonEmployee);
            this.groupBox1.Controls.Add(this.buttonUsers);
            this.groupBox1.Controls.Add(this.buttonTasks);
            this.groupBox1.Controls.Add(this.buttonVacations);
            this.groupBox1.Controls.Add(this.buttonProjects);
            this.groupBox1.Controls.Add(this.buttonSalary);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F);
            this.groupBox1.Location = new System.Drawing.Point(23, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1228, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الوصول السريع";
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.25F);
            this.buttonEmployee.Appearance.Options.UseFont = true;
            this.buttonEmployee.ImageOptions.Image = global::EMS.Properties.Resources.AddEmployee;
            this.buttonEmployee.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.buttonEmployee.Location = new System.Drawing.Point(946, 32);
            this.buttonEmployee.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(122, 70);
            this.buttonEmployee.TabIndex = 0;
            this.buttonEmployee.Text = "الموظفين";
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.25F);
            this.buttonUsers.Appearance.Options.UseFont = true;
            this.buttonUsers.ImageOptions.Image = global::EMS.Properties.Resources.Users;
            this.buttonUsers.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.buttonUsers.Location = new System.Drawing.Point(160, 32);
            this.buttonUsers.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(122, 70);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.Text = "المستحدمين";
            // 
            // buttonTasks
            // 
            this.buttonTasks.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.25F);
            this.buttonTasks.Appearance.Options.UseFont = true;
            this.buttonTasks.ImageOptions.Image = global::EMS.Properties.Resources.Tasks;
            this.buttonTasks.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.buttonTasks.Location = new System.Drawing.Point(318, 32);
            this.buttonTasks.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.buttonTasks.Name = "buttonTasks";
            this.buttonTasks.Size = new System.Drawing.Size(122, 70);
            this.buttonTasks.TabIndex = 0;
            this.buttonTasks.Text = "المهام";
            // 
            // buttonVacations
            // 
            this.buttonVacations.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.25F);
            this.buttonVacations.Appearance.Options.UseFont = true;
            this.buttonVacations.ImageOptions.Image = global::EMS.Properties.Resources.Vacations;
            this.buttonVacations.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.buttonVacations.Location = new System.Drawing.Point(790, 32);
            this.buttonVacations.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.buttonVacations.Name = "buttonVacations";
            this.buttonVacations.Size = new System.Drawing.Size(122, 70);
            this.buttonVacations.TabIndex = 0;
            this.buttonVacations.Text = "الإجازات";
            this.buttonVacations.Click += new System.EventHandler(this.buttonVacations_Click);
            // 
            // buttonProjects
            // 
            this.buttonProjects.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.25F);
            this.buttonProjects.Appearance.Options.UseFont = true;
            this.buttonProjects.ImageOptions.Image = global::EMS.Properties.Resources.Tasks;
            this.buttonProjects.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.buttonProjects.Location = new System.Drawing.Point(476, 32);
            this.buttonProjects.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.buttonProjects.Name = "buttonProjects";
            this.buttonProjects.Size = new System.Drawing.Size(122, 70);
            this.buttonProjects.TabIndex = 0;
            this.buttonProjects.Text = "المشاريع";
            // 
            // buttonSalary
            // 
            this.buttonSalary.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.25F);
            this.buttonSalary.Appearance.Options.UseFont = true;
            this.buttonSalary.ImageOptions.Image = global::EMS.Properties.Resources.AddEmployee;
            this.buttonSalary.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.buttonSalary.Location = new System.Drawing.Point(632, 32);
            this.buttonSalary.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.buttonSalary.Name = "buttonSalary";
            this.buttonSalary.Size = new System.Drawing.Size(122, 70);
            this.buttonSalary.TabIndex = 0;
            this.buttonSalary.Text = "الرواتب";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::EMS.Properties.Resources.IconImage;
            this.pictureBox1.Location = new System.Drawing.Point(521, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1269, 632);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton buttonVacations;
        private DevExpress.XtraEditors.SimpleButton buttonEmployee;
        private DevExpress.XtraEditors.SimpleButton buttonSalary;
        public System.Windows.Forms.Label txtDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton buttonTasks;
        private DevExpress.XtraEditors.SimpleButton buttonProjects;
        private DevExpress.XtraEditors.SimpleButton buttonUsers;
    }
}
