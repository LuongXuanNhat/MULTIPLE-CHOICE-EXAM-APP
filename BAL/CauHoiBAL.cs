using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.BAL
{
    internal class CauHoiBAL
    {
        private readonly CauHoiDAL cauHoiDAL;
        public CauHoiBAL()
        {
            cauHoiDAL = new CauHoiDAL();
        }
        public List<CAUHOI> GetThongTinCauHoi()
        {
            return cauHoiDAL.GetThongTinCauHoi();
        }

        public static void InsertUpdate(CauHoiDTO a)
        {
            CauHoiDAL.InsertUpdate(a);
        }


        public void CapNhapCauHoi(int macauhoi, string noidung, string dapan1, string dapan2, string dapan3, string dapan4,string dapandung,string magv)
        {
            cauHoiDAL.CapNhapCauHoi(macauhoi, noidung, dapan1, dapan2, dapan3, dapan4,dapandung,magv);
        }

        public List<CAUHOI> GetCAUHOIs()
        {
            return cauHoiDAL.GetCAUHOIs();
        }

        public static void Delete(int macauhoi)
        {
            CAUHOI.Delete(macauhoi);    
        }

        public List<CAUHOI> FindName(string mamon)
        {
            return cauHoiDAL.FindName(mamon);
        }
    }
    
}
