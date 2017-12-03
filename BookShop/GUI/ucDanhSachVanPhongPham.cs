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

        #region constructor
        public ucDanhSachVanPhongPham()
        {
            InitializeComponent();
            Helper.Reload();
        }
        #endregion


        #region LoadForm
        private void ucDanhSachVanPhongPham_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void imgAnh_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Sự kiện ngầm
        private void dgvVanPhongPham_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
