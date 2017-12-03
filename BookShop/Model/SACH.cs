namespace BookShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            MATHANGs = new HashSet<MATHANG>();
        }

        public int ID { get; set; }

        public string TEN { get; set; }

        public int? NXBID { get; set; }

        public int? TACGIAID { get; set; }

        public int? THELOAIID { get; set; }

        public int? GIABAN { get; set; }

        public int? NAMXUATBAN { get; set; }

        public string THONGTINSACH { get; set; }

        [Column(TypeName = "image")]
        public byte[] ANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATHANG> MATHANGs { get; set; }

        public virtual NXB NXB { get; set; }

        public virtual TACGIA TACGIA { get; set; }

        public virtual THELOAI THELOAI { get; set; }
    }
}
