using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace management
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }
        //frmBangLuong BangLuong = null;
        private void btBangLuong_Click(object sender, EventArgs e)
        {
            frmBangLuong bl = new frmBangLuong();
            bl.ShowDialog();
            //if (BangLuong == null || BangLuong.IsDisposed)
            //{
            //    BangLuong = new frmBangLuong();
            //    BangLuong.Show();
            //}
            //else BangLuong.Activate();
        }

        private void btBangCong_Click(object sender, EventArgs e)
        {
            BangCong bc = new BangCong();
            bc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        frmPhongban PhongBan = null;
        private void btPhongBan_Click(object sender, EventArgs e)
        {
            //PhongBan pb = new PhongBan();
            //pb.ShowDialog();
            if (PhongBan == null || PhongBan.IsDisposed)
            {
                PhongBan = new frmPhongban();
                PhongBan.Show();
            }
            else PhongBan.Activate();
        }
        Chức_Vụ ChucVu = null;
        private void btChucVu_Click(object sender, EventArgs e)
        {
            if (ChucVu == null || ChucVu.IsDisposed)
            {
                ChucVu = new Chức_Vụ();
                ChucVu.Show();
            }
            else ChucVu.Activate();
        }

        private void btHopDong_Click(object sender, EventArgs e)
        {
            HopDong hd = new HopDong();
            hd.ShowDialog();
        }

        private void btLoaiHopDong_Click(object sender, EventArgs e)
        {
            LoaiHopDong lhd = new LoaiHopDong();
            lhd.ShowDialog();
        }

        private void btCTHD_Click(object sender, EventArgs e)
        {
            frmchitiethopdong cthd = new frmchitiethopdong();
            cthd.ShowDialog();
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.ShowDialog();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }

       
    }
}
