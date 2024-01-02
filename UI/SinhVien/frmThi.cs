using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.BAL;
using PhanMemThiTracNghiem.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemThiTracNghiem
{
    public partial class frmThi : Form
    {

        DuLieuDAL duLieu = new DuLieuDAL();

        List<Button> oCauHoi;
        List<GroupBox> luuBaiCham;
        List<RadioButton> layDapAnThi;

        private readonly ChiTietDeThiBAL danhMucCauHoiBAL;
        private readonly CauHoiBAL cauHoiBAL;
        private readonly BangDiemBAL bangDiemBAL;
        private readonly ChiTietKyThiBAL chiTietKyThiBAL;
        private readonly GiangVienBAL giangVienBAL;
        private readonly SinhVienBAL sinhVienBAL;
        private readonly SINHVIEN sinhVien;
        private readonly MONTHI monThi;
        private readonly KyThiBAL kiThiBAL;
        private readonly DateTime thoiGianBatDau;
        private readonly DateTime thoiGianKetThuc;
        private readonly List<CAUHOI> cauHoiMonThi = new List<CAUHOI>();


        public int TongThoiGian = 6;
        int iPhut = 0;
        int iGiay = 0;



        public frmThi(SINHVIEN sv, MONTHI mt, DateTime ThoiGianBatDauVaoThi, DateTime thoiGianKetThucThi)
        {
            InitializeComponent();

            oCauHoi = new List<Button>();
            luuBaiCham = new List<GroupBox>();
            layDapAnThi = new List<RadioButton>();

            cauHoiBAL = new CauHoiBAL();
            bangDiemBAL = new BangDiemBAL();
            danhMucCauHoiBAL = new ChiTietDeThiBAL();
            chiTietKyThiBAL = new ChiTietKyThiBAL();
            giangVienBAL = new GiangVienBAL();
            sinhVienBAL = new SinhVienBAL();
            kiThiBAL = new KyThiBAL();
            thoiGianBatDau = ThoiGianBatDauVaoThi;
            thoiGianKetThuc = thoiGianKetThucThi;
            sinhVien = sv;
            monThi = mt;

            // Hiển thị thông tin sinh viên 
            lblTenSinhVien.Text = sinhVien.TENSV.ToString() + "  ||  " + sinhVien.MASV.ToString();

            // Hiển thị môn thi
            lblMonThi.Text = monThi.TENMT;
            lblMonThi.Name = monThi.MAMT;

            // Gọi khung hiển thị câu hỏi trắc nghiệm
            flowLayoutPanel1.Enabled = true;
            flowLayoutPanel1_Paint();






        }
        private void frmThi_Load(object sender, EventArgs e)
        {
            btnDemNguoc_Click(sender, e);
            for (int i = 0; i < cauHoiBAL.GetThongTinCauHoi().Count(); i++)
            {
                layDapAnThi.Add(null);
           
            }
        }
        private void flowLayoutPanel1_Paint()
        {
            // Tạo ô câu hỏi bên trái
            int x = 10, y = 105;
            int soCauHoi = 0;
            foreach (var item in cauHoiBAL.GetThongTinCauHoi())
            {
                if(item.MAMT == monThi.MAMT)
                {
                    soCauHoi++;
                    cauHoiMonThi.Add(item);
                }          
            }
            for (int i = 0; i < cauHoiMonThi.Count; i++)
            {
                oCauHoi.Add(TaoNut((i + 1), ref x, ref y));

                x += 60;

                if ((i + 1) % 2 == 0)
                {
                    y += 40;
                    x = 10;
                }
                luuBaiCham.Add(TaoCauHoi( i));
            }
            
            // Tạo tất cả có trong vùng chứa câu hỏi

            foreach (CHITIETDETHI item in danhMucCauHoiBAL.GetCauHoi())
            {
                

            }



        }

        private GroupBox TaoCauHoi(int i)
        {
            // Tạo mỗi GroupBox chứa mỗi 1 câu hỏi
            GroupBox groupBox = new GroupBox();
            groupBox.Location = new Point();
            groupBox.Font = new Font("Be Vietnam Pro", 10, FontStyle.Bold);
            groupBox.Text = "Câu " + (i+1);
            groupBox.Name = (i+1).ToString();
            groupBox.Size = new System.Drawing.Size(1780, 300);
            flowLayoutPanel1.Controls.Add(groupBox);

            // Tiếp theo ta tạo câu hỏi
            Label label = new Label();
            label.Location = new Point(30, 30);
            label.Size = new Size(1600, 50);
            label.Name = i.ToString();
            label.Font = new Font("Be Vietnam Pro", 10);
            
            label.Text = cauHoiMonThi[i].NDCAUHOI;
            groupBox.Controls.Add(label);

            for (int j = 0; j < 4; j++)
            {
                RadioButton rdo = new RadioButton();
                if (j == 1 || j == 3)
                {
                    rdo.Location = new Point(800, 150 + ((j - 1) * 30));
                }
                else
                {
                    rdo.Location = new Point(30, 150 + (j * 30));
                }
                rdo.Size = new Size(450, 30);
                rdo.Name = "rdo" + j.ToString();
                rdo.Font = new Font("Be Vietnam Pro", 10);

                // Lấy 4 đáp án
                if (j == 0)
                {
                    rdo.Text = cauHoiMonThi[i].DAPAN1;
                }
                if (j == 1)
                {
                    rdo.Text = cauHoiMonThi[i].DAPAN2;
                }
                if (j == 2)
                {
                    rdo.Text = cauHoiMonThi[i].DAPAN3;
                }
                if (j == 3)
                {
                    rdo.Text = cauHoiMonThi[i].DAPAN4;
                }

                groupBox.Controls.Add(rdo);

                rdo.Click += (sender, EventArgs) => { buttonNext_Click(sender, EventArgs, groupBox.Name, rdo, (i + 1)) ; };
                //   rdb.CheckedChanged += new System.EventHandler(gbxButtonType_CheckedChanged);
            }





            // Tiếp theo ta tạo các 4 ô để chứa đáp án

            return groupBox;
        }
        private void buttonNext_Click(object sender, EventArgs e, string index, RadioButton rdo, int traloi)
        {
            try
            {
                layDapAnThi[traloi - 1] = rdo;
                foreach (var item in oCauHoi)
                {
                    if (item.Name == index)
                    {
                        item.BackColor = Color.Yellow;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private System.EventHandler CauHoiDaLam(GroupBox a)
        {

            try
            {

                foreach (var item in oCauHoi)
                {

                    if (item.Name == a.Name)
                    {
                        item.BackColor = Color.Yellow;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private Button TaoNut(int i, ref int x, ref int y)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Font = new Font("Be Vietnam Pro", 10);
            btn.Text = i.ToString();
            //btn.Tag = item.MaSoBan;
            btn.Name = i.ToString();
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Size = new Size(42, 36);
            btn.BackColor = Color.White;
            btn.Focus();
            //btn.Click += Btn_Click;
            //btn.Click += Btn_Oder;

            panelMenu.Controls.Add(btn);

            btn.BringToFront();

            return btn;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                flowLayoutPanel1.Controls.Add(new Button() { Text = "Cố lên" });
            }
            for (int i = 0; i < 100; i++)
            {
                flowLayoutPanel1.Controls.Add(new Button() { Text = "Mạnh mẽ lên" });
            }
        }

        private void menuThi_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // NỘP BÀI
        private void NopBai_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn nộp bài không?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;
            NopBai_Click();
        }

        // TÍNH THỜI GIAN CÒN LẠI
        private void btnDemNguoc_Click(object sender, EventArgs e)
        {

            TongThoiGian = (thoiGianKetThuc.Hour - DateTime.Now.Hour) * 60 + (60 - thoiGianBatDau.Minute) + thoiGianKetThuc.Minute;
            iPhut = TongThoiGian - 1;
            iGiay = 59;
            this.timer1.Enabled = true;
            HienThiPhutGio();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Application.DoEvents();

            iGiay--;

            if (iGiay == 0)
            {
                if (iPhut > 0)
                {
                    iPhut--;
                    iGiay = 59;
                }
                else
                {
                    iPhut = 0;
                    iGiay = 0;
                }
            }

            if ((iPhut == 0) && (iGiay == 0))
            {
                HienThiPhutGio();
                this.timer1.Enabled = false;
                MessageBox.Show("Hết giờ làm bài!!");
                NopBai_Click();
            }
            else
            {
                HienThiPhutGio();
            }

        }

        private void NopBai_Click()
        {
            // Lấy thời gian kết thúc thi
            DateTime thoiGianThi = DateTime.Now;
            float diemMotCau;
            float diemThi = 0;
            int demSoCauDung = 0;
            int soCauHoi = cauHoiBAL.GetThongTinCauHoi().Count();
            diemMotCau = (float)10.0 / soCauHoi;
            List<int> luuBaiLam = new List<int>(soCauHoi);
            for (int i = 0; i < soCauHoi; i++)
            {
                luuBaiLam.Add(0);
            }

            for (int i = 0; i < soCauHoi; i++)
            {
                if (layDapAnThi[i] != null)
                {
                    if (String.Equals(layDapAnThi[i].Text.ToString(), cauHoiBAL.GetThongTinCauHoi()[i].DAPANDUNG))
                    {
                        diemThi += diemMotCau;
                        demSoCauDung++;
                        luuBaiLam[i] = 1;
                    }
                }
            }
            diemThi = (float)(Math.Round(diemThi, 2));

            // Lưu dữ liệu vào Chi Tiết Kỳ Thi và Lưu Điểm
            // Tìm thời gian khớp diễn ra kỳ thi để thêm cập nhập điểm, thời gian kết thúc thi và thời gian thi
            foreach (var item in kiThiBAL.GetThongTinKyThi())
            {
                if (DateTime.Now >= item.THOIGIANBDKITHI && DateTime.Now <= item.THOIGIANKTKITHI)
                {
                    foreach (var i in chiTietKyThiBAL.GetThongTinChiTietKyThi())
                    {
                        chiTietKyThiBAL.LuuChiTietKyThi(sinhVien, item.MAKITHI, monThi, diemThi, thoiGianBatDau, thoiGianThi, (thoiGianThi.Hour * 60 + thoiGianThi.Minute) - (thoiGianBatDau.Hour * 60 + thoiGianBatDau.Minute));
                     //   bangDiemBAL.LuuDiemThi(1, diemThi, sinhVien.MASV, item.MAKITHI, monThi.MAMT);
                        break;
                    }
                }
            }

            // Hiển thị  điểm

            ThiTracNghiem thiTracNghiem = new ThiTracNghiem(sinhVien);
            thiTracNghiem.HienThi(diemThi, demSoCauDung, luuBaiLam);
            this.Hide();
            thiTracNghiem.ShowDialog();
            this.Close();

        }

        private void HienThiPhutGio()
        {
            string sPhut = "";
            string sGiay = "";

            if (iPhut < 10)
                sPhut = "0" + iPhut.ToString();
            else
                sPhut = iPhut.ToString();

            if (iGiay < 10)
                sGiay = "0" + iGiay.ToString();
            else
                sGiay = iGiay.ToString();
            // Hiển thị thời gian
            this.lblHienThi.Text = sPhut + ":" + sGiay;

        }

        private void pnlThi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblHienThi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}







// CODE CŨ - LƯU LẠI KHI CẦN XEM

// Tạo câu hỏi
//flowLayoutPanel1.Controls.Add(new GroupBox()
//{
//    Name = tenGbox.ToString(),
//    Text = "Câu " + tenGbox,
//    ForeColor = Color.Black,
//    Size = new System.Drawing.Size(1200, 300),
//    Anchor = AnchorStyles.Top & AnchorStyles.Bottom,
//});
//tenGbox++;


//if (connection.State == ConnectionState.Closed) // "+soThuTu+",
//    connection.Open();
//SqlCommand sqlCommand = new SqlCommand();
//string inSert = "insert into BANGDIEM(ID, MABD, TENBD, DIEM) values('" + soThuTu + "','" + lblMaSoSinhVien.Text + "','" + lblTenSinhVien.Text + "','" + diemThi + "')";
//sqlCommand.CommandType = CommandType.Text;
//sqlCommand.CommandText = inSert;
//sqlCommand.Connection = connection;
//sqlCommand.ExecuteNonQuery();

//giay--;
//lblCount.Text = giay / 60 + ":" + ((giay % 60) >= 10 ? (giay % 60).ToString() : "0" + (giay % 60));
//if (giay == 0)
//{
//    timer1.Stop();
//    MessageBox.Show("Hết giờ làm bài!");
//}