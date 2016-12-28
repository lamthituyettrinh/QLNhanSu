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

            // load du lieu vao comboboxThang tu bang BangLuong
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Thang From BangLuong", cn);
            da.Fill(dt);
            cbbThang.DataSource = dt;
            cbbThang.DisplayMember = "Thang";
            cbbThang.ValueMember = "Thang";


            // load du lieu vao comboboxSoLuong tu bang BangCong
            DataTable bc = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("Select * From BangCong", cn);
            dr.Fill(bc);
            cobSoLuong.DataSource = bc;
            cobSoLuong.DisplayMember = "SoLuong";
            cobSoLuong.ValueMember = "SoLuong";


            cobSoNgay.DataSource = bc;
            cobSoNgay.DisplayMember = "SoNgay";
            cobSoNgay.ValueMember = "SoNgay";


        }
        public DataSet GetBangLuongDataset()
        {
            try
            {
                string sql = "SELECT * FROM BangLuong";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds); //Lay du lieu tu CSDL copy qua dataset(nam tren may tinh)
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

            cmd.Parameters.Add("@id", SqlDbType.Int, 10, "MaNV");
            cmd.Parameters.Add("@Thang", SqlDbType.DateTime, 2, "Thang");
            cmd.Parameters.Add("@Gia", SqlDbType.NVarChar, 50, "Gia");
            cmd.Parameters.Add("@HeSoLuong", SqlDbType.NVarChar, 50, "HeSoLuong");
            cmd.Parameters.Add("@MaLuong", SqlDbType.NVarChar, 5, "@MaLuong");

            da.InsertCommand = cmd;
        

            string del = "DELETE FROM BangLuong WHERE MaLuong=@MaLuong";
            cmd = new SqlCommand(del, cn);
            cmd.Parameters.Add("@MaLuong", SqlDbType.Int, 10, "MaLuong");
            da.DeleteCommand = cmd;
            da.Update(ds);

        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            ds.RejectChanges();
        }

        private void btTongLuong_Click(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt32(cobSoLuong.Text);
            int songay = Convert.ToInt32(cobSoNgay.Text);
            int dongia = Convert.ToInt32(txtdongia.Text);
            int hesoluong = Convert.ToInt32(txthsl.Text);
            lbTongLuong.Text = Convert.ToString(soluong * songay * dongia * hesoluong);
        }

        private void dgvbangluong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvbangluong.Rows[e.RowIndex];
                txtmaluong.Text = row.Cells[0].Value.ToString();
                txthsl.Text = row.Cells[1].Value.ToString();
                cbbThang.Text = row.Cells[2].Value.ToString();
                txtdongia.Text = row.Cells[3].Value.ToString();
                txtmanv.Text = row.Cells[4].Value.ToString();


            }
        }
  
    }
}
