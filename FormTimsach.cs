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

        //Data Source = LAPTOP - F4RS79DJ\SQLEXPRESS;Initial Catalog = DUANNHOMTHUVIEN; Integrated Security = True; Trust Server Certificate=True
        //Data Source=LAPTOP-F4RS79DJ\SQLEXPRESS;Initial Catalog=DUANNHOMTHUVIEN;Integrated Security=True;Trust Server Certificate=True
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T6775II7\\SQLEXPRESS;Initial Catalog=DUANNHOMTHUVIEN;Integrated Security=True;Encrypt=False");
        private void FormTimsach_Load(object sender, EventArgs e)
        {
            load_timsach("", "");
            Capnhatsoluong();
        }

        private void load_timsach(string tensach, string masach)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "Select masach,tensach,namxb,tennxb,tentheloai,httacgia FROM quanlysach INNER JOIN nhaxuatban ON quanlysach.manxb = nhaxuatban.manxb INNER JOIN tacgia ON tacgia.matg = quanlysach.matg INNER JOIN theloai ON quanlysach.matheloai = theloai.matheloai";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }
        private void btTK_Click(object sender, EventArgs e)
        {
            string tensach = txtTS.Text.Trim();
            string masach = txtMS.Text.Trim();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "Select masach,tensach,namxb,tennxb,tentheloai,httacgia FROM quanlysach INNER JOIN nhaxuatban ON quanlysach.manxb = nhaxuatban.manxb INNER JOIN tacgia ON tacgia.matg = quanlysach.matg INNER JOIN theloai ON quanlysach.matheloai = theloai.matheloai where tensach like '%" + tensach + "%' and masach like '%" + masach + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                txtMS.Text = row.Cells[0].Value.ToString();
                txtTS.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btRS_Click(object sender, EventArgs e)
        {
            load_timsach("", "");
            txtTS.Clear();
            txtMS.Clear();
            txtTS.Focus();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Capnhatsoluong()
        {
            int sl = dataGridView1.Rows.Count;
            a.Text = sl.ToString();
            a.ForeColor = Color.Red;
        }
        private void txtTS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
