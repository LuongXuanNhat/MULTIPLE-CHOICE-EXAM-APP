namespace PhanMemThiTracNghiem.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIANGVIEN")]
    public partial class GIANGVIEN
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(15)]
        public string MAGV { get; set; }

        [Required]
        [StringLength(50)]
        public string TENGV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYSINH { get; set; }
    }
}
