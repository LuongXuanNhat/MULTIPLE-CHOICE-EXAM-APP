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
    }
}
