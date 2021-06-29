﻿using QuanLyBanHang.Models.DAO;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang.DTO.UIHistories
{
    public partial class UCHistory : UserControl
    {
        public UCHistory()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {

            hisDao hisDAO = new hisDao();
            dgvHis.DataSource = hisDAO.getAll();
        }
        private void UCHistory_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            hisDao hisDAO = new hisDao();
            dgvHis.DataSource = hisDAO.getAllByProducts();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            hisDao hisDAO = new hisDao();
            dgvHis.DataSource = hisDAO.getAllByUsers();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            hisDao hisDAO = new hisDao();
            dgvHis.DataSource = hisDAO.getAllByOrder();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            hisDao hisDAO = new hisDao();
            dgvHis.DataSource = hisDAO.getAll();
        }
    }
}
