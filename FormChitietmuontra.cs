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
using e_excel = Microsoft.Office.Interop.Excel;

namespace BTLON_NHOMTHUVIEN
{
    public partial class FormChitietmuontra : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T6775II7\\SQLEXPRESS;Initial Catalog=DUANNHOMTHUVIEN;Integrated Security=True;Encrypt=False");

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
        DataTable dt1;
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

            dt1 = new DataTable();
            da.Fill(dt1);
            cmd.Dispose();
            con.Close();

            dgv2.DataSource = dt1;
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

        private void Excel(DataTable tb1, string sheetname)
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

            e_excel.Range head = oSheet.get_Range("A1", "E1");
            head.MergeCells = true;
            head.Value2 = "DANH SÁCH PHIẾU MƯỢN";
            head.Font.Bold = true;
            head.Font.Name = "Aptos Narrow";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ PHIẾU";
            cl1.ColumnWidth = 10.0;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "MÃ SÁCH";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "NGÀY MƯỢN";
            cl3.ColumnWidth = 20.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "NGÀY TRẢ";
            cl4.ColumnWidth = 20.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "GHI CHÚ";
            cl5.ColumnWidth = 40.0;

            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "E3");
            //
            rowHead.Font.Bold = true;

            // Kẻ viền
            rowHead.Borders.LineStyle = e_excel.Constants.xlSolid;

            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[tb1.Rows.Count, tb1.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < tb1.Rows.Count; r++)
            {
                DataRow dr = tb1.Rows[r];
                for (int c = 0; c < tb1.Columns.Count; c++)

                {
                    if (c == 2 || c == 3)
                        arr[r, c] = "'" + dr[c].ToString();
                    else
                        arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb1.Rows.Count - 1;
            int columnEnd = tb1.Columns.Count;
            // Ô bắt đầu điền dữ liệu
            e_excel.Range c1 = (e_excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            e_excel.Range c2 = (e_excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            e_excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = e_excel.Constants.xlSolid;
            // Căn giữa cột STT
            e_excel.Range c3 = (e_excel.Range)oSheet.Cells[rowEnd, columnStart];
            e_excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;

        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            string mm = cbbphieumuon.SelectedValue?.ToString();
            string ms = cbbmasach.SelectedValue?.ToString();
            DateTime nmuon = dtmuon.Value;
            DateTime ntra = dttra.Value;
            string tt = txttinhtrang.Text.Trim();

            if (dt1 == null || dt1.Rows.Count == 0 || dt1.Columns.Count == 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ hoặc trống!");
                return;
            }

            load1();
            Excel(dt1, "DSPhieuMuon");
        }

    }
}
