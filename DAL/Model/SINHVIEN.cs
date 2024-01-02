namespace PhanMemThiTracNghiem.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            CHITIETKYTHI = new HashSet<CHITIETKYTHI>();
        }

        public int STT { get; set; }

        [Key]
        [StringLength(15)]
        public string MASV { get; set; }

        [Required]
        [StringLength(10)]
        public string LOP { get; set; }

        [Required]
        [StringLength(50)]
        public string TENSV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYSINH { get; set; }

        [Required]
        [StringLength(20)]
        public string MATKHAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETKYTHI> CHITIETKYTHI { get; set; }


        public static void Delete(string magv)
        {
            DuLieuDAL duLieuDAL = new DuLieuDAL();
            SINHVIEN ac = duLieuDAL.SINHVIEN.Where(p => p.MASV == magv).FirstOrDefault();
            try
            {
                duLieuDAL.SINHVIEN.Remove(ac);
                duLieuDAL.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertUpdate()
        {
            DuLieuDAL context = new DuLieuDAL();
            context.SINHVIEN.AddOrUpdate(this);
            context.SaveChanges();
        }
    }
}
