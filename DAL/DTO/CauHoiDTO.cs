using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.DAL.DTO
{
    internal class CauHoiDTO
    {


        public CauHoiDTO()
        {
            
        }

        public CauHoiDTO(int sTT, int maCauHoi, string noiDungCauHoi, string dapAn1, string dapAn2, string dapAn3, string dapAn4, string dapAnDung)
        {
            STT = sTT;
            MaCauHoi = maCauHoi;
            NDCAUHOI = noiDungCauHoi;
            DapAn1 = dapAn1;
            DapAn2 = dapAn2;
            DapAn3 = dapAn3;
            DapAn4 = dapAn4;
            DapAnDung = dapAnDung;
        }

        public int STT { get; set; }

        public int MaCauHoi { get; set; }
        public string NDCAUHOI { get; set; }
        public string DapAn1 { get; set; }
        public string DapAn2 { get; set; }
        public string DapAn3 { get; set; }
        public string DapAn4 { get; set; }
        public string DapAnDung { get; set; }
        public string MaGiaoVien { get; set; }
        public string MaMT { get; set; }

    }
}
