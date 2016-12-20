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
    public partial class frmBangLuong : Form
    {
        string cnStr = "";
        SqlConnection cn;
        DataSet ds;
        public frmBangLuong()
        {
            InitializeComponent();
        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            dgvbangluong.DataSource = GetBangLuongDataset().Tables[0];
        }
        public DataSet GetBangLuongDataset()
        {
            try
            {
                string sql = "SELECT * FROM BangLuong";
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

        private void btluu_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();//update
            string ins = "INSERT INTO  BangLuong(MaNV, Thang, Gia, HeSoLuong,MaLuong) VALUES(@id, @Thang, @Gia, @HeSoLuong, @MaLuong)";
            SqlCommand cmd = new SqlCommand(ins, cn);

            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 4, "MaNV");
            //cmd.Parameters.Add("@Thang", SqlDbType.datetime, "Thang");
            cmd.Parameters.Add("@Gia", SqlDbType.NVarChar, 50, "Gia");
            cmd.Parameters.Add("@HeSoLuong", SqlDbType.NVarChar, 50, "HeSoLuong");
            cmd.Parameters.Add("@MaLuong", SqlDbType.NVarChar, 5, "@MaLuong");

            da.InsertCommand = cmd;
        

            string del = "DELETE FROM BangLuong WHERE MaNV=@id";
            cmd = new SqlCommand(del, cn);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 4, "MaKH");
   
            da.DeleteCommand = cmd;
            da.Update(ds);

        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            ds.RejectChanges();
        }
  
    }
}
