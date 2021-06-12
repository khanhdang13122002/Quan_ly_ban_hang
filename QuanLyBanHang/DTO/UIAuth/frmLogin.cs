using QuanLyBanHang.Models.DAO;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang.DTO.UIAuth
{
    public partial class frmLogin : Form
    {
        protected AuthDAO auth = new AuthDAO();
        protected frmResigter frmres = new frmResigter();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmAuth_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserName;
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string user_name = txtUserName.Text.Trim();
            string pass_ = txtPassword.Text.Trim();
            if (user_name.Equals("") || pass_.Equals(""))
            {
                txtUserName.Focus();
                if (pass_.Equals("")) { txtPassword.Focus();}
            }
            else
            {
                bool checkLogin = auth.login(user_name, pass_);
                if (checkLogin)
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("No");

                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void frmRes_FormClosed(object sender, FormClosedEventArgs e)
        {  
            this.Show();
            if (!frmres.txtUserName.Text.Trim().Equals("") && !frmres.txtPasword.Text.Trim().Equals(""))
            {
                txtUserName.Text = frmres.txtUserName.Text.Trim();
                txtPassword.Text = frmres.txtPasword.Text.Trim();
            }
           
        }
      
        private void lblResigter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmres.FormClosed += new FormClosedEventHandler(frmRes_FormClosed);
            frmres.Activate();
            frmres.ShowDialog();
           
        }
    }
}
