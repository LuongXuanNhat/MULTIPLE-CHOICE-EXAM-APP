namespace PhanMemThiTracNghiem.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;

    [Table("DETHI")]
    public partial class DETHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DETHI()
        {
            CHITIETDETHI = new HashSet<CHITIETDETHI>();
        }

        public int? ID { get; set; }

        [Key]
        [StringLength(10)]
        public string MADETHI { get; set; }

        [StringLength(11)]
        public string MAKITHI { get; set; }

        [StringLength(40)]
        public string MAMT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDETHI> CHITIETDETHI { get; set; }

        public virtual MONTHI MONTHI { get; set; }

        public void InsertUpdate()
        {
            DuLieuDAL context = new DuLieuDAL();
            context.DETHI.AddOrUpdate(this);
            context.SaveChanges();
        }
    }
}
