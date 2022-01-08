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
    public partial class fr_TK_BN_NgTru : Form
    {
        DataTable bn_ngoaitru;
        public fr_TK_BN_NgTru()
        {
            InitializeComponent();
        }

        private void fr_TK_BN_NgTru_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "select bn.MaHoSo, bn.TenBN, bn.NgaySinh, bn.GioiTinh, bn_ngtru.Ma_NgoaiTru, bn_ngtru.NgayKham, bn_ngtru.SoBHYT, bs.MaBacSi,bs.TenBacSi, bs.MaKhoa,  bn_ngtru.MaToaThuoc,tt.TenThuoc" +
                " from BenhNhan bn inner join BN_NgoaiTru bn_ngtru on bn_ngtru.MaHoSo=bn.MaHoSo inner join BacSi bs on bs.MaBacSi=bn_ngtru.MaBacSi inner join ToaThuoc tt on tt.MaToaThuoc= bn_ngtru.MaToaThuoc";
            bn_ngoaitru = Functions.GetDataTable(sql); //Đọc dữ liệu từ bảng
            Gridview_BN_Ngoaitru.DataSource = bn_ngoaitru; //Nguồn dữ liệu            
            Gridview_BN_Ngoaitru.Columns[0].HeaderText = "Mã hồ sơ";
            Gridview_BN_Ngoaitru.Columns[1].HeaderText = " Họ tên";
            Gridview_BN_Ngoaitru.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

            Gridview_BN_Ngoaitru.Columns[2].HeaderText = "Ngày sinh";
            Gridview_BN_Ngoaitru.Columns[3].HeaderText = "Giới tính ";
            Gridview_BN_Ngoaitru.Columns[4].HeaderText = "Mã ngoại trú ";
            Gridview_BN_Ngoaitru.Columns[5].HeaderText = "Ngày khám";
            Gridview_BN_Ngoaitru.Columns[6].HeaderText = "Số BHYT";
            Gridview_BN_Ngoaitru.Columns[7].HeaderText = "Mã bác sĩ";
            Gridview_BN_Ngoaitru.Columns[8].HeaderText = "Bác sĩ khám";
            Gridview_BN_Ngoaitru.Columns[9].HeaderText = "Mã khoa";
            Gridview_BN_Ngoaitru.Columns[10].HeaderText = "Mã toa thuốc";
            Gridview_BN_Ngoaitru.Columns[10].HeaderText = "Tên thuốc";
            Gridview_BN_Ngoaitru.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            Gridview_BN_Ngoaitru.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp

        }
        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select bn.MaHoSo, bn.TenBN, bn.NgaySinh, bn.GioiTinh, bn_ngtru.Ma_NgoaiTru, bn_ngtru.NgayKham, bn_ngtru.SoBHYT, bs.MaBacSi,bs.TenBacSi, bs.MaKhoa,  bn_ngtru.MaToaThuoc,tt.TenThuoc" +
                " from BenhNhan bn inner join BN_NgoaiTru bn_ngtru on bn_ngtru.MaHoSo=bn.MaHoSo inner join BacSi bs on bs.MaBacSi=bn_ngtru.MaBacSi inner join ToaThuoc tt on tt.MaToaThuoc= bn_ngtru.MaToaThuoc where TenBN like N'%" + txt_find_by_name.Text.Trim() + "%'";

            bn_ngoaitru = Functions.GetDataTable(sql);
            if (bn_ngoaitru.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + bn_ngoaitru.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_BN_Ngoaitru.DataSource = bn_ngoaitru;
        }

        private void btn_find_maHso_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select bn.MaHoSo, bn.TenBN, bn.NgaySinh, bn.GioiTinh, bn_ngtru.Ma_NgoaiTru, bn_ngtru.NgayKham, bn_ngtru.SoBHYT, bs.MaBacSi,bs.TenBacSi, bs.MaKhoa,  bn_ngtru.MaToaThuoc,tt.TenThuoc" +
                " from BenhNhan bn inner join BN_NgoaiTru bn_ngtru on bn_ngtru.MaHoSo=bn.MaHoSo inner join BacSi bs on bs.MaBacSi=bn_ngtru.MaBacSi inner join ToaThuoc tt on tt.MaToaThuoc= bn_ngtru.MaToaThuoc where bn.MaHoSo like N'%" + txt_find_by_ma.Text.Trim() + "%'";

            bn_ngoaitru = Functions.GetDataTable(sql);
            if (bn_ngoaitru.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + bn_ngoaitru.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_BN_Ngoaitru.DataSource = bn_ngoaitru;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
