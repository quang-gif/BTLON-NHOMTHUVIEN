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
    public partial class FormChitietmuontra : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ShibaInu\\SQLEXPRESS01;Initial Catalog=ThuVien;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        public FormChitietmuontra()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new FornLapphieumuon();
            f.Show();
            this.Hide();
        }

        private void btnthem2_Click(object sender, EventArgs e)
        {
            btnluu2.Enabled = true;
            cbbphieumuon.Enabled = true;
            cbbmasach.Enabled = true;
            btntrasach.Enabled = true;
            dtmuon.Enabled = true;
            dttra.Enabled = true;
            txttinhtrang.Enabled = true;
            btnluu2.Text = "Lưu";
            load2();
            load3();
        }

        private void FormChitietmuontra_Load(object sender, EventArgs e)
        {
            btnluu2.Enabled = false;
            cbbphieumuon.Enabled = false;
            cbbmasach.Enabled = false;
            btntrasach.Enabled = false;
            dtmuon.Enabled = false;
            dttra.Enabled = false;
            txttinhtrang.Enabled = false;

            load1();
            load2();
            load3();
        }

        private void btngiahan_Click(object sender, EventArgs e)
        {
            btnluu2.Text = "Cập nhật";
            btnluu2.Enabled = true;
            cbbmasach.Enabled = false;
            cbbphieumuon.Enabled = false;
            dtmuon.Enabled = false;
            dttra.Enabled = true;
            txttinhtrang.Enabled = true;
        }

        private void btnluu2_Click(object sender, EventArgs e)
        {
            // Kiểm tra giá trị trống
            if (cbbphieumuon.Text == "---Chọn mã phiếu mượn---" ||
                cbbmasach.Text == "---Chọn mã sách---" ||
                string.IsNullOrWhiteSpace(txttinhtrang.Text))
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ các control
            string mm = cbbphieumuon.SelectedValue?.ToString();
            string ms = cbbmasach.SelectedValue?.ToString();
            DateTime nmuon = dtmuon.Value;
            DateTime ntra = dttra.Value;
            string tt = txttinhtrang.Text.Trim();

            // Kiểm tra logic ngày mượn và ngày trả
            if (ntra < nmuon)
            {
                MessageBox.Show("Ngày trả phải sau ngày mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                // Mở kết nối nếu chưa mở
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (btnluu2.Text == "Cập nhật")
                {
                    string sql1 = "UPDATE chitietmuontra SET ngaytra = @ngaytra, tinhtrangsach = @tinhtrangsach WHERE masach = @masach";
                    using (SqlCommand cmd1 = new SqlCommand(sql1, con))
                    {
                        cmd1.Parameters.Add("@ngaytra", SqlDbType.Date).Value = ntra;
                        cmd1.Parameters.Add("@tinhtrangsach", SqlDbType.NVarChar, 50).Value = tt;
                        cmd1.Parameters.Add("@masach", SqlDbType.NVarChar, 50).Value = ms;

                        cmd1.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã cập nhật thành công!");
                    btnluu2.Enabled = false;
                    
                }
                else if (btnluu2.Text == "Lưu")
                {
                    string checkSql = "SELECT COUNT(*) FROM chitietmuontra WHERE masach = '" + ms + "'";
                    SqlCommand checkCmd = new SqlCommand(checkSql, con);

                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("Sách đã được mượn, vui lòng chọn sách khác!");
                        return;
                    }

                    string sql = "INSERT INTO chitietmuontra (mamuon, masach, ngaymuon, ngaytra, tinhtrangsach) VALUES (@mamuon, @masach, @ngaymuon, @ngaytra, @tinhtrangsach)";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@mamuon", SqlDbType.NVarChar, 50).Value = mm;
                        cmd.Parameters.Add("@masach", SqlDbType.NVarChar, 50).Value = ms;
                        cmd.Parameters.Add("@ngaymuon", SqlDbType.Date).Value = nmuon;
                        cmd.Parameters.Add("@ngaytra", SqlDbType.Date).Value = ntra;
                        cmd.Parameters.Add("@tinhtrangsach", SqlDbType.NVarChar, 50).Value = tt;

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Lưu thành công!");
                }

                load1();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            // Bật lại các control
            cbbmasach.Enabled = true;
            cbbphieumuon.Enabled = true;
            dtmuon.Enabled = true;
        }


        private void btntrasach_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn xoá hay không?", "Detele Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {

                string ms = cbbmasach.SelectedValue.ToString();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "Delete chitietmuontra Where masach ='" + ms + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                load1();
                
            }
        }
        //load chi tiet muon tra
        private void load1()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql = "select * from chitietmuontra";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();

            dgv2.DataSource = dt;
            dgv2.Refresh();
        }
        //load muon tra
        private void load2()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql = "select * from muontra";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();

            DataRow r = dt.NewRow();
            r["mamuon"] = "---Chọn mã phiếu mượn---";
            dt.Rows.InsertAt(r, 0);

            cbbphieumuon.DataSource = dt;
            cbbphieumuon.DisplayMember = "mamuon";
            cbbphieumuon.ValueMember = "mamuon";
        }

        private void load3()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql = "select * from quanlysach";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();

            DataRow r = dt.NewRow();
            r["masach"] = "---Chọn mã sách---";
            dt.Rows.InsertAt(r, 0);

            cbbmasach.DataSource = dt;
            cbbmasach.DisplayMember = "masach";
            cbbmasach.ValueMember = "masach";
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            cbbphieumuon.SelectedValue = dgv2.Rows[i].Cells[0].Value.ToString();
            cbbmasach.SelectedValue = dgv2.Rows[i].Cells[1].Value.ToString();
            dtmuon.Value = DateTime.Parse(dgv2.Rows[i].Cells[2].Value.ToString());
            dttra.Value = DateTime.Parse(dgv2.Rows[i].Cells[3].Value.ToString());
            txttinhtrang.Text = dgv2.Rows[i].Cells[4].Value.ToString();
        }
    }
}
