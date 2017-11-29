﻿using MetroFramework.Forms;
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
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Sự kiện mở các form chức năng
        private void barNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachNhanVien uc = new ucDanhSachNhanVien();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachDauSach uc = new ucDanhSachDauSach();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        

        private void barTheLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachTheLoai uc = new ucDanhSachTheLoai();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
        

        private void barNhaXuatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachNhaXuatBan uc = new ucDanhSachNhaXuatBan();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucNhapHang uc = new ucNhapHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucBanHang uc = new ucBanHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barTimKiemSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucTimKiemSach uc = new ucTimKiemSach();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barVanPhongPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachVanPhongPham uc = new ucDanhSachVanPhongPham();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barThongKeBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucThongKeBanHang uc = new ucThongKeBanHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
        private void barTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachTacGia uc = new ucDanhSachTacGia();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }


        #endregion

        private void barThongTinCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongTinCaNhan form = new FrmThongTinCaNhan();
            form.ShowDialog();
        }

        private void barDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDoiMatKhau form = new FrmDoiMatKhau();
            form.ShowDialog();
        }
    }
}
