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
    public partial class fr_bacSi : Form
    {
        DataTable bacsi;
        public fr_bacSi()
        {
            InitializeComponent();
        }

        private void fr_bacSi_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            display_maBacSi();
            display_MaKhoa();
            display_TenBS();
            display_chuyenmon();
        }

        private void display_chuyenmon()
        {
         
        }

        private void display_MaKhoa()
        {
            string sql = " select* from Khoa";
            Functions.FillCombo(sql,cb_makhoa, "MaKhoa", "MaKhoa");
            cb_makhoa.SelectedIndex = -1;
        }

        private void display_maBacSi()
        {
            string sql = " select* from BacSi";
            Functions.FillCombo(sql, cb_maBs, "MaBacSi", "MaBacSi");
            cb_maBs.SelectedIndex = -1;
        }
       
        private void display_TenBS()
        {
            string sql = " select* from BacSi";
            Functions.FillCombo(sql, cb_TenBacSi, "MaBacSi", "TenBacSi");
            cb_TenBacSi.SelectedIndex = -1;
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

        private void Gridview_BS_Click(object sender, EventArgs e)
        {
            cb_maBs.Text = Gridview_BS.CurrentRow.Cells["MaBacSi"].Value.ToString();
            cb_makhoa.Text = Gridview_BS.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txt_ngaysinh.Text = Gridview_BS.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_sdt.Text = Gridview_BS.CurrentRow.Cells["Sđt"].Value.ToString();
            txt_tenKhoa.Text = Gridview_BS.CurrentRow.Cells["TenKhoa"].Value.ToString();
            txt_chuyenmon.Text = Gridview_BS.CurrentRow.Cells["ChuyenMon"].Value.ToString();
            txt_diachi.Text = Gridview_BS.CurrentRow.Cells["DiaChi"].Value.ToString();
            string gioitinh = Gridview_BS.CurrentRow.Cells["GioiTinh"].Value.ToString();
            if(gioitinh == "Nam")
            {
                checkbox_nam.Checked = true;
                checkbox_nu.Checked = false;
            }
            if (gioitinh == "Nữ")
            {
                checkbox_nu.Checked = true;
                checkbox_nam.Checked = false;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Resetvalues();
            cb_maBs.Enabled = true;
        }

        private void Resetvalues()
        {
            txt_chuyenmon.Text = "";
            txt_diachi.Text = "";
            txt_ngaysinh.Text = "";
            txt_ngaysinh.Text = "";
            txt_sdt.Text = "";
            cb_maBs.Text = "";
            cb_makhoa.Text = "";
            cb_TenBacSi.Text = "";
            txt_tenKhoa.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (cb_maBs.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn phải nhập mã bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_maBs.Focus();
                return;
            }
            if (cb_makhoa.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã  khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_makhoa.Focus();
                return;
            }

            if (cb_TenBacSi.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_TenBacSi.Focus();
                return;
            }

            sql = "Select MaBacSi From BacSi where MaBacSi=N'" + cb_maBs.Text.Trim() + "'";
            string check_khoa = "select * from Khoa where MaKhoa='"+cb_makhoa.Text.Trim()+"' ";
            if (Functions.CheckKey(sql) == false && Functions.CheckKey(check_khoa)==true)
            {
                if (checkbox_nam.Checked == true)
                {
                    string gioitinh = "Nam";

                    String sql_add = "insert into BacSi values('"+cb_maBs.Text.Trim()+"',N'"+cb_TenBacSi.Text.Trim()+"','"+txt_ngaysinh.Text.Trim()+"',N'"+gioitinh+"','"+txt_sdt.Text.Trim()+"',N'"+txt_diachi.Text.Trim()+"',N'"+txt_chuyenmon.Text.Trim()+"','"+cb_makhoa.Text.Trim()+"')";
                    Functions.RunSql(sql_add);
                }
                else if (checkbox_nu.Checked == true)
                {
                    string gioitinh = "Nữ";
                    String sql_add = "insert into BacSi values('" + cb_maBs.Text.Trim() + "',N'" + cb_TenBacSi.Text.Trim() + "','" + txt_ngaysinh.Text.Trim() + "',N'" + gioitinh + "','" + txt_sdt.Text.Trim() + "',N'" + txt_diachi.Text.Trim() + "',N'" + txt_chuyenmon.Text.Trim() + "','" + cb_makhoa.Text.Trim() + "')";
                    Functions.RunSql(sql_add);
                }
            }
            else
            {

                MessageBox.Show("Mã bác sĩ  đã tồn tại hoặc mã khoa không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_maBs.Focus();
                return;
            }
            LoadDataGridView(); //Nạp lại DataGridView
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (bacsi.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_maBs.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE BacSi WHERE MaBacSi  ='" + cb_maBs.Text.Trim() + " '";
                Functions.RunSql(sql);
                LoadDataGridView();
                Resetvalues();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
           cb_maBs.Enabled = false;


            if (bacsi.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_maBs.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string gioitinh;

            if (checkbox_nam.Checked == true)
            {
                gioitinh = "Nam";
                string sql_1 = "Update BacSi set MaBacSi ='" + cb_maBs.Text.Trim() + "', TenBacSi= N'" + cb_TenBacSi.Text.Trim() + "',NgaySinh='" + txt_ngaysinh.Text.Trim() + "',GioiTinh=N'" + gioitinh + "',Sđt='" + txt_sdt.Text.Trim() + "', DiaChi=N'" + txt_diachi.Text.Trim() + "', ChuyenMon= N'" + txt_chuyenmon.Text.Trim() + "', MaKhoa='" + cb_makhoa.Text.Trim() + "' where MaBacSi='"+cb_maBs.Text.Trim()+"' ";
                Functions.RunSql(sql_1);
            }
            if (checkbox_nu.Checked == true)
            {
                gioitinh = "Nữ";
                string sql_1 = "Update BacSi set MaBacSi ='" + cb_maBs.Text.Trim() + "', TenBacSi= N'" + cb_TenBacSi.Text.Trim() + "',NgaySinh='" + txt_ngaysinh.Text.Trim() + "',GioiTinh=N'" + gioitinh + "',Sđt='" + txt_sdt.Text.Trim() + "', DiaChi=N'" + txt_diachi.Text.Trim() + "', ChuyenMon= N'" + txt_chuyenmon.Text.Trim() + "', MaKhoa='" + cb_makhoa.Text.Trim() + "' where MaBacSi='" + cb_maBs.Text.Trim() + "' ";
                Functions.RunSql(sql_1);
            }
            if (checkbox_nam.Checked == true && checkbox_nu.Checked == true)
            {
                MessageBox.Show("Bạn chỉ được chọn một giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LoadDataGridView(); //Nạp lại DataGridView
        }

        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select MaBacSi, TenBacSi, NgaySinh, GioiTinh,Sđt,DiaChi, ChuyenMon, Bs.MaKhoa, TenKhoa from BacSi Bs inner join Khoa k on k.MaKhoa= Bs.MaKhoa where TenBacSi like N'%" + txt_find_by_name.Text.Trim() + "%'";

            bacsi  = Functions.GetDataTable(sql);
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
