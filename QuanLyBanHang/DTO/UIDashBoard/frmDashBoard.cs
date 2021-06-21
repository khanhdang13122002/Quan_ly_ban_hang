using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using QuanLyBanHang.DTO.UIProducts;
using QuanLyBanHang.Models.DAO;
using QuanLyBanHang.Models.EF;
using QuanLyBanHang.DTO.UIAnalytics;
using System.Drawing;
using QuanLyBanHang.DTO.UIHistories;
using System.IO;

namespace QuanLyBanHang.DTO.UIDashBoard
{
    public partial class frmDashBoard : Form
    {
        protected string Active = "";
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
        int auth_id;
        public frmDashBoard(int userId)
        {
            InitializeComponent();
            auth_id = userId;
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
            UCAnalytics ucAnatlytics = new UCAnalytics(auth_id);
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
            loadProduct(null);
        }
        public void loadProduct(string key)
        {
            UCProducts ucPro = new UCProducts(key,auth_id);
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
            UCHistory ucHis = new UCHistory();
            plnContent_.Controls.Clear();
            plnContent_.Controls.Add(ucHis);
            
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
                    loadProduct(key);
                }
                if (Active.Contains(btnProucts.Name))
                {
                    loadProduct(key);
                }
                if (Active.Contains(btnAnalytics.Name))
                {

                }
            }
            else
            {
                if (Active.Contains(btnProucts.Name)) {
                    plnContent_.Controls.Clear();
                    loadProduct(null);
                }
            }
        }
    }
}
