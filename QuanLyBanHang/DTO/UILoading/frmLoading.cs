using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuanLyBanHang.DTO.UILoading
{
    public partial class frmLoading : Form
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
        public frmLoading()
        {
            InitializeComponent();
            AddLoading();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }
        void AddLoading()
        {
            UCLoading loading = new UCLoading();
            guna2Panel1.Controls.Add(loading);

        }
        private void frmLoading_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
