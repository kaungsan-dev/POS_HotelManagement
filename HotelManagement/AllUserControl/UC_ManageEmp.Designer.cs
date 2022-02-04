
namespace HotelManagement.AllUserControl
{
    partial class UC_ManageEmp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.empAllList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.empnameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label = new System.Windows.Forms.Label();
            this.emailTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.genderCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.positionTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.createBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.empAllList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Manage Employee";
            // 
            // empAllList
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.empAllList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.empAllList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empAllList.BackgroundColor = System.Drawing.Color.White;
            this.empAllList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empAllList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empAllList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empAllList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.empAllList.ColumnHeadersHeight = 4;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empAllList.DefaultCellStyle = dataGridViewCellStyle18;
            this.empAllList.EnableHeadersVisualStyles = false;
            this.empAllList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empAllList.Location = new System.Drawing.Point(30, 102);
            this.empAllList.Name = "empAllList";
            this.empAllList.RowHeadersVisible = false;
            this.empAllList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empAllList.Size = new System.Drawing.Size(677, 450);
            this.empAllList.TabIndex = 15;
            this.empAllList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.empAllList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.empAllList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.empAllList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.empAllList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.empAllList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.empAllList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empAllList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.empAllList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empAllList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.empAllList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.empAllList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.empAllList.ThemeStyle.HeaderStyle.Height = 4;
            this.empAllList.ThemeStyle.ReadOnly = false;
            this.empAllList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.empAllList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empAllList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.empAllList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.empAllList.ThemeStyle.RowsStyle.Height = 22;
            this.empAllList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empAllList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.empAllList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empAllList_CellDoubleClick);
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
            this.idTxtBox.Location = new System.Drawing.Point(821, 13);
            this.idTxtBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.PasswordChar = '\0';
            this.idTxtBox.PlaceholderText = "";
            this.idTxtBox.SelectedText = "";
            this.idTxtBox.ShadowDecoration.Parent = this.idTxtBox;
            this.idTxtBox.Size = new System.Drawing.Size(247, 40);
            this.idTxtBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.idTxtBox.TabIndex = 17;
            this.idTxtBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(772, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID";
            this.label4.Visible = false;
            // 
            // empnameTxtBox
            // 
            this.empnameTxtBox.BorderRadius = 5;
            this.empnameTxtBox.BorderThickness = 0;
            this.empnameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empnameTxtBox.DefaultText = "";
            this.empnameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empnameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empnameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empnameTxtBox.DisabledState.Parent = this.empnameTxtBox;
            this.empnameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empnameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empnameTxtBox.FocusedState.Parent = this.empnameTxtBox;
            this.empnameTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.empnameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empnameTxtBox.HoverState.Parent = this.empnameTxtBox;
            this.empnameTxtBox.Location = new System.Drawing.Point(776, 144);
            this.empnameTxtBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.empnameTxtBox.Name = "empnameTxtBox";
            this.empnameTxtBox.PasswordChar = '\0';
            this.empnameTxtBox.PlaceholderText = "";
            this.empnameTxtBox.SelectedText = "";
            this.empnameTxtBox.ShadowDecoration.Parent = this.empnameTxtBox;
            this.empnameTxtBox.Size = new System.Drawing.Size(292, 40);
            this.empnameTxtBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.empnameTxtBox.TabIndex = 19;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(772, 99);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 22);
            this.label.TabIndex = 18;
            this.label.Text = "Name";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.BorderRadius = 5;
            this.emailTxtBox.BorderThickness = 0;
            this.emailTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxtBox.DefaultText = "";
            this.emailTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxtBox.DisabledState.Parent = this.emailTxtBox;
            this.emailTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxtBox.FocusedState.Parent = this.emailTxtBox;
            this.emailTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.emailTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxtBox.HoverState.Parent = this.emailTxtBox;
            this.emailTxtBox.Location = new System.Drawing.Point(1181, 144);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.PasswordChar = '\0';
            this.emailTxtBox.PlaceholderText = "";
            this.emailTxtBox.SelectedText = "";
            this.emailTxtBox.ShadowDecoration.Parent = this.emailTxtBox;
            this.emailTxtBox.Size = new System.Drawing.Size(292, 40);
            this.emailTxtBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.emailTxtBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1177, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1177, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Gender";
            // 
            // phTxtBox
            // 
            this.phTxtBox.BorderRadius = 5;
            this.phTxtBox.BorderThickness = 0;
            this.phTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phTxtBox.DefaultText = "";
            this.phTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phTxtBox.DisabledState.Parent = this.phTxtBox;
            this.phTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phTxtBox.FocusedState.Parent = this.phTxtBox;
            this.phTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.phTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phTxtBox.HoverState.Parent = this.phTxtBox;
            this.phTxtBox.Location = new System.Drawing.Point(776, 263);
            this.phTxtBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.phTxtBox.Name = "phTxtBox";
            this.phTxtBox.PasswordChar = '\0';
            this.phTxtBox.PlaceholderText = "";
            this.phTxtBox.SelectedText = "";
            this.phTxtBox.ShadowDecoration.Parent = this.phTxtBox;
            this.phTxtBox.Size = new System.Drawing.Size(292, 40);
            this.phTxtBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.phTxtBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(772, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "PhoneNo";
            // 
            // genderCombo
            // 
            this.genderCombo.BackColor = System.Drawing.Color.Transparent;
            this.genderCombo.BorderRadius = 5;
            this.genderCombo.BorderThickness = 0;
            this.genderCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderCombo.FocusedState.Parent = this.genderCombo;
            this.genderCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.genderCombo.HoverState.Parent = this.genderCombo;
            this.genderCombo.ItemHeight = 30;
            this.genderCombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCombo.ItemsAppearance.Parent = this.genderCombo;
            this.genderCombo.Location = new System.Drawing.Point(1181, 263);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.ShadowDecoration.Parent = this.genderCombo;
            this.genderCombo.Size = new System.Drawing.Size(292, 36);
            this.genderCombo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.genderCombo.TabIndex = 25;
            // 
            // positionTxtBox
            // 
            this.positionTxtBox.BorderRadius = 5;
            this.positionTxtBox.BorderThickness = 0;
            this.positionTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.positionTxtBox.DefaultText = "";
            this.positionTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.positionTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.positionTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.positionTxtBox.DisabledState.Parent = this.positionTxtBox;
            this.positionTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.positionTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.positionTxtBox.FocusedState.Parent = this.positionTxtBox;
            this.positionTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.positionTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.positionTxtBox.HoverState.Parent = this.positionTxtBox;
            this.positionTxtBox.Location = new System.Drawing.Point(985, 362);
            this.positionTxtBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.positionTxtBox.Name = "positionTxtBox";
            this.positionTxtBox.PasswordChar = '\0';
            this.positionTxtBox.PlaceholderText = "";
            this.positionTxtBox.SelectedText = "";
            this.positionTxtBox.ShadowDecoration.Parent = this.positionTxtBox;
            this.positionTxtBox.Size = new System.Drawing.Size(292, 40);
            this.positionTxtBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.positionTxtBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1086, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Position";
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
            this.deleteBtn.Location = new System.Drawing.Point(1298, 461);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ShadowDecoration.Parent = this.deleteBtn;
            this.deleteBtn.Size = new System.Drawing.Size(180, 45);
            this.deleteBtn.TabIndex = 29;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.updateBtn.Location = new System.Drawing.Point(1048, 461);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ShadowDecoration.Parent = this.updateBtn;
            this.updateBtn.Size = new System.Drawing.Size(180, 45);
            this.updateBtn.TabIndex = 28;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.AutoRoundedCorners = true;
            this.createBtn.BorderRadius = 21;
            this.createBtn.CheckedState.Parent = this.createBtn;
            this.createBtn.CustomImages.Parent = this.createBtn;
            this.createBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createBtn.DisabledState.Parent = this.createBtn;
            this.createBtn.FillColor = System.Drawing.Color.Green;
            this.createBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.HoverState.Parent = this.createBtn;
            this.createBtn.Location = new System.Drawing.Point(776, 461);
            this.createBtn.Name = "createBtn";
            this.createBtn.ShadowDecoration.Parent = this.createBtn;
            this.createBtn.Size = new System.Drawing.Size(180, 45);
            this.createBtn.TabIndex = 30;
            this.createBtn.Text = "Create";
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_ManageEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.positionTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genderCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empnameTxtBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.empAllList);
            this.Controls.Add(this.label5);
            this.Name = "UC_ManageEmp";
            this.Size = new System.Drawing.Size(1575, 587);
            this.Load += new System.EventHandler(this.UC_ManageEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empAllList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView empAllList;
        private Guna.UI2.WinForms.Guna2TextBox idTxtBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox empnameTxtBox;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2TextBox emailTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox phTxtBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox genderCombo;
        private Guna.UI2.WinForms.Guna2TextBox positionTxtBox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button createBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
