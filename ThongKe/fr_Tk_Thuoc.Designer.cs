namespace QuanLyBenhNhan.ThongKe
{
    partial class fr_Tk_Thuoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_find_by_ma = new System.Windows.Forms.TextBox();
            this.txt_find_by_name = new System.Windows.Forms.TextBox();
            this.bt_find_name = new System.Windows.Forms.Button();
            this.btn_find_maHso = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Gridview_Thuoc = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_Thuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ  THUỐC";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSum);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txt_find_by_ma);
            this.panel2.Controls.Add(this.txt_find_by_name);
            this.panel2.Controls.Add(this.bt_find_name);
            this.panel2.Controls.Add(this.btn_find_maHso);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 90);
            this.panel2.TabIndex = 10;
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSum.HideSelection = false;
            this.txtSum.Location = new System.Drawing.Point(628, 54);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(59, 27);
            this.txtSum.TabIndex = 37;
            this.txtSum.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::QuanLyBenhNhan.Properties.Resources.icons8_sum_16;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(453, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 27);
            this.button2.TabIndex = 36;
            this.button2.Text = "Tổng số lượng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::QuanLyBenhNhan.Properties.Resources.refresh_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(453, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 26);
            this.button1.TabIndex = 35;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_find_by_ma
            // 
            this.txt_find_by_ma.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_find_by_ma.Location = new System.Drawing.Point(228, 55);
            this.txt_find_by_ma.Name = "txt_find_by_ma";
            this.txt_find_by_ma.Size = new System.Drawing.Size(193, 27);
            this.txt_find_by_ma.TabIndex = 34;
            this.txt_find_by_ma.Text = "Mã bệnh nhân cần tìm";
            // 
            // txt_find_by_name
            // 
            this.txt_find_by_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_find_by_name.Location = new System.Drawing.Point(229, 9);
            this.txt_find_by_name.Name = "txt_find_by_name";
            this.txt_find_by_name.Size = new System.Drawing.Size(192, 27);
            this.txt_find_by_name.TabIndex = 33;
            this.txt_find_by_name.Text = "Tên bệnh nhân cần tìm";
            // 
            // bt_find_name
            // 
            this.bt_find_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_find_name.Image = global::QuanLyBenhNhan.Properties.Resources.search_9_16;
            this.bt_find_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_find_name.Location = new System.Drawing.Point(12, 9);
            this.bt_find_name.Name = "bt_find_name";
            this.bt_find_name.Size = new System.Drawing.Size(202, 25);
            this.bt_find_name.TabIndex = 30;
            this.bt_find_name.Text = "Tìm kiếm theo tên";
            this.bt_find_name.UseVisualStyleBackColor = true;
            this.bt_find_name.Click += new System.EventHandler(this.bt_find_name_Click);
            // 
            // btn_find_maHso
            // 
            this.btn_find_maHso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_find_maHso.Image = global::QuanLyBenhNhan.Properties.Resources.search_9_16;
            this.btn_find_maHso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_find_maHso.Location = new System.Drawing.Point(12, 56);
            this.btn_find_maHso.Name = "btn_find_maHso";
            this.btn_find_maHso.Size = new System.Drawing.Size(202, 26);
            this.btn_find_maHso.TabIndex = 29;
            this.btn_find_maHso.Text = "Tìm kiếm theo mã hồ sơ";
            this.btn_find_maHso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_find_maHso.UseVisualStyleBackColor = true;
            this.btn_find_maHso.Click += new System.EventHandler(this.btn_find_maHso_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Gridview_Thuoc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 450);
            this.panel3.TabIndex = 11;
            // 
            // Gridview_Thuoc
            // 
            this.Gridview_Thuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview_Thuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gridview_Thuoc.Location = new System.Drawing.Point(0, 0);
            this.Gridview_Thuoc.Name = "Gridview_Thuoc";
            this.Gridview_Thuoc.RowTemplate.Height = 25;
            this.Gridview_Thuoc.Size = new System.Drawing.Size(800, 450);
            this.Gridview_Thuoc.TabIndex = 0;
            // 
            // fr_Tk_Thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "fr_Tk_Thuoc";
            this.Text = "Thống kê thuốc";
            this.Load += new System.EventHandler(this.fr_Tk_Thuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_Thuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_find_by_ma;
        private System.Windows.Forms.TextBox txt_find_by_name;
        private System.Windows.Forms.Button bt_find_name;
        private System.Windows.Forms.Button btn_find_maHso;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Gridview_Thuoc;
    }
}