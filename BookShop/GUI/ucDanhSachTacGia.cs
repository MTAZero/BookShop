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
    public partial class ucDanhSachTacGia : UserControl
    {
        private BookShopContext db = Helper.db;
        private int index = 0, index1 = 0;

        #region constructor
        public ucDanhSachTacGia()
        {
            InitializeComponent();
            Helper.Reload();
        }
        #endregion

        #region Hàm chức năng

        private TACGIA getTACGIAByID()
        {
            try
            {
                int id = (int)dgvTacGia.GetFocusedRowCellValue("ID");
                TACGIA ans = db.TACGIAs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new TACGIA();
                return ans;
            }
            catch
            {
                return new TACGIA();
            }
        }

        private TACGIA getTACGIAByForm()
        {
            TACGIA ans = new TACGIA();

            try
            {
                ans.TEN = txtTenTacGia.Text;
                ans.GIOITINH = cbxGioiTinh.SelectedIndex;
                ans.NGAYSINH = dateNgaySinh.DateTime;
                ans.EMAIL = txtEmail.Text;
                ans.DIACHI = txtDiaChi.Text;

                ans.ANH = Helper.imageToByteArray(imgAnh.Image);
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            cbxGioiTinh.SelectedIndex = 0;
            dateNgaySinh.DateTime = DateTime.Now;

            txtTenTacGia.Text = "";
            txtTitleTenTacGia.Text = "";
            txtTitleNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";

            imgAnh.Image = null;
        }

        private void UpdateDetail()
        {
            try
            {
                TACGIA TACGIA = getTACGIAByID();

                if (TACGIA.ID == 0) return;

                txtTenTacGia.Text = TACGIA.TEN;
                txtTitleTenTacGia.Text = TACGIA.TEN;
                txtTitleNgaySinh.Text = ((DateTime)TACGIA.NGAYSINH).ToString("dd/MM/yyyy");
                dateNgaySinh.DateTime = (DateTime)TACGIA.NGAYSINH;
                txtEmail.Text = TACGIA.EMAIL;
                txtDiaChi.Text = TACGIA.DIACHI;

                cbxGioiTinh.SelectedIndex = (int)TACGIA.GIOITINH;

                imgAnh.Image = null;
                imgAnh.Image = Helper.byteArrayToImage(TACGIA.ANH);
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenTacGia.Enabled = false;
            dateNgaySinh.Enabled = false;
            cbxGioiTinh.Enabled = false;
            txtEmail.Enabled = false;
            txtDiaChi.Enabled = false;
            imgAnh.Enabled = false;

            dgvTacGiaMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenTacGia.Enabled = true;
            dateNgaySinh.Enabled = true;
            cbxGioiTinh.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            imgAnh.Enabled = true;

            dgvTacGiaMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (imgAnh.Image == null)
            {
                MessageBox.Show("Ảnh của tác giả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTenTacGia.Text == "")
            {
                MessageBox.Show("Họ tên của tác giả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckLuaChon()
        {
            TACGIA tg = getTACGIAByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có tác giả nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref TACGIA cu, TACGIA moi)
        {
            cu.TEN = moi.TEN;
            cu.GIOITINH = moi.GIOITINH;
            cu.NGAYSINH = moi.NGAYSINH;
            cu.EMAIL = moi.EMAIL;
            cu.DIACHI = moi.DIACHI;
            cu.ANH = moi.ANH;
        }

        #endregion

        #region LoadForm

        private void LoadInitControl()
        {
            ClearControl();
        }

        private void LoadDgvTACGIA()
        {
            int i = 0;
            string keyWord = txtTimKiem.Text.Trim().ToUpper();
            var listNv = db.TACGIAs.ToList()
                           .Select(p => new
                           {
                               ID = p.ID,
                               HoTen = p.TEN
                           })
                                        .ToList();
            dgvTacGiaMain.DataSource = listNv.ToList()
                                         .Where(p => p.HoTen.ToUpper().Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             HoTen = p.HoTen
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvTacGia.FocusedRowHandle = index;
                dgvTacGiaMain.Select();
            }
            catch
            {

            }

        }

        private void ucDanhSachTacGia_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvTACGIA();
            LockControl();
        }

        #endregion

        #region Sự kiện ngầm

        private void dgvTacGia_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvTacGia.FocusedRowHandle;
            }
            catch { }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvTACGIA();
            txtTimKiem.Focus();
        }

        #endregion

        #region sự kiện

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

                    TACGIA moi = getTACGIAByForm();
                    db.TACGIAs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin tác giả thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin tác giả thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvTACGIA();
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

                    TACGIA cu = getTACGIAByID();
                    TACGIA moi = getTACGIAByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin tác giả thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin tác giả thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvTACGIA();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                TACGIA cu = getTACGIAByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa tác giả " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.TACGIAs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin tác giả thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin tác giả thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvTACGIA();

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


    }
}
