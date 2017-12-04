namespace BookShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOADON")]
    public partial class CHITIETHOADON
    {
        public int ID { get; set; }

        public int? MATHANGID { get; set; }

        public int? DONGIA { get; set; }

        public int? SOLUONG { get; set; }

        public int? THANHTIEN { get; set; }

        public int? HOADONBANID { get; set; }

        public virtual MATHANG MATHANG { get; set; }

        public virtual HOADONBAN HOADONBAN { get; set; }
    }
}
