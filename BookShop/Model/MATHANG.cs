namespace BookShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MATHANG")]
    public partial class MATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MATHANG()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
            CHITIETNHAPs = new HashSet<CHITIETNHAP>();
        }

        public int ID { get; set; }

        public int? LOAISP { get; set; }

        public int? SACHID { get; set; }

        public int? VANPHONGPHAMID { get; set; }

        public int? SOLUONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAP> CHITIETNHAPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual SACH SACH { get; set; }

        public virtual VANPHONGPHAM VANPHONGPHAM { get; set; }
    }
}
