using PhanMemThiTracNghiem.BAL;
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

namespace PhanMemThiTracNghiem.UI.SinhVien
{
    public partial class frmSinhVien : Form
    {
        DuLieuDAL duLieuDAL = new DuLieuDAL();

        ChiTietKyThiBAL chiTietKyThiBAL;
        MonThiBAL monThiBAL;
        KyThiBAL kyThiBAL;
        SINHVIEN sinhVien ;
        MONTHI monThi;
        DateTime thoiGianThiGanNhat = DateTime.Now;
        DateTime thoiGianThi ;
        DateTime thoiGianKetThuc;

        public frmSinhVien(SINHVIEN sv)
        {
            InitializeComponent();
            chiTietKyThiBAL = new ChiTietKyThiBAL();
            kyThiBAL = new KyThiBAL();
            monThiBAL = new MonThiBAL();
            sinhVien = sv;
        }
        public frmSinhVien(SINHVIEN sv, int i)
        {
            InitializeComponent();
            chiTietKyThiBAL = new ChiTietKyThiBAL();
            kyThiBAL = new KyThiBAL();
            sinhVien = sv;
            btnVaoThi.Enabled = false;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            btnXemDiem.Hide();
           // Tìm kỳ thi trong thời gian hiện tại
            foreach (var item in kyThiBAL.GetThongTinKyThi())
            {
                if(item.THOIGIANBDKITHI < thoiGianThiGanNhat && item.THOIGIANKTKITHI > thoiGianThiGanNhat)
                {
                    lblTenKyThi.Text = item.TENKITHI + " : " + item.MAKITHI;
                    lblTenKyThi.Text = lblTenKyThi.Text.ToUpper();
                    lblTenKyThi.Name = item.MAKITHI;
                }
            }

            // Lấy thời gian so sánh tìm thông tin gần nhất 
            thoiGianThiGanNhat = new DateTime(1 / 1 / 2000);
            foreach (var item in chiTietKyThiBAL.GetThongTinChiTietKyThi())
            {
                if (lblTenKyThi.Name == item.MAKITHI && item.MASV == sinhVien.MASV)
                {
                    
                    lblHoTen.Text = sinhVien.TENSV;
                    lblLop.Text = sinhVien.LOP;
                    if (thoiGianThiGanNhat < item.THOIGIANBD)
                    {
                        thoiGianThiGanNhat = (DateTime)item.THOIGIANBD;
                        foreach (var i in monThiBAL.GetThongTinMonThi())
                        {
                            if (i.MAMT == item.MAMT)
                            {
                                lblMonThi.Text = i.TENMT;
                                lblMonThi.Name = item.MAMT;
                                monThi = i;
                                break;
                            }
                        }
                        
                        lblNgayThi.Text = item.THOIGIANTHI.ToString();
                        lblThoiGianBatDau.Text = item.THOIGIANBD.ToString();
                        lblThoiGianKetThuc.Text = item.THOIGIANKT.ToString();
                        thoiGianThi = (DateTime)item.THOIGIANBD;
                        thoiGianKetThuc = (DateTime)item.THOIGIANKT;
                    }
                }
            }
        }

        // Bỏ kiểm tra trường hợp ngày thay đổi "Thi đêm"
        private bool KiemTraThoiGianVaoThi()
        {

            if (DateTime.Now.Year == thoiGianThi.Year && DateTime.Now.Month == thoiGianThi.Month && DateTime.Now.Day == thoiGianThi.Day 
                && (DateTime.Now.Hour <= thoiGianThi.Hour || DateTime.Now.Hour <= thoiGianKetThuc.Hour))
            {
                if (DateTime.Now.Hour == thoiGianThi.Hour -1 && DateTime.Now.Minute == 59 && DateTime.Now.Second >= 30 
                    || (DateTime.Now.Hour < thoiGianKetThuc.Hour && DateTime.Now.Hour > thoiGianThi.Hour) 
                    || (DateTime.Now.Hour == thoiGianKetThuc.Hour && DateTime.Now.Minute < thoiGianKetThuc.Minute))
                {
                    return true;                  
                }
                else
                {
                    if (DateTime.Now.Hour == thoiGianThi.Hour && DateTime.Now.Minute < thoiGianThi.Minute - 1 && DateTime.Now.Second >= 30 || DateTime.Now < thoiGianKetThuc
                        || (DateTime.Now.Hour == thoiGianKetThuc.Hour && DateTime.Now.Minute < thoiGianKetThuc.Minute) )
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                
            }
            else
            {
                return false;
            }
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            frmBangDiem frmBangDiem = new frmBangDiem(sinhVien);
            this.Hide();
            frmBangDiem.ShowDialog();         
            this.Close();



        }
        private void btnVaoThi_Click(object sender, EventArgs e)
        {
            if (KiemTraThoiGianVaoThi() == true)
            {
                frmThi frmThi = new frmThi(sinhVien, monThi, DateTime.Now,thoiGianKetThuc);
                this.Hide();
                frmThi.WindowState = FormWindowState.Maximized;
                frmThi.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa đến thời gian bắt đầu thi \nHiện tại là: " + DateTime.Now.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
