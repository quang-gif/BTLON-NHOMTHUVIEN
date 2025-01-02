using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON_NHOMTHUVIEN
{
    public partial class FormNhaxuatban : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T6775II7\\SQLEXPRESS;Initial Catalog=DUANNHOMTHUVIEN;Integrated Security=True;Encrypt=False");
        public FormNhaxuatban()
        {
            InitializeComponent();
        }
        private bool checktrungmnv(string mxb)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select count(*) From nhaxuatban where manxb='" + mxb + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = int.Parse(cmd.ExecuteScalar().ToString());
            if (kq > 0)
                return true;
            else return false;
        }
        private void load_nhaxb()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "Select * from nhaxuatban";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            dgvCapNhatNhaXB.DataSource = tb;
            dgvCapNhatNhaXB.Refresh();
        }
        private void FormNhaxuatban_Load(object sender, EventArgs e)
        {
            load_nhaxb();
            btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mxb = txtMaNhaXB.Text.Trim();
            string txb = txtTenNhaXB.Text.Trim();
            string dc = txtDiaChi.Text.Trim(); 
            string dt = txtSoDienThoai.Text.Trim();
            if (mxb == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhaXB.Focus();
                return;
            }
            if (checktrungmnv(mxb))
            {
                MessageBox.Show("Mã nhà xuất bản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhaXB.Focus();
                return;
            }
            if (txb == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhaXB.Focus();
                return;
            }
            if (dc == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhaXB.Focus();
                return;
            }
            if (dt == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhaXB.Focus();
                return;
            }
            if (con.State == ConnectionState.Closed) con.Open();
            string sql = "Insert nhaxuatban values('"+mxb+"','"+txb+"','"+dc+"','"+dt+"')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công!");
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

            load_nhaxb();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mxb = txtMaNhaXB.Text.Trim();
            string txb = txtTenNhaXB.Text.Trim();
            string dc = txtDiaChi.Text.Trim();
            string dt = txtSoDienThoai.Text.Trim();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Update nhaxuatban Set tennxb=N'" + txb + "',diachi=N'" + dc + "',phone=N'" + dt + "' Where manxb='" + mxb + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            load_nhaxb() ;
        }

        private void dgvCapNhatNhaXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaNhaXB.Text = dgvCapNhatNhaXB.Rows[i].Cells[0].Value.ToString();
            txtTenNhaXB.Text = dgvCapNhatNhaXB.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvCapNhatNhaXB.Rows[i].Cells[2].Value.ToString();
            txtSoDienThoai.Text = dgvCapNhatNhaXB.Rows[i].Cells[3].Value.ToString();
            txtMaNhaXB.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn xoá hay không?", "Detele Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                string mxb = txtMaNhaXB.Text.Trim();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "Delete nhaxuatban Where manhanvien='" + mxb + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                load_nhaxb();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNhaXB.Enabled = true;
            txtMaNhaXB.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtTenNhaXB.Text = "";
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            load_nhaxb() ;
        }
    }
}
