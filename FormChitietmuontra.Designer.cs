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
            this.cbbmasach = new System.Windows.Forms.ComboBox();
            this.dttra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btngiahan = new System.Windows.Forms.Button();
            this.btbtimkiem = new System.Windows.Forms.Button();
            this.btnluu2 = new System.Windows.Forms.Button();
            this.dtmuon = new System.Windows.Forms.DateTimePicker();
            this.maphieumuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbphieumuon
            // 
            this.cbbphieumuon.FormattingEnabled = true;
            this.cbbphieumuon.Location = new System.Drawing.Point(300, 51);
            this.cbbphieumuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbphieumuon.Name = "cbbphieumuon";
            this.cbbphieumuon.Size = new System.Drawing.Size(180, 28);
            this.cbbphieumuon.TabIndex = 0;
            // 
            // btnthem2
            // 
            this.btnthem2.Location = new System.Drawing.Point(243, 278);
            this.btnthem2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem2.Name = "btnthem2";
            this.btnthem2.Size = new System.Drawing.Size(123, 47);
            this.btnthem2.TabIndex = 1;
            this.btnthem2.Text = "Thêm";
            this.btnthem2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày mượn";
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttinhtrang.Location = new System.Drawing.Point(300, 167);
            this.txttinhtrang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttinhtrang.Multiline = true;
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(645, 80);
            this.txttinhtrang.TabIndex = 3;
            this.txttinhtrang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieumuon,
            this.masach,
            this.ngaymuon,
            this.ngaytra,
            this.ghichu});
            this.dgv2.Location = new System.Drawing.Point(77, 360);
            this.dgv2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 62;
            this.dgv2.Size = new System.Drawing.Size(1045, 314);
            this.dgv2.TabIndex = 4;
            // 
            // cbbmasach
            // 
            this.cbbmasach.FormattingEnabled = true;
            this.cbbmasach.Location = new System.Drawing.Point(882, 55);
            this.cbbmasach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbmasach.Name = "cbbmasach";
            this.cbbmasach.Size = new System.Drawing.Size(180, 28);
            this.cbbmasach.TabIndex = 0;
            // 
            // dttra
            // 
            this.dttra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttra.Location = new System.Drawing.Point(882, 115);
            this.dttra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dttra.Name = "dttra";
            this.dttra.Size = new System.Drawing.Size(298, 26);
            this.dttra.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tình trạng sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(706, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(706, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày hẹn trả";
            // 
            // btngiahan
            // 
            this.btngiahan.Location = new System.Drawing.Point(433, 278);
            this.btngiahan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btngiahan.Name = "btngiahan";
            this.btngiahan.Size = new System.Drawing.Size(124, 47);
            this.btngiahan.TabIndex = 1;
            this.btngiahan.Text = "Gia hạn";
            this.btngiahan.UseVisualStyleBackColor = true;
            // 
            // btbtimkiem
            // 
            this.btbtimkiem.Location = new System.Drawing.Point(636, 278);
            this.btbtimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btbtimkiem.Name = "btbtimkiem";
            this.btbtimkiem.Size = new System.Drawing.Size(123, 47);
            this.btbtimkiem.TabIndex = 1;
            this.btbtimkiem.Text = "Tìm kiếm";
            this.btbtimkiem.UseVisualStyleBackColor = true;
            // 
            // btnluu2
            // 
            this.btnluu2.Location = new System.Drawing.Point(845, 278);
            this.btnluu2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnluu2.Name = "btnluu2";
            this.btnluu2.Size = new System.Drawing.Size(117, 47);
            this.btnluu2.TabIndex = 1;
            this.btnluu2.Text = "Lưu";
            this.btnluu2.UseVisualStyleBackColor = true;
            // 
            // dtmuon
            // 
            this.dtmuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmuon.Location = new System.Drawing.Point(300, 114);
            this.dtmuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtmuon.Name = "dtmuon";
            this.dtmuon.Size = new System.Drawing.Size(298, 26);
            this.dtmuon.TabIndex = 5;
            // 
            // maphieumuon
            // 
            this.maphieumuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maphieumuon.HeaderText = "Mã phiếu ";
            this.maphieumuon.MinimumWidth = 8;
            this.maphieumuon.Name = "maphieumuon";
            // 
            // masach
            // 
            this.masach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.masach.HeaderText = "Mã sách";
            this.masach.MinimumWidth = 8;
            this.masach.Name = "masach";
            // 
            // ngaymuon
            // 
            this.ngaymuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaymuon.HeaderText = "Ngày mượn";
            this.ngaymuon.MinimumWidth = 8;
            this.ngaymuon.Name = "ngaymuon";
            // 
            // ngaytra
            // 
            this.ngaytra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaytra.HeaderText = "Ngày trả";
            this.ngaytra.MinimumWidth = 8;
            this.ngaytra.Name = "ngaytra";
            // 
            // ghichu
            // 
            this.ghichu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 8;
            this.ghichu.Name = "ghichu";
            // 
            // FormChitietmuontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
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
            this.Controls.Add(this.btbtimkiem);
            this.Controls.Add(this.btngiahan);
            this.Controls.Add(this.btnthem2);
            this.Controls.Add(this.cbbmasach);
            this.Controls.Add(this.cbbphieumuon);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormChitietmuontra";
            this.Text = "Chi tiết mượn trả";
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
        private System.Windows.Forms.Button btbtimkiem;
        private System.Windows.Forms.Button btnluu2;
        private System.Windows.Forms.DateTimePicker dtmuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieumuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}