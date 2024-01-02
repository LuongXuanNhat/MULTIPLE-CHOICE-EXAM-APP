using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;

namespace PhanMemThiTracNghiem.DAL
{
    class ChiTietDeThiDAL
    {
        private readonly DuLieuDAL cauHoi;
        public ChiTietDeThiDAL()
        {
            cauHoi = new DuLieuDAL();
        }
        public List<CHITIETDETHI> GetCauHoi()
        {
            return cauHoi.CHITIETDETHI.ToList();
        }

        public static void InsertUpdate(ChiTietDeThiDTO chiTietDeThiDTO)
        {
            CHITIETDETHI cHITIETDETHI = new CHITIETDETHI();
            cHITIETDETHI.MADETHI = chiTietDeThiDTO.MaDeThi;
            cHITIETDETHI.MACAUHOI = chiTietDeThiDTO.MaCauHoi;
            cHITIETDETHI.MUCDO = chiTietDeThiDTO.CapDo;
            cHITIETDETHI.InsertUpdate();
        }
       
    }
}

