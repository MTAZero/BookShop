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
        #endregion


    }
}
