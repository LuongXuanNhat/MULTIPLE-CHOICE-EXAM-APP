using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;

namespace PhanMemThiTracNghiem.DAL
{
    class ChiTietDeThiBAL
    {
        private readonly  ChiTietDeThiDAL danhMucCauHoiDAL;
        public ChiTietDeThiBAL()
        {
            danhMucCauHoiDAL = new ChiTietDeThiDAL();
        }
        public List<CHITIETDETHI> GetCauHoi()
        {
            return danhMucCauHoiDAL.GetCauHoi(); 
        }


        public static void InsertUpdate(ChiTietDeThiDTO chiTietDeThiDTO)
        {
            ChiTietDeThiDAL.InsertUpdate(chiTietDeThiDTO);
        }
    }
}
