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
            this.rbtenkh = new System.Windows.Forms.RadioButton();
            this.rbmakh = new System.Windows.Forms.RadioButton();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.dgvGhiNo = new System.Windows.Forms.DataGridView();
            this.ghiNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCuaHang_ThachCaoDataSet = new QuanLi_CuaHangThachCao.dbCuaHang_ThachCaoDataSet1();
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTenKhach = new System.Windows.Forms.ComboBox();
            this.cbxMaHD = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbdienthoai = new System.Windows.Forms.TextBox();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ghiNoTableAdapter = new QuanLi_CuaHangThachCao.dbCuaHang_ThachCaoDataSet1TableAdapters.GhiNoTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCuaHang_ThachCaoDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtenkh);
            this.groupBox2.Controls.Add(this.rbmakh);
            this.groupBox2.Controls.Add(this.tbtimkiem);
            this.groupBox2.Controls.Add(this.bttimkiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(77, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 45);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // rbtenkh
            // 
            this.rbtenkh.AutoSize = true;
            this.rbtenkh.Location = new System.Drawing.Point(485, 18);
            this.rbtenkh.Name = "rbtenkh";
            this.rbtenkh.Size = new System.Drawing.Size(64, 17);
            this.rbtenkh.TabIndex = 10;
            this.rbtenkh.Text = "Mã HD";
            this.rbtenkh.UseVisualStyleBackColor = true;
            // 
            // rbmakh
            // 
            this.rbmakh.AutoSize = true;
            this.rbmakh.Checked = true;
            this.rbmakh.Location = new System.Drawing.Point(398, 18);
            this.rbmakh.Name = "rbmakh";
            this.rbmakh.Size = new System.Drawing.Size(87, 17);
            this.rbmakh.TabIndex = 9;
            this.rbmakh.TabStop = true;
            this.rbmakh.Text = "Tên Khách";
            this.rbmakh.UseVisualStyleBackColor = true;
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Location = new System.Drawing.Point(87, 18);
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(272, 20);
            this.tbtimkiem.TabIndex = 8;
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(6, 16);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(75, 23);
            this.bttimkiem.TabIndex = 11;
            this.bttimkiem.Text = "Tìm Kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            // 
            // dgvGhiNo
            // 
            this.dgvGhiNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGhiNo.Location = new System.Drawing.Point(12, 345);
            this.dgvGhiNo.Name = "dgvGhiNo";
            this.dgvGhiNo.Size = new System.Drawing.Size(720, 150);
            this.dgvGhiNo.TabIndex = 31;
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
            this.btthoat.Location = new System.Drawing.Point(572, 145);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(80, 28);
            this.btthoat.TabIndex = 30;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(572, 101);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(80, 28);
            this.btxoa.TabIndex = 28;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(572, 55);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(80, 28);
            this.btsua.TabIndex = 27;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(572, 15);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 28);
            this.btthem.TabIndex = 25;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxTenKhach);
            this.groupBox1.Controls.Add(this.cbxMaHD);
            this.groupBox1.Controls.Add(this.btthoat);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btsua);
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbdienthoai);
            this.groupBox1.Controls.Add(this.tbdiachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 194);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Ghi Nợ";
            // 
            // cbxTenKhach
            // 
            this.cbxTenKhach.FormattingEnabled = true;
            this.cbxTenKhach.Location = new System.Drawing.Point(158, 53);
            this.cbxTenKhach.Name = "cbxTenKhach";
            this.cbxTenKhach.Size = new System.Drawing.Size(346, 21);
            this.cbxTenKhach.TabIndex = 10;
            // 
            // cbxMaHD
            // 
            this.cbxMaHD.FormattingEnabled = true;
            this.cbxMaHD.Location = new System.Drawing.Point(158, 25);
            this.cbxMaHD.Name = "cbxMaHD";
            this.cbxMaHD.Size = new System.Drawing.Size(346, 21);
            this.cbxMaHD.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tiền Còn Lại";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(346, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 25, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Trả";
            // 
            // tbdienthoai
            // 
            this.tbdienthoai.Location = new System.Drawing.Point(158, 106);
            this.tbdienthoai.Name = "tbdienthoai";
            this.tbdienthoai.Size = new System.Drawing.Size(346, 20);
            this.tbdienthoai.TabIndex = 4;
            // 
            // tbdiachi
            // 
            this.tbdiachi.Location = new System.Drawing.Point(158, 80);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(346, 20);
            this.tbdiachi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã NV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tiền Đã Trả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ghi Nợ";
            // 
            // ghiNoTableAdapter
            // 
            this.ghiNoTableAdapter.ClearBeforeFill = true;
            // 
            // formGhiNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 536);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtenkh;
        private System.Windows.Forms.RadioButton rbmakh;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.DataGridView dgvGhiNo;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbdienthoai;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private dbCuaHang_ThachCaoDataSet1 dbCuaHang_ThachCaoDataSet;
        private System.Windows.Forms.BindingSource ghiNoBindingSource;
        private dbCuaHang_ThachCaoDataSet1TableAdapters.GhiNoTableAdapter ghiNoTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxMaHD;
        private System.Windows.Forms.ComboBox cbxTenKhach;
    }
}