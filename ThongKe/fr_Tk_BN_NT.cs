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
    public partial class fr_Tk_BN_NT : Form
    {
        DataTable bn_noitru;
        public fr_Tk_BN_NT()
        {
            InitializeComponent();
        }

        private void fr_Tk_BN_NT_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT bn.MaHoSo,TenBN, bn.NgaySinh, bn.GioiTinh, Ma_NoiTru,NgayNhapVien, NgayRaVien,ChuanDoanBenh,SoGiuong,bn_nt.MaKhoa, bs.TenBacSi, bs.MaBacSi FROM BenhNhan bn inner join BN_NoiTru bn_nt on bn_nt.MaHoSo=bn.MaHoSo inner join BacSi bs on bs.MaBacSi= bn_nt.MaBacSi";
            bn_noitru = Functions.GetDataTable(sql); //Đọc dữ liệu từ bảng
            Gridview_BN_NoiTru.DataSource = bn_noitru; //Nguồn dữ liệu            
            Gridview_BN_NoiTru.Columns[0].HeaderText = "Mã hồ sơ";
            Gridview_BN_NoiTru.Columns[1].HeaderText = " Họ tên";
            Gridview_BN_NoiTru.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

            Gridview_BN_NoiTru.Columns[2].HeaderText = "Ngày sinh";
            Gridview_BN_NoiTru.Columns[3].HeaderText = "Giới tính ";
            Gridview_BN_NoiTru.Columns[4].HeaderText = "Mã nội trú ";
            Gridview_BN_NoiTru.Columns[5].HeaderText = "Ngày nhập viện";
            Gridview_BN_NoiTru.Columns[6].HeaderText = "Ngày ra viện";
            Gridview_BN_NoiTru.Columns[7].HeaderText = "Chuẩn đoán bệnh";
            Gridview_BN_NoiTru.Columns[8].HeaderText = "Số giường";
            Gridview_BN_NoiTru.Columns[9].HeaderText = "Mã khoa";
            Gridview_BN_NoiTru.Columns[10].HeaderText = "Bác sĩ khám";
            Gridview_BN_NoiTru.Columns[10].HeaderText = "Mã bác sĩ";
            Gridview_BN_NoiTru.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            Gridview_BN_NoiTru.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "SELECT bn.MaHoSo,TenBN, bn.NgaySinh, bn.GioiTinh, Ma_NoiTru,NgayNhapVien, NgayRaVien,ChuanDoanBenh,SoGiuong,bn_nt.MaKhoa, bs.TenBacSi, bs.MaBacSi FROM BenhNhan bn " +
                  " inner join BN_NoiTru bn_nt on bn_nt.MaHoSo=bn.MaHoSo inner join BacSi bs on bs.MaBacSi= bn_nt.MaBacSi where TenBN like N'%" + txt_find_by_name.Text.Trim() + "%'";

            bn_noitru = Functions.GetDataTable(sql);
            if (bn_noitru.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + bn_noitru.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_BN_NoiTru.DataSource = bn_noitru;
        }

        private void btn_find_maHso_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_ma.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "SELECT bn.MaHoSo,TenBN, bn.NgaySinh, bn.GioiTinh, Ma_NoiTru,NgayNhapVien, NgayRaVien,ChuanDoanBenh,SoGiuong,bn_nt.MaKhoa, bs.TenBacSi, bs.MaBacSi FROM BenhNhan bn " +
                  " inner join BN_NoiTru bn_nt on bn_nt.MaHoSo=bn.MaHoSo inner join BacSi bs on bs.MaBacSi= bn_nt.MaBacSi where bn_nt.MaHoSo like N'%" + txt_find_by_ma.Text.Trim() + "%'";

            bn_noitru = Functions.GetDataTable(sql);
            if (bn_noitru.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + bn_noitru.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_BN_NoiTru.DataSource = bn_noitru;
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
