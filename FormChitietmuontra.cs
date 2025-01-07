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

        }


        private void FormChitietmuontra_Load(object sender, EventArgs e)
        {
            cbbmasach.Enabled = false;
            dtmuon.Enabled = false;
            load1();
            load2();
            load3();
            Capnhatsoluong();
        }



        private void btntrasach_Click(object sender, EventArgs e)
        {

        }
        //load chi tiet muon tra
        DataTable dt1;
        private void load1()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql = "Select mamuon, tensach, htdocgia, ngaytra, hotennv FROM chitietmuontra " +
                "INNER JOIN quanlysach ON quanlysach.masach = chitietmuontra.masach " +
                "INNER JOIN docgia ON docgia.madg = chitietmuontra.madg " +
                "INNER JOIN nhanvien ON nhanvien.manhanvien = chitietmuontra.manhanvien ";
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

            string sql = "select * from chitietmuontra";
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
            if (e.RowIndex >= 0 && e.RowIndex < dgv2.Rows.Count)
            {

                var cellMamuon = dgv2.Rows[e.RowIndex].Cells[0].Value;
                var cellNgayTra = dgv2.Rows[e.RowIndex].Cells["ngaytra"].Value;

                if (cellMamuon != null)
                    cbbphieumuon.SelectedValue = cellMamuon.ToString();



                if (cellNgayTra != null && DateTime.TryParse(cellNgayTra.ToString(), out DateTime ngayTra))
                {
                    dttra.Value = ngayTra;
                }

                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ hoặc dòng trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            head.Value2 = "DANH SÁCH MƯỢN TRẢ";
            head.Font.Bold = true;
            head.Font.Name = "Aptos Narrow";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ PHIẾU";
            cl1.ColumnWidth = 10.0;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN SÁCH";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "TÊN ĐỘC GIẢ";
            cl3.ColumnWidth = 20.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "NGÀY TRẢ";
            cl4.ColumnWidth = 20.0;
            e_excel.Range cl4_1 = oSheet.get_Range("D4", "D1000");
            cl4_1.Columns.NumberFormat = "dd/mm/yyyy";
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "NHÂN VIÊN";
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





        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();  
        }

        private void cbbphieumuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbphieumuon.SelectedIndex > 0)
            {
                string mp = cbbphieumuon.SelectedValue.ToString();

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string sql = "SELECT masach, ngaymuon, ngaytra FROM chitietmuontra WHERE mamuon = @mamuon";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mamuon", mp);

                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    // Gán dữ liệu vào các điều khiển
                    cbbmasach.SelectedValue = reader["masach"].ToString();
                    dtmuon.Value = DateTime.Parse(reader["ngaymuon"].ToString());
                    dttra.Value = DateTime.Parse(reader["ngaytra"].ToString());
                }
                else
                {
                    // Nếu không có dữ liệu
                    MessageBox.Show("Không tìm thấy thông tin cho mã phiếu mượn này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
                cmd.Dispose();
                con.Close();
            }
        }

        private void btngiahan_Click_1(object sender, EventArgs e)
        {
            DateTime ngayMuon = dtmuon.Value;
            DateTime ngayTra = dttra.Value;

            if (ngayTra <= ngayMuon)
            {
                MessageBox.Show("Ngày trả phải sau ngày mượn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string sql = "UPDATE chitietmuontra SET ngaytra = @ngaytra WHERE mamuon = @mamuon";
            SqlCommand cmd = new SqlCommand(sql, con);
            
            cmd.Parameters.AddWithValue("@ngaytra", ngayTra);
            cmd.Parameters.AddWithValue("@mamuon", cbbphieumuon.SelectedValue.ToString());

            

            
            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Gia hạn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load1();

            }
            else
            {
                MessageBox.Show("Không thể gia hạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }



        private void btnexcel_Click_1(object sender, EventArgs e)
        {
            if (dt1 == null || dt1.Rows.Count == 0 || dt1.Columns.Count == 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ hoặc trống!");
                return;
            }

            load1();
            Excel(dt1, "DSPhieuMuon");
        }

        private void Capnhatsoluong()
        {
            int sl = dgv2.Rows.Count;
            label6.Text = sl.ToString();
            label6.ForeColor = Color.Red;
        }

        private void btntrasach_Click_1(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn xoá hay không?", "Detele Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {

                string mm = cbbphieumuon.SelectedValue.ToString();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "Delete chitietmuontra Where mamuon ='" + mm + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                load1();
                load2();
                load3();
                Capnhatsoluong();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbbphieumuon.SelectedIndex > 0)
            {
                string mp = cbbphieumuon.SelectedValue.ToString();

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string sql = "SELECT mamuon, ngaytra, tensach, hotennv, htdocgia FROM chitietmuontra " +
                             "INNER JOIN quanlysach ON quanlysach.masach = chitietmuontra.masach " +
                             "INNER JOIN docgia ON docgia.madg = chitietmuontra.madg " +
                             "INNER JOIN nhanvien ON nhanvien.manhanvien = chitietmuontra.manhanvien " +
                             "WHERE mamuon = @mamuon";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mamuon", mp);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmd.Dispose();
                con.Close();

                dgv2.DataSource = dt;
                dgv2.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load1();
            load2();
            load3();
    
        }

        private void FormChitietmuontra_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
