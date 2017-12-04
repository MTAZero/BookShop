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
    public partial class ucDanhSachVanPhongPham : UserControl
    {
        private BookShopContext db = Helper.db;
        private int index = 0, index1 = 0;

        #region constructor
        public ucDanhSachVanPhongPham()
        {
            InitializeComponent();
            Helper.Reload();
        }
        #endregion

        #region Hàm chức năng

        private VANPHONGPHAM getVANPHONGPHAMByID()
        {
            try
            {
                int id = (int)dgvVANPHONGPHAM.GetFocusedRowCellValue("ID");
                VANPHONGPHAM ans = db.VANPHONGPHAMs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new VANPHONGPHAM();
                return ans;
            }
            catch
            {
                return new VANPHONGPHAM();
            }
        }

        private VANPHONGPHAM getVANPHONGPHAMByForm()
        {
            VANPHONGPHAM ans = new VANPHONGPHAM();

            try
            {
                ans.NHASANXUAT = txtNhaSanXuat.Text;
                ans.TEN = txtTen.Text;
                ans.THONGTIN = txtThongTin.Text;
                ans.NGAYSANXUAT = dateNgaySanXuat.DateTime;
                ans.GIABAN = Int32.Parse(txtGiaBan.Text);
                ans.ANH = Helper.imageToByteArray(imgAnh.Image);
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            dateNgaySanXuat.DateTime = DateTime.Now;
            txtTen.Text = "";
            txtThongTin.Text = "";
            txtGiaBan.Text = "";
            txtNhaSanXuat.Text = "";
            imgAnh.Image = null;

            txtTitleNhaSanXuat.Text = "";
            txtTitleTen.Text = "";
        }

        private void UpdateDetail()
        {
            try
            {
                VANPHONGPHAM ans = getVANPHONGPHAMByID();

                if (ans.ID == 0) return;

                dateNgaySanXuat.DateTime = (DateTime)ans.NGAYSANXUAT;
                txtTen.Text = ans.TEN;
                txtThongTin.Text = ans.THONGTIN;
                txtGiaBan.Text = ans.GIABAN.ToString();
                txtNhaSanXuat.Text = ans.NHASANXUAT;

                txtTitleTen.Text = ans.TEN;
                txtTitleNhaSanXuat.Text = ans.NHASANXUAT;

                imgAnh.Image = null;
                imgAnh.Image = Helper.byteArrayToImage(ans.ANH);
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTen.Enabled = false;
            txtNhaSanXuat.Enabled = false;
            txtGiaBan.Enabled = false;
            dateNgaySanXuat.Enabled = false;
            txtThongTin.Enabled = false;
            imgAnh.Enabled = false;

            dgvVANPHONGPHAMMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void UnlockControl()
        {
            txtTen.Enabled = true;
            txtNhaSanXuat.Enabled = true;
            txtGiaBan.Enabled = true;
            dateNgaySanXuat.Enabled = true;
            txtThongTin.Enabled = true;
            imgAnh.Enabled = true;

            dgvVANPHONGPHAMMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (imgAnh.Image == null)
            {
                MessageBox.Show("Ảnh của văn phòng phẩm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTen.Text == "")
            {
                MessageBox.Show("Họ tên của văn phòng phẩm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtNhaSanXuat.Text == "")
            {
                MessageBox.Show("Nhà sản của văn phòng phẩm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            try
            {
                int giaban = Int32.Parse(txtGiaBan.Text);
                giaban = giaban / giaban;
            }
            catch
            {
                MessageBox.Show("Giá bán của sản phẩm phải là số nguyên dương",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
           
            return true;
        }

        private bool CheckLuaChon()
        {
            VANPHONGPHAM tg = getVANPHONGPHAMByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có văn phòng phẩm nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref VANPHONGPHAM cu, VANPHONGPHAM moi)
        {
            cu.TEN = moi.TEN;
            cu.NHASANXUAT = moi.NHASANXUAT;
            cu.NGAYSANXUAT = moi.NGAYSANXUAT;
            cu.THONGTIN = moi.THONGTIN;
            cu.GIABAN = moi.GIABAN;
            cu.ANH = moi.ANH;
        }

        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            ClearControl();
        }

        private void LoadDgvVANPHONGPHAM()
        {
            int i = 0;
            string keyWord = txtTimKiem.Text.Trim().ToUpper();
            var listNv = db.VANPHONGPHAMs.ToList()
                           .Select(p => new
                           {
                               ID = p.ID,
                               Ten = p.TEN,
                               NSX = p.NHASANXUAT
                           })
                                        .ToList();
            dgvVANPHONGPHAMMain.DataSource = listNv.ToList()
                                         .Where(p => p.Ten.ToUpper().Contains(keyWord) || p.NSX.ToUpper().Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             Ten = p.Ten,
                                             NSX = p.NSX
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvVANPHONGPHAM.FocusedRowHandle = index;
                dgvVANPHONGPHAMMain.Select();
            }
            catch
            {

            }

        }

        private void ucDanhSachVanPhongPham_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvVANPHONGPHAM();
            LockControl();
        }
        #endregion

        #region Sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnSua.Enabled = false;
                btnThem.Text = "Lưu";
                btnXoa.Text = "Hủy";

                ClearControl();
                UnlockControl();

                return;
            }

            if (btnThem.Text == "Lưu")
            {
                if (Check())
                {
                    btnThem.Text = "Thêm";
                    btnXoa.Text = "Xóa";
                    LockControl();

                    VANPHONGPHAM moi = getVANPHONGPHAMByForm();
                    db.VANPHONGPHAMs.Add(moi);

                    try
                    {
                        db.SaveChanges();

                        MATHANG mh = new MATHANG();
                        mh.LOAISP = 1;
                        mh.SOLUONG = 0;
                        mh.VANPHONGPHAMID = moi.ID;
                        db.MATHANGs.Add(mh);
                        db.SaveChanges();

                        MessageBox.Show("Thêm thông tin văn phòng phẩm thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin văn phòng phẩm thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvVANPHONGPHAM();
                }
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChon()) return;

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnXoa.Text = "Hủy";
                btnThem.Enabled = false;

                UnlockControl();

                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Check())
                {
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";

                    LockControl();

                    VANPHONGPHAM cu = getVANPHONGPHAMByID();
                    VANPHONGPHAM moi = getVANPHONGPHAMByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin văn phòng phẩm thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin văn phòng phẩm thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvVANPHONGPHAM();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                VANPHONGPHAM cu = getVANPHONGPHAMByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa văn phòng phẩm " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    MATHANG mh = db.MATHANGs.Where(p => p.LOAISP == 1 && p.VANPHONGPHAMID == cu.ID).FirstOrDefault();
                    if (mh != null) db.MATHANGs.Remove(mh);

                    db.VANPHONGPHAMs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin văn phòng phẩm thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin văn phòng phẩm thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvVANPHONGPHAM();

                return;
            }
            if (btnXoa.Text == "Hủy")
            {
                btnSua.Text = "Sửa";
                btnThem.Text = "Thêm";
                btnXoa.Text = "Xóa";

                LockControl();
                UpdateDetail();
                return;
            }
        }

        private void imgAnh_Click(object sender, EventArgs e)
        {
            string path = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                path = open.FileName;
            }
            catch
            {

            }

            try
            {
                Image image = Image.FromFile(path);

                imgAnh.Image = image;
            }
            catch
            {
                MessageBox.Show("Định dạng ảnh không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        #endregion

        #region Sự kiện ngầm
        private void dgvVanPhongPham_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvVANPHONGPHAM.FocusedRowHandle;
            }
            catch { }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvVANPHONGPHAM();
            txtTimKiem.Focus();
        }
        #endregion
    }
}
