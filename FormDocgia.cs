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
using System.Globalization;

namespace BTLON_NHOMTHUVIEN
{
    public partial class FormDocgia : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-F4RS79DJ\\SQLEXPRESS;Initial Catalog=DUANNHOMTHUVIEN;Integrated Security=True;Encrypt=False");
        private void load_dg()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select * from docgia";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            dgvThongTinDocGia.DataSource = dt;
            dgvThongTinDocGia.Refresh();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }
        public FormDocgia()
        {
            InitializeComponent();
        }

        private void FormDocgia_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            load_dg();
        }
        private bool checktrungmadg(string madg)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select count(*) From docgia where madg='" + madg + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = int.Parse(cmd.ExecuteScalar().ToString());
            if (kq > 0)
                return true;
            else return false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string madg = txtMadocgia.Text.Trim();
            string htdocgia = txtHoten.Text.Trim();
            DateTime ngaysinh = dtNgaysinh.Value;
            string gt = cboGioitinh.SelectedItem.ToString();
            string lop = txtLop.Text.Trim();
            if (madg == "")
            {
                MessageBox.Show("Bạn chưa nhập mã độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMadocgia.Focus();
                return;
            }
            if (checktrungmadg(madg))
            {
                MessageBox.Show("Mã độc giả đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMadocgia.Focus();
                return;
            }
            if (htdocgia == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoten.Focus();
                return;
            }
            if (ngaysinh == null)
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNgaysinh.Focus();
                return;
            }
            if (gt == "")
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGioitinh.Focus();
                return;
            }
            if (lop == "")
            {
                MessageBox.Show("Bạn chưa nhập lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLop.Focus();
                return;
            }
            // ket noi csdl
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Insert docgia Values (@madg,@htdocgia,@ngaysinh,@gioitinh,@lop)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@madg", SqlDbType.NVarChar, 50).Value = madg;
            cmd.Parameters.Add("@htdocgia", SqlDbType.NVarChar, 50).Value = htdocgia;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = ngaysinh;
            cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 50).Value = gt;
            cmd.Parameters.Add("@lop", SqlDbType.NVarChar, 200).Value = lop;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_dg();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string madg = txtMadocgia.Text.Trim();
            string htdocgia = txtHoten.Text.Trim();
            DateTime ngaysinh = dtNgaysinh.Value;
            string gioitinh = cboGioitinh.SelectedItem.ToString();
            string lop = txtLop.Text.Trim();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Update docgia Set htdocgia=N'" + htdocgia + "',ngaysinh=@ngaysinh,gioitinh=N'" + gioitinh + "' Where madg=N'" + madg + "'";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = ngaysinh;
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            load_dg();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn xoá hay không?", "Detele Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                string madg = txtMadocgia.Text.Trim();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "Delete docgia Where madg='" + madg + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                load_dg();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvThongTinDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMadocgia.Text = dgvThongTinDocGia.Rows[i].Cells[0].Value.ToString();
            txtHoten.Text = dgvThongTinDocGia.Rows[i].Cells[1].Value.ToString();
            dtNgaysinh.Value = DateTime.Parse(dgvThongTinDocGia.Rows[i].Cells[2].Value.ToString());
            cboGioitinh.SelectedItem = dgvThongTinDocGia.Rows[i].Cells[3].Value.ToString();
            txtLop.Text = dgvThongTinDocGia.Rows[i].Cells[4].Value.ToString();
            txtMadocgia.Enabled = false;
        }
    }
}
