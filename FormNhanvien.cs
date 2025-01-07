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
    public partial class FormNhanvien : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-F4RS79DJ\\SQLEXPRESS;Initial Catalog = DUANNHOMTHUVIEN; Integrated Security=True;Encrypt=False");
        public FormNhanvien()
        {
            InitializeComponent();
        }
        private void load_Nhanvien()
        {
            if(con.State == ConnectionState.Closed)
            con.Open();
            string sql = "select * from nhanvien";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            dgvThongtin.DataSource = dt;
            dgvThongtin.Refresh();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtManhanvien.Enabled = true;
            txtManhanvien.Focus();
        }

        private void FormNhanvien_Load(object sender, EventArgs e)
        {
            cboGioitinh.Items.Add("- Lựa chọn -");
            cboGioitinh.Items.Add("Nam");
            cboGioitinh.Items.Add("Nữ");
            cboGioitinh.Items.Add("Khác");
            btnLuu.Enabled = false;
            cboGioitinh.SelectedIndex = 0;
            load_Nhanvien();
            btnThem.Focus();
        }
        private bool checktrungmnv(string mnv)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select count(*) From nhanvien where manhanvien='" + mnv + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = int.Parse(cmd.ExecuteScalar().ToString());
            if (kq > 0)
                return true;
            else return false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mnv = txtManhanvien.Text.Trim();
            string tnv = txtHoten.Text.Trim();
            DateTime ns = dtNgaysinh.Value;
            string gt = cboGioitinh.SelectedItem.ToString();
            string dc = txtDiachi.Text.Trim();
            string dt = txtDienthoai.Text.Trim();
            if (mnv == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                return;
            }
            if (checktrungmnv(mnv))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                return;
            }
            if (tnv == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoten.Focus();
                return;
            }
            if (ns == null)
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNgaysinh.Focus();
                return;
            }
            if (gt == "- Lựa chọn -")
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGioitinh.Focus();
                return;
            }
            if (dc == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (dt == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienthoai.Focus();
                return;
            }

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Insert nhanvien Values (@manhanvien,@hotennv,@ngaysinh,@gioitinh,@diachi,@dienthoai)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@manhanvien", SqlDbType.NVarChar, 50).Value = mnv;
            cmd.Parameters.Add("@hotennv", SqlDbType.NVarChar, 50).Value = tnv;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = ns;
            cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 50).Value = gt;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 200).Value = dc;
            cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar, 50).Value = dt;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuu.Enabled = false;
            load_Nhanvien();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn xoá hay không?", "Detele Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                string mnv = txtManhanvien.Text.Trim();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "Delete nhanvien Where manhanvien='" + mnv + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                load_Nhanvien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mnv = txtManhanvien.Text.Trim();
            string tnv = txtHoten.Text.Trim();
            DateTime ns = dtNgaysinh.Value;
            string gt = cboGioitinh.SelectedItem.ToString();
            string dc = txtDiachi.Text.Trim();
            string dt = txtDienthoai.Text.Trim();
            if (tnv == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoten.Focus();
                return;
            }
            if (ns == null)
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNgaysinh.Focus();
                return;
            }
            if (gt == "- Lựa chọn -")
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGioitinh.Focus();
                return;
            }
            if (dc == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (dt == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienthoai.Focus();
                return;
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Update nhanvien Set hotennv=N'" + tnv + "',ngaysinh=@ngaysinh,gioitinh=N'" + gt + "',diachi=N'" + dc + "',dienthoai=N'" + dt + "' Where manhanvien=N'" + mnv + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = ns;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_Nhanvien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvThongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtManhanvien.Text = dgvThongtin.Rows[i].Cells[0].Value.ToString();
                txtHoten.Text = dgvThongtin.Rows[i].Cells[1].Value.ToString();
                dtNgaysinh.Value = DateTime.Parse(dgvThongtin.Rows[i].Cells[2].Value.ToString());
                cboGioitinh.SelectedItem = dgvThongtin.Rows[i].Cells[3].Value.ToString();
                txtDiachi.Text = dgvThongtin.Rows[i].Cells[4].Value.ToString();
                txtDienthoai.Text = dgvThongtin.Rows[i].Cells[5].Value.ToString();
                txtManhanvien.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

       
        private void btnReset_Click(object sender, EventArgs e)
        {
            load_Nhanvien();
            txtManhanvien.Text = "";
            txtHoten.Text = "";
            dtNgaysinh.Value = DateTime.Now;
            cboGioitinh.SelectedIndex = 0;
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtManhanvien.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtManhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

