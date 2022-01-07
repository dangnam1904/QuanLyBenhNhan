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
    public partial class frBN_ngoaitru : Form
    {
        DataTable bn_ngoaitru;
        public frBN_ngoaitru()
        {
            InitializeComponent();
        }

        private void frBN_ngoaitru_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            display_maHoSo();
            display_maKhoa();
            display_maNgoaitru();
            display_TenBN();
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

        /// hiển thị dữ liệu trong combobox
        private void display_maHoSo()
        {
            string sql = " select* from BN_NoiTru";
            Functions.FillCombo(sql, cb_maHS, "Ma_NoiTru", "MaHoSo");
            cb_maHS.SelectedIndex = -1;
        }
        private void display_maKhoa()
        {
            string sql = " select* from Khoa";
            Functions.FillCombo(sql, cb_maKhoa, "MaKhoa", "MaKhoa");
            cb_maKhoa.SelectedIndex = -1;
        }
        private void display_maNgoaitru()
        {
            string sql = " select* from BN_NgoaiTru";
            Functions.FillCombo(sql, cb_maNgtru, "Ma_NgoaiTru", "Ma_NgoaiTru");
            cb_maNgtru.SelectedIndex = -1;

        }
        private void display_TenBN()
        {
            string sql = " select* from BenhNhan";
            Functions.FillCombo(sql, cb_TenBn, "MaHoSo", "TenBN");
            cb_TenBn.SelectedIndex = -1;
        }

        private void Resetvalues()
        {
            cb_maHS.Focus();
            cb_maHS.Text = "";
            cb_maKhoa.Text = "";
            cb_maNgtru.Text = "";
            cb_TenBn.Text = "";
            txt_bacsikham.Text = "";
            txt_BHYT.Text = "";
            txt_ngaykham.Text = "";
            txt_mathuoc.Text = "";
            txt_ngaysinh.Text = "";
            txt_tenThuoc.Text = "";

        }

        private void Gridview_BN_Ngoaitru_Click(object sender, EventArgs e)
        {
            if (bn_ngoaitru.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cb_maHS.Text = Gridview_BN_Ngoaitru.CurrentRow.Cells["MaHoSo"].Value.ToString();
            cb_TenBn.Text = Gridview_BN_Ngoaitru.CurrentRow.Cells["TenBN"].Value.ToString();
            string d1 = Gridview_BN_Ngoaitru.CurrentRow.Cells["NgaySinh"].Value.ToString();
            String.Format("{0:MM/dd/yyyy}", d1);
            txt_ngaysinh.Text = d1;
            cb_maNgtru.Text = Gridview_BN_Ngoaitru.CurrentRow.Cells["Ma_NgoaiTru"].Value.ToString();
            txt_ngaykham.Text = Gridview_BN_Ngoaitru.CurrentRow.Cells["NgayKham"].Value.ToString();
           
            txt_BHYT.Text = Gridview_BN_Ngoaitru.CurrentRow.Cells["SoBHYT"].Value.ToString();
            txt_mathuoc.Text = Gridview_BN_Ngoaitru.CurrentRow.Cells["MaToaThuoc"].Value.ToString();
            txt_tenThuoc.Text = Gridview_BN_Ngoaitru.CurrentRow.Cells["TenThuoc"].Value.ToString();
            cb_maKhoa.Text = Gridview_BN_Ngoaitru.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txt_bacsikham.Text = Gridview_BN_Ngoaitru.CurrentRow.Cells["TenBacSi"].Value.ToString();
            txt_mabacsi.Text = Gridview_BN_Ngoaitru.CurrentRow.Cells["MaBacSi"].Value.ToString();
            string sex = Gridview_BN_Ngoaitru.CurrentRow.Cells["Gioitinh"].Value.ToString();
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
            cb_maNgtru.Enabled = true;
            txt_mabacsi.Enabled = true;
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
            if (cb_maNgtru.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã ngoại trú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_maNgtru.Focus();
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
            sql = "Select Ma_NgoaiTru From BN_NgoaiTru where Ma_NgoaiTru=N'" + cb_maNgtru.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã ngoại đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_maNgtru.Focus();
                return;
            }
            string check_key_thuoc = " select MaToaThuoc from ToaThuoc where MaToaThuoc='"+txt_mathuoc.Text.Trim()+"'";
            if (Functions.CheckKey(check_key_thuoc)==false)
            {
                MessageBox.Show("Mã không tồn tại trong kho thuốc, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mathuoc.Focus();
                return;
            }
            sql = "Select MaHoSo From BenhNhan where MaHoSo=N'" + cb_maHS.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                String maLoaiBN = "BN_NGoaiT";
                if (checkbox_nam.Checked == true)
                {
                    string gioitinh = "Nam";
                    String sql_addbenhnhan = "insert into BenhNhan values(N'" + cb_maHS.Text.Trim() + "',N'" + cb_TenBn.Text.Trim() + "','" + txt_ngaysinh.Text.Trim() + "',N'" + gioitinh + "', '" + maLoaiBN + "')";
                    Functions.RunSql(sql_addbenhnhan);
                }
                else if (checkbox_nu.Checked == true)
                {
                    string gioitinh = "Nữ";
                    String sql_addbenhnhan = "insert into BenhNhan values(N'" + cb_maHS.Text.Trim() + "',N'" + cb_TenBn.Text.Trim() + "','" + txt_ngaysinh.Text.Trim() + "',N'" + gioitinh + "','" + maLoaiBN + "')";
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
                string maLoaiBN = "BN_NGoaiT";
                string add_BN_Ntru = "insert into  BN_NgoaiTru values('" + cb_maNgtru.Text.Trim() + "','" +txt_ngaykham.Text.Trim() + "','" + txt_BHYT.Text.Trim() + "','" + txt_mathuoc.Text.Trim() + "','" +cb_maHS.Text.Trim() + "','" + maLoaiBN + "','" + txt_mabacsi.Text.Trim() + "')";
                Functions.RunSql(add_BN_Ntru);
            }
            LoadDataGridView(); //Nạp lại DataGridView

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (bn_ngoaitru.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_maNgtru.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE BN_NgoaiTru WHERE Ma_NgoaiTru='" + cb_maNgtru.Text.Trim() + " '";
                Functions.RunSql(sql);
                LoadDataGridView();
                Resetvalues();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cb_maHS.Enabled = false;
            cb_maNgtru.Enabled = false;
            txt_mabacsi.Enabled = false;

            if (bn_ngoaitru.Rows.Count == 0)
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

            string edit_Bsi = "update BacSi set TenBacSi=N'" + txt_bacsikham.Text.Trim() + "' where MaBacSi ='" + txt_mabacsi.Text.Trim() + "'";
            Functions.RunSql(edit_Bsi);
            String edit_BN_NoiTru = "update BN_NgoaiTru set NgayKham='"+txt_ngaykham.Text.Trim()+"', SoBHYT='"+txt_BHYT.Text.Trim()+"', MaToaThuoc='"+txt_mathuoc.Text.Trim()+"' ";
            Functions.RunSql(edit_BN_NoiTru);
            LoadDataGridView(); //Nạp lại DataGridView
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

        private void sort_Click(object sender, EventArgs e)
        {
           String sql = "select bn.MaHoSo, bn.TenBN, bn.NgaySinh, bn.GioiTinh, bn_ngtru.Ma_NgoaiTru, bn_ngtru.NgayKham, bn_ngtru.SoBHYT, bs.MaBacSi,bs.TenBacSi, bs.MaKhoa,  bn_ngtru.MaToaThuoc,tt.TenThuoc" +
              " from BenhNhan bn inner join BN_NgoaiTru bn_ngtru on bn_ngtru.MaHoSo=bn.MaHoSo inner join BacSi bs on bs.MaBacSi=bn_ngtru.MaBacSi inner join ToaThuoc tt on tt.MaToaThuoc= bn_ngtru.MaToaThuoc  order by TenBN Asc";
            Functions.RunSql(sql);
            LoadDataGridView();
        }

      

        private void txt_mabacsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cb_maNgtru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cb_maHS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_BHYT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cb_maKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_mathuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_tenThuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_ngaykham_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkbox_nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Gridview_BN_Ngoaitru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkbox_nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_bacsikham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ngaysinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_TenBn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_find_by_ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_find_by_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
