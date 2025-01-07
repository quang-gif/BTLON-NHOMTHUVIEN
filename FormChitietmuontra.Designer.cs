namespace BTLON_NHOMTHUVIEN
{
    partial class FormChitietmuontra
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
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.maphieumuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtmuon = new System.Windows.Forms.DateTimePicker();
            this.dttra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbmasach = new System.Windows.Forms.ComboBox();
            this.cbbphieumuon = new System.Windows.Forms.ComboBox();
            this.btnexcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btntrasach = new System.Windows.Forms.Button();
            this.btngiahan = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieumuon,
            this.tensach,
            this.tendg,
            this.ngaytra,
            this.hotennv});
            this.dgv2.Location = new System.Drawing.Point(53, 284);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowHeadersWidth = 62;
            this.dgv2.Size = new System.Drawing.Size(697, 154);
            this.dgv2.TabIndex = 4;
            this.dgv2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellClick);
            // 
            // maphieumuon
            // 
            this.maphieumuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maphieumuon.DataPropertyName = "mamuon";
            this.maphieumuon.HeaderText = "Mã phiếu ";
            this.maphieumuon.MinimumWidth = 8;
            this.maphieumuon.Name = "maphieumuon";
            // 
            // tensach
            // 
            this.tensach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tensach.DataPropertyName = "tensach";
            this.tensach.HeaderText = "Tên sách";
            this.tensach.Name = "tensach";
            // 
            // tendg
            // 
            this.tendg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tendg.DataPropertyName = "htdocgia";
            this.tendg.HeaderText = "Tên độc giả";
            this.tendg.Name = "tendg";
            // 
            // ngaytra
            // 
            this.ngaytra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaytra.DataPropertyName = "ngaytra";
            this.ngaytra.HeaderText = "Ngày trả";
            this.ngaytra.MinimumWidth = 8;
            this.ngaytra.Name = "ngaytra";
            // 
            // hotennv
            // 
            this.hotennv.DataPropertyName = "hotennv";
            this.hotennv.HeaderText = "Nhân viên";
            this.hotennv.Name = "hotennv";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtmuon);
            this.groupBox1.Controls.Add(this.dttra);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbmasach);
            this.groupBox1.Controls.Add(this.cbbphieumuon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 179);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết mượn trả";
            // 
            // dtmuon
            // 
            this.dtmuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmuon.Location = new System.Drawing.Point(171, 104);
            this.dtmuon.Name = "dtmuon";
            this.dtmuon.Size = new System.Drawing.Size(200, 20);
            this.dtmuon.TabIndex = 18;
            // 
            // dttra
            // 
            this.dttra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttra.Location = new System.Drawing.Point(559, 103);
            this.dttra.Name = "dttra";
            this.dttra.Size = new System.Drawing.Size(200, 20);
            this.dttra.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày hẹn trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ngày mượn";
            // 
            // cbbmasach
            // 
            this.cbbmasach.FormattingEnabled = true;
            this.cbbmasach.Location = new System.Drawing.Point(559, 39);
            this.cbbmasach.Name = "cbbmasach";
            this.cbbmasach.Size = new System.Drawing.Size(160, 21);
            this.cbbmasach.TabIndex = 8;
            // 
            // cbbphieumuon
            // 
            this.cbbphieumuon.FormattingEnabled = true;
            this.cbbphieumuon.Location = new System.Drawing.Point(171, 42);
            this.cbbphieumuon.Name = "cbbphieumuon";
            this.cbbphieumuon.Size = new System.Drawing.Size(181, 21);
            this.cbbphieumuon.TabIndex = 9;
            this.cbbphieumuon.SelectedIndexChanged += new System.EventHandler(this.cbbphieumuon_SelectedIndexChanged);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(285, 198);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(79, 31);
            this.btnexcel.TabIndex = 21;
            this.btnexcel.Text = "Xuất Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btntrasach
            // 
            this.btntrasach.Location = new System.Drawing.Point(183, 197);
            this.btntrasach.Name = "btntrasach";
            this.btntrasach.Size = new System.Drawing.Size(82, 31);
            this.btntrasach.TabIndex = 10;
            this.btntrasach.Text = "Trả sách";
            this.btntrasach.UseVisualStyleBackColor = true;
            this.btntrasach.Click += new System.EventHandler(this.btntrasach_Click_1);
            // 
            // btngiahan
            // 
            this.btngiahan.Location = new System.Drawing.Point(80, 197);
            this.btngiahan.Name = "btngiahan";
            this.btngiahan.Size = new System.Drawing.Size(83, 31);
            this.btngiahan.TabIndex = 11;
            this.btngiahan.Text = "Gia hạn";
            this.btngiahan.UseVisualStyleBackColor = true;
            this.btngiahan.Click += new System.EventHandler(this.btngiahan_Click_1);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(386, 198);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 31);
            this.btntimkiem.TabIndex = 22;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Số lượng sách mượn: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "label6";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 25;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormChitietmuontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.btntrasach);
            this.Controls.Add(this.btngiahan);
            this.Name = "FormChitietmuontra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết mượn trả";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChitietmuontra_FormClosed);
            this.Load += new System.EventHandler(this.FormChitietmuontra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtmuon;
        private System.Windows.Forms.DateTimePicker dttra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbmasach;
        private System.Windows.Forms.ComboBox cbbphieumuon;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btntrasach;
        private System.Windows.Forms.Button btngiahan;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieumuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotennv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}