using System;
using System.Windows.Forms;
using QuanLyBanHang.Models.DAO;
namespace QuanLyBanHang.DTO.UIAuth
{
    public partial class frmResigter : Form
    {
        protected AuthDAO auth = new AuthDAO();
        public frmResigter()
        {
            InitializeComponent();
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
                if (pass == conf_pass)
                {
                    bool checkRes = auth.resigter(user, pass);


                    if (checkRes)
                    {
                        if (MessageBox.Show("ok") == DialogResult.OK)
                        {
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("no");

                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận không đúng");
                }
                
            }

        }
        private void btnResigter_Click(object sender, EventArgs e)
        {
            resigter();
        }
    }
}
