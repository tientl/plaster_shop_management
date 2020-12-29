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
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laba = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.dgvListSP = new System.Windows.Forms.DataGridView();
            this.MaHDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrChiTietHD = new System.Windows.Forms.GroupBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.btnXoaSp = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnThemSp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbTenKhach = new System.Windows.Forms.RadioButton();
            this.rbMaHD = new System.Windows.Forms.RadioButton();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btThemKhach = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cbMaKhach = new System.Windows.Forms.ComboBox();
            this.cbTenKhach = new System.Windows.Forms.ComboBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSP)).BeginInit();
            this.GrChiTietHD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(105, 197);
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
            this.cbxTenHang.SelectedIndexChanged += new System.EventHandler(this.cbxTenHang_SelectedIndexChanged);
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
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 285);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.Size = new System.Drawing.Size(564, 202);
            this.dgvHoaDon.TabIndex = 45;
            this.dgvHoaDon.SelectionChanged += new System.EventHandler(this.dgvHoaDon_SelectionChanged);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaHDBan";
            this.Column6.HeaderText = "Mã HD";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenKhach";
            this.Column7.HeaderText = "Tên Khách";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaKhach";
            this.Column8.HeaderText = "Mã Khách";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaNhanVien";
            this.Column9.HeaderText = "Mã NV";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "NgayBan";
            this.Column10.HeaderText = "Ngày Bán";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
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
            this.label6.Location = new System.Drawing.Point(22, 70);
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
            this.dgvListSP.AllowUserToAddRows = false;
            this.dgvListSP.AllowUserToDeleteRows = false;
            this.dgvListSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDBan,
            this.Column4,
            this.Column2,
            this.Column1,
            this.Column5});
            this.dgvListSP.Location = new System.Drawing.Point(0, 285);
            this.dgvListSP.Name = "dgvListSP";
            this.dgvListSP.ReadOnly = true;
            this.dgvListSP.Size = new System.Drawing.Size(514, 208);
            this.dgvListSP.TabIndex = 47;
            this.dgvListSP.DataSourceChanged += new System.EventHandler(this.dgvListSP_DataSourceChanged);
            this.dgvListSP.SelectionChanged += new System.EventHandler(this.dgvListSP_SelectionChanged);
            // 
            // MaHDBan
            // 
            this.MaHDBan.DataPropertyName = "MaHDBan";
            this.MaHDBan.HeaderText = "Mã HD";
            this.MaHDBan.Name = "MaHDBan";
            this.MaHDBan.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenHang";
            this.Column4.HeaderText = "Tên Hàng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SoLuong";
            this.Column2.HeaderText = "Số Lượng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DonGiaBan";
            this.Column1.HeaderText = "Đơn Giá Bán";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TongTien";
            this.Column5.HeaderText = "Tổng Tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // GrChiTietHD
            // 
            this.GrChiTietHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GrChiTietHD.Controls.Add(this.lbTongTien);
            this.GrChiTietHD.Controls.Add(this.txtDonGiaBan);
            this.GrChiTietHD.Controls.Add(this.btnXoaSp);
            this.GrChiTietHD.Controls.Add(this.btLuu);
            this.GrChiTietHD.Controls.Add(this.btnSuaSP);
            this.GrChiTietHD.Controls.Add(this.btnThemSp);
            this.GrChiTietHD.Controls.Add(this.cbxTenHang);
            this.GrChiTietHD.Controls.Add(this.dgvListSP);
            this.GrChiTietHD.Controls.Add(this.txtSoLuong);
            this.GrChiTietHD.Controls.Add(this.label9);
            this.GrChiTietHD.Controls.Add(this.label7);
            this.GrChiTietHD.Controls.Add(this.label2);
            this.GrChiTietHD.Controls.Add(this.label3);
            this.GrChiTietHD.Location = new System.Drawing.Point(588, 82);
            this.GrChiTietHD.Name = "GrChiTietHD";
            this.GrChiTietHD.Size = new System.Drawing.Size(514, 493);
            this.GrChiTietHD.TabIndex = 48;
            this.GrChiTietHD.TabStop = false;
            this.GrChiTietHD.Text = "Chi Tiết HD";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(131, 156);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(19, 24);
            this.lbTongTien.TabIndex = 50;
            this.lbTongTien.Text = "0";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaBan.Location = new System.Drawing.Point(101, 108);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.ReadOnly = true;
            this.txtDonGiaBan.Size = new System.Drawing.Size(289, 20);
            this.txtDonGiaBan.TabIndex = 49;
            // 
            // btnXoaSp
            // 
            this.btnXoaSp.Location = new System.Drawing.Point(423, 108);
            this.btnXoaSp.Name = "btnXoaSp";
            this.btnXoaSp.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSp.TabIndex = 48;
            this.btnXoaSp.Text = "Xóa";
            this.btnXoaSp.UseVisualStyleBackColor = true;
            this.btnXoaSp.Click += new System.EventHandler(this.btnXoaSp_Click);
            // 
            // btLuu
            // 
            this.btLuu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btLuu.Location = new System.Drawing.Point(353, 243);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(145, 28);
            this.btLuu.TabIndex = 48;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Location = new System.Drawing.Point(423, 70);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(75, 23);
            this.btnSuaSP.TabIndex = 48;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnThemSp
            // 
            this.btnThemSp.Location = new System.Drawing.Point(423, 32);
            this.btnThemSp.Name = "btnThemSp";
            this.btnThemSp.Size = new System.Drawing.Size(75, 23);
            this.btnThemSp.TabIndex = 48;
            this.btnThemSp.Text = "Thêm";
            this.btnThemSp.UseVisualStyleBackColor = true;
            this.btnThemSp.Click += new System.EventHandler(this.btnThemSp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Đơn Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tổng Tiền:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btThemKhach);
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Controls.Add(this.cbMaKhach);
            this.groupBox2.Controls.Add(this.cbTenKhach);
            this.groupBox2.Controls.Add(this.btthoat);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 493);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa Đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbTenKhach);
            this.groupBox3.Controls.Add(this.rbMaHD);
            this.groupBox3.Controls.Add(this.tbtimkiem);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(6, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 40);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            // 
            // rbTenKhach
            // 
            this.rbTenKhach.AutoSize = true;
            this.rbTenKhach.Location = new System.Drawing.Point(454, 10);
            this.rbTenKhach.Name = "rbTenKhach";
            this.rbTenKhach.Size = new System.Drawing.Size(78, 17);
            this.rbTenKhach.TabIndex = 2;
            this.rbTenKhach.Text = "Tên Khách";
            this.rbTenKhach.UseVisualStyleBackColor = true;
            this.rbTenKhach.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbMaHD
            // 
            this.rbMaHD.AutoSize = true;
            this.rbMaHD.Checked = true;
            this.rbMaHD.Location = new System.Drawing.Point(389, 10);
            this.rbMaHD.Name = "rbMaHD";
            this.rbMaHD.Size = new System.Drawing.Size(59, 17);
            this.rbMaHD.TabIndex = 2;
            this.rbMaHD.TabStop = true;
            this.rbMaHD.Text = "Mã HD";
            this.rbMaHD.UseVisualStyleBackColor = true;
            this.rbMaHD.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Location = new System.Drawing.Point(99, 8);
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(270, 20);
            this.tbtimkiem.TabIndex = 1;
            this.tbtimkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tìm Kiếm";
            // 
            // btThemKhach
            // 
            this.btThemKhach.Location = new System.Drawing.Point(389, 65);
            this.btThemKhach.Name = "btThemKhach";
            this.btThemKhach.Size = new System.Drawing.Size(120, 50);
            this.btThemKhach.TabIndex = 52;
            this.btThemKhach.Text = "Thêm Khách Hàng";
            this.btThemKhach.UseVisualStyleBackColor = true;
            this.btThemKhach.Click += new System.EventHandler(this.btThemKhach_Click);
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
            this.cbMaKhach.Location = new System.Drawing.Point(99, 93);
            this.cbMaKhach.Name = "cbMaKhach";
            this.cbMaKhach.Size = new System.Drawing.Size(270, 21);
            this.cbMaKhach.TabIndex = 50;
            // 
            // cbTenKhach
            // 
            this.cbTenKhach.FormattingEnabled = true;
            this.cbTenKhach.Location = new System.Drawing.Point(99, 67);
            this.cbTenKhach.Name = "cbTenKhach";
            this.cbTenKhach.Size = new System.Drawing.Size(270, 21);
            this.cbTenKhach.TabIndex = 50;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(400, 196);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(80, 28);
            this.btthoat.TabIndex = 49;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(303, 197);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(80, 28);
            this.btXoa.TabIndex = 47;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(200, 197);
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
            this.label8.Location = new System.Drawing.Point(22, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Mã Khách";
            // 
            // formHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1114, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GrChiTietHD);
            this.Controls.Add(this.label1);
            this.Name = "formHoaDon";
            this.Text = "formHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSP)).EndInit();
            this.GrChiTietHD.ResumeLayout(false);
            this.GrChiTietHD.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox GrChiTietHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTenKhach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMaKhach;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.DateTimePicker date;
        public System.Windows.Forms.Button btThemKhach;
        private System.Windows.Forms.Button btnXoaSp;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnThemSp;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbMaHD;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbTenKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lbTongTien;
    }
}