using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuanLyBanHang.DTO.UIMessage
{
    public partial class frmWarning : Form
    {
        protected bool isYes = true;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
      (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

      );
        public frmWarning()
        {
            InitializeComponent();
        }

        private void frmWarning_Load(object sender, EventArgs e)
        {
            this.guna2PictureBox1.Location = new Point((this.Width - guna2PictureBox1.Width) / 2, 22);
            this.btnYes.Location = new Point((this.Width - btnYes.Width) / 2, 145);
            this.lblcontent.Location = new Point((this.Width - lblcontent.Width) / 2, 104);
            this.AcceptButton = btnYes;


        }
        //Chưa hoàn thành.
        public DialogResult show_(string content)
        {
            this.lblcontent.Text = content.Trim();
            this.ShowDialog();

            return DialogResult;

        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
