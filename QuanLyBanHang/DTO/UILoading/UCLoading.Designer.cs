
namespace QuanLyBanHang.DTO.UILoading
{
    partial class UCLoading
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
            this.cpbLoading = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.SuspendLayout();
            // 
            // cpbLoading
            // 
            this.cpbLoading.Animated = true;
            this.cpbLoading.AnimationSpeed = 1F;
            this.cpbLoading.BackColor = System.Drawing.Color.Transparent;
            this.cpbLoading.FillColor = System.Drawing.Color.LightGray;
            this.cpbLoading.FillOffset = 9;
            this.cpbLoading.FillThickness = 6;
            this.cpbLoading.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cpbLoading.ForeColor = System.Drawing.Color.Black;
            this.cpbLoading.InnerColor = System.Drawing.Color.Transparent;
            this.cpbLoading.Location = new System.Drawing.Point(3, 0);
            this.cpbLoading.Minimum = 0;
            this.cpbLoading.Name = "cpbLoading";
            this.cpbLoading.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.cpbLoading.ProgressColor = System.Drawing.Color.Black;
            this.cpbLoading.ProgressColor2 = System.Drawing.Color.Black;
            this.cpbLoading.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.cpbLoading.ProgressOffset = 10;
            this.cpbLoading.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.cpbLoading.ProgressThickness = 6;
            this.cpbLoading.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpbLoading.ShadowDecoration.Parent = this.cpbLoading;
            this.cpbLoading.Size = new System.Drawing.Size(53, 53);
            this.cpbLoading.TabIndex = 1;
            this.cpbLoading.Text = "%";
            this.cpbLoading.UseTransparentBackground = true;
            this.cpbLoading.Value = 30;
            // 
            // UCLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cpbLoading);
            this.Name = "UCLoading";
            this.Size = new System.Drawing.Size(79, 53);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar cpbLoading;
    }
}
