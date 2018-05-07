﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLTV.GUI
{
    public partial class frmCTPhieuNhapSach : DevExpress.XtraEditors.XtraForm
    {
        public frmCTPhieuNhapSach()
        {
            InitializeComponent();
        }

        private void frmCTPhieuNhapSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUNHAPSACH' table. You can move, or remove it, as needed.
            this.pHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUNHAPSACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_PHIEUNHAPSACH' table. You can move, or remove it, as needed.
            this.cT_PHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUNHAPSACH);

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatCTPhieuNhapSach.Instance.checkCTPhieuNhapSach(tb_IDCTPhieuNhap.Text, cbb_IDPhieuNhap.Text, cbb_IDSach.Text, tb_SoLuong.Text, tb_DonGia.Text);
            if (tb_DonGia.Text != "" && tb_IDCTPhieuNhap.Text != "" && tb_SoLuong.Text != ""  && cbb_IDPhieuNhap.Text != "" && cbb_IDSach.Text != "")
            {
                ADO.adoCTPhieuNhapSach.Instance.Them(tb_IDCTPhieuNhap.Text, cbb_IDPhieuNhap.Text, cbb_IDSach.Text, tb_SoLuong.Text, tb_DonGia.Text);
                this.cT_PHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUNHAPSACH);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }        

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {

        }

        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}