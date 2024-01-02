using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.DAL
{
    internal class CauHoiDAL
    {
        private readonly DuLieuDAL cauHoi;
        public CauHoiDAL()
        {
            cauHoi = new DuLieuDAL();
        }
        public List<CAUHOI> GetThongTinCauHoi()
        {
            return cauHoi.CAUHOI.ToList();
        }


        public static void InsertUpdate(CauHoiDTO cauHoiDTO)
        {
            CAUHOI cAUHOI = new CAUHOI();
            cAUHOI.STT = cauHoiDTO.STT;
            cAUHOI.MACAUHOI = cauHoiDTO.MaCauHoi;
            cAUHOI.NDCAUHOI = cauHoiDTO.NDCAUHOI;
            cAUHOI.DAPAN1 = cauHoiDTO.DapAn1;
            cAUHOI.DAPAN2 = cauHoiDTO.DapAn2;
            cAUHOI.DAPAN3 = cauHoiDTO.DapAn3;
            cAUHOI.DAPAN4 = cauHoiDTO.DapAn4;
            cAUHOI.DAPANDUNG = cauHoiDTO.DapAnDung;
            cAUHOI.MAGV = cauHoiDTO.MaGiaoVien;
            cAUHOI.MAMT = cauHoiDTO.MaMT;   
            cAUHOI.InsertUpdate();
        }

        public void CapNhapCauHoi(int macauhoi,string noidung, string dapan1,string dapan2, string dapan3,string dapan4, string dapandung,string magv)
        {
            CAUHOI cauhoi = cauHoi.CAUHOI.Find(macauhoi);
          //  cauhoi.MACAUHOI = macauhoi;
            cauhoi.NDCAUHOI = noidung;
            cauhoi.DAPAN1 = dapan1;
            cauhoi.DAPAN2 = dapan2;
            cauhoi.DAPAN3 = dapan3;
            cauhoi.DAPAN4 = dapan4;
            cauhoi.DAPANDUNG = dapandung;
            cauhoi.MAGV = magv;
            cauHoi.SaveChanges();
        }



        public List<CAUHOI> GetCAUHOIs()
        {
            return cauHoi.CAUHOI.ToList();
        }


        public List<CAUHOI> FindName(string mamon)
        {
            return cauHoi.CAUHOI.Where(p => p.MAMT.Contains(mamon.Trim())).ToList();
        }
    }
}
