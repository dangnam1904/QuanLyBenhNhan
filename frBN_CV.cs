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

    public partial class frBN_CV : Form
    {

        DataTable bn_cv;
        public frBN_CV()
        {
            InitializeComponent();
        }

        private void frBN_CV_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            display_maHoSo();
            display_maKhoa();
            display_maCV();
            display_TenBN();
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

        /// hiển thị dữ liệu trong combobox
        private void display_maHoSo()
        {
            string sql = " select* from BN_CV";
            Functions.FillCombo(sql, cb_maHS, "Ma_CV", "MaHoSo");
            cb_maHS.SelectedIndex = -1;
        }
        private void display_maKhoa()
        {
            string sql = " select* from Khoa";
            Functions.FillCombo(sql, cb_maKhoa, "MaKhoa", "MaKhoa");
            cb_maKhoa.SelectedIndex = -1;
        }
        private void display_maCV()
        {
            string sql = " select* from BN_CV";
            Functions.FillCombo(sql, cb_MaCV, "Ma_CV", "Ma_CV");
            cb_MaCV.SelectedIndex = -1;

        }
        private void display_TenBN()
        {
            string sql = " select* from BenhNhan";
            Functions.FillCombo(sql, cb_TenBn, "MaHoSo", "TenBN");
            cb_TenBn.SelectedIndex = -1;
        }

        private void Gridview_BN_CV_Click(object sender, EventArgs e)
        {
            if (bn_cv.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cb_maHS.Text = Gridview_BN_CV.CurrentRow.Cells["MaHoSo"].Value.ToString();
            cb_TenBn.Text = Gridview_BN_CV.CurrentRow.Cells["TenBN"].Value.ToString();
            string d1 = Gridview_BN_CV.CurrentRow.Cells["NgaySinh"].Value.ToString();
            
            txt_ngaysinh.Text = d1;
            cb_MaCV.Text = Gridview_BN_CV.CurrentRow.Cells["Ma_CV"].Value.ToString();
            txt_cdoanbenh.Text = Gridview_BN_CV.CurrentRow.Cells["ChuanDoanBenh"].Value.ToString();
            txt_noichuyen.Text = Gridview_BN_CV.CurrentRow.Cells["NoiChuyen"].Value.ToString();
            cb_maKhoa.Text = Gridview_BN_CV.CurrentRow.Cells["MaKhoa"].Value.ToString();
          
            txt_bacsikham.Text = Gridview_BN_CV.CurrentRow.Cells["TenBacSi"].Value.ToString();
            txt_mabacsi.Text = Gridview_BN_CV.CurrentRow.Cells["MaBacSi"].Value.ToString();
            txt_ngaychuyen.Text = Gridview_BN_CV.CurrentRow.Cells["NgayChuyen"].Value.ToString();

            string sex = Gridview_BN_CV.CurrentRow.Cells["Gioitinh"].Value.ToString();
            if (sex == "Nam")
            {
                checkbox_nam.Checked = true;
                checkbox_nu.Checked = false;
            }
            else
            {
                checkbox_nu.Checked = true;
                checkbox_nam.Checked = false;
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Resetvalues();
            cb_maHS.Enabled = true;
            cb_MaCV.Enabled = true;
            txt_mabacsi.Enabled = true;
        }
        private void Resetvalues()
        {
            cb_maHS.Focus();
            cb_maHS.Text = "";
            cb_maKhoa.Text = "";
            cb_MaCV.Text = "";
            cb_TenBn.Text = "";
            txt_bacsikham.Text = "";
            txt_noichuyen.Text = "";
            txt_ngaychuyen.Text = "";
            txt_cdoanbenh.Text = "";
            txt_ngaysinh.Text = "";
            txt_mabacsi.Text = "";


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (cb_maHS.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã hồ sơ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_maHS.Focus();
                return;
            }
            if (cb_MaCV.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã chuyện viện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaCV.Focus();
                return;
            }
            if (cb_maKhoa.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_maKhoa.Focus();
                return;
            }
            if (cb_TenBn.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_TenBn.Focus();
                return;
            }
            sql = "Select Ma_CV From BN_CV where Ma_CV=N'" + cb_MaCV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã ngoại đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_MaCV.Focus();
                return;
            }

            sql = "Select MaHoSo From BenhNhan where MaHoSo=N'" + cb_maHS.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                String maLoaiBN = "BN_CV";
                if (checkbox_nam.Checked == true)
                {
                    string gioitinh = "Nam";
                    String sql_addbenhnhan = "insert into BenhNhan values(N'" + cb_maHS.Text.Trim() + "',N'" + cb_TenBn.Text.Trim() + "','" + txt_ngaysinh.Text.Trim() + "',N'" + gioitinh + "', '" + maLoaiBN + "')";
                    Functions.RunSql(sql_addbenhnhan);
                }
                else if (checkbox_nu.Checked == true)
                {
                    string gioitinh = "Nữ";
                    String sql_addbenhnhan = "insert into BenhNhan values(N'" + cb_maHS.Text.Trim() + "',N'" + cb_TenBn.Text.Trim() + "','" + txt_ngaysinh.Text.Trim() + "',N'" + gioitinh + "', '" + maLoaiBN + "')";
                    Functions.RunSql(sql_addbenhnhan);
                }
            }
            else
            {
                String check_maBs = "select MaBacSi from BacSi where MaBacSi='" + txt_mabacsi.Text.Trim() + "' ";
                if (Functions.CheckKey(check_maBs) == false)
                {
                    MessageBox.Show("Mã bác sĩ không tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_mabacsi.Focus();
                    return;
                }
                string maLoaiBN = "BN_CV";
                string add_BN_Cv = "insert into  BN_CV values('" + cb_MaCV.Text.Trim() + "',N'" + txt_cdoanbenh.Text.Trim() + "','" + txt_ngaychuyen.Text.Trim() + "',N'"+txt_noichuyen.Text.Trim()+"', '" + cb_maKhoa.Text.Trim() + "','" + cb_maHS.Text.Trim() + "','" + maLoaiBN + "','" + txt_mabacsi.Text.Trim() + "')";
                Functions.RunSql(add_BN_Cv);
            }
            LoadDataGridView(); //Nạp lại DataGridView
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (bn_cv.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_MaCV.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE BN_CV WHERE Ma_CV='" + cb_MaCV.Text.Trim() + " '";
                Functions.RunSql(sql);
                LoadDataGridView();
                Resetvalues();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cb_maHS.Enabled = false;
            cb_MaCV.Enabled = false;
            txt_mabacsi.Enabled = false;

            if (bn_cv.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_maHS.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string gioitinh;

            if (checkbox_nam.Checked == true)
            {
                gioitinh = "Nam";
                string sql_1 = "Update BenhNhan set MaHoSo='" + cb_maHS.Text.Trim() + "', TenBN=N'" + cb_TenBn.Text.Trim() + "',NgaySinh='" + txt_ngaysinh.Text.Trim() + "', GioiTinh='" + gioitinh + "' Where MaHoSo='" + cb_maHS.Text.Trim() + "' ";
                Functions.RunSql(sql_1);
            }
            if (checkbox_nu.Checked == true)
            {
                gioitinh = "Nữ";
                string sql_1 = "Update BenhNhan set MaHoSo='" + cb_maHS.Text.Trim() + "', TenBN=N'" + cb_TenBn.Text.Trim() + "',NgaySinh='" + txt_ngaysinh.Text.Trim() + "', GioiTinh='" + gioitinh + "' Where MaHoSo='" + cb_maHS.Text.Trim() + "'  ";
                Functions.RunSql(sql_1);
            }

            string edit_Bsi = "update BacSi set TenBacSi=N'" + txt_bacsikham.Text.Trim() + "' where MaBacSi ='" + txt_mabacsi.Text.Trim() + "' ";
            Functions.RunSql(edit_Bsi);
            String edit_BN_CV = "update BN_CV set ChuanDoanBenh=N'"+txt_cdoanbenh.Text.Trim()+"', NgayChuyen='"+txt_ngaychuyen.Text.Trim()+"', NoiChuyen=N'"+txt_noichuyen.Text.Trim()+"', MaKhoa= '"+cb_maKhoa.Text.Trim()+"', MaBacSi='"+txt_mabacsi.Text.Trim()+"' ";
            Functions.RunSql(edit_BN_CV);
            LoadDataGridView(); //Nạp lại DataGridView
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
