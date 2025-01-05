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
    public partial class FormTimsach : Form
    {
        public FormTimsach()
        {
            InitializeComponent();
        }
        //select masach, tensach,tennxb, namxb, tentheloai from nhaxuatban,quanlysach,theloai where nhaxuatban.manxb=quanlysach.manxb and quanlysach.matheloai=theloai.matheloai and masach like '%'+@masach+'%' and tensach like '%'+@tensach+'%' and tennxb like '%'+@tennxb+'%' and namxb like '%'+@namxb+'%' and tentheloai like '%'+@tentheloai+'%'
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-F4RS79DJ\\SQLEXPRESS;Initial Catalog=DUANNHOMTHUVIEN;Integrated Security=True;Encrypt=False");
        private void FormTimsach_Load(object sender, EventArgs e)
        {

        }

        private void load_timsach(string tensach, string tennxb, string tentg, string theloai, string namxb)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select masach, tensach,tennxb, namxb, tentheloai from nhaxuatban,quanlysach,theloai" +
                " where nhaxuatban.manxb=quanlysach.manxb" +
                " and quanlysach.matheloai=theloai.matheloai" +
                " and masach like '%'+@masach+'%'" +
                " and tensach like '%'+@tensach+'%'" +
                " and tennxb like '%'+@tennxb+'%'" +
                " and namxb like '%'+@namxb+'%'" +
                " and tentheloai like '%'+@tentheloai+'%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@tensach", SqlDbType.NVarChar, 50).Value = tensach;
            cmd.Parameters.Add("@tennxb", SqlDbType.NVarChar, 50).Value = tennxb;
            cmd.Parameters.Add("@tentg", SqlDbType.NVarChar, 50).Value = tentg;
            cmd.Parameters.Add("@theloai", SqlDbType.NVarChar, 50).Value = theloai;
            cmd.Parameters.Add("@namxb", SqlDbType.Date).Value = namxb;
            //B3: Tạo đối tượng dataAdapter để lấy kết quả từ cmd
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //B4: Tạo đối tượng dataTable để lấy dữ liệu từ da
            //DataTable tb = new DataTable();
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }
        private void btTK_Click(object sender, EventArgs e)
        {
            //B1: Lấy dữ liệu từ các control đưa vào biến
            string tensach = txtTS.Text.Trim();
            string tennxb = txtTNXB.Text.Trim();
            string tentg = txtTTG.Text.Trim();
            string theloai;
            if (cboTL.SelectedItem == null)
                theloai = "";
            else
                theloai = cboTL.SelectedItem.ToString();
            string namxb = dateTimePicker1.Value.ToString();
            load_timsach("","","","","");
        }

        private void txtTS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
