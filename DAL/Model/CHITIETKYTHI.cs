namespace PhanMemThiTracNghiem.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETKYTHI")]
    public partial class CHITIETKYTHI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(11)]
        public string MAKITHI { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string MAMT { get; set; }

        public double? DIEM { get; set; }

        public int? THOIGIANTHI { get; set; }

        public DateTime? THOIGIANBD { get; set; }

        public DateTime? THOIGIANKT { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string MASV { get; set; }

        public virtual BANGDIEM BANGDIEM { get; set; }

        public virtual KITHI KITHI { get; set; }

        public virtual MONTHI MONTHI { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
