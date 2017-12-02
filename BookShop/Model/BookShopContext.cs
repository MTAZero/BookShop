namespace BookShop.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookShopContext : DbContext
    {
        public BookShopContext()
            : base("name=BookShopContext")
        {
        }

        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<CHITIETNHAP> CHITIETNHAPs { get; set; }
        public virtual DbSet<HOADONBAN> HOADONBANs { get; set; }
        public virtual DbSet<KHO> KHOes { get; set; }
        public virtual DbSet<MATHANG> MATHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NXB> NXBs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }
        public virtual DbSet<VANPHONGPHAM> VANPHONGPHAMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
