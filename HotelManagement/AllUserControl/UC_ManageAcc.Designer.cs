
namespace HotelManagement.AllUserControl
{
    partial class UC_ManageAcc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.userList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.roleCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userAllList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAllList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage User";
            // 
            // userList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.userList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userList.BackgroundColor = System.Drawing.Color.White;
            this.userList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userList.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userList.DefaultCellStyle = dataGridViewCellStyle3;
            this.userList.EnableHeadersVisualStyles = false;
            this.userList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userList.Location = new System.Drawing.Point(20, 92);
            this.userList.Name = "userList";
            this.userList.RowHeadersVisible = false;
            this.userList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userList.Size = new System.Drawing.Size(717, 458);
            this.userList.TabIndex = 1;
            this.userList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.userList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.userList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.userList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.userList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.userList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.userList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.userList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userList.ThemeStyle.HeaderStyle.Height = 4;
            this.userList.ThemeStyle.ReadOnly = false;
            this.userList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.userList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.userList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userList.ThemeStyle.RowsStyle.Height = 22;
            this.userList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(855, 100);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(66, 22);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(856, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(856, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(856, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID";
            this.label4.Visible = false;
            // 
            // idTxtBox
            // 
            this.idTxtBox.BorderRadius = 5;
            this.idTxtBox.BorderThickness = 0;
            this.idTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTxtBox.DefaultText = "";
            this.idTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTxtBox.DisabledState.Parent = this.idTxtBox;
            this.idTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTxtBox.FocusedState.Parent = this.idTxtBox;
            this.idTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.idTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTxtBox.HoverState.Parent = this.idTxtBox;
            this.idTxtBox.Location = new System.Drawing.Point(1000, 45);
            this.idTxtBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.PasswordChar = '\0';
            this.idTxtBox.PlaceholderText = "";
            this.idTxtBox.SelectedText = "";
            this.idTxtBox.ShadowDecoration.Parent = this.idTxtBox;
            this.idTxtBox.Size = new System.Drawing.Size(247, 40);
            this.idTxtBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.idTxtBox.TabIndex = 6;
            this.idTxtBox.Visible = false;
            this.idTxtBox.TextChanged += new System.EventHandler(this.idTxtBox_TextChanged);
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.BorderRadius = 5;
            this.usernameTxtBox.BorderThickness = 0;
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
            this.usernameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTxtBox.HoverState.Parent = this.usernameTxtBox;
            this.usernameTxtBox.Location = new System.Drawing.Point(859, 145);
            this.usernameTxtBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.PasswordChar = '\0';
            this.usernameTxtBox.PlaceholderText = "";
            this.usernameTxtBox.SelectedText = "";
            this.usernameTxtBox.ShadowDecoration.Parent = this.usernameTxtBox;
            this.usernameTxtBox.Size = new System.Drawing.Size(388, 40);
            this.usernameTxtBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.usernameTxtBox.TabIndex = 7;
            // 
            // passTxtBox
            // 
            this.passTxtBox.BorderRadius = 5;
            this.passTxtBox.BorderThickness = 0;
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
            this.passTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTxtBox.HoverState.Parent = this.passTxtBox;
            this.passTxtBox.Location = new System.Drawing.Point(860, 272);
            this.passTxtBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.PasswordChar = '\0';
            this.passTxtBox.PlaceholderText = "";
            this.passTxtBox.SelectedText = "";
            this.passTxtBox.ShadowDecoration.Parent = this.passTxtBox;
            this.passTxtBox.Size = new System.Drawing.Size(387, 40);
            this.passTxtBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passTxtBox.TabIndex = 8;
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
            this.roleCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roleCombo.HoverState.Parent = this.roleCombo;
            this.roleCombo.ItemHeight = 30;
            this.roleCombo.Items.AddRange(new object[] {
            "Reception",
            "Manager"});
            this.roleCombo.ItemsAppearance.Parent = this.roleCombo;
            this.roleCombo.Location = new System.Drawing.Point(860, 411);
            this.roleCombo.Name = "roleCombo";
            this.roleCombo.ShadowDecoration.Parent = this.roleCombo;
            this.roleCombo.Size = new System.Drawing.Size(387, 36);
            this.roleCombo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.roleCombo.TabIndex = 9;
            // 
            // updateBtn
            // 
            this.updateBtn.AutoRoundedCorners = true;
            this.updateBtn.BorderRadius = 21;
            this.updateBtn.CheckedState.Parent = this.updateBtn;
            this.updateBtn.CustomImages.Parent = this.updateBtn;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.DisabledState.Parent = this.updateBtn;
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.HoverState.Parent = this.updateBtn;
            this.updateBtn.Location = new System.Drawing.Point(859, 505);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ShadowDecoration.Parent = this.updateBtn;
            this.updateBtn.Size = new System.Drawing.Size(180, 45);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoRoundedCorners = true;
            this.deleteBtn.BorderRadius = 21;
            this.deleteBtn.CheckedState.Parent = this.deleteBtn;
            this.deleteBtn.CustomImages.Parent = this.deleteBtn;
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.DisabledState.Parent = this.deleteBtn;
            this.deleteBtn.FillColor = System.Drawing.Color.OrangeRed;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.HoverState.Parent = this.deleteBtn;
            this.deleteBtn.Location = new System.Drawing.Point(1067, 505);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ShadowDecoration.Parent = this.deleteBtn;
            this.deleteBtn.Size = new System.Drawing.Size(180, 45);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // userAllList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.userAllList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.userAllList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userAllList.BackgroundColor = System.Drawing.Color.White;
            this.userAllList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userAllList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userAllList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userAllList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.userAllList.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userAllList.DefaultCellStyle = dataGridViewCellStyle6;
            this.userAllList.EnableHeadersVisualStyles = false;
            this.userAllList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userAllList.Location = new System.Drawing.Point(60, 100);
            this.userAllList.Name = "userAllList";
            this.userAllList.RowHeadersVisible = false;
            this.userAllList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userAllList.Size = new System.Drawing.Size(677, 450);
            this.userAllList.TabIndex = 12;
            this.userAllList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.userAllList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.userAllList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.userAllList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.userAllList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.userAllList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userAllList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userAllList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.userAllList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userAllList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.userAllList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userAllList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userAllList.ThemeStyle.HeaderStyle.Height = 4;
            this.userAllList.ThemeStyle.ReadOnly = false;
            this.userAllList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.userAllList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userAllList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.userAllList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userAllList.ThemeStyle.RowsStyle.Height = 22;
            this.userAllList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userAllList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userAllList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userAllList_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Manage User";
            // 
            // UC_ManageAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userAllList);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.roleCombo);
            this.Controls.Add(this.passTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            //this.Name = "UC_ManageAcc";
            this.Size = new System.Drawing.Size(1575, 587);
            this.Load += new System.EventHandler(this.UC_ManageAcc_Load);
            //this.Leave += new System.EventHandler(this.UC_ManageAcc_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAllList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView userList;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox idTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox passTxtBox;
        private Guna.UI2.WinForms.Guna2ComboBox roleCombo;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView userAllList;
    }
}
