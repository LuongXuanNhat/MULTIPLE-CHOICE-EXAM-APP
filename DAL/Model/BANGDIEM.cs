namespace PhanMemThiTracNghiem.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGDIEM")]
    public partial class BANGDIEM
    {
        public int? ID { get; set; }

        public double? DIEM { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string MASV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(11)]
        public string MAKITHI { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string MAMT { get; set; }

        public virtual CHITIETKYTHI CHITIETKYTHI { get; set; }
    }
}
