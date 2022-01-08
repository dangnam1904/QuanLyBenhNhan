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
    public partial class fr_Tk_Thuoc : Form
    {
        DataTable thuoc;
        public fr_Tk_Thuoc()
        {
            InitializeComponent();
        }

        private void fr_Tk_Thuoc_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
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

            string sort = "Select * from ToaThuoc  where MaToaThuoc order by TenThuoc Asc'";
            Functions.RunSql(sort);
            LoadDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
