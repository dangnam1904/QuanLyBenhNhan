using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    public partial class fr_main : Form
    {
        public fr_main()
        {
            InitializeComponent();
        }

        private void fr_main_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void bệnhNhânNộiTrúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frBN_NoiTru frBN_NoiTru = new frBN_NoiTru();
            frBN_NoiTru.Show();
        }

        private void bệnhNhânNgoạiTrúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frBN_ngoaitru frBN_Ngoaitru = new frBN_ngoaitru();
            frBN_Ngoaitru.Show();
        }

        private void bệnhNhânChuyểnViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frBN_CV frBN_CV = new frBN_CV();
            frBN_CV.Show();
        }

        private void bệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frBenhNhan frBenhNhan = new frBenhNhan();
            frBenhNhan.Show();
        }

        private void bácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_bacSi fr_BacSi = new fr_bacSi();
            fr_BacSi.Show();
        }

        private void toaThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_toathuoc fr_Toathuoc = new fr_toathuoc();
            fr_Toathuoc.Show();
        }

        private void bệnhNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKe.frTk_BN frTk_BN = new ThongKe.frTk_BN();
            frTk_BN.Show();
        }

        private void chuyểnViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe.fr_TK_BN_CV fr_cv= new ThongKe.fr_TK_BN_CV();
            fr_cv.Show();
        }

        private void nộiTrúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe.fr_Tk_BN_NT fr_Tk_BN_NT = new ThongKe.fr_Tk_BN_NT();
            fr_Tk_BN_NT.Show();
        }

        private void ngoạiTrúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe.fr_TK_BN_NgTru fr_NGtru= new ThongKe.fr_TK_BN_NgTru();
            fr_NGtru.Show();
        }

        private void bácSiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe.fr_TK_BS fr_bs= new ThongKe.fr_TK_BS();
            fr_bs.Show();
        }

        private void toaThuốcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKe.fr_Tk_Thuoc fr_Thuoc = new ThongKe.fr_Tk_Thuoc();
            fr_Thuoc.Show();
        }
    }
}
