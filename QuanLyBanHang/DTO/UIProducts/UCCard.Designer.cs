
namespace QuanLyBanHang.DTO.UIProducts
{
    partial class UCCard
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
            this.lblPrices = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnInfo = new Guna.UI2.WinForms.Guna2Button();
            this.ptbPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrices
            // 
            this.lblPrices.BackColor = System.Drawing.Color.Transparent;
            this.lblPrices.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrices.Location = new System.Drawing.Point(103, 172);
            this.lblPrices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPrices.Name = "lblPrices";
            this.lblPrices.Size = new System.Drawing.Size(60, 30);
            this.lblPrices.TabIndex = 6;
            this.lblPrices.Text = "1200$";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.Location = new System.Drawing.Point(100, 138);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 22);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Quan Da";
            // 
            // btnInfo
            // 
            this.btnInfo.Animated = true;
            this.btnInfo.AutoRoundedCorners = true;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BorderRadius = 20;
            this.btnInfo.CheckedState.Parent = this.btnInfo;
            this.btnInfo.CustomImages.Parent = this.btnInfo;
            this.btnInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInfo.DisabledState.Parent = this.btnInfo;
            this.btnInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.HoverState.Parent = this.btnInfo;
            this.btnInfo.Image = global::QuanLyBanHang.Properties.Resources.information__2_;
            this.btnInfo.IndicateFocus = true;
            this.btnInfo.Location = new System.Drawing.Point(228, 2);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.ShadowDecoration.Parent = this.btnInfo;
            this.btnInfo.Size = new System.Drawing.Size(60, 42);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.UseTransparentBackground = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // ptbPic
            // 
            this.ptbPic.ImageRotate = 0F;
            this.ptbPic.Location = new System.Drawing.Point(88, 18);
            this.ptbPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbPic.Name = "ptbPic";
            this.ptbPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbPic.ShadowDecoration.Parent = this.ptbPic;
            this.ptbPic.Size = new System.Drawing.Size(107, 98);
            this.ptbPic.TabIndex = 4;
            this.ptbPic.TabStop = false;
            // 
            // UCCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblPrices);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ptbPic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCCard";
            this.Size = new System.Drawing.Size(285, 229);
            this.Load += new System.EventHandler(this.UCCard_Load);
            this.Click += new System.EventHandler(this.UCCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrices;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptbPic;
    }
}
