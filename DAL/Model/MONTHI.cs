namespace PhanMemThiTracNghiem.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;

    [Table("MONTHI")]
    public partial class MONTHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONTHI()
        {
            CAUHOI = new HashSet<CAUHOI>();
            CHITIETKYTHI = new HashSet<CHITIETKYTHI>();
            DETHI = new HashSet<DETHI>();
        }

        public int? STT { get; set; }

        [Key]
        [StringLength(40)]
        public string MAMT { get; set; }

        [Required]
        [StringLength(50)]
        public string TENMT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAUHOI> CAUHOI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETKYTHI> CHITIETKYTHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETHI> DETHI { get; set; }


        public void InsertUpdate()
        {
            DuLieuDAL context = new DuLieuDAL();
            context.MONTHI.AddOrUpdate(this);
            context.SaveChanges();
        }
    }
}
