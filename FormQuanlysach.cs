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
    public partial class FormQuanlysach : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T6775II7\\SQLEXPRESS;Initial Catalog=DUANNHOMTHUVIEN;Integrated Security=True;Encrypt=False");
        public FormQuanlysach()
        {
            InitializeComponent();
        }
        private void load_Quanlysach()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select * from quanlysach";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            dgvCapnhatsach.DataSource = dt;
            dgvCapnhatsach.Refresh();
        }
        private void checktrungmasach(string ms)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select * from quanlysach where masach='" + txtMasach.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Mã sách đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasach.Focus();
                dr.Close();
                return;
            }
            dr.Close();
            con.Close();
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            load_Quanlysach();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string ms = txtMasach.Text.Trim();
            string ts = txtTensach.Text.Trim();
            DateTime nxb = dtnamxb.Value;
            string manxb = txtManxb.Text.Trim();
            string tls = txtTheloaisach.Text.Trim();
            string mtg = txtMatacgia.Text.Trim();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Update quanlysach Set tensach=N'" + ts + "',namxb=@namxb,manxb=N'" + manxb + "',matheloai=N'" + tls + "',matacgia=N'" + mtg + "' Where masach=N'" + ms + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add(@"namxb", SqlDbType.Date).Value = nxb;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_Quanlysach();
        }

        private void FormQuanlysach_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            load_Quanlysach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn xoá hay không?", "Detele Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                string ms = txtMasach.Text.Trim();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "Delete quanlysach Where masach='" + ms + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                load_Quanlysach();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ms = txtMasach.Text.Trim();
            string ts = txtTensach.Text.Trim();
            DateTime nxb = dtnamxb.Value;
            string manxb = txtManxb.Text.Trim();
            string tls = txtTheloaisach.Text.Trim();
            string mtg = txtMatacgia.Text.Trim();
            if (ms == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasach.Focus();
                return;
            }
            if (ts == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTensach.Focus();
                return;
            }
            if (nxb == null)
            {
                MessageBox.Show("Bạn chưa nhập năm xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtnamxb.Focus();
                return;
            }
            if (manxb == "")
            {
                MessageBox.Show("Bạn chưa chọn nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManxb.Focus();
                return;
            }
            if (tls == "")
            {
                MessageBox.Show("Bạn chưa chọn thể loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTheloaisach.Focus();
                return;
            }
            if (mtg == "")
            {
                MessageBox.Show("Bạn chưa chọn tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatacgia.Focus();
                return;
            }
            // ket noi csdl
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Insert quanlysach Values (@masach,@tensach,@namxb,@manxb,@matheloai,@matacgia)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add(@"masach", SqlDbType.NVarChar, 50).Value = ms;
            cmd.Parameters.Add(@"tensach", SqlDbType.NVarChar, 50).Value = ts;
            cmd.Parameters.Add(@"namxb", SqlDbType.Date).Value = nxb;
            cmd.Parameters.Add(@"manxb", SqlDbType.NVarChar, 50).Value = manxb;
            cmd.Parameters.Add(@"matheloai", SqlDbType.NVarChar, 50).Value = tls;
            cmd.Parameters.Add(@"matacgia", SqlDbType.NVarChar, 50).Value = mtg;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_Quanlysach();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCapnhatsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMasach.Text = dgvCapnhatsach.Rows[i].Cells[0].Value.ToString();
            txtTensach.Text = dgvCapnhatsach.Rows[i].Cells[1].Value.ToString();
            dtnamxb.Value = DateTime.Parse(dgvCapnhatsach.Rows[i].Cells[2].Value.ToString());
            txtManxb.Text = dgvCapnhatsach.Rows[i].Cells[3].Value.ToString();
            txtTheloaisach.Text = dgvCapnhatsach.Rows[i].Cells[4].Value.ToString();
            txtMatacgia.Text = dgvCapnhatsach.Rows[i].Cells[5].Value.ToString();
            txtMasach.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
