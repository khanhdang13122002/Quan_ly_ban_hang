
namespace QuanLyBanHang.DTO.UIMessage
{
    partial class frmWarning
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
            this.btnYes = new Guna.UI2.WinForms.Guna2Button();
            this.lblcontent = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnNo = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.BorderColor = System.Drawing.Color.Transparent;
            this.btnYes.BorderRadius = 4;
            this.btnYes.CheckedState.Parent = this.btnYes;
            this.btnYes.CustomImages.Parent = this.btnYes;
            this.btnYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYes.DisabledState.Parent = this.btnYes;
            this.btnYes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(98)))), ((int)(((byte)(77)))));
            this.btnYes.Font = new System.Drawing.Font("Nunito", 8.249999F, System.Drawing.FontStyle.Bold);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.HoverState.Parent = this.btnYes;
            this.btnYes.Location = new System.Drawing.Point(83, 142);
            this.btnYes.Name = "btnYes";
            this.btnYes.ShadowDecoration.Parent = this.btnYes;
            this.btnYes.Size = new System.Drawing.Size(64, 37);
            this.btnYes.TabIndex = 11;
            this.btnYes.Text = "Yes";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblcontent
            // 
            this.lblcontent.AutoSize = false;
            this.lblcontent.BackColor = System.Drawing.Color.Transparent;
            this.lblcontent.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblcontent.Location = new System.Drawing.Point(101, 95);
            this.lblcontent.Name = "lblcontent";
            this.lblcontent.Size = new System.Drawing.Size(108, 24);
            this.lblcontent.TabIndex = 10;
            this.lblcontent.Text = "Login Success";
            this.lblcontent.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::QuanLyBanHang.Properties.Resources.warning1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(122, 15);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(68, 65);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // btnNo
            // 
            this.btnNo.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNo.BorderRadius = 4;
            this.btnNo.BorderThickness = 1;
            this.btnNo.CheckedState.Parent = this.btnNo;
            this.btnNo.CustomImages.Parent = this.btnNo;
            this.btnNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNo.DisabledState.Parent = this.btnNo;
            this.btnNo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNo.Font = new System.Drawing.Font("Nunito", 8.249999F, System.Drawing.FontStyle.Bold);
            this.btnNo.ForeColor = System.Drawing.Color.DimGray;
            this.btnNo.HoverState.Parent = this.btnNo;
            this.btnNo.Location = new System.Drawing.Point(164, 142);
            this.btnNo.Name = "btnNo";
            this.btnNo.ShadowDecoration.Parent = this.btnNo;
            this.btnNo.Size = new System.Drawing.Size(64, 37);
            this.btnNo.TabIndex = 13;
            this.btnNo.Text = "No";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // frmWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(310, 198);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblcontent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWarning";
            this.Load += new System.EventHandler(this.frmWarning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnYes;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblcontent;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnNo;
    }
}