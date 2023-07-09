using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.Model;

namespace PhanMemThiTracNghiem.DAL
{
    class BangDiemDAL
    {
        private readonly DuLieuDAL diemThi;
        public BangDiemDAL()
        {
            diemThi = new DuLieuDAL();
        }
        public List<BANGDIEM> GetThongTinDiem()
        {
            return diemThi.BANGDIEM.ToList();
        }
        
        public bool LuuDiemThi(int ID, float DIEM, string MASV, string MAKT, string MAMT)
        {
            diemThi.BANGDIEM.Add(new BANGDIEM() { ID = ID, DIEM = DIEM, MASV = MASV, MAKITHI = MAKT, MAMT = MAMT } );
            diemThi.SaveChanges();
            return true;
        }

        public bool LuuDiemThi(BANGDIEM LuuDiemThi)
        {
            try
            {
                diemThi.BANGDIEM.Add(LuuDiemThi);
                diemThi.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

