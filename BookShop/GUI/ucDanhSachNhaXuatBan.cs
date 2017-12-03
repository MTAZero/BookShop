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
    public partial class ucDanhSachNhaXuatBan : UserControl
    {
        private BookShopContext db = Helper.db;
        private int index = 0, index1 = 0;

        #region constructor
        public ucDanhSachNhaXuatBan()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region Hàm chức năng

        private THELOAI getTHELOAIByID()
        {
            try
            {
                int id = (int) dgvNhaXuatBan.GetFocusedRowCellValue("ID");
                THELOAI ans = db.THELOAIs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new THELOAI();
                return ans;
            }
            catch
            {
                return new THELOAI();
            }
        }

        private THELOAI getTHELOAIByForm()
        {
            THELOAI ans = new THELOAI();

            ans.TEN = txtTenNXB.Text;

            return ans;
        }

        private void ClearControl()
        {
            txtTenNXB.Text = "";
        }

        private void UpdateDetail()
        {
            try
            {
                THELOAI tg = getTHELOAIByID();

                if (tg.ID == 0) return;

                txtTenNXB.Text = tg.TEN;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenNXB.Enabled = false;

            dgvNhaXuatBanMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenNXB.Enabled = true;

            dgvNhaXuatBanMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTenNXB.Text == "")
            {
                MessageBox.Show("Tên của nhà xuất bản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            THELOAI tg = getTHELOAIByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có thể loại nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref THELOAI cu, THELOAI moi)
        {
            cu.TEN = moi.TEN;
        }

        #endregion

        #region LoadForm

        private void LoadInitControl()
        {
            ClearControl();
        }

        private void LoadDgvNhanVien()
        {
            int i = 0;
            string keyWord = txtTimKiem.Text.Trim().ToUpper();
            var listTheLoai = db.THELOAIs.ToList()
                           .Select(p => new
                           {
                               ID = p.ID,
                               Ten = p.TEN,
                           })
                           .ToList();
            dgvNhaXuatBanMain.DataSource = listTheLoai.ToList()
                                         .Where(p => p.Ten.ToUpper().Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             Ten = p.Ten,
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvNhaXuatBan.FocusedRowHandle = index;
                dgvNhaXuatBanMain.Select();
            }
            catch
            {

            }

        }

        private void ucDanhSachTheLoai_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvNhanVien();
            LockControl();
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

                    THELOAI moi = getTHELOAIByForm();
                    db.THELOAIs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin thể loại thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin thể loại thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvNhanVien();
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

                    THELOAI cu = getTHELOAIByID();
                    THELOAI moi = getTHELOAIByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin thể loại thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin thể loại thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvNhanVien();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                THELOAI cu = getTHELOAIByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thể loại " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.THELOAIs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin thể loại thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin thể loại thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvNhanVien();

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
        
        #endregion

        #region sự kiện ngầm

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvNhanVien();
            txtTimKiem.Focus();
        }

        private void dgvNhaXuatBan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvNhaXuatBan.FocusedRowHandle;
            }
            catch { }
        }

        #endregion
    }
}
