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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Formlogin();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormDocgia();
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormNhanvien();
            f.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormQuanlysach();
            f.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormTheloai();
            f.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormTacgia();
            f.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormNhaxuatban();
            f.Show();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormMuonsach();
            f.Show();
        }

        private void tìmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormTimsach();
            f.Show();
        }

        private void tìmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormTimdocgia();
            f.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormBCsach();
            f.Show();
        }

        private void độcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new FormBCdocgia();
            f.Show();
        }
    }
}
