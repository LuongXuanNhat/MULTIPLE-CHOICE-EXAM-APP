namespace PhanMemThiTracNghiem.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("GIANGVIEN")]
    public partial class GIANGVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIANGVIEN()
        {
            CAUHOI = new HashSet<CAUHOI>();
        }

        public int? STT { get; set; }

        [Key]
        [StringLength(15)]
        public string MAGV { get; set; }

        [Required]
        [StringLength(50)]
        public string TENGV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYSINH { get; set; }

        [Required]
        [StringLength(20)]
        public string MATKHAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAUHOI> CAUHOI { get; set; }



        public static void Delete(string magv)
        {
            DuLieuDAL duLieuDAL = new DuLieuDAL();
            GIANGVIEN ac = duLieuDAL.GIANGVIEN.Where(p => p.MAGV == magv).FirstOrDefault();
            try
            {
                duLieuDAL.GIANGVIEN.Remove(ac);
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
            context.GIANGVIEN.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static GIANGVIEN GETGiangVien(string magv)
        {
            DuLieuDAL duLieuDAL = new DuLieuDAL();
            return duLieuDAL.GIANGVIEN.Where(p => p.MAGV == magv).FirstOrDefault();
        }
    }
}
