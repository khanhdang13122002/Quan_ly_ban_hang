
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
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.ptbPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrices
            // 
            this.lblPrices.BackColor = System.Drawing.Color.Transparent;
            this.lblPrices.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrices.Location = new System.Drawing.Point(77, 140);
            this.lblPrices.Name = "lblPrices";
            this.lblPrices.Size = new System.Drawing.Size(46, 25);
            this.lblPrices.TabIndex = 6;
            this.lblPrices.Text = "1200$";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Nunito", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.Location = new System.Drawing.Point(75, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Quan Da";
            // 
            // btnRemove
            // 
            this.btnRemove.Animated = true;
            this.btnRemove.AutoRoundedCorners = true;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BorderRadius = 16;
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.DisabledState.Parent = this.btnRemove;
            this.btnRemove.FillColor = System.Drawing.Color.Transparent;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Image = global::QuanLyBanHang.Properties.Resources.rubbish__1_;
            this.btnRemove.IndicateFocus = true;
            this.btnRemove.Location = new System.Drawing.Point(148, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(45, 34);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.UseTransparentBackground = true;
            // 
            // ptbPic
            // 
            this.ptbPic.ImageRotate = 0F;
            this.ptbPic.Location = new System.Drawing.Point(52, 12);
            this.ptbPic.Name = "ptbPic";
            this.ptbPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbPic.ShadowDecoration.Parent = this.ptbPic;
            this.ptbPic.Size = new System.Drawing.Size(80, 80);
            this.ptbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPic.TabIndex = 4;
            this.ptbPic.TabStop = false;
            // 
            // UCCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblPrices);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ptbPic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UCCard";
            this.Size = new System.Drawing.Size(187, 186);
            this.Load += new System.EventHandler(this.UCCard_Load);
            this.Click += new System.EventHandler(this.UCCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrices;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptbPic;
        public Guna.UI2.WinForms.Guna2Button btnRemove;
    }
}
