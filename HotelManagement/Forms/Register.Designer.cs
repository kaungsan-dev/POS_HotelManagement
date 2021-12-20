
namespace HotelManagement
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.signInBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.roleCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.registerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.showPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.conPassTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.signInBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.roleCombo);
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.showPass);
            this.panel1.Controls.Add(this.conPassTxtBox);
            this.panel1.Controls.Add(this.passTxtBox);
            this.panel1.Controls.Add(this.usernameTxtBox);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(57, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 466);
            this.panel1.TabIndex = 0;
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
            this.cancelBtn.Size = new System.Drawing.Size(45, 48);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.UseTransparentBackground = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.BorderRadius = 5;
            this.signInBtn.CheckedState.Parent = this.signInBtn;
            this.signInBtn.CustomImages.Parent = this.signInBtn;
            this.signInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signInBtn.DisabledState.Parent = this.signInBtn;
            this.signInBtn.FillColor = System.Drawing.Color.PeachPuff;
            this.signInBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.signInBtn.ForeColor = System.Drawing.Color.Black;
            this.signInBtn.HoverState.Parent = this.signInBtn;
            this.signInBtn.Location = new System.Drawing.Point(81, 345);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.ShadowDecoration.Parent = this.signInBtn;
            this.signInBtn.Size = new System.Drawing.Size(149, 45);
            this.signInBtn.TabIndex = 8;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Already have account";
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
            this.clearBtn.FillColor = System.Drawing.Color.Gainsboro;
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.HoverState.Parent = this.clearBtn;
            this.clearBtn.Location = new System.Drawing.Point(340, 396);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.ShadowDecoration.Parent = this.clearBtn;
            this.clearBtn.Size = new System.Drawing.Size(256, 45);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // roleCombo
            // 
            this.roleCombo.BackColor = System.Drawing.Color.Transparent;
            this.roleCombo.BorderRadius = 5;
            this.roleCombo.BorderThickness = 0;
            this.roleCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleCombo.FocusedState.Parent = this.roleCombo;
            this.roleCombo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.roleCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roleCombo.HoverState.Parent = this.roleCombo;
            this.roleCombo.ItemHeight = 30;
            this.roleCombo.Items.AddRange(new object[] {
            "Reception",
            "Manager"});
            this.roleCombo.ItemsAppearance.Parent = this.roleCombo;
            this.roleCombo.Location = new System.Drawing.Point(340, 146);
            this.roleCombo.Name = "roleCombo";
            this.roleCombo.ShadowDecoration.Parent = this.roleCombo;
            this.roleCombo.Size = new System.Drawing.Size(256, 36);
            this.roleCombo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.roleCombo.TabIndex = 2;
            this.roleCombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registerBtn
            // 
            this.registerBtn.BorderRadius = 5;
            this.registerBtn.CheckedState.Parent = this.registerBtn;
            this.registerBtn.CustomImages.Parent = this.registerBtn;
            this.registerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerBtn.DisabledState.Parent = this.registerBtn;
            this.registerBtn.FillColor = System.Drawing.Color.PeachPuff;
            this.registerBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.registerBtn.ForeColor = System.Drawing.Color.Black;
            this.registerBtn.HoverState.Parent = this.registerBtn;
            this.registerBtn.Location = new System.Drawing.Point(340, 345);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.ShadowDecoration.Parent = this.registerBtn;
            this.registerBtn.Size = new System.Drawing.Size(256, 45);
            this.registerBtn.TabIndex = 6;
            this.registerBtn.Text = "Register";
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showPass.CheckedState.BorderRadius = 0;
            this.showPass.CheckedState.BorderThickness = 0;
            this.showPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.Location = new System.Drawing.Point(449, 314);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(147, 25);
            this.showPass.TabIndex = 5;
            this.showPass.Text = "Show Password";
            this.showPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPass.UncheckedState.BorderRadius = 0;
            this.showPass.UncheckedState.BorderThickness = 0;
            this.showPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // conPassTxtBox
            // 
            this.conPassTxtBox.BorderColor = System.Drawing.Color.White;
            this.conPassTxtBox.BorderRadius = 5;
            this.conPassTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.conPassTxtBox.DefaultText = "";
            this.conPassTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.conPassTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.conPassTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.conPassTxtBox.DisabledState.Parent = this.conPassTxtBox;
            this.conPassTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.conPassTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.conPassTxtBox.FocusedState.Parent = this.conPassTxtBox;
            this.conPassTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.conPassTxtBox.ForeColor = System.Drawing.Color.Black;
            this.conPassTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.conPassTxtBox.HoverState.Parent = this.conPassTxtBox;
            this.conPassTxtBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("conPassTxtBox.IconLeft")));
            this.conPassTxtBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.conPassTxtBox.Location = new System.Drawing.Point(340, 252);
            this.conPassTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conPassTxtBox.Name = "conPassTxtBox";
            this.conPassTxtBox.PasswordChar = '•';
            this.conPassTxtBox.PlaceholderText = "Confirm Password";
            this.conPassTxtBox.SelectedText = "";
            this.conPassTxtBox.ShadowDecoration.Parent = this.conPassTxtBox;
            this.conPassTxtBox.Size = new System.Drawing.Size(256, 55);
            this.conPassTxtBox.TabIndex = 4;
            this.conPassTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passTxtBox
            // 
            this.passTxtBox.BorderColor = System.Drawing.Color.White;
            this.passTxtBox.BorderRadius = 5;
            this.passTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTxtBox.DefaultText = "";
            this.passTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTxtBox.DisabledState.Parent = this.passTxtBox;
            this.passTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTxtBox.FocusedState.Parent = this.passTxtBox;
            this.passTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.passTxtBox.ForeColor = System.Drawing.Color.Black;
            this.passTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTxtBox.HoverState.Parent = this.passTxtBox;
            this.passTxtBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("passTxtBox.IconLeft")));
            this.passTxtBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.passTxtBox.Location = new System.Drawing.Point(340, 189);
            this.passTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.PasswordChar = '•';
            this.passTxtBox.PlaceholderText = "Password";
            this.passTxtBox.SelectedText = "";
            this.passTxtBox.ShadowDecoration.Parent = this.passTxtBox;
            this.passTxtBox.Size = new System.Drawing.Size(256, 55);
            this.passTxtBox.TabIndex = 3;
            this.passTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.BorderColor = System.Drawing.Color.White;
            this.usernameTxtBox.BorderRadius = 5;
            this.usernameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxtBox.DefaultText = "";
            this.usernameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxtBox.DisabledState.Parent = this.usernameTxtBox;
            this.usernameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTxtBox.FocusedState.Parent = this.usernameTxtBox;
            this.usernameTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.usernameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.usernameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTxtBox.HoverState.Parent = this.usernameTxtBox;
            this.usernameTxtBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("usernameTxtBox.IconLeft")));
            this.usernameTxtBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.usernameTxtBox.Location = new System.Drawing.Point(340, 83);
            this.usernameTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.PasswordChar = '\0';
            this.usernameTxtBox.PlaceholderText = "Username";
            this.usernameTxtBox.SelectedText = "";
            this.usernameTxtBox.ShadowDecoration.Parent = this.usernameTxtBox;
            this.usernameTxtBox.Size = new System.Drawing.Size(256, 55);
            this.usernameTxtBox.TabIndex = 1;
            this.usernameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(39, 83);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(233, 224);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Register";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 540);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox passTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox conPassTxtBox;
        private Guna.UI2.WinForms.Guna2CheckBox showPass;
        private Guna.UI2.WinForms.Guna2Button registerBtn;
        private Guna.UI2.WinForms.Guna2ComboBox roleCombo;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button signInBtn;
        private Guna.UI2.WinForms.Guna2CircleButton cancelBtn;
    }
}

