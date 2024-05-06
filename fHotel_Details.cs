using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Security.Cryptography;

namespace DuLich
{
    public partial class fHotel_Details : Form
    {

        int iDanhGia = 0;
        public string tenTaiKhoan;
        DateTime checkin;
        DateTime checkout;
        List<DanhGia> listdg;
        List<Room> listRoom;
        KHACHSAN ks;
        public fHotel_Details(KHACHSAN ks)
        {
            this.ks = ks;
            InitializeComponent();
        }

        private void fHotel_Details_Load(object sender, EventArgs e)
        {
            ChenThongTinCanBan();
            ChenAnhToTal();
            ChenTNChinh();
            ChenTienNghi();
            ChenPhong();
            ChenDanhGia();
        }
        void ChenDanhGiaKhachHang()
        {
            if (listdg.Any())
            {
                lblNameDG.Text = listdg[0].TenKH;
                lblDiemDG.Text = listdg[0].Diem.ToString();
                lblContentDG.Text = listdg[0].NoiDung;
                UCComment uc1 = new UCComment(listdg[iDanhGia++]);
               // UCComment uc2 = new UCComment(listdg[iDanhGia++]);
                flpDanhGiaKhachHang.Controls.Clear();
                flpDanhGiaKhachHang.Controls.Add(uc1);
                //flpDanhGiaKhachHang.Controls.Add(uc2);
            }
        }

        void ChenDanhGia()
        {
            this.listdg = new DanhGiaDAO().GetDanhGia(ks.Maks);
            int rt = 0, t = 0, tb = 0, k = 0;
            int tong = 0;
            int n = 0;
            foreach (DanhGia danhgia in listdg)
            {
                if (danhgia.Diem < 5)
                {
                    k++;
                }
                if (danhgia.Diem < 7 && danhgia.Diem >= 5)
                {
                    tb++;
                }
                if (danhgia.Diem < 9 && danhgia.Diem >= 7)
                {
                    t++;
                }
                if (danhgia.Diem >= 9)
                {
                    rt++;
                }
                tong += danhgia.Diem;
                n++;
            }
            lblCommentCount.Text = string.Format("Từ " + n + " khách hàng đã ở");
            double dtb = (double)tong / n;
            dtb = Math.Round(dtb, 1);
            double ptRT = (double)rt / n;
            lblPtRT.Size = new Size((int)Math.Round(ptRT * 293, 0), 15);
            double ptT = (double)t / n;
            lblPtT.Size = new Size((int)Math.Round(ptT * 293, 0), 15);
            double ptTB = (double)tb / n;
            lblPtTB.Size = new Size((int)Math.Round(ptTB * 293, 0), 15);
            double ptK = (double)k / n;
            lblPtK.Size = new Size((int)Math.Round(ptK * 293, 0), 15);
            if (n == 0)
            {
                lblDG1.Text = "0";
                lblDG2.Text = "0";
            }
            else
            {
                lblDG1.Text = dtb.ToString();
                lblDG2.Text = dtb.ToString();
            }
            lblRT1.Text = rt.ToString();
            lblRT2.Text = rt.ToString();
            lblT1.Text = t.ToString();
            lblT2.Text = t.ToString();
            lblTB1.Text = tb.ToString();
            lblTB2.Text = tb.ToString();
            lblK1.Text = k.ToString();
            lblK2.Text = k.ToString();
            ChenDanhGiaKhachHang();
        }

        void ChenPhong()
        {
            this.listRoom = new Room_DAO().GetListRoom(ks.MAKS);
            foreach (Room room in listRoom)
            {
                UCPhong uc = new UCPhong(ks, room, checkin, checkout);
                flbRoom.Controls.Add(uc);
            }
        }

        void ChenTienNghi()
        {
            List<string> listTNC = new QL_TN_DAO().GetListTienNghi(ks.MAKS, 1);
            foreach (string tenTN in listTNC)
            {
                UCTN uc = new UCTN(tenTN);
                flpTNChinh.Controls.Add(uc);
            }
            List<string> listDVKS = new QL_TN_DAO().GetListTienNghi(ks.MAKS, 2);
            foreach (string tenTN in listDVKS)
            {
                UCTN uc = new UCTN(tenTN);
                flpDVKS.Controls.Add(uc);
            }
            List<string> listTNCC = new QL_TN_DAO().GetListTienNghi(ks.MAKS, 3);
            foreach (string tenTN in listTNCC)
            {
                UCTN uc = new UCTN(tenTN);
                flpTNCC.Controls.Add(uc);
            }
            List<string> listAmThuc = new QL_TN_DAO().GetListTienNghi(ks.MAKS, 4);
            foreach (string tenTN in listAmThuc)
            {
                UCTN uc = new UCTN(tenTN);
                flpFood.Controls.Add(uc);
            }
        }

        void ChenTNChinh()
        {
            List<TienNghiChinh> list = new TienNghiChinhDAO().GetListTNC(ks.MAKS);
            foreach (TienNghiChinh tnc in list)
            {
                UCTNChinh uc = new UCTNChinh(tnc);
                flpTNC.Controls.Add(uc);
            }
        }

        void ChenAnhToTal()
        {
            List<QL_HinhAnh> list = new QL_HinhAnhDAO().Get(ks.MAKS);
            ptbTotalImage1.Image = Image.FromFile(list[0].ADDRESS);
            ptbTotalImage2.Image = Image.FromFile(list[1].ADDRESS);
            ptbTotalImage3.Image = Image.FromFile(list[2].ADDRESS);
            ptbTotalImage4.Image = Image.FromFile(list[3].ADDRESS);
            ptbTotalImage5.Image = Image.FromFile(list[4].ADDRESS);
            ptbTotalImage6.Image = Image.FromFile(list[5].ADDRESS);
            ptbTotalImage7.Image = Image.FromFile(list[6].ADDRESS);
        }

        void ChenThongTinCanBan()
        {

            lblName.Text = ks.TENKS;
            lblAddress.Text = ks.DIACHI;
            lblPrice.Text = ks.GIA.ToString() + " VNĐ";
            lblDG1.Text = ks.GIA.ToString();
            lblDG2.Text = ks.GIA.ToString();
        }

        private void fHotel_Details_Shown(object sender, EventArgs e)
        {
            panelMain.VerticalScroll.Value = 0;
        }


        void DeleteColor()
        {
            lblTotal.ForeColor = Color.Black;
            lblRoom.ForeColor = Color.Black;
            lblConvenient.ForeColor = Color.Black;
            lblComment.ForeColor = Color.Black;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            DeleteColor();
            panelMain.VerticalScroll.Value = 0;
            lblTotal.ForeColor = Color.DarkTurquoise;
        }

        private void lblRoom_Click(object sender, EventArgs e)
        {
            DeleteColor();
            panelMain.VerticalScroll.Value = 620;
            lblRoom.ForeColor = Color.DarkTurquoise;
        }

        private void lblConvenient_Click(object sender, EventArgs e)
        {
            DeleteColor();
            panelMain.VerticalScroll.Value = 1540;
            lblConvenient.ForeColor = Color.DarkTurquoise;
        }

        private void lblComment_Click(object sender, EventArgs e)
        {
            DeleteColor();
            panelMain.VerticalScroll.Value = 2350;
            lblComment.ForeColor = Color.DarkTurquoise;
        }

        private void lblConvenientDetail_Click(object sender, EventArgs e)
        {
            DeleteColor();
            panelMain.VerticalScroll.Value = 1170;
            lblConvenient.ForeColor = Color.DarkTurquoise;
        }

        private void lblCommentDetail_Click(object sender, EventArgs e)
        {
            DeleteColor();
            panelMain.VerticalScroll.Value = 1750;
            lblComment.ForeColor = Color.DarkTurquoise;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRoomChoose_Click(object sender, EventArgs e)
        {
            FAddAnh f = new FAddAnh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lblBackComment_Click(object sender, EventArgs e)
        {
            if (iDanhGia >= 2)
            {
                iDanhGia -= 2;
                flpDanhGiaKhachHang.Controls.Clear();
                ChenDanhGiaKhachHang();
            }
        }

        private void lblNextComment_Click(object sender, EventArgs e)
        {
            if (iDanhGia < listdg.Count - 2)
            {
                iDanhGia += 2;
                flpDanhGiaKhachHang.Controls.Clear();
                ChenDanhGiaKhachHang();
            }
        }

        private void cbRatTot_CheckedChanged(object sender, EventArgs e)
        {
            SelectDanhGia();
        }

        void SelectDanhGia()
        {
            listdg.Clear();
            if (cbRatTot.Checked)
            {
                AddDanhGia(9, 10);
            }
            if (cbTot.Checked)
            {
                AddDanhGia(7, 8);
            }
            if (cbTrungBinh.Checked)
            {
                AddDanhGia(5, 6);
            }
            if (cbKem.Checked)
            {
                AddDanhGia(0, 4);
            }
            ChenDanhGiaKhachHang();
        }

        void AddDanhGia(int min, int max)
        {
            foreach (DanhGia dg in new DanhGiaDAO().GetDanhGia(ks.Maks))
            {
                if (dg.Diem >= min && dg.Diem <= max)
                {
                    listdg.Add(dg);
                }
            }
        }

        private void cbTot_CheckedChanged(object sender, EventArgs e)
        {
            SelectDanhGia();
        }

        private void cbTrungBinh_CheckedChanged(object sender, EventArgs e)
        {
            SelectDanhGia();
        }

        private void cbKem_CheckedChanged(object sender, EventArgs e)
        {
            SelectDanhGia();
        }



        public DateTime CheckIn
        {
            get { return checkin; }
            set { checkin = value; }
        }

        public DateTime CheckOut
        {
            set { checkout = value; }
            get { return checkout; }
        }

    }
}
