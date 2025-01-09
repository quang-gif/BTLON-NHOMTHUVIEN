namespace BTLON_NHOMTHUVIEN
{
    partial class FormTimsach
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
            this.btTK = new System.Windows.Forms.Button();
            this.txtTS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentheloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.httacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.btRS = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btTK
            // 
            this.btTK.Location = new System.Drawing.Point(744, 44);
            this.btTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(168, 28);
            this.btTK.TabIndex = 0;
            this.btTK.Text = "Tìm kiếm";
            this.btTK.UseVisualStyleBackColor = true;
            this.btTK.Click += new System.EventHandler(this.btTK_Click);
            // 
            // txtTS
            // 
            this.txtTS.Location = new System.Drawing.Point(195, 31);
            this.txtTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTS.Name = "txtTS";
            this.txtTS.Size = new System.Drawing.Size(356, 22);
            this.txtTS.TabIndex = 1;
            this.txtTS.TextChanged += new System.EventHandler(this.txtTS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.tensach,
            this.namxb,
            this.tennxb,
            this.tentheloai,
            this.httacgia});
            this.dataGridView1.Location = new System.Drawing.Point(27, 214);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(997, 249);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.MinimumWidth = 6;
            this.masach.Name = "masach";
            this.masach.Width = 125;
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "tensach";
            this.tensach.HeaderText = "Tên sách";
            this.tensach.MinimumWidth = 6;
            this.tensach.Name = "tensach";
            this.tensach.Width = 200;
            // 
            // namxb
            // 
            this.namxb.DataPropertyName = "namxb";
            this.namxb.HeaderText = "Năm xuất bản";
            this.namxb.MinimumWidth = 6;
            this.namxb.Name = "namxb";
            this.namxb.Width = 125;
            // 
            // tennxb
            // 
            this.tennxb.DataPropertyName = "tennxb";
            this.tennxb.HeaderText = "Tên NXB";
            this.tennxb.MinimumWidth = 6;
            this.tennxb.Name = "tennxb";
            this.tennxb.Width = 125;
            // 
            // tentheloai
            // 
            this.tentheloai.DataPropertyName = "tentheloai";
            this.tentheloai.HeaderText = "Thể loại";
            this.tentheloai.MinimumWidth = 6;
            this.tentheloai.Name = "tentheloai";
            this.tentheloai.Width = 125;
            // 
            // httacgia
            // 
            this.httacgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.httacgia.DataPropertyName = "httacgia";
            this.httacgia.HeaderText = "Tên tác giả";
            this.httacgia.MinimumWidth = 6;
            this.httacgia.Name = "httacgia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã sách";
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(195, 64);
            this.txtMS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(356, 22);
            this.txtMS.TabIndex = 13;
            // 
            // btRS
            // 
            this.btRS.Location = new System.Drawing.Point(803, 480);
            this.btRS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRS.Name = "btRS";
            this.btRS.Size = new System.Drawing.Size(107, 28);
            this.btRS.TabIndex = 14;
            this.btRS.Text = "Reset";
            this.btRS.UseVisualStyleBackColor = true;
            this.btRS.Click += new System.EventHandler(this.btRS_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(917, 480);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(107, 28);
            this.btThoat.TabIndex = 15;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "TÌM KIẾM SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTK);
            this.groupBox1.Controls.Add(this.txtTS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMS);
            this.groupBox1.Location = new System.Drawing.Point(27, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(997, 111);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số lượng sách:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(127, 183);
            this.a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(0, 16);
            this.a.TabIndex = 19;
            // 
            // FormTimsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 523);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btRS);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTimsach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm sách";
            this.Load += new System.EventHandler(this.FormTimsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTK;
        private System.Windows.Forms.TextBox txtTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn namxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentheloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn httacgia;
        private System.Windows.Forms.Button btRS;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label a;
    }
}