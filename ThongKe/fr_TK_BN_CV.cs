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
    public partial class fr_TK_BN_CV : Form
    {
        DataTable bn_cv;
        public fr_TK_BN_CV()
        {
            InitializeComponent();
        }

        private void fr_TK_BN_CV_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            String sql = " select bn.MaHoSo, bn.TenBN, bn.NgaySinh, bn.GioiTinh, bn_cv.Ma_CV, bn_cv.ChuanDoanBenh,bn_cv.NgayChuyen,NoiChuyen, bn_cv.MaKhoa, bs.MaBacSi, bs.TenBacSi from BenhNhan bn inner join BN_CV bn_cv on bn.MaHoSo=bn_cv.MaHoSo inner join BacSi bs on bs.MaBacSi= bn_cv.MaBacSi";
            bn_cv = Functions.GetDataTable(sql); //Đọc dữ liệu từ bảng
            Gridview_BN_CV.DataSource = bn_cv; //Nguồn dữ liệu            
            Gridview_BN_CV.Columns[0].HeaderText = "Mã hồ sơ";
            Gridview_BN_CV.Columns[1].HeaderText = " Họ tên";
            Gridview_BN_CV.Columns[2].HeaderText = "Ngày sinh";
            Gridview_BN_CV.Columns[3].HeaderText = "Giới tính ";
            Gridview_BN_CV.Columns[4].HeaderText = "Mã chuyển viện ";
            Gridview_BN_CV.Columns[5].HeaderText = "Chuẩn đoán bệnh";
            Gridview_BN_CV.Columns[6].HeaderText = "Ngày chuyển";
            Gridview_BN_CV.Columns[7].HeaderText = "Nơi chuyển";
            Gridview_BN_CV.Columns[8].HeaderText = "Mã khoa";
            Gridview_BN_CV.Columns[9].HeaderText = "Mã bác sĩ";
            Gridview_BN_CV.Columns[10].HeaderText = "Tên bác sĩ";
            Gridview_BN_CV.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            Gridview_BN_CV.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp

        }
        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select bn.MaHoSo, bn.TenBN, bn.NgaySinh, bn.GioiTinh, bn_cv.Ma_CV, bn_cv.ChuanDoanBenh,bn_cv.NgayChuyen, bn_cv.NoiChuyen, bn_cv.MaKhoa, bs.MaBacSi, bs.TenBacSi from BenhNhan bn inner join BN_CV bn_cv on bn.MaHoSo=bn_cv.MaHoSo inner join BacSi bs on bs.MaBacSi= bn_cv.MaBacSi where TenBN like N'%" + txt_find_by_name.Text.Trim() + "%'";

            bn_cv = Functions.GetDataTable(sql);
            if (bn_cv.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + bn_cv.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_BN_CV.DataSource = bn_cv;
        }

        private void btn_find_maHso_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_ma.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select bn.MaHoSo, bn.TenBN, bn.NgaySinh, bn.GioiTinh, bn_cv.Ma_CV, bn_cv.ChuanDoanBenh,bn_cv.NgayChuyen, bn_cv.NoiChuyen, bn_cv.MaKhoa, bs.MaBacSi, bs.TenBacSi from BenhNhan bn inner join BN_CV bn_cv on bn.MaHoSo=bn_cv.MaHoSo inner join BacSi bs on bs.MaBacSi= bn_cv.MaBacSi where bn.MaHoSo like N'%" + txt_find_by_ma.Text.Trim() + "%'";

            bn_cv = Functions.GetDataTable(sql);
            if (bn_cv.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + bn_cv.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_BN_CV.DataSource = bn_cv;
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            String sql = "select bn.MaHoSo, bn.TenBN, bn.NgaySinh, bn.GioiTinh, bn_cv.Ma_CV, bn_cv.ChuanDoanBenh,bn_cv.NgayChuyen, bn_cv.NoiChuyen, bn_cv.MaKhoa, bs.MaBacSi, bs.TenBacSi from BenhNhan bn inner join BN_CV bn_cv on bn.MaHoSo=bn_cv.MaHoSo inner join BacSi bs on bs.MaBacSi= bn_cv.MaBacSi order by TenBN Asc";
            Functions.RunSql(sql);
            LoadDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
