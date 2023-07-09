using ExcelDataReader;
using OfficeOpenXml;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;
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
  
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

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
                    cauHoi.NoiDungCauHoi = dt.Rows[i]["NDCAUHOI"].ToString();
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
                txtNoiDungCauHoi.Text = dgvCauHoi.Rows[e.RowIndex].Cells["NoiDungCauHoi"].FormattedValue.ToString();
                txtDapAnA.Text = dgvCauHoi.Rows[e.RowIndex].Cells["DapAn1"].FormattedValue.ToString();
                txtDapAnB.Text = dgvCauHoi.Rows[e.RowIndex].Cells["DapAn2"].FormattedValue.ToString();
                txtDapAnC.Text = dgvCauHoi.Rows[e.RowIndex].Cells["DapAn3"].FormattedValue.ToString();
                txtDapAnD.Text = dgvCauHoi.Rows[e.RowIndex].Cells["DapAn4"].FormattedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
