using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhNhan.ThongKe
{
    public partial class frTk_BN : Form
    {
        DataTable BenhNhan;
        public frTk_BN()
        {
            InitializeComponent();
        }

        private void frTk_BN_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            String sql = " select bn.MaHoSo, TenBN,NgaySinh,GioiTinh,bn.MaLoaiBN, TenLoai from BenhNhan bn inner join LoaiBN LBn on bn.MaLoaiBN=LBn.MaLoaiBN";
            BenhNhan = Functions.GetDataTable(sql); //Đọc dữ liệu từ bảng
            Gridview_BN.DataSource = BenhNhan; //Nguồn dữ liệu            
            Gridview_BN.Columns[0].HeaderText = "Mã hồ sơ";
            Gridview_BN.Columns[1].HeaderText = " Họ tên";
            Gridview_BN.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            Gridview_BN.Columns[2].HeaderText = "Ngày sinh";
            Gridview_BN.Columns[3].HeaderText = "Giới tính ";
            Gridview_BN.Columns[4].HeaderText = "Mã loại ";
            Gridview_BN.Columns[5].HeaderText = "TenLoai";
            Gridview_BN.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            Gridview_BN.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select bn.MaHoSo, TenBN,NgaySinh,GioiTinh,bn.MaLoaiBN, TenLoai from BenhNhan bn inner join LoaiBN LBn on bn.MaLoaiBN=LBn.MaLoaiBN where TenBN like N'%" + txt_find_by_name.Text.Trim() + "%'";

            BenhNhan = Functions.GetDataTable(sql);
            if (BenhNhan.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + BenhNhan.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_BN.DataSource = BenhNhan;
        }

        private void btn_find_maHso_Click(object sender, EventArgs e)
        {

            if ((txt_find_by_ma.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select bn.MaHoSo, TenBN,NgaySinh,GioiTinh,bn.MaLoaiBN, TenLoai from BenhNhan bn inner join LoaiBN LBn on bn.MaLoaiBN=LBn.MaLoaiBN where MaHoSo like N'%" + txt_find_by_ma.Text.Trim() + "%'";

            BenhNhan = Functions.GetDataTable(sql);
            if (BenhNhan.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + BenhNhan.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_BN.DataSource = BenhNhan;
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
