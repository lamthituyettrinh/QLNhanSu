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
        frmBangLuong BangLuong = null;
        private void btBangLuong_Click(object sender, EventArgs e)
        {
            //BangLuong bl = new frmBangLuong();
            //bl.ShowDialog();
            if (BangLuong == null || BangLuong.IsDisposed)
            {
                BangLuong = new frmBangLuong();
                BangLuong.Show();
            }
            else BangLuong.Activate();
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

        private void btPhongBan_Click(object sender, EventArgs e)
        {
            //PhongBan pb = new PhongBan();
            //pb.ShowDialog();
        }

        private void btChucVu_Click(object sender, EventArgs e)
        {
            //ChucVu cv = new ChucVu();
            //cv.ShowDialog();
        }

        private void btHopDong_Click(object sender, EventArgs e)
        {
            //HopDong hd = new HopDong();
            //hd.ShowDialog();
        }

        private void btLoaiHopDong_Click(object sender, EventArgs e)
        {
            //LoaiHopDong lhd = new LoaiHopDong();
            //lhd.ShowDialog();
        }

        private void btCTHD_Click(object sender, EventArgs e)
        {
            //ChiTietHopDong cthd = new ChiTietHopDong();
            //cthd.ShowDialog();
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            //NhanVien nv = new NhanVien();
            //nv.ShowDialog();
        }
    }
}
