using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void ExportExcel(DataTable tb, string sheetname)
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

            e_excel.Range head = oSheet.get_Range("A1", "H1");
            head.MergeCells = true;
            head.Value2 = "DANH SÁCH NHÀ XUẤT BẢN";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ SINH VIÊN";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "HỌ VÀ TÊN";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "NGÀY SINH";
            cl3.ColumnWidth = 15.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "GIỚI TÍNH";
            cl4.ColumnWidth = 15.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "MÃ LỚP";
            cl5.ColumnWidth = 15.0;
            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "ĐIỆN THOẠI";
            cl6.ColumnWidth = 20.0;
            e_excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl6.Value2 = "ĐỊA CHỈ";
            cl6.ColumnWidth = 40.0;
            e_excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl6.Value2 = "TÊN LỚP";
            cl6.ColumnWidth = 20.0;
            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "F3");
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
                        arr[r, c] = "'" + dr[c].ToString(); //chuyen cot C thanh Text
                    else
                        arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
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
            //dinh dang ngay thang cot C
            e_excel.Range cotBD = (e_excel.Range)oSheet.Cells[rowStart, columnStart];
            e_excel.Range cotKT = (e_excel.Range)oSheet.Cells[rowEnd, columnEnd];
            //
            //
        }

        private void btExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
