namespace QuanLi_CuaHangThachCao
{
    partial class formHoaDon
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
            this.btthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbxTenHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.laba = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.dgvListSP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTongtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cbMaKhach = new System.Windows.Forms.ComboBox();
            this.cbTenKhach = new System.Windows.Forms.ComboBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(39, 196);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 28);
            this.btthem.TabIndex = 29;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(529, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hóa Đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tên Hàng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(101, 74);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(289, 20);
            this.txtSoLuong.TabIndex = 41;
            // 
            // cbxTenHang
            // 
            this.cbxTenHang.FormattingEnabled = true;
            this.cbxTenHang.Location = new System.Drawing.Point(101, 37);
            this.cbxTenHang.Name = "cbxTenHang";
            this.cbxTenHang.Size = new System.Drawing.Size(289, 21);
            this.cbxTenHang.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ngày Bán";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 287);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(550, 193);
            this.dgvHoaDon.TabIndex = 45;
            this.dgvHoaDon.SelectionChanged += new System.EventHandler(this.dgvHoaDon_SelectionChanged);
            // 
            // laba
            // 
            this.laba.AutoSize = true;
            this.laba.Location = new System.Drawing.Point(22, 43);
            this.laba.Name = "laba";
            this.laba.Size = new System.Drawing.Size(41, 13);
            this.laba.TabIndex = 40;
            this.laba.Text = "Mã HD";
            // 
            // tbMaHD
            // 
            this.tbMaHD.Location = new System.Drawing.Point(99, 40);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(411, 20);
            this.tbMaHD.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Mã NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Tên Khách";
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(99, 124);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(411, 20);
            this.tbMaNV.TabIndex = 41;
            // 
            // dgvListSP
            // 
            this.dgvListSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSP.Location = new System.Drawing.Point(12, 196);
            this.dgvListSP.Name = "dgvListSP";
            this.dgvListSP.Size = new System.Drawing.Size(496, 196);
            this.dgvListSP.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxTenHang);
            this.groupBox1.Controls.Add(this.dgvListSP);
            this.groupBox1.Controls.Add(this.tbTongtien);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(588, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 401);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết HD";
            // 
            // tbTongtien
            // 
            this.tbTongtien.Location = new System.Drawing.Point(101, 111);
            this.tbTongtien.Name = "tbTongtien";
            this.tbTongtien.Size = new System.Drawing.Size(289, 20);
            this.tbTongtien.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tổng Tiền";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Controls.Add(this.cbMaKhach);
            this.groupBox2.Controls.Add(this.cbTenKhach);
            this.groupBox2.Controls.Add(this.btthoat);
            this.groupBox2.Controls.Add(this.btLuu);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btsua);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btthem);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.laba);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbMaHD);
            this.groupBox2.Controls.Add(this.dgvHoaDon);
            this.groupBox2.Controls.Add(this.tbMaNV);
            this.groupBox2.Location = new System.Drawing.Point(12, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 493);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa Đơn";
            // 
            // date
            // 
            this.date.CustomFormat = "dd/MM/yyyy";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(99, 155);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(411, 20);
            this.date.TabIndex = 51;
            this.date.Value = new System.DateTime(2020, 12, 25, 0, 0, 0, 0);
            // 
            // cbMaKhach
            // 
            this.cbMaKhach.FormattingEnabled = true;
            this.cbMaKhach.Location = new System.Drawing.Point(99, 66);
            this.cbMaKhach.Name = "cbMaKhach";
            this.cbMaKhach.Size = new System.Drawing.Size(411, 21);
            this.cbMaKhach.TabIndex = 50;
            // 
            // cbTenKhach
            // 
            this.cbTenKhach.FormattingEnabled = true;
            this.cbTenKhach.Location = new System.Drawing.Point(99, 94);
            this.cbTenKhach.Name = "cbTenKhach";
            this.cbTenKhach.Size = new System.Drawing.Size(411, 21);
            this.cbTenKhach.TabIndex = 50;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(430, 196);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(80, 28);
            this.btthoat.TabIndex = 49;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(340, 196);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(80, 28);
            this.btLuu.TabIndex = 48;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(237, 196);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(80, 28);
            this.btXoa.TabIndex = 47;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(134, 196);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(80, 28);
            this.btsua.TabIndex = 47;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Mã Khách";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "formHoaDon";
            this.Text = "formHoaDon";
            this.Load += new System.EventHandler(this.formHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbxTenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label laba;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.DataGridView dgvListSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.TextBox tbTongtien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTenKhach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMaKhach;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date;
    }
}