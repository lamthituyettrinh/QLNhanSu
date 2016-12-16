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
    public partial class LoaiHopDong : Form
    {
        string cnStr = "";
        SqlConnection cn;
        DataSet ds = new DataSet(); 
        public LoaiHopDong()
        {
            InitializeComponent();
        }

        private void LoaiHopDong_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            dgvLoaiHD.DataSource = GetDataset().Tables[0];
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            ds.RejectChanges();
        }

        public DataSet GetDataset()
        {
            try
            {
                string sql = "SELECT* FROM LoaiHopDong";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //DataSet ds = new DataSet(); //bo de khong bi loi khong dong bo voi dataset toan cuc
                da.Fill(ds);
                //Lay du lieu tu CSDL copy qua dataset(nam tren may tinh) 
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

        private void dgvLoaiHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvLoaiHD.Rows[e.RowIndex];
                txtMaLoaiHD.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            // them du lieu vao bang BangCong
            SqlDataAdapter da = new SqlDataAdapter();
            string ins = "INSERT INTO LoaiHopDong(MaLoaiHD, Ten) VALUES (@maloaihd, @ten)";
            SqlCommand cmd = new SqlCommand(ins, cn);
            cmd.Parameters.Add("@maloaihd", SqlDbType.NVarChar, 5, "MaLoaiHD");
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 50, "Ten");
            da.InsertCommand = cmd;

            // xoa du lieu tu bang BangCong
            string det = "DELETE FROM LoaiHopDong WHERE MaLoaiHD = @maloaihd";
            cmd = new SqlCommand(det, cn);
            cmd.Parameters.Add("@maloaihd", SqlDbType.NVarChar, 5, "MaLoaiHD");
            da.DeleteCommand = cmd;
            //update lai du lieu
            da.Update(ds);
        }

        

    }
}
