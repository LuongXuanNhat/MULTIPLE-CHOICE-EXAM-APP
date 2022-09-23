using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PhanMemThiTracNghiem.DAL
{
    public partial class GiangVienDAL : DbContext
    {
        public GiangVienDAL()
            : base("name=GiangVienDAL")
        {
        }

        public virtual DbSet<GIANGVIEN> GIANGVIEN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GIANGVIEN>()
                .Property(e => e.MAGV)
                .IsUnicode(false);
        }
    }
}
