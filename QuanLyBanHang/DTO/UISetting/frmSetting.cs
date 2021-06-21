using Guna.UI2.WinForms;
using QuanLyBanHang.DTO.UIMessage;
using QuanLyBanHang.Models.DAO;
using QuanLyBanHang.Models.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.DTO.UISetting
{
    public partial class frmSetting : Form
    {
        protected frmSuccess msbSuccess = new frmSuccess();
        protected frmError mbsErr = new frmError();

        private int userID;
        public int UserID
        {
            set { userID = value; }
        }

        public frmSetting(int id)
        {
            userID = id;
            InitializeComponent();
        }

        private bool CheckEmptyData(Guna2TextBox data)
        {
            bool mark = false;
            if (!String.IsNullOrEmpty(data.Text))
            {
                mark = true;
            }
            else
            {
                epError.SetError(data, "Hãy điền đầy đủ thông tin");
                data.Focus();
            }
            return mark;
        }

        // check xem email đã tồn tại chưa
        private bool CheckEmail(Guna2TextBox data)
        {
            UsersDAO dao = new UsersDAO();
            bool mark = false;
            string email = txtEmail.Text; // lấy email người dùng nhập vào
            User count = dao.GetEmail(email); // lấy ra sinh viên có email đã nhập (nếu có)

            if (count != null)
            {
                epError.SetError(data, "Email này đã tồn tại!");
                data.Focus();
            }
            else
            {
                mark = true;
            }
            return mark;
        }

        // validate email
        private bool FormatEmail(Guna2TextBox data)
        {
            bool mark = false;
            string email = txtEmail.Text; // lấy email người dùng nhập vào
            var regexEmail = new Regex(@"^[^\d]+\w*@\w+\.[a-zA-Z]{3}$");

            if (!regexEmail.IsMatch(email))
            {
                epError.SetError(data, "Email của bạn sai định dạng!");
                data.Focus();
            }
            else
            {
                mark = true;
            }
            return mark;
        }

        // format số điện thoại cá nhân
        private bool FormatPhonenumber(Guna2TextBox data)
        {
            bool mark = false;
            string phonenumber = txtPhoneNumber.Text;
            var regexPhonenumber = new Regex(@"^[03|09]\d{9}$");

            if (!regexPhonenumber.IsMatch(phonenumber))
            {
                epError.SetError(data, "Số điện thoại cá nhân của bạn không phù hợp!");
                data.Focus();
            }
            else
            {
                mark = true;
            }
            return mark;
        }

        // kiểm tra mật khẩu nhập lại có trùng với mật khẩu mới k
        private bool CheckConfirmPass(Guna2TextBox data)
        {
            bool mark = false;
            string newPassword = txtNewPassword.Text;
            string confirmNewPassword = txtConfirmNewPass.Text;
            if (newPassword != confirmNewPassword)
            {
                epError.SetError(data, "Mật khẩu không trùng khớp");
                data.Focus();
            } else
            {
                mark = true;
            }
            return mark;
        }

        /*chuyen image sang byte de save vao db*/
        byte[] ConvertImage(Image img)
        {
            if (img != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            return null;
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

        private void frmSetting_Load(object sender, EventArgs e)
        {
            UsersDAO dao = new UsersDAO();
            var getUser = dao.GetSingleByID(userID);
            if (getUser != null)
            {
                txtUserName.Text = getUser.UserName;
                txtEmail.Text = getUser.Email;
                txtPhoneNumber.Text = getUser.Sdt;
                txtAddress.Text = getUser.Address_;
                txtDesc_.Text = getUser.Desc_;
                ptbAvatar.Image = ByteArrayToImage(getUser.Avatar);
            } else
            {
                this.Close();
            }
        }

        private void ptbAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            string filePath = "";
            if (open.FileName != null)
            {
                if (filePath != open.FileName)
                {
                    filePath = open.FileName;
                    ptbAvatar.Image = Image.FromFile(filePath);
                }
            }
        }

        private User InitUser()
        {
            User user = new User();
            user.UserName = txtUserName.Text.Trim();
            user.Email = txtEmail.Text.Trim();
            user.Address_ = txtAddress.Text.Trim();
            user.Sdt = txtPhoneNumber.Text.Trim();
            user.Desc_ = txtDesc_.Text.Trim();
            user.Avatar = ConvertImage(ptbAvatar.Image);
            return user;
        }

        private Auth InitAuth()
        {
            Auth auth = new Auth();
            auth.username = txtUserName.Text.Trim();
            auth.password_ = txtNewPassword.Text;
            return auth;
        }

        private void CallUpdateFunc()
        {
            UsersDAO dao = new UsersDAO();
            var getInfo = InitUser();
            if (dao.Update(getInfo, userID))
            {
                msbSuccess.show_("Sửa Thành Công");
                this.Close();
            }
            else
            {
                mbsErr.show_("Sửa Thất Bại");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UsersDAO dao = new UsersDAO();
            User temp = dao.GetSingleByID(userID);
            if (CheckEmptyData(txtUserName) && CheckEmptyData(txtEmail) && CheckEmptyData(txtAddress)
                    && CheckEmptyData(txtPhoneNumber) && FormatPhonenumber(txtPhoneNumber))
            {
                epError.Clear();
                if (CheckEmptyData(txtNewPassword) && CheckEmptyData(txtConfirmNewPass))
                {
                    if (CheckConfirmPass(txtConfirmNewPass))
                    {
                        epError.Clear();
                        AuthDAO authDAO = new AuthDAO();
                        var getAuthInfo = InitAuth();
                        if (authDAO.Update(getAuthInfo, userID))
                        {
                            msbSuccess.show_("Sửa Thành Công");
                            this.Close();
                        }
                        else
                        {
                            mbsErr.show_("Sửa Thất Bại");
                        }
                    }
                } else
                {
                    epError.Clear();
                    if (txtEmail.Text == temp.Email.Trim())
                    {
                        CallUpdateFunc();
                    }
                    else
                    {
                        if (FormatEmail(txtEmail) && CheckEmail(txtEmail))
                        {
                            CallUpdateFunc();
                        }
                    }
                }
            }
        }
    }
}
