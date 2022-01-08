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
    public partial class fr_TK_BS : Form
    {
        DataTable bacsi;
        public fr_TK_BS()
        {
            InitializeComponent();
        }

        private void fr_TK_BS_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            String sql = "select MaBacSi, TenBacSi, NgaySinh, GioiTinh,Sđt,DiaChi, ChuyenMon, Bs.MaKhoa, TenKhoa from BacSi Bs inner join Khoa k on k.MaKhoa= Bs.MaKhoa";
            bacsi = Functions.GetDataTable(sql); //Đọc dữ liệu từ bảng
            Gridview_BS.DataSource = bacsi; //Nguồn dữ liệu            
            Gridview_BS.Columns[0].HeaderText = "Mã bác sĩ";
            Gridview_BS.Columns[1].HeaderText = "Tên bác sĩ";
            Gridview_BS.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            Gridview_BS.Columns[2].HeaderText = "Ngày sinh";
            Gridview_BS.Columns[3].HeaderText = "Giới tính ";
            Gridview_BS.Columns[4].HeaderText = "Địa chỉ ";
            Gridview_BS.Columns[5].HeaderText = "Chuyên môn";
            Gridview_BS.Columns[6].HeaderText = "Mã khoa";
            Gridview_BS.Columns[7].HeaderText = "Tên khoa";

            Gridview_BS.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            Gridview_BS.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp

        }
        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select MaBacSi, TenBacSi, NgaySinh, GioiTinh,Sđt,DiaChi, ChuyenMon, Bs.MaKhoa, TenKhoa from BacSi Bs inner join Khoa k on k.MaKhoa= Bs.MaKhoa where TenBacSi like N'%" + txt_find_by_name.Text.Trim() + "%'";

            bacsi = Functions.GetDataTable(sql);
            if (bacsi.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + bacsi.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_BS.DataSource = bacsi;
        }

        private void btn_find_maHso_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select MaBacSi, TenBacSi, NgaySinh, GioiTinh,Sđt,DiaChi, ChuyenMon, Bs.MaKhoa, TenKhoa from BacSi Bs inner join Khoa k on k.MaKhoa= Bs.MaKhoa where MaBacSi like N'%" + txt_find_by_ma.Text.Trim() + "%'";

            bacsi = Functions.GetDataTable(sql);
            if (bacsi.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + bacsi.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_BS.DataSource = bacsi;
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            String sort = "select MaBacSi, TenBacSi, NgaySinh, GioiTinh, Sđt, DiaChi, ChuyenMon, Bs.MaKhoa, TenKhoa from BacSi Bs inner join Khoa k on k.MaKhoa = Bs.MaKhoa order by TenBacSi ASC ";
            Functions.RunSql(sort);
            LoadDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
