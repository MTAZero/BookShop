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
    public partial class ucLapPhieuNhap : UserControl
    {
        private PHIEUNHAP pn = new PHIEUNHAP();
        private BookShopContext db = Helper.db;

        #region Hàm khởi tạo
        public ucLapPhieuNhap()
        {
            InitializeComponent();
            Helper.Reload();
            pn = db.PHIEUNHAPs.Where(p => p.ID == Helper.IDPhieuNhap).FirstOrDefault();
            if (pn == null) pn = new PHIEUNHAP();
        }
        #endregion

        #region Hàm chức năng

        private PHIEUNHAP getPhieuNhapByForm()
        {
            PHIEUNHAP ans = new PHIEUNHAP();
            ans.MAPHIEUNHAP = txtMaPhieuNhap.Text;
            ans.NGAY = dateNgayBan.DateTime;
            ans.NHANVIENID = (int) cbxNhanVien.EditValue;
            ans.TONGTIEN = Int32.Parse(txtChiPhi.Text);
            

            return ans;
        }

        #endregion

        #region LoadForm

        private void LoadInitControl()
        {
            cbxNhanVien.Properties.DataSource = db.NHANVIENs.Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxNhanVien.Properties.DisplayMember = "Ten";
            cbxNhanVien.Properties.ValueMember = "ID";

            cbxNhanVien.Enabled = false;
            dateNgayBan.Enabled = false;

            dateNgayBan.DateTime = DateTime.Now;

            cbxNhanVien.EditValue = (int) Helper.IDNhanVien;
        }

        private void LoadNewPhieuNhap()
        {
            btnLapPhieuNhap.Enabled = true;

            btnThem.Enabled = false;
            btnTra.Enabled = false;
            btnInHoaDon.Enabled = false;
            btnHoanThanhPhieuNhap.Enabled = false;

            dgvChiTietNhapMain.Enabled = false;

            txtMaPhieuNhap.Enabled = true;
        }

        private void LoadOldPhieuNhap()
        {
            txtMaPhieuNhap.Enabled = false;

            txtMaPhieuNhap.Text = pn.MAPHIEUNHAP; txtMaPhieuNhap.Enabled = false;
            dateNgayBan.DateTime = (DateTime)pn.NGAY; dateNgayBan.Enabled = false;
            cbxNhanVien.EditValue = pn.NHANVIENID; cbxNhanVien.Enabled = false;
            txtChiPhi.Text = ((int)pn.TONGTIEN).ToString("N0");

            btnLapPhieuNhap.Enabled = true;

            btnThem.Enabled = true;
            btnTra.Enabled = true;
            btnInHoaDon.Enabled = true;
            btnHoanThanhPhieuNhap.Enabled = true;

            dgvChiTietNhapMain.Enabled = true;

        }
        private void ucLapPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            if (pn.ID == 0)
            {
                LoadNewPhieuNhap();
            }
            else
            {
                LoadOldPhieuNhap();
            }
        }
        #endregion

        #region Sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemChiTietNhap form = new FrmThemChiTietNhap(pn);
            form.ShowDialog();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnHoanThanhPhieuNhap_Click(object sender, EventArgs e)
        {
            Helper.IDPhieuNhap = 0;
            dateNgayBan.DateTime = DateTime.Now;
            Helper.IDPhieuNhap = 0;

            MessageBox.Show("Hoàn thành thêm phiếu nhập thành côbg",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void btnTra_Click(object sender, EventArgs e)
        {

        }


        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            PHIEUNHAP z = getPhieuNhapByForm();
            db.PHIEUNHAPs.Add(z);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Thêm chi tiết phiếu nhập thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                Helper.IDPhieuNhap = z.ID;
                pn = z;
                LoadOldPhieuNhap();
               
            }
            catch
            {
                
            }
        }
        #endregion


    }
}
