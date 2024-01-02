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
    class KyThiDAL
    {
        private readonly DuLieuDAL kyThi;
        public KyThiDAL()
        {
            kyThi = new DuLieuDAL();
        }
        public List<KITHI> GetThongTinKyThi()
        {
            return kyThi.KITHI.ToList();
        }

        public static void InsertUpdate(KiThiDTO kiThiDTO)
        {

            KITHI kithi = new KITHI();
            kithi.ID = kiThiDTO.ID;
            kithi.MAKITHI = kiThiDTO.MaKiThi;
            kithi.TENKITHI = kiThiDTO.TenKiThi;
            kithi.ADMIN = kiThiDTO.Admin;
            kithi.THOIGIANBDKITHI = kiThiDTO.ThoiGianBD;
            kithi.THOIGIANKTKITHI = kiThiDTO.ThoiGianKT;
            kithi.InsertUpdate();
        }

       

        public List<KITHI> GetKITHIs()
        {
            return kyThi.KITHI.ToList();
        }

        public List<KITHI> GetNameKITHI()
        {
            return kyThi.KITHI.ToList();
        }
    }
}

