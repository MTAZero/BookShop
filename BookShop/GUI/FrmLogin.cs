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
    public partial class FrmLogin : MetroForm
    {
        private BookShopContext db = Helper.db;

        #region Hàm khởi tạo
        public FrmLogin()
        {
            InitializeComponent();
            Helper.Reload();
        }
        #endregion

        #region Sự kiện
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
