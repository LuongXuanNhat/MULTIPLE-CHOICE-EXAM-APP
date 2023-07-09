using PhanMemThiTracNghiem.DAL;
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
    }
}
