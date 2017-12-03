using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public static class Helper
    {

        #region Database
        public static BookShopContext db = new BookShopContext();

        public static void Reload()
        {
            try
            {
                var context = ((IObjectContextAdapter)db).ObjectContext;
                var refreshableObjects = (from entry in context.ObjectStateManager.GetObjectStateEntries(
                                                           EntityState.Added
                                                           | EntityState.Deleted
                                                           | EntityState.Modified
                                                           | EntityState.Unchanged)
                                          where entry.EntityKey != null
                                          select entry.Entity).ToList();

                context.Refresh(RefreshMode.StoreWins, refreshableObjects);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        #endregion

        #region Hàm chức năng

        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        #endregion

        public static string TenSanPham(MATHANG a)
        {
            string ans = "";

            if (a.LOAISP == 0) return db.SACHes.Where(p => p.ID == a.SACHID).FirstOrDefault().TEN;
            if (a.LOAISP == 1) return db.VANPHONGPHAMs.Where(p => p.ID == a.VANPHONGPHAMID).FirstOrDefault().TEN;

            return ans;
        }

        public static int IDSanPham = 0; // sản phẩm lựa chọn

    }
}
