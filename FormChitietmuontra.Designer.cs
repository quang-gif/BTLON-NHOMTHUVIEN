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
            this.cbbphieumuon = new System.Windows.Forms.ComboBox();
            this.btnthem2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.maphieumuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbmasach = new System.Windows.Forms.ComboBox();
            this.dttra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btngiahan = new System.Windows.Forms.Button();
            this.btntrasach = new System.Windows.Forms.Button();
            this.btnluu2 = new System.Windows.Forms.Button();
            this.dtmuon = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbphieumuon
            // 
            this.cbbphieumuon.FormattingEnabled = true;
            this.cbbphieumuon.Location = new System.Drawing.Point(200, 33);
            this.cbbphieumuon.Name = "cbbphieumuon";
            this.cbbphieumuon.Size = new System.Drawing.Size(181, 21);
            this.cbbphieumuon.TabIndex = 0;
            // 
            // btnthem2
            // 
            this.btnthem2.Location = new System.Drawing.Point(95, 181);
            this.btnthem2.Name = "btnthem2";
            this.btnthem2.Size = new System.Drawing.Size(82, 31);
            this.btnthem2.TabIndex = 1;
            this.btnthem2.Text = "Thêm";
            this.btnthem2.UseVisualStyleBackColor = true;
            this.btnthem2.Click += new System.EventHandler(this.btnthem2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày mượn";
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttinhtrang.Location = new System.Drawing.Point(200, 109);
            this.txttinhtrang.Multiline = true;
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(431, 53);
            this.txttinhtrang.TabIndex = 3;
            this.txttinhtrang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieumuon,
            this.masach,
            this.ngaymuon,
            this.ngaytra,
            this.ghichu});
            this.dgv2.Location = new System.Drawing.Point(51, 234);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowHeadersWidth = 62;
            this.dgv2.Size = new System.Drawing.Size(697, 204);
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
            // masach
            // 
            this.masach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.MinimumWidth = 8;
            this.masach.Name = "masach";
            // 
            // ngaymuon
            // 
            this.ngaymuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaymuon.DataPropertyName = "ngaymuon";
            this.ngaymuon.HeaderText = "Ngày mượn";
            this.ngaymuon.MinimumWidth = 8;
            this.ngaymuon.Name = "ngaymuon";
            // 
            // ngaytra
            // 
            this.ngaytra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaytra.DataPropertyName = "ngaytra";
            this.ngaytra.HeaderText = "Ngày trả";
            this.ngaytra.MinimumWidth = 8;
            this.ngaytra.Name = "ngaytra";
            // 
            // ghichu
            // 
            this.ghichu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghichu.DataPropertyName = "tinhtrangsach";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 8;
            this.ghichu.Name = "ghichu";
            // 
            // cbbmasach
            // 
            this.cbbmasach.FormattingEnabled = true;
            this.cbbmasach.Location = new System.Drawing.Point(588, 36);
            this.cbbmasach.Name = "cbbmasach";
            this.cbbmasach.Size = new System.Drawing.Size(160, 21);
            this.cbbmasach.TabIndex = 0;
            // 
            // dttra
            // 
            this.dttra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttra.Location = new System.Drawing.Point(588, 75);
            this.dttra.Name = "dttra";
            this.dttra.Size = new System.Drawing.Size(200, 20);
            this.dttra.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tình trạng sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày hẹn trả";
            // 
            // btngiahan
            // 
            this.btngiahan.Location = new System.Drawing.Point(223, 181);
            this.btngiahan.Name = "btngiahan";
            this.btngiahan.Size = new System.Drawing.Size(83, 31);
            this.btngiahan.TabIndex = 1;
            this.btngiahan.Text = "Gia hạn";
            this.btngiahan.UseVisualStyleBackColor = true;
            this.btngiahan.Click += new System.EventHandler(this.btngiahan_Click);
            // 
            // btntrasach
            // 
            this.btntrasach.Location = new System.Drawing.Point(354, 181);
            this.btntrasach.Name = "btntrasach";
            this.btntrasach.Size = new System.Drawing.Size(82, 31);
            this.btntrasach.TabIndex = 1;
            this.btntrasach.Text = "Trả sách";
            this.btntrasach.UseVisualStyleBackColor = true;
            this.btntrasach.Click += new System.EventHandler(this.btntrasach_Click);
            // 
            // btnluu2
            // 
            this.btnluu2.Location = new System.Drawing.Point(475, 181);
            this.btnluu2.Name = "btnluu2";
            this.btnluu2.Size = new System.Drawing.Size(78, 31);
            this.btnluu2.TabIndex = 1;
            this.btnluu2.Text = "Lưu";
            this.btnluu2.UseVisualStyleBackColor = true;
            this.btnluu2.Click += new System.EventHandler(this.btnluu2_Click);
            // 
            // dtmuon
            // 
            this.dtmuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmuon.Location = new System.Drawing.Point(200, 74);
            this.dtmuon.Name = "dtmuon";
            this.dtmuon.Size = new System.Drawing.Size(200, 20);
            this.dtmuon.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lập phiếu mượn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(588, 181);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(79, 31);
            this.btnexcel.TabIndex = 7;
            this.btnexcel.Text = "Xuất Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // FormChitietmuontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtmuon);
            this.Controls.Add(this.dttra);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.txttinhtrang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnluu2);
            this.Controls.Add(this.btntrasach);
            this.Controls.Add(this.btngiahan);
            this.Controls.Add(this.btnthem2);
            this.Controls.Add(this.cbbmasach);
            this.Controls.Add(this.cbbphieumuon);
            this.Name = "FormChitietmuontra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết mượn trả";
            this.Load += new System.EventHandler(this.FormChitietmuontra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbphieumuon;
        private System.Windows.Forms.Button btnthem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.ComboBox cbbmasach;
        private System.Windows.Forms.DateTimePicker dttra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btngiahan;
        private System.Windows.Forms.Button btntrasach;
        private System.Windows.Forms.Button btnluu2;
        private System.Windows.Forms.DateTimePicker dtmuon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieumuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.Button btnexcel;
    }
}