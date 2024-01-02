using Microsoft.Reporting.WinForms;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemThiTracNghiem.UI.SinhVien;

namespace PhanMemThiTracNghiem.UI.SinhVien
{
    public partial class frmBangDiem : Form
    {
        private readonly SINHVIEN sinhVien;
        public frmBangDiem(SINHVIEN sv)
        {
            InitializeComponent();
            sinhVien = sv;
            
        }

        private void frmBangDiem_Load(object sender, EventArgs e)
        {
            DuLieuDAL duLieuDAL  = new DuLieuDAL();
            List<BANGDIEM> listBangDiem = new List<BANGDIEM>();
            List<BANGDIEMreport> listReportBangDiem = new List<BANGDIEMreport>();
            listBangDiem = duLieuDAL.BANGDIEM.ToList();

            // Mã số sinh viên label
            lblMaSoSinhVien.Text = sinhVien.TENSV +" | "+ sinhVien.MASV;

            foreach (BANGDIEM item in listBangDiem)
            {
                if (sinhVien.MASV == item.MASV)
                {
                    BANGDIEMreport diem = new BANGDIEMreport();
                    diem.ID = item.ID;
                    diem.MAKITHI = item.MAKITHI;
                    diem.MASV = item.MASV;
                    diem.DIEM = item.DIEM;
                    diem.MAMT = item.MAMT;
                    listReportBangDiem.Add(diem);
                }                                                                              
            }
            if(listReportBangDiem.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu điểm! Vui lòng chờ cập nhập");
            }
            else
            {
                this.reportViewer1.LocalReport.ReportPath = "./UI/SinhVien/ReportBangDiem.rdlc";
                var reportDatasource = new ReportDataSource("BangDiemDataSet", listReportBangDiem);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDatasource);

                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
            }           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmSinhVien frmSinhVien = new frmSinhVien(sinhVien);
            this.Hide();
            frmSinhVien.ShowDialog();
            this.Close();
            
        }
    }
}
