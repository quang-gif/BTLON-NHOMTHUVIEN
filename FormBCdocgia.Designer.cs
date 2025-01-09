namespace BTLON_NHOMTHUVIEN
{
    partial class FormBCdocgia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.cbothongkedocgia = new System.Windows.Forms.ComboBox();
            this.dgvTKDG = new System.Windows.Forms.DataGridView();
            this.madg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.htdocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnthongke);
            this.groupBox1.Controls.Add(this.cbothongkedocgia);
            this.groupBox1.Location = new System.Drawing.Point(35, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1079, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn thống kê";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(548, 48);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 28);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(871, 48);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(707, 48);
            this.btnthongke.Margin = new System.Windows.Forms.Padding(4);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(100, 28);
            this.btnthongke.TabIndex = 1;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // cbothongkedocgia
            // 
            this.cbothongkedocgia.FormattingEnabled = true;
            this.cbothongkedocgia.Location = new System.Drawing.Point(77, 52);
            this.cbothongkedocgia.Margin = new System.Windows.Forms.Padding(4);
            this.cbothongkedocgia.Name = "cbothongkedocgia";
            this.cbothongkedocgia.Size = new System.Drawing.Size(305, 24);
            this.cbothongkedocgia.TabIndex = 0;
            // 
            // dgvTKDG
            // 
            this.dgvTKDG.AllowUserToAddRows = false;
            this.dgvTKDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madg,
            this.htdocgia,
            this.ngaysinh,
            this.gioitinh,
            this.lop});
            this.dgvTKDG.Location = new System.Drawing.Point(35, 265);
            this.dgvTKDG.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTKDG.Name = "dgvTKDG";
            this.dgvTKDG.RowHeadersVisible = false;
            this.dgvTKDG.RowHeadersWidth = 51;
            this.dgvTKDG.Size = new System.Drawing.Size(1079, 274);
            this.dgvTKDG.TabIndex = 3;
            // 
            // madg
            // 
            this.madg.DataPropertyName = "madg";
            this.madg.HeaderText = "Mã độc giả";
            this.madg.MinimumWidth = 6;
            this.madg.Name = "madg";
            this.madg.Width = 125;
            // 
            // htdocgia
            // 
            this.htdocgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.htdocgia.DataPropertyName = "htdocgia";
            this.htdocgia.HeaderText = "Tên độc giả";
            this.htdocgia.MinimumWidth = 6;
            this.htdocgia.Name = "htdocgia";
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            // 
            // lop
            // 
            this.lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lop.DataPropertyName = "lop";
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "BÁO CÁO THỐNG KÊ ĐỘC GIẢ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số lượng độc giả:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(167, 235);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(0, 16);
            this.a.TabIndex = 6;
            // 
            // FormBCdocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 554);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTKDG);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBCdocgia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo độc giả";
            this.Load += new System.EventHandler(this.FormBCdocgia_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.ComboBox cbothongkedocgia;
        private System.Windows.Forms.DataGridView dgvTKDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.DataGridViewTextBoxColumn madg;
        private System.Windows.Forms.DataGridViewTextBoxColumn htdocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
    }
}