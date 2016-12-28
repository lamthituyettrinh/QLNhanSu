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
    public partial class frmchitiethopdong : Form
    {
        string cnStr = "";
        SqlConnection cn;
        DataSet ds;
        public frmchitiethopdong()
        {
            InitializeComponent();
        }

        private void frmchitiethopdong_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            dgvCTHD.DataSource = GetCTHDDataset().Tables[0];

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select NgayKy From ChiTietHD", cn);
            da.Fill(dt);
            cbbNgayky.DataSource = dt;
            cbbNgayky.DisplayMember = "NgayKy";
            cbbNgayky.ValueMember = "NgayKy";
        }
        public DataSet GetCTHDDataset()
        {
            try
            {
                string sql = "SELECT * FROM ChiTietHD";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cn.Close();
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();//update
            string ins = "INSERT INTO  ChiTietHD(MaHD, MaNV, NgayKy, NhiemVu) VALUES(@idHD, @idNV, @Ngayky, @Nhiemvu)";
            SqlCommand cmd = new SqlCommand(ins, cn);

            cmd.Parameters.Add("@idHD", SqlDbType.NVarChar, 5, "MaHD");
            //cmd.Parameters.Add("@Thang", SqlDbType.datetime, "Thang");
            cmd.Parameters.Add("@idNV", SqlDbType.NVarChar, 50, "MaNV");
            cmd.Parameters.Add("@Nhiemvu", SqlDbType.NChar, 10, "NhiemVu");

            da.InsertCommand = cmd;


            string del = "DELETE FROM ChiTietHD WHERE MaNV=@idNV";
            cmd = new SqlCommand(del, cn);
            cmd.Parameters.Add("@idNV", SqlDbType.NVarChar, 50, "MaNV");

            da.DeleteCommand = cmd;
            //da.Update(ds);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.RejectChanges();
        }
    }
}
