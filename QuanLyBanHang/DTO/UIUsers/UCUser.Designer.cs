
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gnBtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.gnBtnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.gnBtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gnDgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanLyBanHangDataSet1 = new QuanLyBanHang.QuanLyBanHangDataSet1();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new QuanLyBanHang.QuanLyBanHangDataSet1TableAdapters.UsersTableAdapter();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gnDgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.gnBtnDelete);
            this.panel1.Controls.Add(this.gnBtnEdit);
            this.panel1.Controls.Add(this.gnBtnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 132);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gnBtnDelete
            // 
            this.gnBtnDelete.Animated = true;
            this.gnBtnDelete.AutoRoundedCorners = true;
            this.gnBtnDelete.BorderRadius = 18;
            this.gnBtnDelete.CheckedState.Parent = this.gnBtnDelete;
            this.gnBtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnBtnDelete.CustomImages.Parent = this.gnBtnDelete;
            this.gnBtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnBtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnBtnDelete.DisabledState.Parent = this.gnBtnDelete;
            this.gnBtnDelete.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gnBtnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.gnBtnDelete.ForeColor = System.Drawing.Color.DimGray;
            this.gnBtnDelete.HoverState.Parent = this.gnBtnDelete;
            this.gnBtnDelete.Image = global::QuanLyBanHang.Properties.Resources.rubbish__1_;
            this.gnBtnDelete.ImageOffset = new System.Drawing.Point(-6, 0);
            this.gnBtnDelete.ImageSize = new System.Drawing.Size(16, 16);
            this.gnBtnDelete.IndicateFocus = true;
            this.gnBtnDelete.Location = new System.Drawing.Point(320, 73);
            this.gnBtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.gnBtnDelete.Name = "gnBtnDelete";
            this.gnBtnDelete.ShadowDecoration.Parent = this.gnBtnDelete;
            this.gnBtnDelete.Size = new System.Drawing.Size(128, 39);
            this.gnBtnDelete.TabIndex = 6;
            this.gnBtnDelete.Text = "Xóa";
            this.gnBtnDelete.UseTransparentBackground = true;
            this.gnBtnDelete.Click += new System.EventHandler(this.gnBtnDelete_Click);
            // 
            // gnBtnEdit
            // 
            this.gnBtnEdit.Animated = true;
            this.gnBtnEdit.AutoRoundedCorners = true;
            this.gnBtnEdit.BorderRadius = 18;
            this.gnBtnEdit.CheckedState.Parent = this.gnBtnEdit;
            this.gnBtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnBtnEdit.CustomImages.Parent = this.gnBtnEdit;
            this.gnBtnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnBtnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnBtnEdit.DisabledState.Parent = this.gnBtnEdit;
            this.gnBtnEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gnBtnEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.gnBtnEdit.ForeColor = System.Drawing.Color.DimGray;
            this.gnBtnEdit.HoverState.Parent = this.gnBtnEdit;
            this.gnBtnEdit.Image = global::QuanLyBanHang.Properties.Resources.edit;
            this.gnBtnEdit.ImageOffset = new System.Drawing.Point(-6, -2);
            this.gnBtnEdit.ImageSize = new System.Drawing.Size(16, 16);
            this.gnBtnEdit.IndicateFocus = true;
            this.gnBtnEdit.Location = new System.Drawing.Point(158, 73);
            this.gnBtnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.gnBtnEdit.Name = "gnBtnEdit";
            this.gnBtnEdit.ShadowDecoration.Parent = this.gnBtnEdit;
            this.gnBtnEdit.Size = new System.Drawing.Size(128, 39);
            this.gnBtnEdit.TabIndex = 5;
            this.gnBtnEdit.Text = "Sửa";
            this.gnBtnEdit.UseTransparentBackground = true;
            this.gnBtnEdit.Click += new System.EventHandler(this.gnBtnEdit_Click);
            // 
            // gnBtnAdd
            // 
            this.gnBtnAdd.Animated = true;
            this.gnBtnAdd.AutoRoundedCorners = true;
            this.gnBtnAdd.BorderRadius = 18;
            this.gnBtnAdd.CheckedState.Parent = this.gnBtnAdd;
            this.gnBtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnBtnAdd.CustomImages.Parent = this.gnBtnAdd;
            this.gnBtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnBtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnBtnAdd.DisabledState.Parent = this.gnBtnAdd;
            this.gnBtnAdd.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gnBtnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.gnBtnAdd.ForeColor = System.Drawing.Color.DimGray;
            this.gnBtnAdd.HoverState.Parent = this.gnBtnAdd;
            this.gnBtnAdd.Image = global::QuanLyBanHang.Properties.Resources.plus;
            this.gnBtnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnBtnAdd.ImageOffset = new System.Drawing.Point(16, 0);
            this.gnBtnAdd.ImageSize = new System.Drawing.Size(14, 14);
            this.gnBtnAdd.IndicateFocus = true;
            this.gnBtnAdd.Location = new System.Drawing.Point(0, 73);
            this.gnBtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.gnBtnAdd.Name = "gnBtnAdd";
            this.gnBtnAdd.ShadowDecoration.Parent = this.gnBtnAdd;
            this.gnBtnAdd.Size = new System.Drawing.Size(128, 39);
            this.gnBtnAdd.TabIndex = 4;
            this.gnBtnAdd.Text = "Thêm";
            this.gnBtnAdd.UseTransparentBackground = true;
            this.gnBtnAdd.Click += new System.EventHandler(this.gnBtnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gnDgvUsers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 341);
            this.panel2.TabIndex = 1;
            // 
            // gnDgvUsers
            // 
            this.gnDgvUsers.AllowUserToAddRows = false;
            this.gnDgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.gnDgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gnDgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gnDgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.gnDgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gnDgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gnDgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gnDgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gnDgvUsers.ColumnHeadersHeight = 40;
            this.gnDgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gnDgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.UserName,
            this.Email,
            this.Address_,
            this.Sdt,
            this.Desc_,
            this.Avatar,
            this.Auths,
            this.order_,
            this.products});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gnDgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.gnDgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnDgvUsers.EnableHeadersVisualStyles = false;
            this.gnDgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.gnDgvUsers.Location = new System.Drawing.Point(0, 0);
            this.gnDgvUsers.Margin = new System.Windows.Forms.Padding(2);
            this.gnDgvUsers.Name = "gnDgvUsers";
            this.gnDgvUsers.ReadOnly = true;
            this.gnDgvUsers.RowHeadersVisible = false;
            this.gnDgvUsers.RowHeadersWidth = 51;
            this.gnDgvUsers.RowTemplate.Height = 24;
            this.gnDgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gnDgvUsers.Size = new System.Drawing.Size(830, 341);
            this.gnDgvUsers.TabIndex = 0;
            this.gnDgvUsers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.gnDgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.gnDgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gnDgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gnDgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gnDgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gnDgvUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gnDgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.gnDgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.gnDgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gnDgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gnDgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gnDgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gnDgvUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.gnDgvUsers.ThemeStyle.ReadOnly = true;
            this.gnDgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gnDgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gnDgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gnDgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gnDgvUsers.ThemeStyle.RowsStyle.Height = 24;
            this.gnDgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.gnDgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            // quanLyBanHangDataSet1
            // 
            this.quanLyBanHangDataSet1.DataSetName = "QuanLyBanHangDataSet1";
            this.quanLyBanHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.quanLyBanHangDataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(201, 27);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "Quản Lý Người Dùng";
            // 
            // UCUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCUser";
            this.Size = new System.Drawing.Size(830, 473);
            this.Load += new System.EventHandler(this.UCUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gnDgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button gnBtnAdd;
        private System.Windows.Forms.Panel panel2;
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
        private Guna.UI2.WinForms.Guna2Button gnBtnEdit;
        private Guna.UI2.WinForms.Guna2Button gnBtnDelete;
        private QuanLyBanHangDataSet1 quanLyBanHangDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private QuanLyBanHangDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        public Guna.UI2.WinForms.Guna2DataGridView gnDgvUsers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
