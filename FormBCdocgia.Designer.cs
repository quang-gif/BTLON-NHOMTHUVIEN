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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.cbothongke = new System.Windows.Forms.ComboBox();
            this.dgvTKDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.madg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.htdocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btnthongke);
            this.groupBox1.Controls.Add(this.cbothongke);
            this.groupBox1.Location = new System.Drawing.Point(35, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1079, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn thống kê";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(871, 48);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 28);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(707, 48);
            this.btnthongke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(100, 28);
            this.btnthongke.TabIndex = 1;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.UseVisualStyleBackColor = true;
            // 
            // cbothongke
            // 
            this.cbothongke.FormattingEnabled = true;
            this.cbothongke.Items.AddRange(new object[] {
            "Tất cả độc giả",
            "Độc giả trễ hạn"});
            this.cbothongke.Location = new System.Drawing.Point(83, 48);
            this.cbothongke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbothongke.Name = "cbothongke";
            this.cbothongke.Size = new System.Drawing.Size(231, 24);
            this.cbothongke.TabIndex = 0;
            // 
            // dgvTKDG
            // 
            this.dgvTKDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madg,
            this.htdocgia,
            this.ngaysinh,
            this.gioitinh,
            this.lop});
            this.dgvTKDG.Location = new System.Drawing.Point(35, 240);
            this.dgvTKDG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTKDG.Name = "dgvTKDG";
            this.dgvTKDG.RowHeadersWidth = 51;
            this.dgvTKDG.Size = new System.Drawing.Size(1079, 299);
            this.dgvTKDG.TabIndex = 3;
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
            this.htdocgia.DataPropertyName = "htdocgia";
            this.htdocgia.HeaderText = "Tên độc giả";
            this.htdocgia.MinimumWidth = 6;
            this.htdocgia.Name = "htdocgia";
            this.htdocgia.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // lop
            // 
            this.lop.DataPropertyName = "lop";
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 125;
            // 
            // FormBCdocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTKDG);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBCdocgia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo độc giả";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.ComboBox cbothongke;
        private System.Windows.Forms.DataGridView dgvTKDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn madg;
        private System.Windows.Forms.DataGridViewTextBoxColumn htdocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
    }
}