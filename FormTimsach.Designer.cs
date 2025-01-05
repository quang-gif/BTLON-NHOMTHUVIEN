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
            this.txtTNXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTTG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentheloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.httacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTL = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btTK
            // 
            this.btTK.Location = new System.Drawing.Point(394, 76);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(374, 23);
            this.btTK.TabIndex = 0;
            this.btTK.Text = "Tìm kiếm";
            this.btTK.UseVisualStyleBackColor = true;
            this.btTK.Click += new System.EventHandler(this.btTK_Click);
            // 
            // txtTS
            // 
            this.txtTS.Location = new System.Drawing.Point(111, 26);
            this.txtTS.Name = "txtTS";
            this.txtTS.Size = new System.Drawing.Size(252, 20);
            this.txtTS.TabIndex = 1;
            this.txtTS.TextChanged += new System.EventHandler(this.txtTS_TextChanged);
            // 
            // txtTNXB
            // 
            this.txtTNXB.Location = new System.Drawing.Point(111, 52);
            this.txtTNXB.Name = "txtTNXB";
            this.txtTNXB.Size = new System.Drawing.Size(252, 20);
            this.txtTNXB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên nhà xuất bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Năm xuất bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thể loại";
            // 
            // txtTTG
            // 
            this.txtTTG.Location = new System.Drawing.Point(111, 78);
            this.txtTTG.Name = "txtTTG";
            this.txtTTG.Size = new System.Drawing.Size(252, 20);
            this.txtTTG.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên tác giả";
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 333);
            this.dataGridView1.TabIndex = 11;
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.Name = "masach";
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "tensach";
            this.tensach.HeaderText = "Tên sách";
            this.tensach.Name = "tensach";
            this.tensach.Width = 200;
            // 
            // namxb
            // 
            this.namxb.DataPropertyName = "namxb";
            this.namxb.HeaderText = "Năm xuất bản";
            this.namxb.Name = "namxb";
            // 
            // tennxb
            // 
            this.tennxb.DataPropertyName = "tennxb";
            this.tennxb.HeaderText = "NXB";
            this.tennxb.Name = "tennxb";
            // 
            // tentheloai
            // 
            this.tentheloai.DataPropertyName = "tentheloai";
            this.tentheloai.HeaderText = "Thể loại";
            this.tentheloai.Name = "tentheloai";
            // 
            // httacgia
            // 
            this.httacgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.httacgia.DataPropertyName = "httacgia";
            this.httacgia.HeaderText = "Tác giả";
            this.httacgia.Name = "httacgia";
            // 
            // cboTL
            // 
            this.cboTL.FormattingEnabled = true;
            this.cboTL.Location = new System.Drawing.Point(483, 25);
            this.cboTL.Name = "cboTL";
            this.cboTL.Size = new System.Drawing.Size(285, 21);
            this.cboTL.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(483, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // FormTimsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboTL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTTG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTNXB);
            this.Controls.Add(this.txtTS);
            this.Controls.Add(this.btTK);
            this.Name = "FormTimsach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm sách";
            this.Load += new System.EventHandler(this.FormTimsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTK;
        private System.Windows.Forms.TextBox txtTS;
        private System.Windows.Forms.TextBox txtTNXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTTG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn namxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentheloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn httacgia;
        private System.Windows.Forms.ComboBox cboTL;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}