using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.DTO;
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

namespace PhanMemThiTracNghiem.UI.Admin.KyThi
{
    public partial class frmThemChiTiet : Form
    {
        private readonly DuLieuDAL duLieuDAL;
        private string makithi;
        private string tenkithi;


        public frmThemChiTiet()
        {
            InitializeComponent();
           
        }
        public frmThemChiTiet(string makt,string tenkt)
        {
            InitializeComponent();
            duLieuDAL = new DuLieuDAL();
            this.makithi = makt;
            this.tenkithi = tenkt;
        }

        private void frmThemChiTiet_Load(object sender, EventArgs e)
        {
             labelMaKiThi.Text = makithi.ToString();
              labelTenKiThi.Text = tenkithi.ToString();
            List<MONTHI> listmonthi = duLieuDAL.MONTHI.ToList();
            foreach (var item in listmonthi)
            {
                cbMonThi.Items.Add(item.TENMT);
            }
            List<CHITIETKYTHI> list = duLieuDAL.CHITIETKYTHI.ToList();  
            dgvdemo.DataSource = list;      



        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DateTime thoiGianBatDau = datetimeBD.Value;
            DateTime thoiGianKetThuc = datetimeKT.Value;
            int thoigianthi = (thoiGianKetThuc.Hour * 60 + thoiGianKetThuc.Minute) - (thoiGianBatDau.Hour * 60 + thoiGianBatDau.Minute);
            string tenmt = cbMonThi.Text;
            string loaimt="";
            List<MONTHI> listmonthi = duLieuDAL.MONTHI.Where(p => p.TENMT == tenmt).ToList();
            var users = duLieuDAL.SINHVIEN.ToList();
            foreach (var item in listmonthi)
            {
                loaimt = item.MAMT;
            }
            try
            {
                foreach (var user in users)
                {
                    ChiTietKiThiDTO chiTietKiThiDTO = new ChiTietKiThiDTO();
                    chiTietKiThiDTO.MaKiThi = makithi.ToString();
                    chiTietKiThiDTO.MaMonThi = loaimt.ToString();
                    chiTietKiThiDTO.Diem = 0.0;
                    chiTietKiThiDTO.ThoiGianBD = datetimeBD.Value;
                    chiTietKiThiDTO.ThoiGianKT = datetimeKT.Value;
                    chiTietKiThiDTO.ThoiGianThi = thoigianthi;
                    chiTietKiThiDTO.MaSinhVien = user.MASV;
                    ChiTietKyThiBAL.InsertUpdate(chiTietKiThiDTO);
                }
                MessageBox.Show("Cập nhập thành công");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


       

     

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            DateTime thoiGianBatDau = datetimeBD.Value;
            DateTime thoiGianKetThuc = datetimeKT.Value;
            int thoigianthi = (thoiGianKetThuc.Hour * 60 + thoiGianKetThuc.Minute) - (thoiGianBatDau.Hour * 60 + thoiGianBatDau.Minute);
            if (datetimeBD.Value == null && datetimeKT.Value == null)
            {
                MessageBox.Show("Chưa nhập thời gian bắt đầu hoặc kết thúc");
            }
            else if (datetimeBD.Value > datetimeKT.Value)
            {
                MessageBox.Show("Thời gian bắt đầu không được lớn hơn thời gian kết thúc");
            }
            else
            {
                btnKiemTra.Text = thoigianthi.ToString();
            }
        }

        private void datetimeKT_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
