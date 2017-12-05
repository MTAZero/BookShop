using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.Model;

namespace BookShop.GUI
{
    public partial class ucThongKeBanHang : UserControl
    {
        private BookShopContext db = Helper.db;

        #region Hàm khởi tạo
        public ucThongKeBanHang()
        {
            InitializeComponent();
            Helper.Reload();
        }
        #endregion

        #region LoadForm
        private void Loaddgv()
        {
            int i = 0;
            dgvMatHangMain.DataSource = (
                                         from mathang in db.MATHANGs.ToList()
                                         select new
                                         {
                                             STT = ++i,
                                             MatHang = Helper.TenSanPham(mathang),
                                             DonGia = Helper.GiaSanPham(mathang),
                                             SoLuong = Helper.SoLuong(mathang,dateBatDau.DateTime,dateKetThuc.DateTime),
                                             ThanhTien = ((int)Helper.GiaSanPham(mathang) * Helper.SoLuong(mathang, dateBatDau.DateTime, dateKetThuc.DateTime)).ToString("N0")
                                         })
                                        .ToList();
                                        
        }
        private void ucThongKeBanHang_Load(object sender, EventArgs e)
        {
            dateBatDau.DateTime = DateTime.Now.AddDays(-30);
            dateKetThuc.DateTime = DateTime.Now;
            Loaddgv();
        }
        #endregion

        #region Sự kiện ngầm
        private void dateKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            Loaddgv();
        }
        #endregion
    }
}
