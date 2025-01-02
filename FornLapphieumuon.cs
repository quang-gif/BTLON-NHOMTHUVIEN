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
    public partial class FornLapphieumuon : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T6775II7\\SQLEXPRESS;Initial Catalog=DUANNHOMTHUVIEN;Integrated Security=True;Encrypt=False");
 
        public FornLapphieumuon()
        {
            InitializeComponent();
        }

        private void load_docgia()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql = "select * from docgia ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();
            
            DataRow r = dt.NewRow();
            
            r["madg"] = "---Chọn mã độc giả---";
            dt.Rows.InsertAt(r, 0);

            cbbdocgia.DataSource = dt;
            cbbdocgia.DisplayMember = "madg";
            cbbdocgia.ValueMember = "madg";
        }

        private void load_nhanvien()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql = "select * from nhanvien ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();

            DataRow r = dt.NewRow();
            r["manhanvien"] = "---Chọn mã nhân viên---";
            dt.Rows.InsertAt(r, 0);

            cbbnhanvien.DataSource = dt;
            cbbnhanvien.DisplayMember = "manhanvien";
            cbbnhanvien.ValueMember = "manhanvien";
        }

        private void load_muonsach()
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

            dgv1.DataSource = dt;
            dgv1.Refresh();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void FornLapphieumuon_Load(object sender, EventArgs e)
        {
            btnluu.Enabled = false;
            load_docgia();
            load_nhanvien();
            load_muonsach();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //b1: lay du lieu tu cac control dua vao bien
            string pm = txtphieumuon.Text.Trim();
            string nv = cbbnhanvien.SelectedValue.ToString();
            string dg = cbbdocgia.SelectedValue.ToString();
            

            //b2: ket noi db
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if (pm == "")
            {
                MessageBox.Show("Mã mượn đang còn trống! ");
                txtphieumuon.Focus();
                return;
            }


            if (dg == "---Chọn mã độc giả---")
            {
                MessageBox.Show("Bạn chưa chọn thông tin! ");
                txtphieumuon.Focus();
                return;
            }

            if (nv == "---Chọn mã nhân viên---")
            {
                MessageBox.Show("Bạn chưa chọn thông tin! ");
                txtphieumuon.Focus();
                return;
            }

            string checkSql = "SELECT COUNT(*) FROM muontra WHERE mamuon = @mamuon";
            SqlCommand checkCmd = new SqlCommand(checkSql, con);
            checkCmd.Parameters.Add("@mamuon", SqlDbType.NVarChar, 50).Value = pm;

            int exists = (int)checkCmd.ExecuteScalar();
            if (exists > 0)
            {
                MessageBox.Show("Mã phiếu mượn đã tồn tại, vui lòng nhập mã khác!");
                txtphieumuon.Focus();
                return;
            }

            //b3: tao doi tuong command de thuc hien cau lenh sql
            string sql = "insert muontra values (@mamuon, @madg, @manhanvien)";
            SqlCommand cmd = new SqlCommand(sql, con);

            //b4
            cmd.Parameters.Add("@mamuon", SqlDbType.NVarChar, 50).Value = pm;
            cmd.Parameters.Add("@manhanvien", SqlDbType.NVarChar, 50).Value = nv;
            cmd.Parameters.Add("@madg", SqlDbType.NVarChar, 50).Value = dg;


            
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            MessageBox.Show("Lưu mới thành công!");
            load_muonsach();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string pm = txtphieumuon.Text.Trim();
            string nv = cbbnhanvien.SelectedValue.ToString();
            string dg = cbbdocgia.SelectedValue.ToString();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if (string.IsNullOrEmpty(pm)) 
            { 
                MessageBox.Show("Vui lòng chọn thông tin sửa!" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "Update muontra set manhanvien = '" + nv + "', madg =  '"+dg+"' where mamuon = '"+pm+"'";
            SqlCommand cmd = new SqlCommand(@sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            MessageBox.Show("Sửa thành công!");
            load_muonsach();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn xoá hay không?", "Detele Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                
                string pm = txtphieumuon.Text.Trim();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "Delete muontra Where mamuon ='" + pm + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            load_muonsach();

        }



        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
           
            txtphieumuon.Text = dgv1.Rows[i].Cells[0].Value.ToString();
            cbbdocgia.SelectedValue = dgv1.Rows[i].Cells[1].Value.ToString();
            cbbnhanvien.SelectedValue = dgv1.Rows[i].Cells[2].Value.ToString();
            txtphieumuon.Enabled = false;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtphieumuon.Enabled = true;
            txtphieumuon.Text = "";
            load_docgia();
            load_nhanvien();
        }

        private void txtphieumuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f = new FormChitietmuontra();
            f.Show();
            this.Hide();
        }
    }
}
