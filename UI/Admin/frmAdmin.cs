using PhanMemThiTracNghiem.BAL;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;
using PhanMemThiTracNghiem.UI.Admin.DanhSachGiangVien;
using PhanMemThiTracNghiem.UI.Admin.DanhSachSinhVien;
using PhanMemThiTracNghiem.UI.Admin.DeThi;
using PhanMemThiTracNghiem.UI.Admin.KyThi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemThiTracNghiem.UI.Admin
{
    public partial class frmAdmin: Form
    {
        private readonly GiangVienBAL giangVienBAL;
        private readonly SinhVienBAL sinhVienBAL;
        private readonly QuanTriBAL quanTriBAL;
        private readonly QUANTRI quanTri;
        private readonly KyThiBAL kyThiBAL;
        private readonly DuLieuDAL duLieuDAL;
        private readonly MonThiBAL monThiBAL;
     
        
        public frmAdmin(QUANTRI qt)
        {
            InitializeComponent();
            giangVienBAL = new GiangVienBAL();
            sinhVienBAL = new SinhVienBAL();
            quanTriBAL = new QuanTriBAL();
            kyThiBAL = new KyThiBAL();
            duLieuDAL = new DuLieuDAL();
            monThiBAL = new MonThiBAL();
            quanTri = qt;
        }

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnNhapExcelGiangVien_Click(object sender, EventArgs e)
        {
            
            NhapExcelGiangVien nhapExcelGiangVien = new NhapExcelGiangVien(this);
            nhapExcelGiangVien.ShowDialog();
        }

        public void frmAdmin_Load(object sender, EventArgs e)
        {
            labelAdmin.Text = quanTri.ADMIN.ToString();
            dgvDanhSachGiangVien.DataSource = giangVienBAL.GetGIANGVIENs();
            dgvDanhSachSinhVien.DataSource = sinhVienBAL.GetSINHVIENs();
           
            foreach (var item in kyThiBAL.GetKITHIs())
            {
                cbTenKiThi1.Items.Add(item.TENKITHI);
            }
            cbTenKiThi1.SelectedIndex = -1;
            foreach (var item in monThiBAL.GetThongTinMonThi())
            {
                cbTenMonThi.Items.Add(item.TENMT);
            }
            cbTenMonThi.SelectedIndex = -1;
            List<KITHI> listKiThi = duLieuDAL.KITHI.ToList();
            LoadDGVKiThi(listKiThi);
           
            
        }

        private void LoadDGVKiThi(List<KITHI> listkithi)
        {
            dgvKiThi.Rows.Clear();
            foreach (var item in listkithi)
            {
                int index = dgvKiThi.Rows.Add();
                dgvKiThi.Rows[index].Cells["colSTT"].Value = item.ID;
                dgvKiThi.Rows[index].Cells["colMaKiThi"].Value = item.MAKITHI;
                dgvKiThi.Rows[index].Cells["colTenKiThi"].Value = item.TENKITHI;
                dgvKiThi.Rows[index].Cells["colThoiGianBD"].Value = item.THOIGIANBDKITHI;
                dgvKiThi.Rows[index].Cells["colThoiGianKT"].Value = item.THOIGIANKTKITHI;
            }
        }

   

        private void dgvDanhSachGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDanhSachGiangVien.CurrentRow.Selected = true;
            txtMaGiangVien.Text = dgvDanhSachGiangVien.Rows[e.RowIndex].Cells["MAGV"].FormattedValue.ToString();
            txtTenGiangVien.Text = dgvDanhSachGiangVien.Rows[e.RowIndex].Cells["TENGV"].FormattedValue.ToString();
            dtNgaySinhGiangVien.Value = DateTime.Parse(dgvDanhSachGiangVien.Rows[e.RowIndex].Cells["NGAYSINH"].FormattedValue.ToString());
            txtMatKhauGiangVien.Text = dgvDanhSachGiangVien.Rows[e.RowIndex].Cells["MATKHAU"].FormattedValue.ToString();
        }

        private void dgvDanhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDanhSachSinhVien.CurrentRow.Selected = true;
            txtMaSinhVien.Text = dgvDanhSachSinhVien.Rows[e.RowIndex].Cells["MASV"].FormattedValue.ToString();
            txtLopSinhVien.Text = dgvDanhSachSinhVien.Rows[e.RowIndex].Cells["LOP"].FormattedValue.ToString();
            txtTenSinhVien.Text = dgvDanhSachSinhVien.Rows[e.RowIndex].Cells["TENSV"].FormattedValue.ToString();
            dtNgaySinhSinhVien.Value = DateTime.Parse(dgvDanhSachSinhVien.Rows[e.RowIndex].Cells["NGAYSINH"].FormattedValue.ToString());
        }

        private void btnCapNhapGiangVien_Click(object sender, EventArgs e)
        {
            try
            {
                string magv = txtMaGiangVien.Text;
                string tengv = txtTenGiangVien.Text;
                DateTime ngaysinh = dtNgaySinhGiangVien.Value;
                string matkhau = txtMatKhauGiangVien.Text;
                giangVienBAL.CapNhapGiangVien(magv,tengv,ngaysinh,matkhau);
                
                MessageBox.Show("Cập nhập thành công!");
                frmAdmin_Load(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }

        private void btnNhapMotGiangVien_Click(object sender, EventArgs e)
        {
            ThemMotGiangVien themMot = new ThemMotGiangVien(this);
            themMot.ShowDialog();
        }

        private void btnXoaMotGiangVien_Click(object sender, EventArgs e)
        {
            dgvDanhSachGiangVien.CurrentRow.Selected = true;
            string r = dgvDanhSachGiangVien.SelectedRows[0].Cells[1].Value.ToString();
            try
            {
                GiangVienBAL.Delete(r);
                MessageBox.Show("Xóa thành công !!!");
                dgvDanhSachGiangVien.DataSource = giangVienBAL.GetGIANGVIENs();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiemGiangVien_TextChanged(object sender, EventArgs e)
        {
            string tengv = txtTimKiemGiangVien.Text.Trim();
            if (tengv == "")
            {
                frmAdmin_Load(sender, e);
            }
            else
            {
                dgvDanhSachGiangVien.DataSource  = giangVienBAL.FindName(tengv);
            }
        }

        private void btnNhapExcelSinhVien_Click(object sender, EventArgs e)
        {
            NhapExcelSinhVien nhapExcelSinhVien = new NhapExcelSinhVien(this);
            nhapExcelSinhVien.ShowDialog();
        }

        private void btnThemMotSinhVien_Click(object sender, EventArgs e)
        {
            ThemMotSinhVien themMotSinhVien = new ThemMotSinhVien(this);
            themMotSinhVien.ShowDialog();
        }

        private void btnXoaMotSinhVien_Click(object sender, EventArgs e)
        {
            dgvDanhSachSinhVien.CurrentRow.Selected = true;
            string r = dgvDanhSachSinhVien.SelectedRows[0].Cells[1].Value.ToString();
            try
            {
                SinhVienBAL.Delete(r);
                MessageBox.Show("Xóa thành công !!!");
                dgvDanhSachSinhVien.DataSource = sinhVienBAL.GetSINHVIENs();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhapSV_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = txtMaSinhVien.Text;
                string lop = txtLopSinhVien.Text;
                string tensv = txtTenSinhVien.Text;
                DateTime ngaysinh = dtNgaySinhSinhVien.Value;
                sinhVienBAL.CapNhapSinhVien(masv,lop, tensv, ngaysinh);
                MessageBox.Show("Cập nhập thành công!");
                frmAdmin_Load(sender,e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiemSinhVien_TextChanged(object sender, EventArgs e)
        {
            string tensv = txtTimKiemSinhVien.Text.Trim();
            if (tensv == "")
            {
                frmAdmin_Load(sender, e);
            }
            else
            {
                dgvDanhSachSinhVien.DataSource = sinhVienBAL.FindName(tensv);
            }
        }



      

        private void btnThemMonThi_Click(object sender, EventArgs e)
        {
            try
            {
                MonThiDTO monthi = new MonThiDTO();
                monthi.STT++;
                monthi.MaMT = txtMaMonThi.Text;
                monthi.TenMT = txtTenMonThi.Text;
                MonThiBAL.InsertUpdate(monthi);
                frmAdmin_Load(sender, e);
                MessageBox.Show("Thêm thành công!");
                txtMaMonThi.Clear();
                txtTenMonThi.Clear();
                frmAdmin_Load(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemKiThi_Click_1(object sender, EventArgs e)
        {
            try
            {
                KiThiDTO kithi = new KiThiDTO();
                kithi.ID++;
                kithi.MaKiThi = txtMaKiThi.Text;
                kithi.TenKiThi = txtTenKiThi.Text;
                kithi.Admin = quanTri.ADMIN.ToString();
                kithi.ThoiGianBD = dateBD.Value;
                kithi.ThoiGianKT = dateKT.Value;
                frmThemChiTiet frmThemChiTiet = new frmThemChiTiet(txtMaKiThi.Text, txtTenKiThi.Text);
                frmThemChiTiet.ShowDialog();
                KyThiBAL.InsertUpdate(kithi);
                frmAdmin_Load(sender, e);
                MessageBox.Show("Thêm thành công!");
                txtMaKiThi.Clear();
                txtTenKiThi.Clear();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemDeThi_Click(object sender, EventArgs e)
        {
            string tenkithi = cbTenKiThi1.Text;
            string makithi = "";
            List<KITHI> listkithi = duLieuDAL.KITHI.Where(p => p.TENKITHI == tenkithi).ToList();
            foreach (var item in listkithi)
            {
                makithi = item.MAKITHI;
            }
            string tenmonthi = cbTenMonThi.Text;
            string mamonthi = "";
            List<MONTHI> listmontthi = duLieuDAL.MONTHI.Where(p => p.TENMT == tenmonthi).ToList();
            foreach (var item in listmontthi)
            {
                mamonthi = item.MAMT;
            }
            try
            {

                DeThiDTO dethi = new DeThiDTO();
                dethi.ID++;
                dethi.MaDeThi = txtMaDeThi.Text;
                dethi.MaKiThi = makithi;
                dethi.MaMonThi = mamonthi;               
                DeThiBAL.InsertUpdate(dethi);
                frmAdmin_Load(sender, e);
                frmAdmin_Load(sender, e);

                // Mở chi tiết đề thi chỉnh sửa
                ChiTietDeThi chiTietDeThi = new ChiTietDeThi(txtMaDeThi.Text);
                chiTietDeThi.ShowDialog();
                txtMaDeThi.Clear();
                cbTenKiThi1.SelectedIndex = -1;
                cbTenMonThi.SelectedIndex = -1;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvKiThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvKiThi.CurrentRow.Selected = true;
            txtMaKiThi.Text = dgvKiThi.Rows[e.RowIndex].Cells["colMaKiThi"].FormattedValue.ToString();
            txtTenKiThi.Text = dgvKiThi.Rows[e.RowIndex].Cells["colTenKiThi"].FormattedValue.ToString();
            dateBD.Value =DateTime.Parse( dgvKiThi.Rows[e.RowIndex].Cells["colThoiGianBD"].FormattedValue.ToString());
            dateKT.Value = DateTime.Parse(dgvKiThi.Rows[e.RowIndex].Cells["colThoiGianKT"].FormattedValue.ToString());

        }

        private void dgvKiThi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string makithi = dgvKiThi.Rows[e.RowIndex].Cells["colMaKiThi"].FormattedValue.ToString();
            string tenkithi = dgvKiThi.Rows[e.RowIndex].Cells["colTenKiThi"].FormattedValue.ToString();
            frmChiTietKiThi frmChiTietKiThi = new frmChiTietKiThi(makithi,tenkithi);
            frmChiTietKiThi.ShowDialog();   
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
