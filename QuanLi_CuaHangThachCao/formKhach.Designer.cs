namespace QuanLi_CuaHangThachCao
{
    partial class formKhach
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtenkh = new System.Windows.Forms.RadioButton();
            this.rbmakh = new System.Windows.Forms.RadioButton();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbmakh = new System.Windows.Forms.TextBox();
            this.tbtenkh = new System.Windows.Forms.TextBox();
            this.tbdienthoai = new System.Windows.Forms.TextBox();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.khachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.khachBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbCuaHang_ThachCaoDataSet1 = new QuanLi_CuaHangThachCao.dbCuaHang_ThachCaoDataSet1();
            this.ghiNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangTableAdapter = new QuanLi_CuaHangThachCao.dbCuaHang_ThachCaoDataSet1TableAdapters.HangTableAdapter();
            this.khachTableAdapter = new QuanLi_CuaHangThachCao.dbCuaHang_ThachCaoDataSet1TableAdapters.KhachTableAdapter();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCuaHang_ThachCaoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiNoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rbtenkh);
            this.groupBox2.Controls.Add(this.rbmakh);
            this.groupBox2.Controls.Add(this.tbtimkiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 45);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tìm Kiếm";
            // 
            // rbtenkh
            // 
            this.rbtenkh.AutoSize = true;
            this.rbtenkh.Location = new System.Drawing.Point(431, 17);
            this.rbtenkh.Name = "rbtenkh";
            this.rbtenkh.Size = new System.Drawing.Size(68, 17);
            this.rbtenkh.TabIndex = 10;
            this.rbtenkh.Text = "Tên KH";
            this.rbtenkh.UseVisualStyleBackColor = true;
            // 
            // rbmakh
            // 
            this.rbmakh.AutoSize = true;
            this.rbmakh.Checked = true;
            this.rbmakh.Location = new System.Drawing.Point(350, 16);
            this.rbmakh.Name = "rbmakh";
            this.rbmakh.Size = new System.Drawing.Size(63, 17);
            this.rbmakh.TabIndex = 9;
            this.rbmakh.TabStop = true;
            this.rbmakh.Text = "Mã KH";
            this.rbmakh.UseVisualStyleBackColor = true;
            this.rbmakh.CheckedChanged += new System.EventHandler(this.rbmakh_CheckedChanged);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Location = new System.Drawing.Point(93, 17);
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(239, 20);
            this.tbtimkiem.TabIndex = 8;
            this.tbtimkiem.TextChanged += new System.EventHandler(this.tbtimkiem_TextChanged);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(602, 227);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(80, 28);
            this.btthoat.TabIndex = 21;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(602, 143);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(80, 28);
            this.btxoa.TabIndex = 19;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(602, 99);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(80, 28);
            this.btsua.TabIndex = 18;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(602, 54);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 28);
            this.btthem.TabIndex = 16;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbmakh);
            this.groupBox1.Controls.Add(this.tbtenkh);
            this.groupBox1.Controls.Add(this.tbdienthoai);
            this.groupBox1.Controls.Add(this.tbdiachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 142);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // tbmakh
            // 
            this.tbmakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmakh.Location = new System.Drawing.Point(94, 25);
            this.tbmakh.Name = "tbmakh";
            this.tbmakh.Size = new System.Drawing.Size(406, 20);
            this.tbmakh.TabIndex = 1;
            // 
            // tbtenkh
            // 
            this.tbtenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtenkh.Location = new System.Drawing.Point(94, 52);
            this.tbtenkh.Name = "tbtenkh";
            this.tbtenkh.Size = new System.Drawing.Size(406, 20);
            this.tbtenkh.TabIndex = 2;
            // 
            // tbdienthoai
            // 
            this.tbdienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdienthoai.Location = new System.Drawing.Point(94, 106);
            this.tbdienthoai.Name = "tbdienthoai";
            this.tbdienthoai.Size = new System.Drawing.Size(406, 20);
            this.tbdienthoai.TabIndex = 4;
            // 
            // tbdiachi
            // 
            this.tbdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdiachi.Location = new System.Drawing.Point(94, 80);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(406, 20);
            this.tbdiachi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(238, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Khách Hàng";
            // 
            // khachBindingSource
            // 
            this.khachBindingSource.DataMember = "Khach";
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Location = new System.Drawing.Point(38, 277);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.ReadOnly = true;
            this.dgvkhachhang.Size = new System.Drawing.Size(644, 175);
            this.dgvkhachhang.TabIndex = 22;
            this.dgvkhachhang.SelectionChanged += new System.EventHandler(this.dgvkhachhang_SelectionChanged);
            // 
            // khachBindingSource1
            // 
            this.khachBindingSource1.DataMember = "Khach";
            this.khachBindingSource1.DataSource = this.dbCuaHang_ThachCaoDataSet1;
            // 
            // dbCuaHang_ThachCaoDataSet1
            // 
            this.dbCuaHang_ThachCaoDataSet1.DataSetName = "dbCuaHang_ThachCaoDataSet1";
            this.dbCuaHang_ThachCaoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ghiNoBindingSource
            // 
            this.ghiNoBindingSource.DataMember = "GhiNo";
            // 
            // hangTableAdapter
            // 
            this.hangTableAdapter.ClearBeforeFill = true;
            // 
            // khachTableAdapter
            // 
            this.khachTableAdapter.ClearBeforeFill = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(602, 186);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 28);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // formKhach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(723, 530);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvkhachhang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "formKhach";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCuaHang_ThachCaoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiNoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtenkh;
        private System.Windows.Forms.RadioButton rbmakh;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbmakh;
        private System.Windows.Forms.TextBox tbtenkh;
        private System.Windows.Forms.TextBox tbdienthoai;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        
        private System.Windows.Forms.BindingSource khachBindingSource;
        
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhach;
        private System.Windows.Forms.BindingSource ghiNoBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private dbCuaHang_ThachCaoDataSet1 dbCuaHang_ThachCaoDataSet1;
        private dbCuaHang_ThachCaoDataSet1TableAdapters.HangTableAdapter hangTableAdapter;
        private System.Windows.Forms.BindingSource khachBindingSource1;
        private dbCuaHang_ThachCaoDataSet1TableAdapters.KhachTableAdapter khachTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
    }
}