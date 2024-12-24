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
    public partial class FormTacgia : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T6775II7\\SQLEXPRESS;Initial Catalog=DUANNHOMTHUVIEN;Integrated Security=True;Encrypt=False");
        public FormTacgia()
        {
            InitializeComponent();
        }
        DataTable tb1;
        private void load_tacgia(string mtg, string ttg)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select * from tacgia where " +
                "matg like '%' +@matg+ '%' and " +
                "httacgia like '%'+@httacgia+'%' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@matg", SqlDbType.NVarChar, 50).Value = mtg;
            cmd.Parameters.Add("@httacgia", SqlDbType.NVarChar, 50).Value = ttg;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            tb1 = new DataTable();
            da.Fill(tb1);
            cmd.Dispose();
            con.Close();
            dgvCapNhatTacGia.DataSource = tb1;
            dgvCapNhatTacGia.Refresh();
        }
        private bool checktrungmatg(string mtg)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select count(*) From tacgia where matg='" + mtg + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = int.Parse(cmd.ExecuteScalar().ToString());
            if (kq > 0)
                return true;
            else return false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaTacGia.Enabled = true;
            txtMaTacGia.Text = "";
            txtHoTen.Text = "";
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            load_tacgia("", "");
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
                string mtg = txtMaTacGia.Text.Trim();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "Delete tacgia Where matg='" + mtg + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            load_tacgia("", "");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mtg = txtMaTacGia.Text.Trim();
            string ttg = txtHoTen.Text.Trim();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "update tacgia Set httacgia=N'" + ttg + "' where matg='" + mtg + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sửa thành công!");
            load_tacgia("", "");
        }

        private void dgvCapNhatTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaTacGia.Text = dgvCapNhatTacGia.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvCapNhatTacGia.Rows[i].Cells[1].Value.ToString();
            txtMaTacGia.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mtg = txtMaTacGia.Text.Trim();
            string ttg = txtHoTen.Text.Trim();
            if (mtg == "")
            {
                MessageBox.Show("Mã tác giả rỗng");
                txtMaTacGia.Focus();
                return;
            }
            if (checktrungmatg(mtg))
            {
                MessageBox.Show("Trùng mã tác giả");
                txtMaTacGia.Focus();
                return;
            }
            if (ttg == "")
            {
                MessageBox.Show("Tên tác giả không được rỗng!");
                txtHoTen.Focus();
                return;
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "Insert tacgia Values (N'" + mtg + "',N'" + ttg + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công");
            load_tacgia("", "");

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void FormTacgia_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            load_tacgia("", "");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            load_tacgia("", "");
        }
    }
}
