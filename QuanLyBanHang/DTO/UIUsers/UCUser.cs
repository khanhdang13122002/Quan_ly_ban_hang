using QuanLyBanHang.DTO.UIMessage;
using QuanLyBanHang.Models.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.DTO.UIUsers
{
    public partial class UCUser : UserControl
    {
        protected frmSuccess msbSuccess = new frmSuccess();
        protected frmError mbsErr = new frmError();
        public UCUser()
        {
            InitializeComponent();
        }
        private void UCUser_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            LoadData();
        }

        // Load danh sách user
        private void LoadData()
        {
            UsersDAO dao = new UsersDAO();
            gnDgvUsers.DataSource = dao.GetAll();
        }

        private void gnBtnSearch_Click(object sender, EventArgs e)
        {
            UsersDAO dao = new UsersDAO();
            gnDgvUsers.DataSource = dao.GetByKeyword(gnTxtKeyword.Text.Trim());
        }

        private void gnBtnAdd_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.IsAdd = true;
            frm.ShowDialog();
            if (frm.Result)
            {
                LoadData();
            }
        }

        private void gnBtnEdit_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            int getID = (int)gnDgvUsers.CurrentRow.Cells["userId"].Value;
            frm.IsAdd = false;
            frm.UserId = getID;
            frm.ShowDialog();
            if (frm.Result)
            {
                LoadData();
            }
        }

        private void gnBtnDelete_Click(object sender, EventArgs e)
        {
            UsersDAO dao = new UsersDAO();
            int getID = (int)gnDgvUsers.CurrentRow.Cells["userId"].Value;
            if (dao.Delete(getID))
            {
                msbSuccess.show_("Xóa Thành Công");
                LoadData();
            } else
            {
                mbsErr.show_("Xóa Thất Bại");
            }     
        }
    }
}
