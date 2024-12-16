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
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbphieumuon
            // 
            this.cbbphieumuon.FormattingEnabled = true;
            this.cbbphieumuon.Location = new System.Drawing.Point(212, 45);
            this.cbbphieumuon.Name = "cbbphieumuon";
            this.cbbphieumuon.Size = new System.Drawing.Size(121, 21);
            this.cbbphieumuon.TabIndex = 0;
            // 
            // btnthem2
            // 
            this.btnthem2.Location = new System.Drawing.Point(197, 205);
            this.btnthem2.Name = "btnthem2";
            this.btnthem2.Size = new System.Drawing.Size(75, 23);
            this.btnthem2.TabIndex = 1;
            this.btnthem2.Text = "Thêm";
            this.btnthem2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày mượn";
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttinhtrang.Location = new System.Drawing.Point(212, 132);
            this.txttinhtrang.Multiline = true;
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(319, 53);
            this.txttinhtrang.TabIndex = 3;
            this.txttinhtrang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(92, 234);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(644, 204);
            this.dgv2.TabIndex = 4;
            // 
            // cbbmasach
            // 
            this.cbbmasach.FormattingEnabled = true;
            this.cbbmasach.Location = new System.Drawing.Point(588, 45);
            this.cbbmasach.Name = "cbbmasach";
            this.cbbmasach.Size = new System.Drawing.Size(121, 21);
            this.cbbmasach.TabIndex = 0;
            // 
            // dttra
            // 
            this.dttra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttra.Location = new System.Drawing.Point(588, 88);
            this.dttra.Name = "dttra";
            this.dttra.Size = new System.Drawing.Size(200, 20);
            this.dttra.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tình trạng sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày hẹn trả";
            // 
            // btngiahan
            // 
            this.btngiahan.Location = new System.Drawing.Point(325, 205);
            this.btngiahan.Name = "btngiahan";
            this.btngiahan.Size = new System.Drawing.Size(75, 23);
            this.btngiahan.TabIndex = 1;
            this.btngiahan.Text = "Gia hạn";
            this.btngiahan.UseVisualStyleBackColor = true;
            // 
            // btbtimkiem
            // 
            this.btbtimkiem.Location = new System.Drawing.Point(456, 205);
            this.btbtimkiem.Name = "btbtimkiem";
            this.btbtimkiem.Size = new System.Drawing.Size(75, 23);
            this.btbtimkiem.TabIndex = 1;
            this.btbtimkiem.Text = "Tìm kiếm";
            this.btbtimkiem.UseVisualStyleBackColor = true;
            // 
            // btnluu2
            // 
            this.btnluu2.Location = new System.Drawing.Point(576, 205);
            this.btnluu2.Name = "btnluu2";
            this.btnluu2.Size = new System.Drawing.Size(75, 23);
            this.btnluu2.TabIndex = 1;
            this.btnluu2.Text = "Lưu";
            this.btnluu2.UseVisualStyleBackColor = true;
            // 
            // dtmuon
            // 
            this.dtmuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmuon.Location = new System.Drawing.Point(212, 87);
            this.dtmuon.Name = "dtmuon";
            this.dtmuon.Size = new System.Drawing.Size(200, 20);
            this.dtmuon.TabIndex = 5;
            // 
            // FormChitietmuontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}