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
        int id_;
        protected frmSuccess msbSuccess = new frmSuccess();
        protected frmError mbsErr = new frmError();
        public UCUser(int id,string key)
        {
            id_ = id;
            InitializeComponent();
            LoadData(key);
        }
        private void UCUser_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        // Load danh sách user
        private void LoadData(string key)
        {
                UsersDAO dao = new UsersDAO();
                gnDgvUsers.DataSource = dao.GetAll(key);
        }

        private void gnBtnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void gnBtnAdd_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser(id_);
            frm.IsAdd = true;
            frm.ShowDialog();
            if (frm.Result) LoadData(null);
        }

        private void gnBtnEdit_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser(id_);
            int getID = (int)gnDgvUsers.CurrentRow.Cells["userId"].Value;
            frm.IsAdd = false;
            frm.UserId = getID;
            frm.ShowDialog();
            if (frm.Result) LoadData(null);
        }

        private void gnBtnDelete_Click(object sender, EventArgs e)
        {
            UsersDAO dao = new UsersDAO();
            int getID = (int)gnDgvUsers.CurrentRow.Cells["userId"].Value;
            if (dao.Delete(getID,id_))
            {
                msbSuccess.show_("Xóa Thành Công");
                gnDgvUsers.DataSource = dao.GetAll(null);
            }
            else
            {
                mbsErr.show_("Xóa Thất Bại");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
