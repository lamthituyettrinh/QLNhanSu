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
    public partial class Chức_Vụ : Form
    {
        string cnStr = "";
        SqlConnection cn;

        DataSet ds = new DataSet();
        public Chức_Vụ()
        {
            InitializeComponent();
        }

        private void Chức_Vụ_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);

            string sql = " select * from ChucVu";
            dgvChucVu.DataSource = GetDataset(sql).Tables[0];




            DataTable cv = new DataTable();
            cv = GetDataset(sql).Tables[0];
            txtMaCV.DataBindings.Add("Text", cv, "MaChucVu");
            txtTenCV.DataBindings.Add("Text", cv, "Ten");
            txtMaNV.DataBindings.Add("Text", cv, "MaNV");
           
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
            string ins = "INSERT INTO ChucVu(MaCV, TenCV, MaNV) VALUES (@idcv, @tencv, @idnv)";
            SqlCommand cmd = new SqlCommand(ins, cn);
            cmd.Parameters.Add("@idcv", SqlDbType.NVarChar, 5, "MaCV");
            cmd.Parameters.Add("@ten", SqlDbType.Int, 10, "TenCV");
            cmd.Parameters.Add("@idnv", SqlDbType.NVarChar, 50, "MaNV");
          
            da.InsertCommand = cmd;
            da.Update(ds);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string upd = "UPDATE ChucVu SET  MaCV=@MaCV,TenCV=@TenCV,MaNV=@MaNV WHERE MaCV = @MaCV";
            SqlCommand cmd = new SqlCommand(upd, cn);
            cmd = new SqlCommand(upd, cn);
            cmd.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "MaCV");
            cmd.Parameters.Add("@TenCV", SqlDbType.Int, 10, "TenCV");
            cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar, 50, "MaNV");
            
            da.UpdateCommand = cmd;
            da.Update(ds);
        }

        private void dgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;
            //txtMaCV.Text = dgvChucVu.Rows[index].Cells[0].Value.ToString();
            //txtTenCV.Text = dgvChucVu.Rows[index].Cells[0].Value.ToString();
            //txtMaNV.Text = dgvChucVu.Rows[index].Cells[1].Value.ToString();
            
        }
    }
}
