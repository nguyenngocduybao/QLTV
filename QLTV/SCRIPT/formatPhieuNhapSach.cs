﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatPhieuNhapSach
    {
        private static formatPhieuNhapSach instance;

        internal static formatPhieuNhapSach Instance
        {
            get
            {
                if (instance == null) instance = new formatPhieuNhapSach(); return SCRIPT.formatPhieuNhapSach.instance;
            }

            private set
            {
                SCRIPT.formatPhieuNhapSach.instance = value;
            }
        }
        public string returnIDPhieuNhapSach(string id)
        {
            string IDDocGia;
            IDDocGia = "INS" + id;
            return IDDocGia;
        }
        public void checkPhieuNhapSach(string IDPhieuNhap,string NgayNhap,string TongTien)
        {
            if(IDPhieuNhap=="") MessageBox.Show("Không được để trống ID phiếu nhập sách", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(NgayNhap=="") MessageBox.Show("Không được để trống ngày nhập", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(TongTien=="") MessageBox.Show("Không được để trống tổng tiền", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
