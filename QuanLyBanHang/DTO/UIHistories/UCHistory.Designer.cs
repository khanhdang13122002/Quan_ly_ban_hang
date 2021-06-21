
namespace QuanLyBanHang.DTO.UIHistories
{
    partial class UCHistory
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
            this.dgvHis = new Guna.UI2.WinForms.Guna2DataGridView();
            this.historyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isProductDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isOrderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isUserDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet = new QuanLyBanHang.QuanLyBanHangDataSet();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.historyTableAdapter = new QuanLyBanHang.QuanLyBanHangDataSetTableAdapters.historyTableAdapter();
            this.btnGetAll = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHis
            // 
            this.dgvHis.AllowUserToAddRows = false;
            this.dgvHis.AllowUserToDeleteRows = false;
            this.dgvHis.AllowUserToResizeColumns = false;
            this.dgvHis.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHis.AutoGenerateColumns = false;
            this.dgvHis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHis.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHis.ColumnHeadersHeight = 40;
            this.dgvHis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.historyIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.isProductDataGridViewCheckBoxColumn,
            this.isOrderDataGridViewCheckBoxColumn,
            this.isUserDataGridViewCheckBoxColumn});
            this.dgvHis.DataSource = this.historyBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHis.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHis.EnableHeadersVisualStyles = false;
            this.dgvHis.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHis.Location = new System.Drawing.Point(-3, 138);
            this.dgvHis.Name = "dgvHis";
            this.dgvHis.ReadOnly = true;
            this.dgvHis.RowHeadersVisible = false;
            this.dgvHis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHis.Size = new System.Drawing.Size(874, 326);
            this.dgvHis.TabIndex = 0;
            this.dgvHis.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHis.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHis.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHis.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHis.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHis.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHis.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHis.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvHis.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHis.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvHis.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHis.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHis.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvHis.ThemeStyle.ReadOnly = true;
            this.dgvHis.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHis.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvHis.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHis.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvHis.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHis.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHis.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            // 
            // historyIdDataGridViewTextBoxColumn
            // 
            this.historyIdDataGridViewTextBoxColumn.DataPropertyName = "historyId";
            this.historyIdDataGridViewTextBoxColumn.HeaderText = "historyId";
            this.historyIdDataGridViewTextBoxColumn.Name = "historyIdDataGridViewTextBoxColumn";
            this.historyIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isProductDataGridViewCheckBoxColumn
            // 
            this.isProductDataGridViewCheckBoxColumn.DataPropertyName = "isProduct";
            this.isProductDataGridViewCheckBoxColumn.HeaderText = "isProduct";
            this.isProductDataGridViewCheckBoxColumn.Name = "isProductDataGridViewCheckBoxColumn";
            this.isProductDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isOrderDataGridViewCheckBoxColumn
            // 
            this.isOrderDataGridViewCheckBoxColumn.DataPropertyName = "isOrder";
            this.isOrderDataGridViewCheckBoxColumn.HeaderText = "isOrder";
            this.isOrderDataGridViewCheckBoxColumn.Name = "isOrderDataGridViewCheckBoxColumn";
            this.isOrderDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isUserDataGridViewCheckBoxColumn
            // 
            this.isUserDataGridViewCheckBoxColumn.DataPropertyName = "isUser";
            this.isUserDataGridViewCheckBoxColumn.HeaderText = "isUser";
            this.isUserDataGridViewCheckBoxColumn.Name = "isUserDataGridViewCheckBoxColumn";
            this.isUserDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "history";
            this.historyBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // quanLyBanHangDataSet
            // 
            this.quanLyBanHangDataSet.DataSetName = "QuanLyBanHangDataSet";
            this.quanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(-3, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(164, 27);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Lịch Sử Thao Tác";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(159, 68);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(131, 37);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Lịch Sử Sản Phẩm";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 17;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.IndicateFocus = true;
            this.guna2Button3.Location = new System.Drawing.Point(488, 68);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(131, 37);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "Lịch Sử Order";
            this.guna2Button3.UseTransparentBackground = true;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 17;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.IndicateFocus = true;
            this.guna2Button2.Location = new System.Drawing.Point(316, 68);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(138, 37);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "Lịch Sử Người Dùng";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Animated = true;
            this.btnGetAll.AutoRoundedCorners = true;
            this.btnGetAll.BackColor = System.Drawing.Color.Transparent;
            this.btnGetAll.BorderRadius = 17;
            this.btnGetAll.CheckedState.Parent = this.btnGetAll;
            this.btnGetAll.CustomImages.Parent = this.btnGetAll;
            this.btnGetAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGetAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGetAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGetAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGetAll.DisabledState.Parent = this.btnGetAll;
            this.btnGetAll.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetAll.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnGetAll.ForeColor = System.Drawing.Color.DimGray;
            this.btnGetAll.HoverState.Parent = this.btnGetAll;
            this.btnGetAll.IndicateFocus = true;
            this.btnGetAll.Location = new System.Drawing.Point(0, 68);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.ShadowDecoration.Parent = this.btnGetAll;
            this.btnGetAll.Size = new System.Drawing.Size(131, 37);
            this.btnGetAll.TabIndex = 6;
            this.btnGetAll.Text = "Tất Cả";
            this.btnGetAll.UseTransparentBackground = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // UCHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvHis);
            this.Name = "UCHistory";
            this.Size = new System.Drawing.Size(874, 453);
            this.Load += new System.EventHandler(this.UCHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvHis;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isProductDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOrderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isUserDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private QuanLyBanHangDataSet quanLyBanHangDataSet;
        private QuanLyBanHangDataSetTableAdapters.historyTableAdapter historyTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnGetAll;
    }
}
