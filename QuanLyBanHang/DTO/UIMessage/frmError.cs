using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuanLyBanHang.DTO.UIMessage
{
    public partial class frmError : Form
    {
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
        public frmError()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void frmError_Load(object sender, EventArgs e)
        {
            this.guna2CirclePictureBox1.Location = new Point((this.Width - guna2CirclePictureBox1.Width) / 2, 22);
            this.btnOK.Location = new Point((this.Width - btnOK.Width) / 2, 145);
            this.lblcontent.Location = new Point((this.Width - lblcontent.Width) / 2, 104);
            this.AcceptButton = btnOK;
        }
        public void show_(string content)
        {
            this.lblcontent.Text = content.Trim();
            btnOK.DialogResult = DialogResult.OK;
            this.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblcontent_Click(object sender, EventArgs e)
        {

        }
    }
}
