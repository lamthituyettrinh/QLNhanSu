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
    public partial class HopDong : Form
    {
        string cnStr = "";
        SqlConnection cn;

        DataSet ds = new DataSet();
        public HopDong()
        {
            InitializeComponent();
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);

            string sql = " select * from HopDong";
            dgvHopDong.DataSource = GetDataset(sql).Tables[0];
            DataTable hd = new DataTable();
            hd = GetDataset(sql).Tables[0];
            txtMaHD.DataBindings.Add("Text", hd, "MaHD");
            txtTen.DataBindings.Add("Text", hd, "Ten");
            txtMaLoaiHD.DataBindings.Add("Text", hd, "MaLoaiHD");
        }
        public DataSet GetDataset(string sql)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string ins = "INSERT INTO HopDong(MaHD, Ten, MaLoaiHD) VALUES (@idhd, @ten, @idloaihd)";
            SqlCommand cmd = new SqlCommand(ins, cn);
            cmd.Parameters.Add("@idhd", SqlDbType.NVarChar, 5, "MaHD");
            cmd.Parameters.Add("@ten", SqlDbType.Int, 10, "Ten");
            cmd.Parameters.Add("@idloaihd", SqlDbType.NVarChar, 50, "MaLoaiHD");

            da.InsertCommand = cmd;
            da.Update(ds);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string upd = "UPDATE HopDong SET  MaHD=@MaHD,Ten=@Ten,MaLoaiHD=@MaLoaiHD WHERE MaHD = @MaHD";
            SqlCommand cmd = new SqlCommand(upd, cn);
            cmd = new SqlCommand(upd, cn);
            cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar, 5, "MaHD");
            cmd.Parameters.Add("@Ten", SqlDbType.Int, 10, "Ten");
            cmd.Parameters.Add("@MaLoaiHD", SqlDbType.NVarChar, 50, "MaLoaiHD");

            da.UpdateCommand = cmd;
            da.Update(ds);
        }
    }
}
