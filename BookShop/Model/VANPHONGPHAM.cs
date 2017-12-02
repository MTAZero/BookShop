namespace BookShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VANPHONGPHAM")]
    public partial class VANPHONGPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VANPHONGPHAM()
        {
            MATHANGs = new HashSet<MATHANG>();
        }

        public int ID { get; set; }

        public string TEN { get; set; }

        public string NHASANXUAT { get; set; }

        public int? GIABAN { get; set; }

        public DateTime? NGAYSANXUAT { get; set; }

        public string THONGTIN { get; set; }

        [Column(TypeName = "image")]
        public byte[] ANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATHANG> MATHANGs { get; set; }
    }
}
