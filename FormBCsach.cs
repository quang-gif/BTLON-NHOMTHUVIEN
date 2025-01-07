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
using e_excel=Microsoft.Office.Interop.Excel;

namespace BTLON_NHOMTHUVIEN
{
    public partial class FormBCsach : Form
    {
        
        //Data Source=LAPTOP-F4RS79DJ\\SQLEXPRESS;Initial Catalog = DUANNHOMTHUVIEN; Integrated Security=True;Encrypt=False
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-F4RS79DJ\\SQLEXPRESS;Initial Catalog = DUANNHOMTHUVIEN; Integrated Security=True;Encrypt=False");
        public FormBCsach()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
        DataTable tb1 = new DataTable();
        public void HienThiTatCaDocGia()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            tb1.Clear();
            string sql = "Select chitietmuontra.masach,tensach,namxb,tennxb,tentheloai,ngaymuon,ngaytra FROM quanlysach INNER JOIN nhaxuatban ON quanlysach.manxb = nhaxuatban.manxb INNER JOIN tacgia ON tacgia.matg = quanlysach.matg INNER JOIN theloai ON quanlysach.matheloai = theloai.matheloai INNER JOIN chitietmuontra ON quanlysach.masach = chitietmuontra.masach";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(tb1);
            dataGridView1.DataSource = tb1;
        }
        public void HienThiDocGiaTreHan()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            tb1.Clear();
            string sql = "Select chitietmuontra.masach,tensach,namxb,tennxb,tentheloai,ngaymuon,ngaytra FROM quanlysach INNER JOIN nhaxuatban ON quanlysach.manxb = nhaxuatban.manxb INNER JOIN tacgia ON tacgia.matg = quanlysach.matg INNER JOIN theloai ON quanlysach.matheloai = theloai.matheloai INNER JOIN chitietmuontra ON quanlysach.masach = chitietmuontra.masach WHERE chitietmuontra.ngaytra < GETDATE()";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(tb1);
            dataGridView1.DataSource = tb1;
        }
        public void HienThiDocGiaDangMuon()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            tb1.Clear();
            string sql = "Select chitietmuontra.masach,tensach,namxb,tennxb,tentheloai,ngaymuon,ngaytra FROM quanlysach INNER JOIN nhaxuatban ON quanlysach.manxb = nhaxuatban.manxb INNER JOIN tacgia ON tacgia.matg = quanlysach.matg INNER JOIN theloai ON quanlysach.matheloai = theloai.matheloai INNER JOIN chitietmuontra ON quanlysach.masach = chitietmuontra.masach WHERE chitietmuontra.ngaytra >= GETDATE()";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(tb1);
            dataGridView1.DataSource = tb1;
        }
        private void btnthongke_Click(object sender, EventArgs e)
        {
            if (cbothongke.SelectedItem.ToString() == "Tất cả sách")
            {
                HienThiTatCaDocGia();
            }
            else if (cbothongke.SelectedItem.ToString() == "Sách trễ hạn")
            {
                HienThiDocGiaTreHan();
            }
            else if(cbothongke.SelectedItem.ToString() == "Sách đang mượn")
            {
                HienThiDocGiaDangMuon();
            }
        }

        private void ExportExcel(DataTable tb, string sheetname)
        {
            e_excel.Application oExcel = new e_excel.Application();
            e_excel.Workbooks oBooks;
            e_excel.Sheets oSheets;
            e_excel.Workbook oBook;
            e_excel.Worksheet oSheet;

            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (e_excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (e_excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;

            e_excel.Range head = oSheet.get_Range("A1", "E1");
            head.MergeCells = true;
            head.Value2 = "BÁO CÁO THỐNG KÊ SÁCH TRONG THƯ VIỆN";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;

            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ SÁCH";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN SÁCH";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "NXB";
            cl3.ColumnWidth = 15.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "NĂM XB";
            cl4.ColumnWidth = 15.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "THÊ LOẠI";
            cl5.ColumnWidth = 15.0;
            e_excel.Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = e_excel.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
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
            e_excel.Range cotBD = (e_excel.Range)oSheet.Cells[rowStart, columnStart];
            e_excel.Range cotKT = (e_excel.Range)oSheet.Cells[rowEnd, columnEnd];
        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            {
                string excel = cbothongke.SelectedItem.ToString();
                if (excel == "Tất cả sách")
                {
                    DataTable tb1 = new DataTable();

                }
                else if (excel == "Sách trễ hạn")
                {
                    DataTable tb1 = new DataTable();
                }
                else if (excel == "Sách đang mượn")
                {
                    DataTable tb1 = new DataTable();
                }
                if (tb1.Rows.Count > 0)
                {
                    ExportExcel(tb1, excel);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FormBCsach_Load(object sender, EventArgs e)
        {
            cbothongke.Items.Add("Tất cả sách");
            cbothongke.Items.Add("Sách trễ hạn");
            cbothongke.Items.Add("Sách đang mượn");
            cbothongke.SelectedIndex = 0;
        }
    }
}
