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
    public partial class FormTimdocgia : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU9S3VB\\SQLEXPRESS01;Initial Catalog=DUANNHOMTHUVIEN;Integrated Security=True;Encrypt=False");
        public FormTimdocgia()
        {
            InitializeComponent();
        }
        private void load_docgia()
        {
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string sql = "select * from docgia ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
            dgvdocgia.DataSource = dt;
            dgvdocgia.Refresh();
            
        }
      
        private void FormTimdocgia_Load(object sender, EventArgs e)
        {
            load_docgia();
            txtMadocgia.Focus();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string madg = txtMadocgia.Text;
            string tendg = txtTendocgia.Text;
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string sql = "select * from docgia where madg like '%" + madg + "%' and htdocgia like '%" + tendg + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@madg", SqlDbType.NVarChar,50).Value = madg;
            cmd.Parameters.Add("@htdocgia", SqlDbType.NVarChar, 50).Value = tendg;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
            dgvdocgia.DataSource = dt;
            dgvdocgia.Refresh();
            if(txtMadocgia.Text == "" && txtTendocgia.Text == "")
            {
                 MessageBox.Show("Vui lòng nhập thông tin tìm kiếm");
                txtMadocgia.Focus();
            }
        }
        private void dgvdocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if(i >= 0)
            {
                DataGridViewRow row = dgvdocgia.Rows[i];
                txtMadocgia.Text = row.Cells[0].Value.ToString();
                txtTendocgia.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            load_docgia();
            txtMadocgia.Text = "";
            txtTendocgia.Text = "";
            txtMadocgia.Focus();
        }
    }
}
