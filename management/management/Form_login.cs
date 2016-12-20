using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace management
{
    public partial class Form_login : Form
    {
        string cnStr = "";
        SqlConnection cn;
     
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            //string sql = "SELECT * FROM TaiKhoan WHERE TaiKhoan = '" + txtTaiKhoan.Text + "'and MatKhau = '" + txtMatKhau.Text + "'";
        }

        private void DangNhap()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                    MessageBox.Show("Ket noi thanh cong", "Dang nhap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

                }

            catch (SqlException ex)
            {
                MessageBox.Show("Ket noi không thành  cong", "Dang nhap", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            
            
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
            Form_main main = new Form_main();
            main.ShowDialog();
        }

        
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
      
    }
}
