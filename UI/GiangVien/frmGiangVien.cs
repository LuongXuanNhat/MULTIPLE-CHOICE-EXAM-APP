using ExcelDataReader;
using OfficeOpenXml;
using PhanMemThiTracNghiem.BAL;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;
using PhanMemThiTracNghiem.UI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;


using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemThiTracNghiem.UI.GiangVien
{
    public partial class frmGiangVien : Form
    {
        private readonly MonThiBAL monThiBAL;
        private readonly CauHoiBAL cauHoiBAL;
        DuLieuDAL context = new DuLieuDAL();
        private string magv;
        GiangVienDTO giangVienDTO = new GiangVienDTO();
        public frmGiangVien(string magv)
        {
            
           this.magv = magv;
            InitializeComponent();
            cauHoiBAL = new CauHoiBAL();
            monThiBAL = new MonThiBAL();        
        }

     

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            dgvCauHoi.DataSource = cauHoiBAL.GetCAUHOIs();
            txtMaGV.Text = GiangVienBAL.GETGiangVien(magv).MAGV;
            txtTenGV.Text = GiangVienBAL.GETGiangVien(magv).TENGV;
            txtPassword.Text = GiangVienBAL.GETGiangVien(magv).MATKHAU;
            dateGV.Value = GiangVienBAL.GETGiangVien(magv).NGAYSINH;

            foreach (var item in monThiBAL.GetThongTinMonThi())
            {
                cbDanhMucMT.Items.Add(item.TENMT);
            }
            cbDanhMucMT.SelectedIndex = -1;

        }





        DataTableCollection tableCollection;
        private void btnNhap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook| *.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // txtFileName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName); //add sheet to combobox
                        }
                    }
                }
            }
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];

            if (dt != null)
            {
                List<CauHoiDTO> listcauHoi = new List<CauHoiDTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CauHoiDTO cauHoi = new CauHoiDTO();
                    cauHoi.STT = int.Parse(dt.Rows[i]["STT"].ToString());
                    cauHoi.MaCauHoi = int.Parse(dt.Rows[i]["IDCAUHOI"].ToString());
                    cauHoi.NDCAUHOI = dt.Rows[i]["NDCAUHOI"].ToString();
                    cauHoi.DapAn1 = dt.Rows[i]["DAPAN1"].ToString();
                    cauHoi.DapAn2 = dt.Rows[i]["DAPAN2"].ToString();
                    cauHoi.DapAn3 = dt.Rows[i]["DAPAN3"].ToString();
                    cauHoi.DapAn4 = dt.Rows[i]["DAPAN4"].ToString();
                    cauHoi.DapAnDung = dt.Rows[i]["DAPANDUNG"].ToString();
                    listcauHoi.Add(cauHoi);
                }
                dgvCauHoi.DataSource = listcauHoi;
            }
        }

        private void dgvCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                dgvCauHoi.CurrentRow.Selected = true;
                txtMaCauHoi.Text = dgvCauHoi.Rows[e.RowIndex].Cells["MACAUHOI"].FormattedValue.ToString();
                txtNoiDungCauHoi.Text = dgvCauHoi.Rows[e.RowIndex].Cells["NDCAUHOI"].FormattedValue.ToString();
                txtDapAnA.Text = dgvCauHoi.Rows[e.RowIndex].Cells["DAPAN1"].FormattedValue.ToString();
                txtDapAnB.Text = dgvCauHoi.Rows[e.RowIndex].Cells["DAPAN2"].FormattedValue.ToString();
                txtDapAnC.Text = dgvCauHoi.Rows[e.RowIndex].Cells["DAPAN3"].FormattedValue.ToString();
                txtDapAnD.Text = dgvCauHoi.Rows[e.RowIndex].Cells["DAPAN4"].FormattedValue.ToString();
                string dapandung = dgvCauHoi.Rows[e.RowIndex].Cells["DAPANDUNG"].FormattedValue.ToString();
                if (txtDapAnA.Text.Equals(dapandung + "" ))
                {
                    checkBoxA.Checked = true;
                    checkBoxB.Checked = false;
                    checkBoxC.Checked = false;
                    checkBoxD.Checked = false;
                }
                else if (txtDapAnB.Text.Equals(dapandung+""))
                {
                    checkBoxB.Checked = true;
                    checkBoxC.Checked = false;
                    checkBoxD.Checked = false;
                    checkBoxA.Checked = false;
                }
                else if (txtDapAnC.Text.Equals(dapandung + ""))
                {
                    checkBoxA.Checked = false;
                    checkBoxB.Checked = false;
                    checkBoxC.Checked = true;
                    checkBoxD.Checked = false;
                }
                else if (txtDapAnD.Text.Equals(dapandung + ""))
                {
                    checkBoxA.Checked = false;
                    checkBoxB.Checked = false;
                    checkBoxC.Checked = false;
                    checkBoxD.Checked = true;
                }
                else
                {
                    MessageBox.Show("Chưa có đáp án đúng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            var database = new DuLieuDAL();
            List<CAUHOI> list = new List<CAUHOI>();
            string tenmt = cbDanhMucMT.Text;
            string mamt = "";
            List<MONTHI> monthis = database.MONTHI.Where(p => p.TENMT == tenmt).ToList();
            foreach (var item in monthis)
            {
                mamt = item.MAMT.ToString();    
            }
            try
            {
               

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (cbDanhMucMT is null)
                    {
                        MessageBox.Show("Vui lòng chọn môn thi");
                    }

                    CAUHOI cauhoi = new CAUHOI()
                    {
                        STT = Convert.ToInt32(dt.Rows[i]["STT"].ToString()),
                        MACAUHOI = Convert.ToInt32(dt.Rows[i]["IDCAUHOI"].ToString()),
                        NDCAUHOI = dt.Rows[i]["NDCAUHOI"].ToString(),
                        DAPAN1 = dt.Rows[i]["DAPAN1"].ToString(),
                        DAPAN2 = dt.Rows[i]["DAPAN2"].ToString(),
                        DAPAN3 = dt.Rows[i]["DAPAN3"].ToString(),
                        DAPAN4 = dt.Rows[i]["DAPAN4"].ToString(),
                        DAPANDUNG = dt.Rows[i]["DAPANDUNG"].ToString(),
                        MAGV = magv.ToString(),
                        MAMT = mamt.ToString()
                            
                    };
                    list.Add(cauhoi);
                }
                foreach (var cauhoi in list)
                {
                    database.CAUHOI.Add(cauhoi);
                    database.SaveChanges();
                    frmGiangVien_Load(sender, e);
                }
                MessageBox.Show("Lưu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                
                int macauh = int.Parse(txtMaCauHoi.Text);
                string noidung = txtNoiDungCauHoi.Text;
                string dapan1 = txtDapAnA.Text;
                string dapan2 = txtDapAnB.Text;
                string dapan3 = txtDapAnC.Text;
                string dapan4 = txtDapAnD.Text;
                string dapandung="";
                string magv1 = magv.ToString();
                if (checkBoxA.Checked == true)
                {
                    dapandung = txtDapAnA.Text;
                }
                else if (checkBoxB.Checked == true)
                {
                    dapandung=txtDapAnB.Text;       
                }
                else if (checkBoxC.Checked == true)
                {
                    dapandung=txtDapAnC.Text;   
                }
                else if (checkBoxD.Checked == true)
                {
                    dapandung=txtDapAnD.Text;   
                }
                cauHoiBAL.CapNhapCauHoi(macauh, noidung, dapan1, dapan2, dapan3, dapan4,dapandung,magv1);
                MessageBox.Show("Cập nhập thành công");
                frmGiangVien_Load(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                string mamt = "";
                string tenmt = cbDanhMucMT.Text;
                List<MONTHI> list = context.MONTHI.Where(p => p.TENMT == tenmt).ToList();
                foreach (var item in list)
                {
                    mamt = item.MAMT;
                }

                CauHoiDTO cauHoiDTO = new CauHoiDTO();
                cauHoiDTO.STT++;
                cauHoiDTO.MaCauHoi = int.Parse(txtMaCauHoi.Text);
                cauHoiDTO.NDCAUHOI = txtNoiDungCauHoi.Text;
                cauHoiDTO.DapAn1 = txtDapAnA.Text;
                cauHoiDTO.DapAn2 = txtDapAnB.Text;
                cauHoiDTO.DapAn3 = txtDapAnC.Text;
                cauHoiDTO.DapAn4 = txtDapAnD.Text;
                if (checkBoxA.Checked == true)
                {
                    cauHoiDTO.DapAnDung = txtDapAnA.Text;
                }
                else if (checkBoxB.Checked == true)
                {
                    cauHoiDTO.DapAnDung = txtDapAnB.Text;
                }
                else if (checkBoxC.Checked == true)
                {
                    cauHoiDTO.DapAnDung = txtDapAnC.Text;
                }
                else if (checkBoxD.Checked == true)
                {
                    cauHoiDTO.DapAnDung = txtDapAnD.Text;
                }
                cauHoiDTO.MaGiaoVien = magv.ToString();
                cauHoiDTO.MaMT = mamt;
                CauHoiBAL.InsertUpdate(cauHoiDTO);
                frmGiangVien_Load(sender, e);
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvCauHoi.CurrentRow.Selected = true;
            int r = int.Parse(dgvCauHoi.SelectedRows[0].Cells[1].Value.ToString());
            try
            {
                CauHoiBAL.Delete(r);
                MessageBox.Show("Xóa thành công !!!");
                dgvCauHoi.DataSource = cauHoiBAL.GetCAUHOIs();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

    

        private void btnAnHien_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DoiMKGiangVien doiMK = new DoiMKGiangVien(magv);
            doiMK.ShowDialog();
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
