using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON_NHOMTHUVIEN
{
    public partial class Formlogin : Form
    {
        string tentk = "nhomthuvien";
        string mk = "123456";
        public Formlogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (kiemtradangnhap(txttaikhoan.Text,txtmk.Text))
            {
                Form f = new FormMain();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu hoặc chưa nhập dữ liệu", "Lỗi");
                txttaikhoan.Focus();
            }    
            
        }

        private void Formlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        bool kiemtradangnhap(string tentk, string mk)
        {
            if(tentk==this.tentk && mk == this.mk) 
            { 
                return true; 
            } 
                
            return false;
        }
    }
}
