namespace PhanMemThiTracNghiem.DAL.Model
{
    using PhanMemThiTracNghiem.DAL.DTO;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDETHI")]
    public partial class CHITIETDETHI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MADETHI { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MACAUHOI { get; set; }

        [StringLength(50)]
        public string MUCDO { get; set; }

        /*        public virtual CAUHOI CAUHOI { get; set; }

                public virtual DETHI DETHI { get; set; }*/

        public void InsertUpdate()
        {
            DuLieuDAL context = new DuLieuDAL();
            context.CHITIETDETHI.AddOrUpdate(this);
            context.SaveChanges();
        }
    }
}
