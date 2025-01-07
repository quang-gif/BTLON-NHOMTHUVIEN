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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using e_excel = Microsoft.Office.Interop.Excel;
namespace BTLON_NHOMTHUVIEN
{
    public partial class FormBCdocgia : Form
    {
       

        SqlConnection con=new SqlConnection("Data Source=ShibaInu\\SQLEXPRESS01;Initial Catalog=ThuVien;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        public FormBCdocgia()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
        DataTable tb1=new DataTable();
        public void HienThiTatCaDocGia()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            tb1.Clear();
            string sql = "Select *from docgia";
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataAdapter da= new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(tb1);
            dgvTKDG.DataSource = tb1;
        }
        public void HienThiDocGiaTreHan()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            tb1.Clear();
            string sql = "Select docgia.* FROM docgia JOIN chitietmuontra ON docgia.madg = chitietmuontra.madg WHERE chitietmuontra.ngaytra < GETDATE()";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(tb1);
            dgvTKDG.DataSource = tb1;
        }
        private void btnthongke_Click(object sender, EventArgs e)
        {
            if (cbothongkedocgia.SelectedItem.ToString() == "Tất cả độc giả")
            {
                HienThiTatCaDocGia();
            }
            else if (cbothongkedocgia.SelectedItem.ToString() == "Độc giả trễ hạn")
            {
                HienThiDocGiaTreHan();
            }
        }

        private void FormBCdocgia_Load(object sender, EventArgs e)
        {
            cbothongkedocgia.Items.Add("Tất cả độc giả");
            cbothongkedocgia.Items.Add("Độc giả trễ hạn");
            cbothongkedocgia.SelectedIndex = 0;
        }

        private void Excel(DataTable tb, string sheetname)
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
            head.MergeCells = true; //trộn nhiều ô thành 1 ô
            head.Value2 = "BÁO CÁO THỐNG KÊ ĐỘC GIẢ";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "15";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter; //căn giữa

            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ ĐỘC GIẢ";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN ĐỘC GIẢ";
            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "NGÀY SINH";
            cl3.ColumnWidth = 15.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "GIỚI TÍNH";
            cl4.ColumnWidth = 25.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "LỚP";
            cl5.ColumnWidth = 40.0;
   
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
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            {
                string excel = cbothongkedocgia.SelectedItem.ToString();
                if (excel== "Tất cả độc giả")
                {
                    DataTable tb1 = new DataTable();
                  
                }
                else if (excel == "Độc giả trễ hạn")
                {
                    DataTable tb1= new DataTable();
                }
                if (tb1.Rows.Count > 0)
                {
                    Excel(tb1, excel);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
