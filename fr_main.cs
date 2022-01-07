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
    }
}
