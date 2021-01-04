namespace QuanLi_CuaHangThachCao
{
    partial class formGhiNo
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbMaHD = new System.Windows.Forms.RadioButton();
            this.rbTenKhach = new System.Windows.Forms.RadioButton();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.dgvGhiNo = new System.Windows.Forms.DataGridView();
            this.ghiNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCuaHang_ThachCaoDataSet = new QuanLi_CuaHangThachCao.dbCuaHang_ThachCaoDataSet1();
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxTenKhach = new System.Windows.Forms.ComboBox();
            this.cbxMaHD = new System.Windows.Forms.ComboBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ghiNoTableAdapter = new QuanLi_CuaHangThachCao.dbCuaHang_ThachCaoDataSet1TableAdapters.GhiNoTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbTienTra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btXoaTT = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btSuaTT = new System.Windows.Forms.Button();
            this.btThemTT = new System.Windows.Forms.Button();
            this.dateNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTienDaTra = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvCTGhiNo = new System.Windows.Forms.DataGridView();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCuaHang_ThachCaoDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTGhiNo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rbMaHD);
            this.groupBox2.Controls.Add(this.rbTenKhach);
            this.groupBox2.Controls.Add(this.tbtimkiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 45);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tìm Kiếm";
            // 
            // rbMaHD
            // 
            this.rbMaHD.AutoSize = true;
            this.rbMaHD.Location = new System.Drawing.Point(693, 21);
            this.rbMaHD.Name = "rbMaHD";
            this.rbMaHD.Size = new System.Drawing.Size(64, 17);
            this.rbMaHD.TabIndex = 10;
            this.rbMaHD.Text = "Mã HD";
            this.rbMaHD.UseVisualStyleBackColor = true;
            // 
            // rbTenKhach
            // 
            this.rbTenKhach.AutoSize = true;
            this.rbTenKhach.Checked = true;
            this.rbTenKhach.Location = new System.Drawing.Point(579, 22);
            this.rbTenKhach.Name = "rbTenKhach";
            this.rbTenKhach.Size = new System.Drawing.Size(87, 17);
            this.rbTenKhach.TabIndex = 9;
            this.rbTenKhach.TabStop = true;
            this.rbTenKhach.Text = "Tên Khách";
            this.rbTenKhach.UseVisualStyleBackColor = true;
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Location = new System.Drawing.Point(152, 16);
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(390, 20);
            this.tbtimkiem.TabIndex = 8;
            this.tbtimkiem.TextChanged += new System.EventHandler(this.tbtimkiem_TextChanged);
            // 
            // dgvGhiNo
            // 
            this.dgvGhiNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGhiNo.Location = new System.Drawing.Point(39, 349);
            this.dgvGhiNo.Name = "dgvGhiNo";
            this.dgvGhiNo.Size = new System.Drawing.Size(482, 184);
            this.dgvGhiNo.TabIndex = 31;
            this.dgvGhiNo.SelectionChanged += new System.EventHandler(this.dgvGhiNo_SelectionChanged);
            // 
            // ghiNoBindingSource
            // 
            this.ghiNoBindingSource.DataMember = "GhiNo";
            this.ghiNoBindingSource.DataSource = this.dbCuaHang_ThachCaoDataSet;
            // 
            // dbCuaHang_ThachCaoDataSet
            // 
            this.dbCuaHang_ThachCaoDataSet.DataSetName = "dbCuaHang_ThachCaoDataSet";
            this.dbCuaHang_ThachCaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(330, 168);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(80, 28);
            this.btthoat.TabIndex = 30;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(233, 169);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(80, 28);
            this.btxoa.TabIndex = 28;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Location = new System.Drawing.Point(128, 169);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(80, 28);
            this.btsua.TabIndex = 27;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(42, 169);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 28);
            this.btthem.TabIndex = 25;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTongTien);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbxTenKhach);
            this.groupBox1.Controls.Add(this.cbxMaHD);
            this.groupBox1.Controls.Add(this.btthoat);
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.btsua);
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.tbMaNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 227);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Ghi Nợ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(109, 119);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(301, 20);
            this.tbTongTien.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Tổng Tiền";
            // 
            // cbxTenKhach
            // 
            this.cbxTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenKhach.FormattingEnabled = true;
            this.cbxTenKhach.Location = new System.Drawing.Point(109, 60);
            this.cbxTenKhach.Name = "cbxTenKhach";
            this.cbxTenKhach.Size = new System.Drawing.Size(301, 21);
            this.cbxTenKhach.TabIndex = 10;
            // 
            // cbxMaHD
            // 
            this.cbxMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaHD.FormattingEnabled = true;
            this.cbxMaHD.Location = new System.Drawing.Point(109, 32);
            this.cbxMaHD.Name = "cbxMaHD";
            this.cbxMaHD.Size = new System.Drawing.Size(301, 21);
            this.cbxMaHD.TabIndex = 9;
            this.cbxMaHD.SelectedIndexChanged += new System.EventHandler(this.cbxMaHD_SelectedIndexChanged);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(370, 164);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(80, 28);
            this.btLuu.TabIndex = 30;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // tbMaNV
            // 
            this.tbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNV.Location = new System.Drawing.Point(109, 87);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(301, 20);
            this.tbMaNV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã NV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(469, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ghi Nợ";
            // 
            // ghiNoTableAdapter
            // 
            this.ghiNoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTongTien);
            this.groupBox3.Controls.Add(this.tbTienTra);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btXoaTT);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btLuu);
            this.groupBox3.Controls.Add(this.btSuaTT);
            this.groupBox3.Controls.Add(this.btThemTT);
            this.groupBox3.Controls.Add(this.dateNgayTra);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbTienDaTra);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(521, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 227);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // tbTienTra
            // 
            this.tbTienTra.Location = new System.Drawing.Point(121, 39);
            this.tbTienTra.Name = "tbTienTra";
            this.tbTienTra.Size = new System.Drawing.Size(209, 20);
            this.tbTienTra.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Đã Trả";
            // 
            // btXoaTT
            // 
            this.btXoaTT.Location = new System.Drawing.Point(357, 97);
            this.btXoaTT.Name = "btXoaTT";
            this.btXoaTT.Size = new System.Drawing.Size(93, 21);
            this.btXoaTT.TabIndex = 55;
            this.btXoaTT.Text = "Xóa";
            this.btXoaTT.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 21);
            this.label11.TabIndex = 51;
            this.label11.Text = "Tiền Còn Lại:";
            // 
            // btSuaTT
            // 
            this.btSuaTT.Location = new System.Drawing.Point(357, 70);
            this.btSuaTT.Name = "btSuaTT";
            this.btSuaTT.Size = new System.Drawing.Size(93, 21);
            this.btSuaTT.TabIndex = 54;
            this.btSuaTT.Text = "Sửa";
            this.btSuaTT.UseVisualStyleBackColor = true;
            // 
            // btThemTT
            // 
            this.btThemTT.Location = new System.Drawing.Point(357, 38);
            this.btThemTT.Name = "btThemTT";
            this.btThemTT.Size = new System.Drawing.Size(93, 21);
            this.btThemTT.TabIndex = 53;
            this.btThemTT.Text = "Thanh Toán";
            this.btThemTT.UseVisualStyleBackColor = true;
            this.btThemTT.Click += new System.EventHandler(this.btThemTT_Click);
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTra.Location = new System.Drawing.Point(121, 100);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(209, 20);
            this.dateNgayTra.TabIndex = 50;
            this.dateNgayTra.Value = new System.DateTime(2020, 11, 25, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Ngày Trả";
            // 
            // tbTienDaTra
            // 
            this.tbTienDaTra.Location = new System.Drawing.Point(121, 72);
            this.tbTienDaTra.Name = "tbTienDaTra";
            this.tbTienDaTra.ReadOnly = true;
            this.tbTienDaTra.Size = new System.Drawing.Size(209, 20);
            this.tbTienDaTra.TabIndex = 48;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(56, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Tiền Trả";
            // 
            // dgvCTGhiNo
            // 
            this.dgvCTGhiNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTGhiNo.Location = new System.Drawing.Point(523, 349);
            this.dgvCTGhiNo.Name = "dgvCTGhiNo";
            this.dgvCTGhiNo.Size = new System.Drawing.Size(460, 184);
            this.dgvCTGhiNo.TabIndex = 33;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTongTien.Location = new System.Drawing.Point(171, 170);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(19, 21);
            this.lbTongTien.TabIndex = 59;
            this.lbTongTien.Text = "0";
            // 
            // formGhiNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 565);
            this.Controls.Add(this.dgvCTGhiNo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvGhiNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "formGhiNo";
            this.Text = "formGhiNo";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCuaHang_ThachCaoDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTGhiNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMaHD;
        private System.Windows.Forms.RadioButton rbTenKhach;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.DataGridView dgvGhiNo;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private dbCuaHang_ThachCaoDataSet1 dbCuaHang_ThachCaoDataSet;
        private System.Windows.Forms.BindingSource ghiNoBindingSource;
        private dbCuaHang_ThachCaoDataSet1TableAdapters.GhiNoTableAdapter ghiNoTableAdapter;
        private System.Windows.Forms.ComboBox cbxMaHD;
        private System.Windows.Forms.ComboBox cbxTenKhach;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbTienTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btXoaTT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btSuaTT;
        private System.Windows.Forms.Button btThemTT;
        private System.Windows.Forms.DateTimePicker dateNgayTra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTienDaTra;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvCTGhiNo;
        private System.Windows.Forms.Label lbTongTien;
    }
}