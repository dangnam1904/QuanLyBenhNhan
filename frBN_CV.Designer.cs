
namespace QuanLyBenhNhan
{
    partial class frBN_CV
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
            this.checkbox_nu = new System.Windows.Forms.CheckBox();
            this.Gridview_BN_CV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.checkbox_nam = new System.Windows.Forms.CheckBox();
            this.txt_bacsikham = new System.Windows.Forms.TextBox();
            this.btn_sort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.cb_TenBn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_find_by_ma = new System.Windows.Forms.TextBox();
            this.btn_find_maHso = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_find_by_name = new System.Windows.Forms.TextBox();
            this.bt_find_name = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_mabacsi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_MaCV = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_maHS = new System.Windows.Forms.ComboBox();
            this.txt_cdoanbenh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_maKhoa = new System.Windows.Forms.ComboBox();
            this.txt_noichuyen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.date_ngaychuyen = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_BN_CV)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkbox_nu
            // 
            this.checkbox_nu.AutoSize = true;
            this.checkbox_nu.Location = new System.Drawing.Point(690, 65);
            this.checkbox_nu.Name = "checkbox_nu";
            this.checkbox_nu.Size = new System.Drawing.Size(42, 19);
            this.checkbox_nu.TabIndex = 7;
            this.checkbox_nu.Text = "Nữ";
            this.checkbox_nu.UseVisualStyleBackColor = true;
            // 
            // Gridview_BN_CV
            // 
            this.Gridview_BN_CV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview_BN_CV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gridview_BN_CV.Location = new System.Drawing.Point(0, 0);
            this.Gridview_BN_CV.Name = "Gridview_BN_CV";
            this.Gridview_BN_CV.RowTemplate.Height = 25;
            this.Gridview_BN_CV.Size = new System.Drawing.Size(973, 185);
            this.Gridview_BN_CV.TabIndex = 0;
            this.Gridview_BN_CV.Click += new System.EventHandler(this.Gridview_BN_CV_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày chuyển";
            // 
            // checkbox_nam
            // 
            this.checkbox_nam.AutoSize = true;
            this.checkbox_nam.Location = new System.Drawing.Point(628, 65);
            this.checkbox_nam.Name = "checkbox_nam";
            this.checkbox_nam.Size = new System.Drawing.Size(52, 19);
            this.checkbox_nam.TabIndex = 6;
            this.checkbox_nam.Text = "Nam";
            this.checkbox_nam.UseVisualStyleBackColor = true;
            // 
            // txt_bacsikham
            // 
            this.txt_bacsikham.Location = new System.Drawing.Point(410, 110);
            this.txt_bacsikham.Name = "txt_bacsikham";
            this.txt_bacsikham.Size = new System.Drawing.Size(168, 23);
            this.txt_bacsikham.TabIndex = 5;
            // 
            // btn_sort
            // 
            this.btn_sort.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sort.Image = global::QuanLyBenhNhan.Properties.Resources.alphabetical_sorting_16;
            this.btn_sort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sort.Location = new System.Drawing.Point(767, 13);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(155, 27);
            this.btn_sort.TabIndex = 20;
            this.btn_sort.Text = "Sắp xếp theo tên";
            this.btn_sort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên bệnh nhân";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_save.Image = global::QuanLyBenhNhan.Properties.Resources.save_16__1_;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(51, 62);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 26);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Image = global::QuanLyBenhNhan.Properties.Resources.delete_2_16;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(198, 15);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 25);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.Image = global::QuanLyBenhNhan.Properties.Resources.edit_2_16;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(198, 62);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(98, 26);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // cb_TenBn
            // 
            this.cb_TenBn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_TenBn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_TenBn.FormattingEnabled = true;
            this.cb_TenBn.Location = new System.Drawing.Point(115, 107);
            this.cb_TenBn.Name = "cb_TenBn";
            this.cb_TenBn.Size = new System.Drawing.Size(181, 23);
            this.cb_TenBn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hồ sơ";
            // 
            // txt_find_by_ma
            // 
            this.txt_find_by_ma.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_find_by_ma.Location = new System.Drawing.Point(539, 61);
            this.txt_find_by_ma.Name = "txt_find_by_ma";
            this.txt_find_by_ma.Size = new System.Drawing.Size(193, 27);
            this.txt_find_by_ma.TabIndex = 19;
            this.txt_find_by_ma.Text = "Mã bệnh nhân cần tìm";
            // 
            // btn_find_maHso
            // 
            this.btn_find_maHso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_find_maHso.Image = global::QuanLyBenhNhan.Properties.Resources.search_9_16;
            this.btn_find_maHso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_find_maHso.Location = new System.Drawing.Point(323, 62);
            this.btn_find_maHso.Name = "btn_find_maHso";
            this.btn_find_maHso.Size = new System.Drawing.Size(202, 26);
            this.btn_find_maHso.TabIndex = 1;
            this.btn_find_maHso.Text = "Tìm kiếm theo mã hồ sơ";
            this.btn_find_maHso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_find_maHso.UseVisualStyleBackColor = true;
            this.btn_find_maHso.Click += new System.EventHandler(this.btn_find_maHso_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Gridview_BN_CV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 185);
            this.panel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bác sĩ khám";
            // 
            // txt_find_by_name
            // 
            this.txt_find_by_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_find_by_name.Location = new System.Drawing.Point(540, 13);
            this.txt_find_by_name.Name = "txt_find_by_name";
            this.txt_find_by_name.Size = new System.Drawing.Size(192, 27);
            this.txt_find_by_name.TabIndex = 18;
            this.txt_find_by_name.Text = "Tên bệnh nhân cần tìm";
            // 
            // bt_find_name
            // 
            this.bt_find_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_find_name.Image = global::QuanLyBenhNhan.Properties.Resources.search_9_16;
            this.bt_find_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_find_name.Location = new System.Drawing.Point(323, 15);
            this.bt_find_name.Name = "bt_find_name";
            this.bt_find_name.Size = new System.Drawing.Size(202, 25);
            this.bt_find_name.TabIndex = 1;
            this.bt_find_name.Text = "Tìm kiếm theo tên";
            this.bt_find_name.UseVisualStyleBackColor = true;
            this.bt_find_name.Click += new System.EventHandler(this.bt_find_name_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date_ngaychuyen);
            this.panel1.Controls.Add(this.date_ngaysinh);
            this.panel1.Controls.Add(this.txt_mabacsi);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cb_MaCV);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cb_maHS);
            this.panel1.Controls.Add(this.txt_cdoanbenh);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cb_maKhoa);
            this.panel1.Controls.Add(this.txt_noichuyen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkbox_nu);
            this.panel1.Controls.Add(this.checkbox_nam);
            this.panel1.Controls.Add(this.txt_bacsikham);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_TenBn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 232);
            this.panel1.TabIndex = 6;
            // 
            // txt_mabacsi
            // 
            this.txt_mabacsi.Location = new System.Drawing.Point(410, 150);
            this.txt_mabacsi.Name = "txt_mabacsi";
            this.txt_mabacsi.Size = new System.Drawing.Size(100, 23);
            this.txt_mabacsi.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Mã bác sĩ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(375, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "QUẢN LÍ BỆNH NHÂN CHUYỂN VIỆN";
            // 
            // cb_MaCV
            // 
            this.cb_MaCV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_MaCV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_MaCV.FormattingEnabled = true;
            this.cb_MaCV.Location = new System.Drawing.Point(115, 199);
            this.cb_MaCV.Name = "cb_MaCV";
            this.cb_MaCV.Size = new System.Drawing.Size(121, 23);
            this.cb_MaCV.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Mã chuyển viện";
            // 
            // cb_maHS
            // 
            this.cb_maHS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_maHS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_maHS.FormattingEnabled = true;
            this.cb_maHS.Location = new System.Drawing.Point(115, 58);
            this.cb_maHS.Name = "cb_maHS";
            this.cb_maHS.Size = new System.Drawing.Size(121, 23);
            this.cb_maHS.TabIndex = 18;
            // 
            // txt_cdoanbenh
            // 
            this.txt_cdoanbenh.Location = new System.Drawing.Point(410, 196);
            this.txt_cdoanbenh.Name = "txt_cdoanbenh";
            this.txt_cdoanbenh.Size = new System.Drawing.Size(180, 23);
            this.txt_cdoanbenh.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Chuẩn đoán bệnh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã khoa";
            // 
            // cb_maKhoa
            // 
            this.cb_maKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_maKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_maKhoa.FormattingEnabled = true;
            this.cb_maKhoa.Location = new System.Drawing.Point(115, 155);
            this.cb_maKhoa.Name = "cb_maKhoa";
            this.cb_maKhoa.Size = new System.Drawing.Size(121, 23);
            this.cb_maKhoa.TabIndex = 14;
            // 
            // txt_noichuyen
            // 
            this.txt_noichuyen.Location = new System.Drawing.Point(723, 142);
            this.txt_noichuyen.Name = "txt_noichuyen";
            this.txt_noichuyen.Size = new System.Drawing.Size(199, 23);
            this.txt_noichuyen.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nơi chuyển";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Image = global::QuanLyBenhNhan.Properties.Resources.add_16;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(51, 15);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(98, 25);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_sort);
            this.panel2.Controls.Add(this.txt_find_by_ma);
            this.panel2.Controls.Add(this.txt_find_by_name);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_find_maHso);
            this.panel2.Controls.Add(this.bt_find_name);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 100);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::QuanLyBenhNhan.Properties.Resources.refresh_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(767, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 26);
            this.button1.TabIndex = 31;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaysinh.Location = new System.Drawing.Point(414, 60);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.Size = new System.Drawing.Size(164, 23);
            this.date_ngaysinh.TabIndex = 24;
            // 
            // date_ngaychuyen
            // 
            this.date_ngaychuyen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaychuyen.Location = new System.Drawing.Point(723, 109);
            this.date_ngaychuyen.Name = "date_ngaychuyen";
            this.date_ngaychuyen.Size = new System.Drawing.Size(164, 23);
            this.date_ngaychuyen.TabIndex = 25;
            // 
            // frBN_CV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 517);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frBN_CV";
            this.Text = "Quản lý bệnh nhân chuyển viện";
            this.Load += new System.EventHandler(this.frBN_CV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_BN_CV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkbox_nu;
        private System.Windows.Forms.DataGridView Gridview_BN_CV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkbox_nam;
        private System.Windows.Forms.TextBox txt_bacsikham;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox cb_TenBn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_find_by_ma;
        private System.Windows.Forms.Button btn_find_maHso;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_find_by_name;
        private System.Windows.Forms.Button bt_find_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_mabacsi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_MaCV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_maHS;
        private System.Windows.Forms.TextBox txt_cdoanbenh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_maKhoa;
        private System.Windows.Forms.TextBox txt_noichuyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date_ngaychuyen;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
    }
}