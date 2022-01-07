
namespace QuanLyBenhNhan
{
    partial class fr_toathuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_find_by_ma = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_find_by_name = new System.Windows.Forms.TextBox();
            this.bt_find_name = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_find_maHso = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TenThuoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Gridview_Thuoc = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_maThuoc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxt_mota = new System.Windows.Forms.RichTextBox();
            this.rtxt_ghichu = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_Thuoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_sort);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.txt_find_by_ma);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.txt_find_by_name);
            this.panel2.Controls.Add(this.bt_find_name);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.btn_find_maHso);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 100);
            this.panel2.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::QuanLyBenhNhan.Properties.Resources.refresh_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(767, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 26);
            this.button1.TabIndex = 30;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sort.Image = global::QuanLyBenhNhan.Properties.Resources.alphabetical_sorting_16;
            this.btn_sort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sort.Location = new System.Drawing.Point(767, 17);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(155, 27);
            this.btn_sort.TabIndex = 29;
            this.btn_sort.Text = "Sắp xếp theo tên";
            this.btn_sort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Image = global::QuanLyBenhNhan.Properties.Resources.delete_2_16;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(198, 19);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 25);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_find_by_ma
            // 
            this.txt_find_by_ma.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_find_by_ma.Location = new System.Drawing.Point(539, 65);
            this.txt_find_by_ma.Name = "txt_find_by_ma";
            this.txt_find_by_ma.Size = new System.Drawing.Size(193, 27);
            this.txt_find_by_ma.TabIndex = 28;
            this.txt_find_by_ma.Text = "Mã bệnh nhân cần tìm";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Image = global::QuanLyBenhNhan.Properties.Resources.add_16;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(51, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(98, 25);
            this.btn_add.TabIndex = 21;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_find_by_name
            // 
            this.txt_find_by_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_find_by_name.Location = new System.Drawing.Point(540, 17);
            this.txt_find_by_name.Name = "txt_find_by_name";
            this.txt_find_by_name.Size = new System.Drawing.Size(192, 27);
            this.txt_find_by_name.TabIndex = 27;
            this.txt_find_by_name.Text = "Tên bệnh nhân cần tìm";
            // 
            // bt_find_name
            // 
            this.bt_find_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_find_name.Image = global::QuanLyBenhNhan.Properties.Resources.search_9_16;
            this.bt_find_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_find_name.Location = new System.Drawing.Point(323, 19);
            this.bt_find_name.Name = "bt_find_name";
            this.bt_find_name.Size = new System.Drawing.Size(202, 25);
            this.bt_find_name.TabIndex = 23;
            this.bt_find_name.Text = "Tìm kiếm theo tên";
            this.bt_find_name.UseVisualStyleBackColor = true;
            this.bt_find_name.Click += new System.EventHandler(this.bt_find_name_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_save.Image = global::QuanLyBenhNhan.Properties.Resources.save_16__1_;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(51, 66);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 26);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_find_maHso
            // 
            this.btn_find_maHso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_find_maHso.Image = global::QuanLyBenhNhan.Properties.Resources.search_9_16;
            this.btn_find_maHso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_find_maHso.Location = new System.Drawing.Point(323, 66);
            this.btn_find_maHso.Name = "btn_find_maHso";
            this.btn_find_maHso.Size = new System.Drawing.Size(202, 26);
            this.btn_find_maHso.TabIndex = 22;
            this.btn_find_maHso.Text = "Tìm kiếm theo mã hồ sơ";
            this.btn_find_maHso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_find_maHso.UseVisualStyleBackColor = true;
            this.btn_find_maHso.Click += new System.EventHandler(this.btn_find_maHso_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.Image = global::QuanLyBenhNhan.Properties.Resources.edit_2_16;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(198, 66);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(98, 26);
            this.btn_edit.TabIndex = 24;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên thuốc";
            // 
            // cb_TenThuoc
            // 
            this.cb_TenThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_TenThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_TenThuoc.FormattingEnabled = true;
            this.cb_TenThuoc.Location = new System.Drawing.Point(99, 99);
            this.cb_TenThuoc.Name = "cb_TenThuoc";
            this.cb_TenThuoc.Size = new System.Drawing.Size(236, 23);
            this.cb_TenThuoc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mô tả ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã toa thuốc";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Gridview_Thuoc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 211);
            this.panel3.TabIndex = 14;
            // 
            // Gridview_Thuoc
            // 
            this.Gridview_Thuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview_Thuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gridview_Thuoc.Location = new System.Drawing.Point(0, 0);
            this.Gridview_Thuoc.Name = "Gridview_Thuoc";
            this.Gridview_Thuoc.RowTemplate.Height = 25;
            this.Gridview_Thuoc.Size = new System.Drawing.Size(959, 211);
            this.Gridview_Thuoc.TabIndex = 0;
            this.Gridview_Thuoc.Click += new System.EventHandler(this.Gridview_Thuoc_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(375, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "QUẢN LÍ THUỐC";
            // 
            // cb_maThuoc
            // 
            this.cb_maThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_maThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_maThuoc.FormattingEnabled = true;
            this.cb_maThuoc.Location = new System.Drawing.Point(99, 58);
            this.cb_maThuoc.Name = "cb_maThuoc";
            this.cb_maThuoc.Size = new System.Drawing.Size(121, 23);
            this.cb_maThuoc.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtxt_ghichu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rtxt_mota);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cb_maThuoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_TenThuoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 224);
            this.panel1.TabIndex = 12;
            // 
            // rtxt_mota
            // 
            this.rtxt_mota.Location = new System.Drawing.Point(425, 58);
            this.rtxt_mota.Name = "rtxt_mota";
            this.rtxt_mota.Size = new System.Drawing.Size(330, 82);
            this.rtxt_mota.TabIndex = 22;
            this.rtxt_mota.Text = "";
            // 
            // rtxt_ghichu
            // 
            this.rtxt_ghichu.Location = new System.Drawing.Point(90, 157);
            this.rtxt_ghichu.Name = "rtxt_ghichu";
            this.rtxt_ghichu.Size = new System.Drawing.Size(330, 47);
            this.rtxt_ghichu.TabIndex = 24;
            this.rtxt_ghichu.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ghi chú";
            // 
            // fr_toathuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 435);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "fr_toathuoc";
            this.Text = "Quản lý thuốc";
            this.Load += new System.EventHandler(this.fr_toathuoc_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_Thuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_find_by_ma;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_find_by_name;
        private System.Windows.Forms.Button bt_find_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_find_maHso;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_TenThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Gridview_Thuoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_maThuoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxt_ghichu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxt_mota;
    }
}