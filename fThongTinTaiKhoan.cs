using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuLich
{
    public partial class fThongTinTaiKhoan : Form
    {
        public string tentk;
        public string mk;
        // Khai báo danh sách để lưu các Mã phòng
        public List<int> maPhongList = new List<int>();
        public int index = 0;
        HuyPhongDAO hpdao = new HuyPhongDAO();
        public fThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        public int maks;

        private void fThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            uPhong3.Size = new Size(1221, 620);
            uThongtin2.tentk = tentk;
            uThongtin2.mk = mk;
            uThongTinKhachSan1.SetTenTK(tentk);
            uThongtin1.tentk = tentk;
            uViTri1.SetTenTK(tentk);
            uHoSo1.SetTenTK(tentk);
            uMatKhau1.tentk = tentk;
            uUuDai1.tentk = tentk;
            uAnh1.tk = tentk;
            uAnh2.SetTenTK(tentk);
            uTienNghi1.SetTenTK(tentk);
            Modify modify = new Modify();
            string query = "Select * from KHACHSAN_THUOC_TAIKHOAN where TaiKhoan = '" + tentk + "' ";
            var result = modify.KhachSanThuocTaiKhoan(query);
            if (result.Count() > 0)
            {
                btn_ThongTinKhachSan.Visible = true;
                btn_ThongTinKhachSan.Visible = true;
                uUuDai1.SetTenTK(tentk);
            }
            luuTruMaPhong luutru = new luuTruMaPhong();
            luutru.luuMaPhong(tentk, maPhongList);   
        }
        public void ShowQLHuy()
        {
            panel6.Visible = true;
            btn_QuanLyHuy.Visible = true;
        }
        public void HideQLHuy()
        {
            panel6.Visible = false;
            uPhong3.Ktr(index, maPhongList);
            uPhong3.HienThi(index, maPhongList);
            btn_QuanLyHuy.Visible = false;
        }
        public void ShowThongTinCanBan()
        {
            btn_ThongTingKS.Visible = true;
        }
        public void ShowViTri()
        {
            btn_ViTri.Visible = true;
        }
        public void ShowChiTietPhong()
        {
            btn_ChiTietPhong.Visible = true;
        }
        public void ShowAnh()
        {
            btn_Anh.Visible = true;
        }
        public void ShowHoSo()
        {
            btn_HoSo.Visible = true;
        }
        public void HideThongTinCanBan()
        {
            btn_ThongTingKS.Visible = false;
        }
        public void HideViTri()
        {
            btn_ViTri.Visible = false;
        }
        public void HideChiTietPhong()
        {
            btn_ChiTietPhong.Visible = false;
        }
        public void HideAnh()
        {
            btn_Anh.Visible = false;
        }
        public void HideHoSo()
        {
            btn_HoSo.Visible = false;
        }
        public void ShowThongTinKS()
        {
            btn_ThongTinKhachSan.Visible = true;
        }
        public void ShowUDai()
        {
            btn_UDai.Visible = true;
        }
        public void HideUDai()
        {
            btn_UDai.Visible = false;
        }
        public void HideTienNghi()
        {
            btn_TienNghi.Visible = false;
        }
        public void ShowTienNghi()
        {
            btn_TienNghi.Visible = true;
        }
        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            uThongtin2.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_MatKhau_Click(object sender, EventArgs e)
        {
            uMatKhau1.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_ThongTingKS_Click(object sender, EventArgs e)
        {
            uThongTinKhachSan1.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_ViTri_Click(object sender, EventArgs e)
        {
            uViTri1.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_ChiTietPhong_Click(object sender, EventArgs e)
        {
            uPhong2.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
            uPhong3.BringToFront();
        }

        private void btn_Anh_Click(object sender, EventArgs e)
        {
            uAnh2.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_HoSo_Click(object sender, EventArgs e)
        {
            uHoSo1.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }
        int dem = 0;
        private void btn_ThongTinKhachSan_Click(object sender, EventArgs e)
        {
            if (dem % 2 == 0)
            {
                ShowThongTinCanBan();
                ShowViTri();
                ShowChiTietPhong();
                ShowAnh();
                ShowHoSo();
                ShowUDai();
                ShowTienNghi();
                ShowQLHuy();
                dem++;
            }
            else
            {
                HideThongTinCanBan();
                HideViTri();
                HideChiTietPhong();
                HideAnh();
                HideHoSo();
                HideUDai();
                HideTienNghi();
                HideQLHuy();
                dem++;
            }
        }

        private void uThongtin2_Load(object sender, EventArgs e)
        {

        }

        private void btn_TienNghi_Click(object sender, EventArgs e)
        {
            uTienNghi1.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_UDai_Click(object sender, EventArgs e)
        {
            uUuDai1.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_QuanLyHuy_Click(object sender, EventArgs e)
        {
            flP_QuanLyHuy.BringToFront();
            flP_QuanLyHuy.Visible = true;
            List<DatPhong> listPhongDat = new List<DatPhong>();
            hpdao.getPhongMuonHuy(tentk, listPhongDat);
            foreach (DatPhong i in listPhongDat)
            {
                UCHuyphongCKS uc = new UCHuyphongCKS(i);
                flP_QuanLyHuy.Controls.Add(uc);
            }
        }

        private void uChiTietPhongo1_Load(object sender, EventArgs e)
        {

        }

        private void flP_QuanLyHuy_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
