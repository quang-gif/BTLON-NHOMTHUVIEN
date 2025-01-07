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
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormDocgia();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormNhanvien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormQuanlysach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormTheloai();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormTacgia();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormNhaxuatban();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FornLapphieumuon();
            this.Hide();
            f.ShowDialog();
        }

        private void tìmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormTimsach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tìmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormTimdocgia();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormBCsach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void độcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new FormBCdocgia();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void chiTiếtMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormChitietmuontra();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Formtrogiup();
            this.Hide();
            f.ShowDialog();
        }
    }
}
