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
    class MonThiBAL
    {
        private readonly MonThiDAL monThiDAL;
        public MonThiBAL()
        {
            monThiDAL = new MonThiDAL();
        }
        public List<MONTHI> GetThongTinMonThi()
        {
            return monThiDAL.GetThongTinMonThi();
        }

        public static void InsertUpdate(MonThiDTO monThiDTO)
        {
            MonThiDAL.InsertUpdate(monThiDTO);  
        }
    }
}

