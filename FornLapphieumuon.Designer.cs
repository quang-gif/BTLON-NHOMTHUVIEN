namespace BTLON_NHOMTHUVIEN
{
    partial class FornLapphieumuon
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
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtphieumuon = new System.Windows.Forms.TextBox();
            this.cbbdocgia = new System.Windows.Forms.ComboBox();
            this.cbbnhanvien = new System.Windows.Forms.ComboBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mamuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnthem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem.Location = new System.Drawing.Point(858, 24);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(112, 35);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            this.btnthem.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            // 
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnsua.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsua.Location = new System.Drawing.Point(552, 257);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(112, 35);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            this.btnsua.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            // 
            // btnluu
            // 
            this.btnluu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnluu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Location = new System.Drawing.Point(393, 257);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(112, 35);
            this.btnluu.TabIndex = 1;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            this.btnluu.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnthoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoat.Location = new System.Drawing.Point(858, 155);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(112, 35);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            this.btnthoat.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnxoa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoa.Location = new System.Drawing.Point(858, 85);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(112, 35);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            this.btnxoa.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            // 
            // txtphieumuon
            // 
            this.txtphieumuon.Location = new System.Drawing.Point(443, 24);
            this.txtphieumuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtphieumuon.Multiline = true;
            this.txtphieumuon.Name = "txtphieumuon";
            this.txtphieumuon.Size = new System.Drawing.Size(236, 32);
            this.txtphieumuon.TabIndex = 2;
            // 
            // cbbdocgia
            // 
            this.cbbdocgia.FormattingEnabled = true;
            this.cbbdocgia.Location = new System.Drawing.Point(443, 159);
            this.cbbdocgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbdocgia.Name = "cbbdocgia";
            this.cbbdocgia.Size = new System.Drawing.Size(254, 28);
            this.cbbdocgia.TabIndex = 3;
            // 
            // cbbnhanvien
            // 
            this.cbbnhanvien.FormattingEnabled = true;
            this.cbbnhanvien.Location = new System.Drawing.Point(443, 89);
            this.cbbnhanvien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbnhanvien.Name = "cbbnhanvien";
            this.cbbnhanvien.Size = new System.Drawing.Size(254, 28);
            this.cbbnhanvien.TabIndex = 3;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamuon,
            this.madocgia,
            this.manhanvien});
            this.dgv1.Location = new System.Drawing.Point(74, 302);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.Size = new System.Drawing.Size(1056, 355);
            this.dgv1.TabIndex = 4;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã phiếu mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã nhân viên";
            // 
            // mamuon
            // 
            this.mamuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mamuon.DataPropertyName = "mamuon";
            this.mamuon.HeaderText = "Mã phiếu ";
            this.mamuon.MinimumWidth = 8;
            this.mamuon.Name = "mamuon";
            // 
            // madocgia
            // 
            this.madocgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.madocgia.DataPropertyName = "madg";
            this.madocgia.HeaderText = "Mã độc giả";
            this.madocgia.MinimumWidth = 8;
            this.madocgia.Name = "madocgia";
            // 
            // manhanvien
            // 
            this.manhanvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manhanvien.DataPropertyName = "manhanvien";
            this.manhanvien.HeaderText = "Mã nhân viên";
            this.manhanvien.MinimumWidth = 8;
            this.manhanvien.Name = "manhanvien";
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(717, 257);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(85, 35);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // FornLapphieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.cbbnhanvien);
            this.Controls.Add(this.cbbdocgia);
            this.Controls.Add(this.txtphieumuon);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FornLapphieumuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu mượn";
            this.Load += new System.EventHandler(this.FornLapphieumuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtphieumuon;
        private System.Windows.Forms.ComboBox cbbdocgia;
        private System.Windows.Forms.ComboBox cbbnhanvien;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn madocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.Button btnreset;
    }
}