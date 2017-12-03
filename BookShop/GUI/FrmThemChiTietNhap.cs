using BookShop.Model;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.GUI
{
    public partial class FrmThemChiTietNhap : MetroForm
    {
        public FrmThemChiTietNhap()
        {
            InitializeComponent();
        }

        #region Hàm chức năng
        private void Loadz()
        {
            try
            {
                MATHANG mh = Helper.db.MATHANGs.Where(p => p.ID == Helper.IDSanPham).First();
                if (mh != null)
                {
                    txtTenMatHang.Text = Helper.TenSanPham(mh);

                }
            }
            catch { }
        }

        private void TinhThanhTien()
        {
            Int64 gt = (Int64) txtSoLuong.Value *  (Int64) txtDonGia.Value;
            txtThanhTien.Text = gt.ToString("N0");
        }

        #endregion

        #region Sự kiện
        private void btnChon_Click(object sender, EventArgs e)
        {
            FrmLuaChonSanPham form = new FrmLuaChonSanPham();
            this.Hide();
            form.Focus();
            form.ShowDialog();
            this.Show();
            this.Focus();

            Loadz();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Sự kiện ngầm
        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtDonGia_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }
        #endregion

        #region LoadForm
        private void FrmThemChiTietNhap_Load(object sender, EventArgs e)
        {
            Loadz();
        }
        #endregion
    }
}
