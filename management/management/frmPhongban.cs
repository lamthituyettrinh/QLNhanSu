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
    public partial class frmPhongban : Form
    {
        string cnStr = "";
        SqlConnection cn;
        public frmPhongban()
        {
            InitializeComponent();
        }

        private void frmPhongban_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
        }
        private void Connect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Closed)
                    cn.Open();
                if (cn.State == ConnectionState.Open)
                    MessageBox.Show("Ket noi thanh cong", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        private void DisConnect()
        {

            try
            {
                if (cn != null && cn.State == ConnectionState.Open)

                    cn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }
        public List<PhongBan> GetPhongBan(string sql)
        {
            Connect();
            List<PhongBan> list = new List<PhongBan>();
            try
            {
               
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                int id;
                string Name;
                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                    Name = dr.GetString(1);
                    PhongBan pb = new PhongBan(id, Name);
                    list.Add(pb);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DisConnect();
            }
            return list;
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            string sql = "SELECT*FROM NhanVien WHERE";
            if (rdbma.Checked == true)
                sql += "MaNV =" + txtnhap.Text;
            else if (rdbten.Checked == true)
                sql += "TenPB LIKE '%" + txtnhap.Text + "%'";
            dgvPhongban.DataSource = GetPhongBan(sql);
        }

    }
}
