namespace HotelManagement.Forms
{
    partial class Dashboard1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard1));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuestRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.btnexit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_CustomerDetail1 = new HotelManagement.AllUserControl.UC_CustomerDetail();
            this.uC_CustomerCheckOut1 = new HotelManagement.AllUserControl.UC_CustomerCheckOut();
            this.uC_CustomerRegistration1 = new HotelManagement.AllUserControl.UC_CustomerRegistration();
            this.uC_AddRoom1 = new HotelManagement.AllUserControl.UC_AddRoom();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.guna2Panel1.Controls.Add(this.btnAddRoom);
            this.guna2Panel1.Controls.Add(this.btnCustomerDetail);
            this.guna2Panel1.Controls.Add(this.btnCheckout);
            this.guna2Panel1.Controls.Add(this.btnGuestRegistration);
            this.guna2Panel1.Location = new System.Drawing.Point(40, 11);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1864, 104);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 26;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.Coral;
            this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAddRoom.CheckedState.Parent = this.btnAddRoom;
            this.btnAddRoom.CustomImages.Parent = this.btnAddRoom;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.DisabledState.Parent = this.btnAddRoom;
            this.btnAddRoom.FillColor = System.Drawing.Color.LightCoral;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.Parent = this.btnAddRoom;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddRoom.Location = new System.Drawing.Point(34, 17);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ShadowDecoration.Parent = this.btnAddRoom;
            this.btnAddRoom.Size = new System.Drawing.Size(214, 68);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.BorderRadius = 26;
            this.btnCustomerDetail.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnCustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetail.CheckedState.FillColor = System.Drawing.Color.Coral;
            this.btnCustomerDetail.CheckedState.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCustomerDetail.CheckedState.Parent = this.btnCustomerDetail;
            this.btnCustomerDetail.CustomImages.Parent = this.btnCustomerDetail;
            this.btnCustomerDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDetail.DisabledState.Parent = this.btnCustomerDetail;
            this.btnCustomerDetail.FillColor = System.Drawing.Color.LightCoral;
            this.btnCustomerDetail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetail.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetail.HoverState.Parent = this.btnCustomerDetail;
            this.btnCustomerDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDetail.Image")));
            this.btnCustomerDetail.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCustomerDetail.Location = new System.Drawing.Point(1504, 17);
            this.btnCustomerDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.ShadowDecoration.Parent = this.btnCustomerDetail;
            this.btnCustomerDetail.Size = new System.Drawing.Size(288, 68);
            this.btnCustomerDetail.TabIndex = 5;
            this.btnCustomerDetail.Text = "Customer Detail";
            this.btnCustomerDetail.Click += new System.EventHandler(this.btnCustomerDetail_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BorderRadius = 26;
            this.btnCheckout.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnCheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckout.CheckedState.FillColor = System.Drawing.Color.Coral;
            this.btnCheckout.CheckedState.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCheckout.CheckedState.Parent = this.btnCheckout;
            this.btnCheckout.CustomImages.Parent = this.btnCheckout;
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.DisabledState.Parent = this.btnCheckout;
            this.btnCheckout.FillColor = System.Drawing.Color.LightCoral;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.HoverState.Parent = this.btnCheckout;
            this.btnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Image")));
            this.btnCheckout.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCheckout.Location = new System.Drawing.Point(1039, 17);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.ShadowDecoration.Parent = this.btnCheckout;
            this.btnCheckout.Size = new System.Drawing.Size(206, 68);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnGuestRegistration
            // 
            this.btnGuestRegistration.BorderRadius = 26;
            this.btnGuestRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGuestRegistration.CheckedState.FillColor = System.Drawing.Color.Coral;
            this.btnGuestRegistration.CheckedState.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnGuestRegistration.CheckedState.Parent = this.btnGuestRegistration;
            this.btnGuestRegistration.CustomImages.Parent = this.btnGuestRegistration;
            this.btnGuestRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuestRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuestRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuestRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuestRegistration.DisabledState.Parent = this.btnGuestRegistration;
            this.btnGuestRegistration.FillColor = System.Drawing.Color.LightCoral;
            this.btnGuestRegistration.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestRegistration.ForeColor = System.Drawing.Color.White;
            this.btnGuestRegistration.HoverState.Parent = this.btnGuestRegistration;
            this.btnGuestRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnGuestRegistration.Image")));
            this.btnGuestRegistration.ImageSize = new System.Drawing.Size(35, 35);
            this.btnGuestRegistration.Location = new System.Drawing.Point(511, 17);
            this.btnGuestRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuestRegistration.Name = "btnGuestRegistration";
            this.btnGuestRegistration.ShadowDecoration.Parent = this.btnGuestRegistration;
            this.btnGuestRegistration.Size = new System.Drawing.Size(282, 68);
            this.btnGuestRegistration.TabIndex = 2;
            this.btnGuestRegistration.Text = "Guest Registration";
            this.btnGuestRegistration.Click += new System.EventHandler(this.btnGuestRegistration_Click);
            // 
            // btnexit
            // 
            this.btnexit.CheckedState.Parent = this.btnexit;
            this.btnexit.CustomImages.Parent = this.btnexit;
            this.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexit.DisabledState.Parent = this.btnexit;
            this.btnexit.FillColor = System.Drawing.Color.Empty;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.HoverState.Parent = this.btnexit;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnexit.Location = new System.Drawing.Point(-2, 11);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnexit.ShadowDecoration.Parent = this.btnexit;
            this.btnexit.Size = new System.Drawing.Size(36, 29);
            this.btnexit.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.guna2Panel2.Controls.Add(this.uC_CustomerDetail1);
            this.guna2Panel2.Controls.Add(this.uC_CustomerCheckOut1);
            this.guna2Panel2.Controls.Add(this.uC_CustomerRegistration1);
            this.guna2Panel2.Controls.Add(this.uC_AddRoom1);
            this.guna2Panel2.Location = new System.Drawing.Point(12, 120);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1906, 921);
            this.guna2Panel2.TabIndex = 3;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.guna2Panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.guna2Panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.guna2Panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.guna2Panel2;
            // 
            // uC_CustomerDetail1
            // 
            this.uC_CustomerDetail1.BackColor = System.Drawing.Color.Cornsilk;
            this.uC_CustomerDetail1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.uC_CustomerDetail1.Location = new System.Drawing.Point(4, 4);
            this.uC_CustomerDetail1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_CustomerDetail1.Name = "uC_CustomerDetail1";
            this.uC_CustomerDetail1.Size = new System.Drawing.Size(1906, 913);
            this.uC_CustomerDetail1.TabIndex = 3;
            // 
            // uC_CustomerCheckOut1
            // 
            this.uC_CustomerCheckOut1.BackColor = System.Drawing.Color.Cornsilk;
            this.uC_CustomerCheckOut1.Location = new System.Drawing.Point(1, 4);
            this.uC_CustomerCheckOut1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_CustomerCheckOut1.Name = "uC_CustomerCheckOut1";
            this.uC_CustomerCheckOut1.Size = new System.Drawing.Size(1906, 921);
            this.uC_CustomerCheckOut1.TabIndex = 2;
            // 
            // uC_CustomerRegistration1
            // 
            this.uC_CustomerRegistration1.BackColor = System.Drawing.Color.Cornsilk;
            this.uC_CustomerRegistration1.Location = new System.Drawing.Point(1, 4);
            this.uC_CustomerRegistration1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_CustomerRegistration1.Name = "uC_CustomerRegistration1";
            this.uC_CustomerRegistration1.Size = new System.Drawing.Size(1925, 921);
            this.uC_CustomerRegistration1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.Cornsilk;
            this.uC_AddRoom1.Location = new System.Drawing.Point(4, 4);
            this.uC_AddRoom1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1906, 921);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // Dashboard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Dashboard1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetail;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2Button btnGuestRegistration;
        private Guna.UI2.WinForms.Guna2CircleButton btnexit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControl.UC_CustomerDetail uC_CustomerDetail1;
        private AllUserControl.UC_CustomerCheckOut uC_CustomerCheckOut1;
        private AllUserControl.UC_CustomerRegistration uC_CustomerRegistration1;
        private AllUserControl.UC_AddRoom uC_AddRoom1;
    }
}