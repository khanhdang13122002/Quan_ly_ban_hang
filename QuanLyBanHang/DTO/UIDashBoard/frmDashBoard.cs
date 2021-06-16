using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using QuanLyBanHang.DTO.UIProducts;
using QuanLyBanHang.Models.DAO;
using QuanLyBanHang.Models.EF;
using QuanLyBanHang.DTO.UIAnalytics;
using System.Drawing;
using System.IO;

namespace QuanLyBanHang.DTO.UIDashBoard
{
    public partial class frmDashBoard : Form
    {
        protected string Active = "";
        protected ProductsDAO prDao = new ProductsDAO();
        protected UCProducts ucPro = new UCProducts();
        protected DashBoardDAO dashDao = new DashBoardDAO();

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
        public frmDashBoard(int userId)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 6, 6));
            pnlNav(btnAnalytics.Top, btnAnalytics.Height);
            loadUcAnallytics();
            loadUserData(userId);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void pnlNav(int location_,int height) {
            this.plnActiveNav.Top = location_;
            this.plnActiveNav.Height = height;
            
        }
        void loadUcAnallytics()
        {
            plnContent_.Controls.Clear();
            UCAnalytics ucAnatlytics = new UCAnalytics();
            plnContent_.Controls.Add(ucAnatlytics);
            Active = btnAnalytics.Name;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnlNav(btnAnalytics.Top,btnAnalytics.Height);
            Active = btnAnalytics.Name;
            loadUcAnallytics(); 
            
        }
       
        private void btnProucts_Click(object sender, EventArgs e)
        {
            loadProduct();
        }
        public void loadProduct()
        {
            pnlNav(btnProucts.Top, btnProucts.Height);
            Active = btnProucts.Name;
            plnContent_.Controls.Clear();
            plnContent_.Controls.Add(ucPro);
        }
        private void btnUsersManager_Click(object sender, EventArgs e)
        {
            Active = btnUsersManager.Name;
            pnlNav(btnUsersManager.Top, btnUsersManager.Height);

        }

        private void btnHistories_Click(object sender, EventArgs e)
        {
            Active = btnHistories.Name;
            pnlNav(btnHistories.Top, btnHistories.Height);

        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            pnlNav(btnSetting.Top, btnSetting.Height);
        }
        void loadUserData(int user_id) {
            User user_ = dashDao.getUser(user_id);
            lblUserName.Text = user_.UserName;
            if (user_.Avatar != null)
            {
                ptbAvatar.Image =  ByteArrayToImage(user_.Avatar);
            }
        }
        public Image ByteArrayToImage(byte[] byteArr)
        {
            if (byteArr != null)
            {
                using (MemoryStream ms = new MemoryStream(byteArr))
                {
                    Image img = Image.FromStream(ms);
                    return img;
                }
            }
            else
            {
                return null;
            }

        }
        private void plnNavbarTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim();
            if (key != null)
            {
                if (Active.Contains(btnAnalytics.Name))
                {
                    loadProduct();
                }
                if (Active.Contains(btnAnalytics.Name))
                {

                }
                if (Active.Contains(btnAnalytics.Name))
                {

                }
            }
            else
            {
                
            }
        }
    }
}
