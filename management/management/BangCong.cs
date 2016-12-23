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
    public partial class BangCong : Form
    {
        string cnStr = "";
        SqlConnection cn;
        DataSet ds = new DataSet();
       
        public BangCong()
        {
            InitializeComponent();
        }
         private void BangCong_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            dgvBangCong.DataSource = GetDataset().Tables[0];

            // load du lieu vao comboboxMaLuong tu bang BangLuong
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select MaLuong From BangLuong", cn);
            da.Fill(dt);
            cbbMaLuong.DataSource = dt;
            cbbMaLuong.DisplayMember = "MaLuong";
            cbbMaLuong.ValueMember = "MaLuong";
          
        }
        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataSet GetDataset()
        {
            try
            {
                string sql = "SELECT* FROM BangCong";
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

        private void dgvBangCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBangCong.Rows[e.RowIndex];
                txtMaCong.Text = row.Cells[0].Value.ToString();
                txtSoLuong.Text = row.Cells[1].Value.ToString();
                txtSoNgay.Text = row.Cells[2].Value.ToString();
                cbbMaLuong.Text = row.Cells[3].Value.ToString();
               
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            // them du lieu vao bang BangCong
            SqlDataAdapter da = new SqlDataAdapter();
            string ins = "INSERT INTO BangCong(MaCong, SoLuong, SoNgay, MaLuong) VALUES (@macong, @soluong, @songay,@maluong)";
            SqlCommand cmd = new SqlCommand(ins, cn);
            cmd.Parameters.Add("@macong", SqlDbType.NVarChar, 5, "MaCong");
            cmd.Parameters.Add("@soluong", SqlDbType.Int, 10, "SoLuong");
            cmd.Parameters.Add("@songay", SqlDbType.NVarChar, 50, "SoNgay");
            cmd.Parameters.Add("@maluong", SqlDbType.NVarChar, 5, "MaLuong");
            da.InsertCommand = cmd;

            // xoa du lieu tu bang BangCong
            string det = "DELETE FROM BangCong WHERE MaCong = @macong";
            cmd = new SqlCommand(det, cn);
            cmd.Parameters.Add("@macong", SqlDbType.NVarChar, 5, "MaCong");
            da.DeleteCommand = cmd;
            da.Update(ds);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            ds.RejectChanges();
        }

        private void btTongCong_Click(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt32(txtSoLuong.Text);
            int songay = Convert.ToInt32(txtSoNgay.Text);
            lbTongCong.Text = Convert.ToString(soluong * songay);
        }
      

       

            

        
            
           

       
        }

    }

       