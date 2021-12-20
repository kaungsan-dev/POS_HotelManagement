
namespace HotelManagement.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.errLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.signUpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.showPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.passLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.roleLogin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.userNameLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errLbl);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.signUpBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.showPass);
            this.panel1.Controls.Add(this.passLogin);
            this.panel1.Controls.Add(this.roleLogin);
            this.panel1.Controls.Add(this.userNameLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Location = new System.Drawing.Point(45, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 400);
            this.panel1.TabIndex = 0;
            // 
            // errLbl
            // 
            this.errLbl.AutoSize = true;
            this.errLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLbl.ForeColor = System.Drawing.Color.Red;
            this.errLbl.Location = new System.Drawing.Point(380, 348);
            this.errLbl.Name = "errLbl";
            this.errLbl.Size = new System.Drawing.Size(238, 21);
            this.errLbl.TabIndex = 16;
            this.errLbl.Text = "Wrong Username or Password";
            this.errLbl.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.CheckedState.Parent = this.cancelBtn;
            this.cancelBtn.CustomImages.Parent = this.cancelBtn;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.DisabledState.Parent = this.cancelBtn;
            this.cancelBtn.FillColor = System.Drawing.Color.Empty;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.HoverState.Parent = this.cancelBtn;
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.cancelBtn.Location = new System.Drawing.Point(1, 1);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cancelBtn.ShadowDecoration.Parent = this.cancelBtn;
            this.cancelBtn.Size = new System.Drawing.Size(63, 61);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.UseTransparentBackground = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BorderRadius = 5;
            this.clearBtn.CheckedState.Parent = this.clearBtn;
            this.clearBtn.CustomImages.Parent = this.clearBtn;
            this.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearBtn.DisabledState.Parent = this.clearBtn;
            this.clearBtn.FillColor = System.Drawing.Color.PeachPuff;
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.HoverState.Parent = this.clearBtn;
            this.clearBtn.Location = new System.Drawing.Point(269, 16);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.ShadowDecoration.Parent = this.clearBtn;
            this.clearBtn.Size = new System.Drawing.Size(112, 35);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.Visible = false;
            // 
            // signUpBtn
            // 
            this.signUpBtn.BorderRadius = 5;
            this.signUpBtn.CheckedState.Parent = this.signUpBtn;
            this.signUpBtn.CustomImages.Parent = this.signUpBtn;
            this.signUpBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signUpBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signUpBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signUpBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signUpBtn.DisabledState.Parent = this.signUpBtn;
            this.signUpBtn.FillColor = System.Drawing.Color.PeachPuff;
            this.signUpBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.signUpBtn.ForeColor = System.Drawing.Color.Black;
            this.signUpBtn.HoverState.Parent = this.signUpBtn;
            this.signUpBtn.Location = new System.Drawing.Point(105, 293);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.ShadowDecoration.Parent = this.signUpBtn;
            this.signUpBtn.Size = new System.Drawing.Size(112, 35);
            this.signUpBtn.TabIndex = 8;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "If you haven\'t account";
            // 
            // loginBtn
            // 
            this.loginBtn.BorderRadius = 5;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.DisabledState.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.PeachPuff;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(371, 296);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(256, 45);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showPass.CheckedState.BorderRadius = 0;
            this.showPass.CheckedState.BorderThickness = 0;
            this.showPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.Location = new System.Drawing.Point(480, 265);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(147, 25);
            this.showPass.TabIndex = 6;
            this.showPass.Text = "Show Password";
            this.showPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPass.UncheckedState.BorderRadius = 0;
            this.showPass.UncheckedState.BorderThickness = 0;
            this.showPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // passLogin
            // 
            this.passLogin.BorderColor = System.Drawing.Color.White;
            this.passLogin.BorderRadius = 5;
            this.passLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passLogin.DefaultText = "";
            this.passLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passLogin.DisabledState.Parent = this.passLogin;
            this.passLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passLogin.FocusedState.Parent = this.passLogin;
            this.passLogin.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.passLogin.ForeColor = System.Drawing.Color.Black;
            this.passLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passLogin.HoverState.Parent = this.passLogin;
            this.passLogin.IconLeft = ((System.Drawing.Image)(resources.GetObject("passLogin.IconLeft")));
            this.passLogin.IconLeftSize = new System.Drawing.Size(30, 30);
            this.passLogin.Location = new System.Drawing.Point(371, 161);
            this.passLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passLogin.Name = "passLogin";
            this.passLogin.PasswordChar = '•';
            this.passLogin.PlaceholderText = "Password";
            this.passLogin.SelectedText = "";
            this.passLogin.ShadowDecoration.Parent = this.passLogin;
            this.passLogin.Size = new System.Drawing.Size(256, 55);
            this.passLogin.TabIndex = 4;
            this.passLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roleLogin
            // 
            this.roleLogin.BackColor = System.Drawing.Color.Transparent;
            this.roleLogin.BorderRadius = 5;
            this.roleLogin.BorderThickness = 0;
            this.roleLogin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleLogin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleLogin.FocusedState.Parent = this.roleLogin;
            this.roleLogin.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.roleLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roleLogin.HoverState.Parent = this.roleLogin;
            this.roleLogin.ItemHeight = 30;
            this.roleLogin.Items.AddRange(new object[] {
            "Reception",
            "Manager"});
            this.roleLogin.ItemsAppearance.Parent = this.roleLogin;
            this.roleLogin.Location = new System.Drawing.Point(371, 223);
            this.roleLogin.Name = "roleLogin";
            this.roleLogin.ShadowDecoration.Parent = this.roleLogin;
            this.roleLogin.Size = new System.Drawing.Size(256, 36);
            this.roleLogin.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.roleLogin.TabIndex = 5;
            this.roleLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userNameLogin
            // 
            this.userNameLogin.BorderColor = System.Drawing.Color.White;
            this.userNameLogin.BorderRadius = 5;
            this.userNameLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameLogin.DefaultText = "";
            this.userNameLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameLogin.DisabledState.Parent = this.userNameLogin;
            this.userNameLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameLogin.FocusedState.Parent = this.userNameLogin;
            this.userNameLogin.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.userNameLogin.ForeColor = System.Drawing.Color.Black;
            this.userNameLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameLogin.HoverState.Parent = this.userNameLogin;
            this.userNameLogin.IconLeft = ((System.Drawing.Image)(resources.GetObject("userNameLogin.IconLeft")));
            this.userNameLogin.IconLeftSize = new System.Drawing.Size(30, 30);
            this.userNameLogin.Location = new System.Drawing.Point(371, 98);
            this.userNameLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameLogin.Name = "userNameLogin";
            this.userNameLogin.PasswordChar = '\0';
            this.userNameLogin.PlaceholderText = "Username";
            this.userNameLogin.SelectedText = "";
            this.userNameLogin.ShadowDecoration.Parent = this.userNameLogin;
            this.userNameLogin.Size = new System.Drawing.Size(256, 55);
            this.userNameLogin.TabIndex = 3;
            this.userNameLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(59, 57);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(213, 209);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox userNameLogin;
        private Guna.UI2.WinForms.Guna2ComboBox roleLogin;
        private Guna.UI2.WinForms.Guna2TextBox passLogin;
        private Guna.UI2.WinForms.Guna2CheckBox showPass;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2Button signUpBtn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2CircleButton cancelBtn;
        private System.Windows.Forms.Label errLbl;
    }
}