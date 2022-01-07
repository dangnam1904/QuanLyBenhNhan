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
    
    public partial class fr_toathuoc : Form
    {
        DataTable thuoc;
        public fr_toathuoc()
        {
            InitializeComponent();
        }

        private void fr_toathuoc_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            display_maThuoc();
            display_TenThuoc();
        }

        private void display_TenThuoc()
        {
            string sql = " select* from ToaThuoc";
            Functions.FillCombo(sql, cb_TenThuoc, "MaToaThuoc", "TenThuoc");
            cb_TenThuoc.SelectedIndex = -1;
        }

        private void display_maThuoc()
        {
            string sql = " select* from ToaThuoc";
            Functions.FillCombo(sql, cb_maThuoc, "MaToaThuoc", "MaToaThuoc");
            cb_maThuoc.SelectedIndex = -1;
        }

        private void LoadDataGridView()
        {
            String load = "select *from ToaThuoc";
            thuoc = Functions.GetDataTable(load); //Đọc dữ liệu từ bảng
            Gridview_Thuoc.DataSource = thuoc; //Nguồn dữ liệu            
            Gridview_Thuoc.Columns[0].HeaderText = "Mã Thuốc";
            Gridview_Thuoc.Columns[1].HeaderText = "Tên Thuốc";
            Gridview_Thuoc.Columns[2].HeaderText = "Mô tả thuốc";
            Gridview_Thuoc.Columns[3].HeaderText = "Ghi chú ";
            Gridview_Thuoc.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            Gridview_Thuoc.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp

        }

        private void Gridview_Thuoc_Click(object sender, EventArgs e)
        {
            cb_maThuoc.Text = Gridview_Thuoc.CurrentRow.Cells["MaToaThuoc"].Value.ToString();
            cb_TenThuoc.Text = Gridview_Thuoc.CurrentRow.Cells["TenThuoc"].Value.ToString();
            rtxt_mota.Text = Gridview_Thuoc.CurrentRow.Cells["MoTa"].Value.ToString();
            rtxt_ghichu.Text = Gridview_Thuoc.CurrentRow.Cells["GhiChu"].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ResetValues();
            cb_maThuoc.Enabled = true;
        }

        private void ResetValues()
        {
            cb_maThuoc.Text = "";
            cb_TenThuoc.Text = "";
            rtxt_ghichu.Text = "";
            rtxt_mota.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (cb_maThuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_maThuoc.Focus();
                return;
            }

            if (cb_TenThuoc.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_TenThuoc.Focus();
                return;
            }

            sql = "Select MaToaThuoc From ToaThuoc where MaToaThuoc=N'" + cb_maThuoc.Text.Trim() + "'";
          
            if (Functions.CheckKey(sql) == false )
            {
                    String sql_add = "insert into ToaThuoc values('N'" + cb_maThuoc.Text.Trim() + "',N'" + cb_TenThuoc.Text.Trim() + "',N'" + rtxt_mota.Text.Trim() + "',N'" + rtxt_ghichu.Text.Trim() + "' ')";
                    Functions.RunSql(sql_add);
     
            }
            else
            {

                MessageBox.Show("Mã thuốc đã tồn tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_maThuoc.Focus();
                return;
            }
            LoadDataGridView(); //Nạp lại DataGridView
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (thuoc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_maThuoc.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE ToaThuoc WHERE MaToaThuoc  ='" + cb_maThuoc.Text.Trim() + " '";
                Functions.RunSql(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cb_maThuoc.Enabled = false;


            if (thuoc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_maThuoc.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
               string sql_1 = "Update ToaThuoc set TenThuoc='"+cb_TenThuoc.Text.Trim()+"',MoTa='"+rtxt_mota.Text.Trim()+"',GhiChu='"+rtxt_ghichu.Text.Trim()+"' where MaToaThuoc='"+cb_maThuoc.Text.Trim()+"' ";

                Functions.RunSql(sql_1);
           
            LoadDataGridView(); //Nạp lại DataGridView
        }

        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "Select * from ToaThuoc  where TenThuoc like N'%" + txt_find_by_name.Text.Trim() + "%'";

            thuoc = Functions.GetDataTable(sql);
            if (thuoc.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + thuoc.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           Gridview_Thuoc.DataSource = thuoc;
        }

        private void btn_find_maHso_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "Select * from ToaThuoc  where MaToaThuoc like N'%" + txt_find_by_ma.Text.Trim() + "%'";

            thuoc = Functions.GetDataTable(sql);
            if (thuoc.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + thuoc.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_Thuoc.DataSource = thuoc;
        }

        private void btn_sort_Click(object sender, EventArgs e)
        { 

            string sort  = "Select * from ToaThuoc  where MaToaThuoc order by TenThuoc Asc'";
            Functions.RunSql(sort);
            LoadDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
