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
    public partial class frBN_NoiTru : Form
    {
        DataTable bn_noitru;
        public frBN_NoiTru()
        {
            InitializeComponent();
        }

        private void frBN_NoiTru_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            display_maHoSo();
            display_maKhoa();
            display_maNoiTru();
            display_TenBN();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT bn.MaHoSo,TenBN, bn.NgaySinh, bn.GioiTinh, Ma_NoiTru,NgayNhapVien, NgayRaVien,ChuanDoanBenh,SoGiuong,bn_nt.MaKhoa, bs.TenBacSi, bs.MaBacSi FROM BenhNhan bn inner join BN_NoiTru bn_nt on bn_nt.MaHoSo=bn.MaHoSo inner join BacSi bs on bs.MaBacSi= bn_nt.MaBacSi";
            bn_noitru = Functions.GetDataTable(sql); //Đọc dữ liệu từ bảng
            Gridview_BN_NoiTru.DataSource = bn_noitru; //Nguồn dữ liệu            
            Gridview_BN_NoiTru.Columns[0].HeaderText = "Mã hồ sơ";
            Gridview_BN_NoiTru.Columns[1].HeaderText = " Họ tên";
            Gridview_BN_NoiTru.Columns[1].Width=250;
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

        private void Gridview_BN_NoiTru_Click(object sender, EventArgs e)
        {
            if (bn_noitru.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cb_maHS.Text = Gridview_BN_NoiTru.CurrentRow.Cells["MaHoSo"].Value.ToString();
            cb_TenBn.Text = Gridview_BN_NoiTru.CurrentRow.Cells["TenBN"].Value.ToString();
          datetime_ngaysinh.Value= (DateTime) Gridview_BN_NoiTru.CurrentRow.Cells["NgaySinh"].Value;

            cb_maNoiTru.Text = Gridview_BN_NoiTru.CurrentRow.Cells["Ma_NoiTru"].Value.ToString();
           date_nhapvien.Value =(DateTime) Gridview_BN_NoiTru.CurrentRow.Cells["NgayNhapVien"].Value;
           date_ravien.Value = (DateTime) Gridview_BN_NoiTru.CurrentRow.Cells["NgayRaVien"].Value;
            txt_chuandoanbenh.Text = Gridview_BN_NoiTru.CurrentRow.Cells["ChuanDoanBenh"].Value.ToString();
            txt_sogiuong.Text = Gridview_BN_NoiTru.CurrentRow.Cells["SoGiuong"].Value.ToString();
            cb_maNoiTru.Text = Gridview_BN_NoiTru.CurrentRow.Cells["Ma_NoiTru"].Value.ToString();
            cb_maKhoa.Text = Gridview_BN_NoiTru.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txt_bacsikham.Text = Gridview_BN_NoiTru.CurrentRow.Cells["TenBacSi"].Value.ToString();
            txt_mabacsi.Text = Gridview_BN_NoiTru.CurrentRow.Cells["MaBacSi"].Value.ToString();
            string sex = Gridview_BN_NoiTru.CurrentRow.Cells["Gioitinh"].Value.ToString();
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

        /// hiển thị dữ liệu trong combobox
        private void display_maHoSo()
        {
            string sql = " select* from BN_NoiTru";
            Functions.FillCombo(sql,cb_maHS, "Ma_NoiTru", "MaHoSo");
            cb_maHS.SelectedIndex = -1;
        }
        private void display_maKhoa()
        {
            string sql = " select* from Khoa";
            Functions.FillCombo(sql, cb_maKhoa, "MaKhoa", "MaKhoa");
            cb_maKhoa.SelectedIndex = -1;
        }
        private void display_maNoiTru()
        {
            string sql = " select* from BN_NoiTru";
            Functions.FillCombo(sql, cb_maNoiTru, "Ma_NoiTru", "Ma_NoiTru");
           cb_maNoiTru.SelectedIndex = -1;

        }
        private void display_TenBN()
        {
            string sql = " select* from BenhNhan";
            Functions.FillCombo(sql, cb_TenBn, "MaHoSo", "TenBN");
            cb_TenBn.SelectedIndex = -1;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Resetvalues();
            btn_add.Enabled = false;
            cb_maHS.Enabled = true;
            cb_maNoiTru.Enabled = true;
            txt_mabacsi.Enabled = true;
        }

        private void Resetvalues()
        {
            cb_maHS.Focus();
            cb_maHS.Text = "";
            cb_maKhoa.Text = "";
            cb_maNoiTru.Text = "";
            cb_TenBn.Text = "";
            txt_bacsikham.Text = "";
            txt_chuandoanbenh.Text = "";
            txt_sogiuong.Text = "";
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
            if (cb_maNoiTru.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã nội trú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_maNoiTru.Focus();
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
            sql = "Select Ma_NoiTru From BN_NoiTru where Ma_NoiTru=N'" + cb_maNoiTru.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nội trú đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_maNoiTru.Focus();
                return;
            }

            sql = "Select MaHoSo From BenhNhan where MaHoSo=N'" + cb_maHS.Text.Trim() + "'";
            if (Functions.CheckKey(sql)==false)
            {
                //MessageBox.Show("Mã không tồn tại đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //cb_maHS.Focus();
                //return;
                string maLoaiBN = "BN_NoiT";
                if (checkbox_nam.Checked == true)
                {
                    string  gioitinh = "Nam";
                   
                    String sql_addbenhnhan = "insert into BenhNhan values(N'" + cb_maHS.Text.Trim() + "',N'" + cb_TenBn.Text.Trim() + "','" + datetime_ngaysinh.Value + "',N'" + gioitinh + "','"+maLoaiBN+"')";
                    Functions.RunSql(sql_addbenhnhan);
                }
                else if( checkbox_nu.Checked==true)
                {
                   string gioitinh = "Nữ";
                    String sql_addbenhnhan = "insert into BenhNhan values(N'" + cb_maHS.Text.Trim() + "',N'" + cb_TenBn.Text.Trim() + "','" + datetime_ngaysinh.Value + "',N'" + gioitinh + "', '" + maLoaiBN + "')";
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
                string maLoaiBN = "BN_NoiT";
                string add_BN_Ntru = "insert into  BN_NoiTru values('" + cb_maNoiTru.Text.Trim() + "','" + date_nhapvien.Value + "','" + date_ravien.Value + "','" + txt_chuandoanbenh.Text.Trim() + "'," + txt_sogiuong.Text.Trim() + ",'" + cb_maKhoa.Text.Trim() + "','"+maLoaiBN+"','" + cb_maHS.Text.Trim() + "','" + txt_mabacsi.Text.Trim() + "')";
                Functions.RunSql(add_BN_Ntru);
            }
            LoadDataGridView(); //Nạp lại DataGridView

        }

        private void cb_TenBn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string sSQL = "SELECT * FROM Sinhvien WHERE Makhoa=N'" +cboKhoadaotao.SelectedValue.ToString() + "' ORDER BY MaSV";
            //mySqlCommand = new SqlCommand(sSQL, mySqlConnection);
            //SqlDataReader mySqlDataReader =
            //mySqlCommand.ExecuteReader();
            //DataTable myDataTable = new DataTable();
            //myDataTable.Load(mySqlDataReader);
            //GridView1.DataSource = myDataTable;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cb_maHS.Enabled = false;
            cb_maNoiTru.Enabled = false;
            txt_mabacsi.Enabled = false;

            if (bn_noitru.Rows.Count == 0)
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
                string sql_1 = "Update BenhNhan set MaHoSo='" + cb_maHS.Text.Trim() + "', TenBN=N'" + cb_TenBn.Text.Trim() + "',NgaySinh='" + datetime_ngaysinh.Value + "', GioiTinh='" + gioitinh + "' Where MaHoSo='"+cb_maHS.Text.Trim()+"' ";
                Functions.RunSql(sql_1);
            }
            if (checkbox_nu.Checked == true)
            {
                    gioitinh = "Nữ";
                    string sql_1 = "Update BenhNhan set MaHoSo='" + cb_maHS.Text.Trim() + "', TenBN=N'" + cb_TenBn.Text.Trim() + "',NgaySinh='" + datetime_ngaysinh.Value + "', GioiTinh='" + gioitinh + "' Where MaHoSo='" + cb_maHS.Text.Trim() + "'  ";
                    Functions.RunSql(sql_1);
            }

            string edit_Bsi = "update BacSi set TenBacSi=N'" + txt_bacsikham.Text.Trim() + "' where MaBacSi ='"+txt_mabacsi.Text.Trim()+"'";
            Functions.RunSql(edit_Bsi);
            String edit_BN_NoiTru = "update BN_NoiTru set NgayNhapVien='"+date_nhapvien.Value+"',NgayRaVien='"+date_ravien.Value+"', ChuanDoanBenh='"+txt_chuandoanbenh.Text.Trim()+"',SoGiuong="+txt_sogiuong.Text.Trim()+",MaKhoa='"+cb_maKhoa.Text.Trim()+"' where Ma_NoiTru='"+cb_maNoiTru.Text.Trim()+"' ";
            Functions.RunSql(edit_BN_NoiTru);
            LoadDataGridView(); //Nạp lại DataGridView
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            if (bn_noitru.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_maNoiTru.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               string sql = "DELETE BN_NoiTru WHERE Ma_NoiTru='" + cb_maNoiTru.Text.Trim() + " '";
                Functions.RunSql(sql);
                LoadDataGridView();
                Resetvalues();
            }

        }

        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          string  sql = "SELECT bn.MaHoSo,TenBN, bn.NgaySinh, bn.GioiTinh, Ma_NoiTru,NgayNhapVien, NgayRaVien,ChuanDoanBenh,SoGiuong,bn_nt.MaKhoa, bs.TenBacSi, bs.MaBacSi FROM BenhNhan bn " +
                " inner join BN_NoiTru bn_nt on bn_nt.MaHoSo=bn.MaHoSo inner join BacSi bs on bs.MaBacSi= bn_nt.MaBacSi where TenBN like N'%" + txt_find_by_name.Text.Trim() + "%'";

            bn_noitru = Functions.GetDataTable(sql);
            if (bn_noitru.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + bn_noitru.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           Gridview_BN_NoiTru.DataSource =bn_noitru;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string sql_sort = "SELECT bn.MaHoSo,TenBN, bn.NgaySinh, bn.GioiTinh, Ma_NoiTru,NgayNhapVien, NgayRaVien,ChuanDoanBenh,SoGiuong,bn_nt.MaKhoa, bs.TenBacSi, bs.MaBacSi FROM BenhNhan bn inner join BN_NoiTru bn_nt on bn_nt.MaHoSo=bn.MaHoSo inner join BacSi bs on bs.MaBacSi= bn_nt.MaBacSi order by TenBN Asc";
            Functions.RunSql(sql_sort);
            LoadDataGridView();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
    
}
