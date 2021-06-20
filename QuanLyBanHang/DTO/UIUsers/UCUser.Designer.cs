
namespace QuanLyBanHang.DTO.UIUsers
{
    partial class UCUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gnBtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.gnBtnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.gnBtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.gnBtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.gnTxtKeyword = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gnDgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gnDgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gnBtnAdd);
            this.panel1.Controls.Add(this.gnBtnEdit);
            this.panel1.Controls.Add(this.gnBtnDelete);
            this.panel1.Controls.Add(this.gnBtnSearch);
            this.panel1.Controls.Add(this.gnTxtKeyword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 86);
            this.panel1.TabIndex = 0;
            // 
            // gnBtnAdd
            // 
            this.gnBtnAdd.CheckedState.Parent = this.gnBtnAdd;
            this.gnBtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnBtnAdd.CustomImages.Parent = this.gnBtnAdd;
            this.gnBtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnBtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnBtnAdd.DisabledState.Parent = this.gnBtnAdd;
            this.gnBtnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.gnBtnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gnBtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnBtnAdd.ForeColor = System.Drawing.Color.White;
            this.gnBtnAdd.HoverState.Parent = this.gnBtnAdd;
            this.gnBtnAdd.Location = new System.Drawing.Point(842, 0);
            this.gnBtnAdd.Name = "gnBtnAdd";
            this.gnBtnAdd.ShadowDecoration.Parent = this.gnBtnAdd;
            this.gnBtnAdd.Size = new System.Drawing.Size(88, 86);
            this.gnBtnAdd.TabIndex = 4;
            this.gnBtnAdd.Text = "Thêm";
            this.gnBtnAdd.Click += new System.EventHandler(this.gnBtnAdd_Click);
            // 
            // gnBtnEdit
            // 
            this.gnBtnEdit.CheckedState.Parent = this.gnBtnEdit;
            this.gnBtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnBtnEdit.CustomImages.Parent = this.gnBtnEdit;
            this.gnBtnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnBtnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnBtnEdit.DisabledState.Parent = this.gnBtnEdit;
            this.gnBtnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.gnBtnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gnBtnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnBtnEdit.ForeColor = System.Drawing.Color.White;
            this.gnBtnEdit.HoverState.Parent = this.gnBtnEdit;
            this.gnBtnEdit.Location = new System.Drawing.Point(930, 0);
            this.gnBtnEdit.Name = "gnBtnEdit";
            this.gnBtnEdit.ShadowDecoration.Parent = this.gnBtnEdit;
            this.gnBtnEdit.Size = new System.Drawing.Size(88, 86);
            this.gnBtnEdit.TabIndex = 3;
            this.gnBtnEdit.Text = "Sửa";
            this.gnBtnEdit.Click += new System.EventHandler(this.gnBtnEdit_Click);
            // 
            // gnBtnDelete
            // 
            this.gnBtnDelete.CheckedState.Parent = this.gnBtnDelete;
            this.gnBtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnBtnDelete.CustomImages.Parent = this.gnBtnDelete;
            this.gnBtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnBtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnBtnDelete.DisabledState.Parent = this.gnBtnDelete;
            this.gnBtnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.gnBtnDelete.FillColor = System.Drawing.Color.Red;
            this.gnBtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnBtnDelete.ForeColor = System.Drawing.Color.White;
            this.gnBtnDelete.HoverState.Parent = this.gnBtnDelete;
            this.gnBtnDelete.Location = new System.Drawing.Point(1018, 0);
            this.gnBtnDelete.Name = "gnBtnDelete";
            this.gnBtnDelete.ShadowDecoration.Parent = this.gnBtnDelete;
            this.gnBtnDelete.Size = new System.Drawing.Size(88, 86);
            this.gnBtnDelete.TabIndex = 2;
            this.gnBtnDelete.Text = "Xóa";
            this.gnBtnDelete.Click += new System.EventHandler(this.gnBtnDelete_Click);
            // 
            // gnBtnSearch
            // 
            this.gnBtnSearch.Animated = true;
            this.gnBtnSearch.BorderRadius = 10;
            this.gnBtnSearch.CheckedState.Parent = this.gnBtnSearch;
            this.gnBtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnBtnSearch.CustomImages.Parent = this.gnBtnSearch;
            this.gnBtnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnBtnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnBtnSearch.DisabledState.Parent = this.gnBtnSearch;
            this.gnBtnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnBtnSearch.ForeColor = System.Drawing.Color.White;
            this.gnBtnSearch.HoverState.Parent = this.gnBtnSearch;
            this.gnBtnSearch.Location = new System.Drawing.Point(307, 27);
            this.gnBtnSearch.Name = "gnBtnSearch";
            this.gnBtnSearch.ShadowDecoration.Parent = this.gnBtnSearch;
            this.gnBtnSearch.Size = new System.Drawing.Size(136, 35);
            this.gnBtnSearch.TabIndex = 1;
            this.gnBtnSearch.Text = "Tìm kiếm";
            this.gnBtnSearch.Click += new System.EventHandler(this.gnBtnSearch_Click);
            // 
            // gnTxtKeyword
            // 
            this.gnTxtKeyword.Animated = true;
            this.gnTxtKeyword.BorderColor = System.Drawing.Color.Purple;
            this.gnTxtKeyword.BorderRadius = 10;
            this.gnTxtKeyword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gnTxtKeyword.DefaultText = "";
            this.gnTxtKeyword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gnTxtKeyword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gnTxtKeyword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gnTxtKeyword.DisabledState.Parent = this.gnTxtKeyword;
            this.gnTxtKeyword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gnTxtKeyword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gnTxtKeyword.FocusedState.Parent = this.gnTxtKeyword;
            this.gnTxtKeyword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnTxtKeyword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.gnTxtKeyword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gnTxtKeyword.HoverState.Parent = this.gnTxtKeyword;
            this.gnTxtKeyword.Location = new System.Drawing.Point(30, 26);
            this.gnTxtKeyword.Name = "gnTxtKeyword";
            this.gnTxtKeyword.PasswordChar = '\0';
            this.gnTxtKeyword.PlaceholderText = "Nhập từ khóa tìm kiếm";
            this.gnTxtKeyword.SelectedText = "";
            this.gnTxtKeyword.ShadowDecoration.Parent = this.gnTxtKeyword;
            this.gnTxtKeyword.Size = new System.Drawing.Size(257, 36);
            this.gnTxtKeyword.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gnDgvUsers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 496);
            this.panel2.TabIndex = 1;
            // 
            // gnDgvUsers
            // 
            this.gnDgvUsers.AllowUserToAddRows = false;
            this.gnDgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gnDgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gnDgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gnDgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.gnDgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gnDgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gnDgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gnDgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gnDgvUsers.ColumnHeadersHeight = 27;
            this.gnDgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.UserName,
            this.Auths,
            this.order_,
            this.products,
            this.Email,
            this.Address_,
            this.Sdt,
            this.Desc_,
            this.Avatar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gnDgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.gnDgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnDgvUsers.EnableHeadersVisualStyles = false;
            this.gnDgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gnDgvUsers.Location = new System.Drawing.Point(0, 0);
            this.gnDgvUsers.Name = "gnDgvUsers";
            this.gnDgvUsers.ReadOnly = true;
            this.gnDgvUsers.RowHeadersVisible = false;
            this.gnDgvUsers.RowHeadersWidth = 51;
            this.gnDgvUsers.RowTemplate.Height = 24;
            this.gnDgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gnDgvUsers.Size = new System.Drawing.Size(1106, 496);
            this.gnDgvUsers.TabIndex = 0;
            this.gnDgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gnDgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gnDgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gnDgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gnDgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gnDgvUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gnDgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gnDgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gnDgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gnDgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gnDgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gnDgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gnDgvUsers.ThemeStyle.HeaderStyle.Height = 27;
            this.gnDgvUsers.ThemeStyle.ReadOnly = true;
            this.gnDgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gnDgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gnDgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gnDgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gnDgvUsers.ThemeStyle.RowsStyle.Height = 24;
            this.gnDgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gnDgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // userId
            // 
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "ID";
            this.userId.MinimumWidth = 6;
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Auths
            // 
            this.Auths.DataPropertyName = "Auths";
            this.Auths.HeaderText = "Auths";
            this.Auths.MinimumWidth = 6;
            this.Auths.Name = "Auths";
            this.Auths.ReadOnly = true;
            this.Auths.Visible = false;
            // 
            // order_
            // 
            this.order_.DataPropertyName = "order_";
            this.order_.HeaderText = "Order";
            this.order_.MinimumWidth = 6;
            this.order_.Name = "order_";
            this.order_.ReadOnly = true;
            this.order_.Visible = false;
            // 
            // products
            // 
            this.products.DataPropertyName = "products";
            this.products.HeaderText = "products";
            this.products.MinimumWidth = 6;
            this.products.Name = "products";
            this.products.ReadOnly = true;
            this.products.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address_
            // 
            this.Address_.DataPropertyName = "Address_";
            this.Address_.HeaderText = "Address";
            this.Address_.MinimumWidth = 6;
            this.Address_.Name = "Address_";
            this.Address_.ReadOnly = true;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Phone number";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            // 
            // Desc_
            // 
            this.Desc_.DataPropertyName = "Desc_";
            this.Desc_.HeaderText = "Description";
            this.Desc_.MinimumWidth = 6;
            this.Desc_.Name = "Desc_";
            this.Desc_.ReadOnly = true;
            // 
            // Avatar
            // 
            this.Avatar.DataPropertyName = "Avatar";
            this.Avatar.HeaderText = "Avatar";
            this.Avatar.MinimumWidth = 6;
            this.Avatar.Name = "Avatar";
            this.Avatar.ReadOnly = true;
            // 
            // UCUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCUser";
            this.Size = new System.Drawing.Size(1106, 582);
            this.Load += new System.EventHandler(this.UCUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gnDgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox gnTxtKeyword;
        private Guna.UI2.WinForms.Guna2Button gnBtnSearch;
        private Guna.UI2.WinForms.Guna2Button gnBtnAdd;
        private Guna.UI2.WinForms.Guna2Button gnBtnEdit;
        private Guna.UI2.WinForms.Guna2Button gnBtnDelete;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView gnDgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auths;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_;
        private System.Windows.Forms.DataGridViewTextBoxColumn products;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avatar;
    }
}
