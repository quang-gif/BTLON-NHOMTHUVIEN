using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace BTLON_NHOMTHUVIEN
{
    public partial class FormQuanlysach : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU9S3VB\\SQLEXPRESS01;Initial Catalog=DUANNHOMTHUVIEN;Integrated Security=True;Encrypt=False");
        public FormQuanlysach()
        {
            InitializeComponent();
        }
        DataTable dt1;
        private void load_Nhaxuatban()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql = "select * from nhaxuatban ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();

            DataRow r = dt.NewRow();

            r["manxb"] = "---Chọn mã nhà xuất bản---";
            dt.Rows.InsertAt(r, 0);

            cboManxb.DataSource = dt;
            cboManxb.DisplayMember = "manxb";
            cboManxb.ValueMember = "manxb";

        }
        private void load_theloai()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql = "select * from theloai ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();

            DataRow r = dt.NewRow();

            r["matheloai"] = "---Chọn mã thể loại---";
            dt.Rows.InsertAt(r, 0);

            cboTheloai.DataSource = dt;
            cboTheloai.DisplayMember = "matheloai";
            cboTheloai.ValueMember = "matheloai";

        }
        private void load_tacgia()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql = "select * from tacgia ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();

            DataRow r = dt.NewRow();

            r["matg"] = "---Chọn mã tác giả---";
            dt.Rows.InsertAt(r, 0);

            cboMatg.DataSource = dt;
            cboMatg.DisplayMember = "matg";
            cboMatg.ValueMember = "matg";

        }
        private bool checktrung(string ms)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Select count(*) From quanlysach where masach = '" + ms + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = int.Parse(cmd.ExecuteScalar().ToString());
            if (kq > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void load_Quanlysach()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select * from quanlysach";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            dt1 = new DataTable();
            adapter.Fill(dt1);
            con.Close();
            dgvCapnhatsach.DataSource = dt1;
            dgvCapnhatsach.Refresh();
           
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            load_Quanlysach();
            txtMasach.Enabled = true;
            dtnamxb.Value = DateTime.Now;
            txtMasach.Focus();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string ms = txtMasach.Text.Trim();
            string ts = txtTensach.Text.Trim();
            DateTime nxb = dtnamxb.Value;
            string manxb = cboManxb.SelectedItem.ToString();
            string tls = cboTheloai.SelectedItem.ToString();
            string mtg = cboMatg.SelectedItem.ToString();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Update quanlysach Set tensach=N'" + ts + "',namxb=@namxb,manxb=N'" + manxb + "',matheloai=N'" + tls + "',matg=N'" + mtg + "' Where masach=N'" + ms + "'";
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
            load_Nhaxuatban();
            load_theloai();
            load_tacgia();
            txtMasach.Focus();
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
                txtMasach.Text = "";
                txtTensach.Text = "";
                load_Nhaxuatban();
                load_theloai();
                load_tacgia();
                txtMasach.Enabled = true;
                btnThem.Focus();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ms = txtMasach.Text.Trim();
            string ts = txtTensach.Text.Trim();
            DateTime nxb = dtnamxb.Value;
            string manxb = cboManxb.SelectedValue.ToString();
            string tls = cboTheloai.SelectedValue.ToString();
            string mtg = cboMatg.SelectedValue.ToString();

            if (checktrung(ms) == true)
            {
                MessageBox.Show("Mã sách đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasach.Focus();
                return;
            }
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
            if (manxb == "---Chọn mã nhà xuất bản---")
            {
                MessageBox.Show("Bạn chưa chọn nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasach.Focus();
                return;
            }
            if (tls == "---Chọn mã thể loại---")
            {
                MessageBox.Show("Bạn chưa chọn thể loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasach.Focus();
                return;
            }
            if (mtg == "---Chọn mã tác giả---")
            {
                MessageBox.Show("Bạn chưa chọn tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasach.Focus();
                return;
            }
            // ket noi csdl
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Insert quanlysach Values (@masach,@tensach,@namxb,@manxb,@matheloai,@matg)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add(@"masach", SqlDbType.NVarChar, 50).Value = ms;
            cmd.Parameters.Add(@"tensach", SqlDbType.NVarChar, 50).Value = ts;
            cmd.Parameters.Add(@"namxb", SqlDbType.Date).Value = nxb;
            cmd.Parameters.Add(@"manxb", SqlDbType.NVarChar, 50).Value = manxb;
            cmd.Parameters.Add(@"matheloai", SqlDbType.NVarChar, 50).Value = tls;
            cmd.Parameters.Add(@"matg", SqlDbType.NVarChar, 50).Value = mtg;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_Quanlysach();
            btnLuu.Enabled = false;
            btnThem.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCapnhatsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMasach.Text = dgvCapnhatsach.Rows[i].Cells["Column1"].Value.ToString();
                txtTensach.Text = dgvCapnhatsach.Rows[i].Cells["Column2"].Value.ToString();
                dtnamxb.Value = DateTime.Parse(dgvCapnhatsach.Rows[i].Cells["Column3"].Value.ToString());
                cboManxb.Text = dgvCapnhatsach.Rows[i].Cells["Column4"].Value.ToString();
                cboTheloai.Text = dgvCapnhatsach.Rows[i].Cells["Column5"].Value.ToString();
                cboMatg.Text = dgvCapnhatsach.Rows[i].Cells["Column6"].Value.ToString();
                txtMasach.Enabled = false;
            }

        }
        private void Excel(DataTable tb, string sheetname)
        {
            e_excel.Application oExcel = new e_excel.Application();
            e_excel.Workbooks oBooks;
            e_excel.Sheets oSheets;
            e_excel.Workbook oBook;
            e_excel.Worksheet oSheet;
            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (e_excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (e_excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            // Tạo phần đầu nếu muốn

            e_excel.Range head = oSheet.get_Range("A1", "F1");
            head.MergeCells = true;
            head.Value2 = "Danh sách các đầu sách";
            head.Font.Bold = true;
            head.Font.Name = "Aptos Narrow";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã sách";
            cl1.ColumnWidth = 20.0;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên sách";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Năm xuất bản";
            cl3.ColumnWidth = 20.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Mã nhà xuất bản";
            cl4.ColumnWidth = 20.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Mã thể loại";
            cl5.ColumnWidth = 20.0;
            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Mã tác giả";
            cl6.ColumnWidth = 20.0;

            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "F3");
            //
            rowHead.Font.Bold = true;

            // Kẻ viền
            rowHead.Borders.LineStyle = e_excel.Constants.xlSolid;

            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)

                {
                    if (c == 2)
                        arr[r, c] = "'" + dr[c].ToString();
                    else
                        arr[r, c] = dr[c];
                }
            }
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
            e_excel.Range c1 = (e_excel.Range)oSheet.Cells[rowStart, columnStart];
            e_excel.Range c2 = (e_excel.Range)oSheet.Cells[rowEnd, columnEnd];
            e_excel.Range range = oSheet.get_Range(c1, c2);
            range.Value2 = arr;
            range.Borders.LineStyle = e_excel.Constants.xlSolid;
            e_excel.Range c3 = (e_excel.Range)oSheet.Cells[rowEnd, columnStart];
            e_excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
        }

        private void txtExcel_Click(object sender, EventArgs e)
        {
            if (dt1 == null || dt1.Rows.Count == 0 || dt1.Columns.Count == 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ hoặc trống!");
                return;
            }

            load_Quanlysach();
            Excel(dt1, "DSQuanlysach");
        }

      
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            load_Quanlysach();
            load_Nhaxuatban();
            load_theloai();
            load_tacgia();
            txtMasach.Text = "";
            txtTensach.Text = "";
            txtMasach.Enabled = true;
            txtMasach.Focus();
        }
    }
}


