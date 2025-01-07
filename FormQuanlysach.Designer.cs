namespace BTLON_NHOMTHUVIEN
{
    partial class FormQuanlysach
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
            this.dgvCapnhatsach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.cboMatg = new System.Windows.Forms.ComboBox();
            this.cboTheloai = new System.Windows.Forms.ComboBox();
            this.cboManxb = new System.Windows.Forms.ComboBox();
            this.dtnamxb = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapnhatsach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCapnhatsach
            // 
            this.dgvCapnhatsach.AllowUserToAddRows = false;
            this.dgvCapnhatsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapnhatsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvCapnhatsach.Location = new System.Drawing.Point(40, 155);
            this.dgvCapnhatsach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCapnhatsach.Name = "dgvCapnhatsach";
            this.dgvCapnhatsach.RowHeadersVisible = false;
            this.dgvCapnhatsach.RowHeadersWidth = 51;
            this.dgvCapnhatsach.RowTemplate.Height = 24;
            this.dgvCapnhatsach.Size = new System.Drawing.Size(676, 217);
            this.dgvCapnhatsach.TabIndex = 14;
            this.dgvCapnhatsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCapnhatsach_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.cboMatg);
            this.groupBox2.Controls.Add(this.cboTheloai);
            this.groupBox2.Controls.Add(this.cboManxb);
            this.groupBox2.Controls.Add(this.dtnamxb);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txtTensach);
            this.groupBox2.Controls.Add(this.txtMasach);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(40, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(676, 128);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật sách";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(436, 94);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 19);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(520, 95);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(56, 19);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.txtExcel_Click);
            // 
            // cboMatg
            // 
            this.cboMatg.FormattingEnabled = true;
            this.cboMatg.Location = new System.Drawing.Point(544, 53);
            this.cboMatg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMatg.Name = "cboMatg";
            this.cboMatg.Size = new System.Drawing.Size(128, 21);
            this.cboMatg.TabIndex = 5;
            // 
            // cboTheloai
            // 
            this.cboTheloai.FormattingEnabled = true;
            this.cboTheloai.Location = new System.Drawing.Point(544, 24);
            this.cboTheloai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTheloai.Name = "cboTheloai";
            this.cboTheloai.Size = new System.Drawing.Size(128, 21);
            this.cboTheloai.TabIndex = 5;
            // 
            // cboManxb
            // 
            this.cboManxb.FormattingEnabled = true;
            this.cboManxb.Location = new System.Drawing.Point(313, 50);
            this.cboManxb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboManxb.Name = "cboManxb";
            this.cboManxb.Size = new System.Drawing.Size(132, 21);
            this.cboManxb.TabIndex = 5;
            // 
            // dtnamxb
            // 
            this.dtnamxb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtnamxb.Location = new System.Drawing.Point(313, 24);
            this.dtnamxb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtnamxb.Name = "dtnamxb";
            this.dtnamxb.Size = new System.Drawing.Size(132, 20);
            this.dtnamxb.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(607, 95);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(56, 19);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(347, 95);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(56, 19);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(254, 95);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 19);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(158, 95);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 19);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(64, 95);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 19);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(91, 53);
            this.txtTensach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(125, 20);
            this.txtTensach.TabIndex = 1;
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(91, 25);
            this.txtMasach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(125, 20);
            this.txtMasach.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã nhà XB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã tác giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Năm xuất bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thể loại sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "masach";
            this.Column1.HeaderText = "Mã sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tensach";
            this.Column2.HeaderText = "Tên sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "namxb";
            this.Column3.HeaderText = "Năm xuất bản ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "manxb";
            this.Column4.HeaderText = "Mã nhà xuất bản";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 115;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "matheloai";
            this.Column5.HeaderText = "Mã thể loại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 101;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "matg";
            this.Column6.HeaderText = "Mã tác giả";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // FormQuanlysach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 395);
            this.Controls.Add(this.dgvCapnhatsach);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormQuanlysach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.FormQuanlysach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapnhatsach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCapnhatsach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtnamxb;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboManxb;
        private System.Windows.Forms.ComboBox cboMatg;
        private System.Windows.Forms.ComboBox cboTheloai;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}