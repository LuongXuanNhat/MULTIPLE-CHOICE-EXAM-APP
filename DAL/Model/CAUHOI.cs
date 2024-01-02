namespace PhanMemThiTracNghiem.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("CAUHOI")]
    public partial class CAUHOI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAUHOI()
        {
        /*    CHITIETDETHI = new HashSet<CHITIETDETHI>();*/
        }

        public int STT { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MACAUHOI { get; set; }

        [StringLength(500)]
        public string NDCAUHOI { get; set; }

        [Required]
        [StringLength(200)]
        public string DAPAN1 { get; set; }

        [Required]
        [StringLength(200)]
        public string DAPAN2 { get; set; }

        [Required]
        [StringLength(200)]
        public string DAPAN3 { get; set; }

        [Required]
        [StringLength(200)]
        public string DAPAN4 { get; set; }

        [Required]
        [StringLength(200)]
        public string DAPANDUNG { get; set; }

        [Required]
        [StringLength(15)]
        public string MAGV { get; set; }

        [StringLength(40)]
        public string MAMT { get; set; }

      //  public virtual GIANGVIEN GIANGVIEN { get; set; }

    /*    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDETHI> CHITIETDETHI { get; set; }*/

      //  public virtual MONTHI MONTHI { get; set; }

        public static void Delete(int macauhoi)
        {
            DuLieuDAL duLieuDAL = new DuLieuDAL();
            CAUHOI ac = duLieuDAL.CAUHOI.Where(p => p.MACAUHOI == macauhoi).FirstOrDefault();
            try
            {
                duLieuDAL.CAUHOI.Remove(ac);
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
            context.CAUHOI.AddOrUpdate(this);
            context.SaveChanges();
        }
    }
}
