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
    public partial class NhanVien : Form
    {
        string cnStr = "";
        SqlConnection cn;
        
        DataSet ds = new DataSet();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            
            string sql = " select * from NhanVien";
            dgvNhanVien.DataSource = GetDataset(sql).Tables[0];




            DataTable nv = new DataTable();
            nv = GetDataset(sql).Tables[0];
            txtMaNV.DataBindings.Add("Text", nv, "MaNV");
            txtHoNV.DataBindings.Add("Text", nv, "HoNV");
            txtTen.DataBindings.Add("Text", nv, "Ten");
            txtDiaChi.DataBindings.Add("Text", nv, "DiaChi");
            txtDienThoai.DataBindings.Add("Text", nv, "DienThoai");
            txtMaPB.DataBindings.Add("Text", nv, "MaPB");   
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

        private void dvgNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;
            //txtMaNV.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
            //txtHoNV.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            //txtTen.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
            //txtDiaChi.Text = dgvNhanVien.Rows[index].Cells[3].Value.ToString();
            //txtDienThoai.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
            //txtMaPB.Text = dgvNhanVien.Rows[index].Cells[5].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string ins = "INSERT INTO NhanVien(MaNV, HoNV, Ten, DiaChi,DienThoai,MaPB) VALUES (@idnv, @ho, @ten,@diachi,@dienthoai,@idpb)";
            SqlCommand cmd = new SqlCommand(ins, cn);
            cmd.Parameters.Add("@idnv", SqlDbType.NVarChar, 5, "MaNV");
            cmd.Parameters.Add("@ho", SqlDbType.Int, 10, "HoNV");
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 50, "Ten");
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 5, "DiaChi");
            cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar, 5, "DienThoai");
            cmd.Parameters.Add("@idpb", SqlDbType.NVarChar, 5, "MaPB");
            da.InsertCommand = cmd;
            da.Update(ds);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string upd = "UPDATE NhanVien SET  MaNV = @MaNV , HoNV = @HoNV, Ten = @Ten,DiaChi=@DiaChi,DienThoai=@DienThoai,MaPB=@MaPB WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(upd, cn);
            cmd = new SqlCommand(upd, cn);
            cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "MaNV");
            cmd.Parameters.Add("@HoNV", SqlDbType.Int, 10, "HoNV");
            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 50, "Ten");
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 5, "DiaChi");
            cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar, 5, "DienThoai");
            cmd.Parameters.Add("@MaPB", SqlDbType.NVarChar, 5, "MaPB");
            da.UpdateCommand = cmd;
            da.Update(ds);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string det = "DELETE FROM BangCong WHERE MaCong = @macong";
            SqlCommand cmd = new SqlCommand(det, cn);
            cmd = new SqlCommand(det, cn);
            cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "MaNV");
            da.DeleteCommand = cmd;
            da.Update(ds);
            
        }
    }
}
