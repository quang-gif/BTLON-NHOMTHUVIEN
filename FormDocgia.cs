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
        private void load_dg(string madg, string htdocgia, string ngaysinh, string gioitinh, string lop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select * from docgia";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@madg", SqlDbType.NVarChar, 50).Value = madg;
            cmd.Parameters.Add("@htdocgia", SqlDbType.NVarChar, 50).Value = htdocgia;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
            cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 50).Value = gioitinh;
            cmd.Parameters.Add("@lop", SqlDbType.NVarChar, 50).Value = lop;
            //B3: Tạo đối tượng dataAdapter để lấy kết quả từ cmd
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //B4: Tạo đối tượng dataTable để lấy dữ liệu từ da
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            dgvThongTinDocGia.DataSource = tb;
            dgvThongTinDocGia.Refresh();
        }
        private bool checktrungMaDG(string madg)
        {
            //B1: Kết nối database
            if (con.State == ConnectionState.Closed)
                con.Open();
            //B2: Tạo đối tượng command để thực thi câu lệnh sql
            string sql = "Select count(*) From docgia Where madg='" + madg + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = int.Parse(cmd.ExecuteScalar().ToString()); // Gán kết quả (dạng int) sang lệnh command (dạng string)
            if (kq > 0)
                return true; //Trùng mã loại
            else
                return false; //Ko trùng
        }
        public FormDocgia()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void FormDocgia_Load(object sender, EventArgs e)
        {
            load_dg("", "", "", "", "");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string madg = txtMadocgia.Text.Trim();
            string htdocgia = txtHoten.Text.Trim();
            DateTime ngaysinh = dtNgaysinh.Value;
            string gioitinh = cboGioitinh.SelectedItem.ToString();
            string lop = txtLop.Text.Trim();
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (checktrungMaDG(madg))
            {
                MessageBox.Show("Trùng mã loại");
                txtMadocgia.Focus();
                return; // Dừng ko thực hiện lệnh sau
            }
            string sql = "Insert Sinhvien Values(@Masv,@Hoten,@Ngaysinh,@Gioitinh,@Malop,@Dienthoai,@Diachi)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@madg", SqlDbType.NVarChar, 50).Value = madg;
            cmd.Parameters.Add("@htdocgia", SqlDbType.NVarChar, 50).Value = htdocgia;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = ngaysinh;
            cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 50).Value = gioitinh;
            cmd.Parameters.Add("@lop", SqlDbType.NVarChar, 50).Value = lop;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công");
            load_dg("", "", "", "", "");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string madg = txtMadocgia.Text.Trim();
            string htdocgia = txtHoten.Text.Trim();
            DateTime ngaysinh = dtNgaysinh.Value;
            string gioitinh = cboGioitinh.SelectedItem.ToString();
            string lop = txtLop.Text.Trim();
            //B2: Kết nối database
            if (con.State == ConnectionState.Closed)
                con.Open();
            //B3: Tạo đối tượng command để thực thi câu lệnh sql
            string sql = "Update docgia Set madg=N'" + madg + "',htdocgia=N'" + htdocgia + "',ngaysinh=N" + ngaysinh + "',gioitinh=N" + gioitinh + "'lop=N" + lop + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sửa thành công");
            load_dg("", "", "", "", "");
        }
    }
}
