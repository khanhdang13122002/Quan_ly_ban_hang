using QuanLyBanHang.DTO.UIMessage;
using QuanLyBanHang.Models.DAO;
using System;
using System.Threading;
using System.Windows.Forms;
using QuanLyBanHang.DTO.UILoading;
namespace QuanLyBanHang.DTO.UIAuth

{
    public partial class frmResigter : Form
    {
        protected frmError smbError = new frmError();
        protected frmSuccess msbSuccess = new frmSuccess();

        protected AuthDAO auth = new AuthDAO();
        public frmResigter()
        {
           
            InitializeComponent();
        }

        private void AddLoad()
        {
            frmLoading load = new frmLoading();
            load.ShowDialog();
        }

        private void frmResigter_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnResigter;
            this.ActiveControl = txtUserName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        void resigter()
        {
            string user = txtUserName.Text.Trim();
            string pass = txtPasword.Text.Trim();
            string conf_pass = txtPasswordConfirm.Text.Trim();
            if (user.Equals("") || pass.Equals("") || conf_pass.Equals(""))
            {
                txtUserName.Focus();
                if (pass.Equals(""))
                {
                    txtPasword.Focus();

                }
                else if (conf_pass.Equals(""))
                {
                    txtPasswordConfirm.Focus();
                }
            }
            else
            {
                Thread th = new Thread(AddLoad);
                th.Start();
                if (pass == conf_pass)
                {
                    bool checkRes = auth.resigter(user, pass);


                    if (checkRes)
                    {
                        th.Abort();
                        if (msbSuccess.show_("Đăng Ký Thành Công") == DialogResult.OK)
                        {
                            this.Close();
                        }

                    }
                    else
                    {
                        th.Abort();
                        smbError.show_("Đăng Ký Thất Bại");

                    }
                }
                else
                {
                    smbError.show_("Mật Khẩu Không Đúng");
                }

            }

        }
        private void btnResigter_Click(object sender, EventArgs e)
        {
            resigter();
        }

        private void frmResigter_KeyDown(object sender, KeyEventArgs e)
        {
            /*txtUserName.Focus();*/
        }

        private void Brand_Click(object sender, EventArgs e)
        {

        }
    }
}
