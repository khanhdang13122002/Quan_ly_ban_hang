using Guna.UI2.WinForms;
using QuanLyBanHang.DTO.UIMessage;
using QuanLyBanHang.Models.DAO;
using QuanLyBanHang.Models.EF;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyBanHang.DTO.UIUsers
{
    public partial class frmUser : Form
    {
        protected frmSuccess msbSuccess = new frmSuccess();
        protected frmError mbsErr = new frmError();

        private bool isAdd = true;
        public bool IsAdd
        {
            set
            {
                isAdd = value;
            }
        }

        private int userId;
        public int UserId
        {
            get { return userId; }

            set
            {
                userId = value;
            }
        }

        private bool result = false;
        public bool Result
        {
            get
            {
                return result;
            }
        }

        public frmUser(int id)
        {
            UserId = id;
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

        // Load form thêm hoặc form sửa
        private void frmUser_Load(object sender, EventArgs e)
        {
            if (!isAdd)
            {
                UsersDAO dao = new UsersDAO();
                lblTitle.Text = "Sửa Thông tin";
                btnAdd.Text = "Sửa";
                var info = dao.GetSingleByID(userId);
                if (info != null)
                {
                    txtUserName.Text = info.UserName;
                    txtEmail.Text = info.Email;
                    txtAddress.Text = info.Address_;
                    txtPhoneNumber.Text = info.Sdt;
                    txtDesc_.Text = info.Desc_;
                    // Avatar
                    ptbAvatar.Image = ByteArrayToImage(info.Avatar);
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                lblTitle.Text = "Thêm người dùng";
            }
        }

        // Hàm này lưu trữ thông tin thêm mới hoặc đc sửa
        private User InitUser()
        {
            User user = new User();
            UsersDAO dao = new UsersDAO();
            if (isAdd)
            {
                int id = dao.getMaxId();
                user.userId = id + 1;
            }
            user.UserName = txtUserName.Text.Trim();
            user.Email = txtEmail.Text.Trim();
            user.Address_ = txtAddress.Text.Trim();
            user.Sdt = txtPhoneNumber.Text.Trim();
            user.Desc_ = txtDesc_.Text.Trim();
            // Avatar
            user.Avatar = ConvertImage(ptbAvatar.Image);
            return user;
        }

        // Thực thi update thông tin
        private void CallUpdateFunc()
        {
            UsersDAO dao = new UsersDAO();
            var getInfo = InitUser();
            if (dao.Update(getInfo, UserId))
            {
                msbSuccess.show_("Sửa Thành Công");
                result = true;
                this.Close();
            }
            else
            {
                mbsErr.show_("Sửa Thất Bại");
            }
        }

        // sự kiện cho nút thêm hoặc sửa
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UsersDAO dao = new UsersDAO();
            var getInfo = InitUser();
            if (isAdd)
            {
                if (CheckEmptyData(txtUserName) && CheckEmptyData(txtEmail) && CheckEmptyData(txtAddress)
                    && CheckEmptyData(txtPhoneNumber) && FormatEmail(txtEmail) && CheckEmail(txtEmail)
                    && FormatPhonenumber(txtPhoneNumber))
                {
                    epError.Clear();
                    if (dao.InsertNewUser(getInfo, UserId))
                    {
                        msbSuccess.show_("Thêm Thành Công");
                        result = true;
                        this.Close();
                    }
                    else
                    {
                        mbsErr.show_("Thêm Thất Bại");
                    }
                }
            }
            else
            {
                User temp = dao.GetSingleByID(userId);
                if (CheckEmptyData(txtUserName) && CheckEmptyData(txtEmail) && CheckEmptyData(txtAddress)
                    && CheckEmptyData(txtPhoneNumber) && FormatPhonenumber(txtPhoneNumber))
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
