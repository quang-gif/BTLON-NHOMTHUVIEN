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
    public partial class FormTheloai : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T6775II7\\SQLEXPRESS;Initial Catalog=DUANNHOMTHUVIEN;Integrated Security=True;Encrypt=False");
        public FormTheloai()
        {
            InitializeComponent();
        }

        DataTable tb1;
        private void load_theloai(string ml, string tl)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select * from theloai where " +
                "matheloai like '%' +@matheloai+ '%' and " +
                "tentheloai like '%'+@tentheloai+'%' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@matheloai", SqlDbType.NVarChar, 50).Value = ml;
            cmd.Parameters.Add("@tentheloai", SqlDbType.NVarChar, 100).Value = tl;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            tb1 = new DataTable();
            da.Fill(tb1);
            cmd.Dispose();
            con.Close();
            dgvCapNhatTheLoai.DataSource = tb1;
            dgvCapNhatTheLoai.Refresh();
        }
        private bool checktrungmatheloai(string ml)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select count(*) From theloai where matheloai='" + ml + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = int.Parse(cmd.ExecuteScalar().ToString());
            if (kq > 0)
                return true;
            else return false;
        }
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn xoá hay không?", "Detele Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                string ml = txtMaTheLoai.Text.Trim();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "Delete theloai Where matheloai='" + ml + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            txtMaTheLoai.Enabled = true;
            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
            txtMaTheLoai.Focus();

            load_theloai("", "");
            
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string ml = txtMaTheLoai.Text.Trim();
            string tl = txtTenTheLoai.Text.Trim();
            if (tl == "")
            {
                MessageBox.Show("Tên thể loại không được rỗng!");
                txtTenTheLoai.Focus();
                return;
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "update theloai Set tentheloai=N'" + tl + "' where matheloai='" + ml + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Cập nhật thành công!");
            txtMaTheLoai.Enabled=true;
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
            load_theloai("", "");
        }
        private void dgvCapNhatTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaTheLoai.Text = dgvCapNhatTheLoai.Rows[i].Cells[0].Value.ToString();
            txtTenTheLoai.Text = dgvCapNhatTheLoai.Rows[i].Cells[1].Value.ToString();
            txtMaTheLoai.Enabled = false; //để không sửa được mã loại
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ml = txtMaTheLoai.Text.Trim();
            string tl = txtTenTheLoai.Text.Trim();
            if (ml == "")
            {
                MessageBox.Show("Mã thể loại không được rỗng");
                txtMaTheLoai.Focus();
                return;
            }
            if (checktrungmatheloai(ml))
            {
                MessageBox.Show("Trùng mã thể loại");
                txtMaTheLoai.Focus();
                return;
            }
            if (tl == "")
            {
                MessageBox.Show("Tên thể loại không được rỗng!");
                txtTenTheLoai.Focus();
                return;
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "Insert theloai Values (N'" + ml + "',N'" + tl + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công");
            load_theloai("", "");
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnTimkiem.Enabled = true;
            btnLuu.Enabled = false;
        }
        private void FormTheloai_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            load_theloai("", "");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled=true;
            btnTimkiem.Enabled=false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            load_theloai("", "");
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string ml = txtMaTheLoai.Text.Trim();
            string tl = txtTenTheLoai.Text.Trim();
            load_theloai(ml, tl);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
            txtMaTheLoai.Enabled=true;
            txtTenTheLoai.Enabled = true;
            btnThem.Enabled=true;
            btnSua.Enabled=true;
            btnXoa.Enabled=true;
            btnLuu.Enabled=false;
            btnTimkiem.Enabled =true;
            load_theloai("", "");
        }
    }
}





