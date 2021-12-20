
namespace HotelManagement.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.movingPanel = new System.Windows.Forms.Panel();
            this.manageEmpBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.manageAccBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_ManageAcc1 = new HotelManagement.AllUserControl.UC_ManageAcc();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuPanel.Controls.Add(this.movingPanel);
            this.menuPanel.Controls.Add(this.manageEmpBtn);
            this.menuPanel.Controls.Add(this.manageAccBtn);
            this.menuPanel.Location = new System.Drawing.Point(327, 12);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(971, 99);
            this.menuPanel.TabIndex = 0;
            // 
            // movingPanel
            // 
            this.movingPanel.BackColor = System.Drawing.Color.DarkOrange;
            this.movingPanel.Location = new System.Drawing.Point(107, 75);
            this.movingPanel.Name = "movingPanel";
            this.movingPanel.Size = new System.Drawing.Size(180, 5);
            this.movingPanel.TabIndex = 3;
            // 
            // manageEmpBtn
            // 
            this.manageEmpBtn.BorderRadius = 5;
            this.manageEmpBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.manageEmpBtn.CheckedState.FillColor = System.Drawing.Color.Bisque;
            this.manageEmpBtn.CheckedState.FillColor2 = System.Drawing.Color.Moccasin;
            this.manageEmpBtn.CheckedState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageEmpBtn.CheckedState.Parent = this.manageEmpBtn;
            this.manageEmpBtn.CustomImages.Parent = this.manageEmpBtn;
            this.manageEmpBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageEmpBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageEmpBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageEmpBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageEmpBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageEmpBtn.DisabledState.Parent = this.manageEmpBtn;
            this.manageEmpBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.manageEmpBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.manageEmpBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.manageEmpBtn.ForeColor = System.Drawing.Color.Black;
            this.manageEmpBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.manageEmpBtn.HoverState.Parent = this.manageEmpBtn;
            this.manageEmpBtn.Image = ((System.Drawing.Image)(resources.GetObject("manageEmpBtn.Image")));
            this.manageEmpBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.manageEmpBtn.Location = new System.Drawing.Point(566, 27);
            this.manageEmpBtn.Name = "manageEmpBtn";
            this.manageEmpBtn.ShadowDecoration.Parent = this.manageEmpBtn;
            this.manageEmpBtn.Size = new System.Drawing.Size(208, 45);
            this.manageEmpBtn.TabIndex = 1;
            this.manageEmpBtn.Text = "Manage Employee";
            this.manageEmpBtn.Click += new System.EventHandler(this.manageEmpBtn_Click);
            // 
            // manageAccBtn
            // 
            this.manageAccBtn.BorderRadius = 5;
            this.manageAccBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.manageAccBtn.CheckedState.FillColor = System.Drawing.Color.Bisque;
            this.manageAccBtn.CheckedState.FillColor2 = System.Drawing.Color.Moccasin;
            this.manageAccBtn.CheckedState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageAccBtn.CheckedState.Parent = this.manageAccBtn;
            this.manageAccBtn.CustomImages.Parent = this.manageAccBtn;
            this.manageAccBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageAccBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageAccBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageAccBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageAccBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageAccBtn.DisabledState.Parent = this.manageAccBtn;
            this.manageAccBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.manageAccBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.manageAccBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.manageAccBtn.ForeColor = System.Drawing.Color.Black;
            this.manageAccBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.manageAccBtn.HoverState.Parent = this.manageAccBtn;
            this.manageAccBtn.Image = ((System.Drawing.Image)(resources.GetObject("manageAccBtn.Image")));
            this.manageAccBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.manageAccBtn.Location = new System.Drawing.Point(99, 27);
            this.manageAccBtn.Name = "manageAccBtn";
            this.manageAccBtn.ShadowDecoration.Parent = this.manageAccBtn;
            this.manageAccBtn.Size = new System.Drawing.Size(196, 45);
            this.manageAccBtn.TabIndex = 0;
            this.manageAccBtn.Text = "Manage Account";
            this.manageAccBtn.Click += new System.EventHandler(this.manageAccBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.CheckedState.Parent = this.logoutBtn;
            this.logoutBtn.CustomImages.Parent = this.logoutBtn;
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.DisabledState.Parent = this.logoutBtn;
            this.logoutBtn.FillColor = System.Drawing.Color.Empty;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.HoverState.Parent = this.logoutBtn;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.logoutBtn.Location = new System.Drawing.Point(12, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.logoutBtn.ShadowDecoration.Parent = this.logoutBtn;
            this.logoutBtn.Size = new System.Drawing.Size(34, 45);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.UseTransparentBackground = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.uC_ManageAcc1);
            this.panel1.Location = new System.Drawing.Point(13, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1575, 619);
            this.panel1.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // uC_ManageAcc1
            // 
            this.uC_ManageAcc1.Location = new System.Drawing.Point(124, 0);
            this.uC_ManageAcc1.Name = "uC_ManageAcc1";
            this.uC_ManageAcc1.Size = new System.Drawing.Size(1333, 616);
            this.uC_ManageAcc1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1600, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private Guna.UI2.WinForms.Guna2CircleButton logoutBtn;
        private Guna.UI2.WinForms.Guna2GradientButton manageAccBtn;
        private Guna.UI2.WinForms.Guna2GradientButton manageEmpBtn;
        private System.Windows.Forms.Panel movingPanel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AllUserControl.UC_ManageAcc uC_ManageAcc1;
    }
}