using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.GUI
{
    public partial class ucLapPhieuNhap : UserControl
    {
        public ucLapPhieuNhap()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemChiTietNhap form = new FrmThemChiTietNhap();
            form.ShowDialog();
        }
    }
}
