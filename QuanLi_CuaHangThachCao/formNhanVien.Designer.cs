namespace QuanLi_CuaHangThachCao
{
    partial class formNhanVien
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btluu = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbmakh = new System.Windows.Forms.TextBox();
            this.tbtenkh = new System.Windows.Forms.TextBox();
            this.tbdienthoai = new System.Windows.Forms.TextBox();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(71, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 45);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // rbtenkh
            // 
            this.rbtenkh.AutoSize = true;
            this.rbtenkh.Location = new System.Drawing.Point(485, 18);
            this.rbtenkh.Name = "rbtenkh";
            this.rbtenkh.Size = new System.Drawing.Size(68, 17);
            this.rbtenkh.TabIndex = 10;
            this.rbtenkh.Text = "Tên NV";
            this.rbtenkh.UseVisualStyleBackColor = true;
            // 
            // rbmakh
            // 
            this.rbmakh.AutoSize = true;
            this.rbmakh.Checked = true;
            this.rbmakh.Location = new System.Drawing.Point(398, 18);
            this.rbmakh.Name = "rbmakh";
            this.rbmakh.Size = new System.Drawing.Size(63, 17);
            this.rbmakh.TabIndex = 9;
            this.rbmakh.TabStop = true;
            this.rbmakh.Text = "Mã NV";
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
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.DataSource = this.nhanVienBindingSource;
            this.dgvNhanVien.Location = new System.Drawing.Point(71, 331);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(647, 150);
            this.dgvNhanVien.TabIndex = 22;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhachhang_CellContentClick);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(638, 115);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(80, 28);
            this.btluu.TabIndex = 17;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(539, 163);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(80, 28);
            this.btthoat.TabIndex = 21;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(539, 120);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(80, 28);
            this.btxoa.TabIndex = 19;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(638, 79);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(80, 28);
            this.btsua.TabIndex = 18;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(539, 79);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 28);
            this.btthem.TabIndex = 16;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbmakh);
            this.groupBox1.Controls.Add(this.tbtenkh);
            this.groupBox1.Controls.Add(this.tbdienthoai);
            this.groupBox1.Controls.Add(this.tbdiachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 172);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 25, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Sinh";
            // 
            // tbmakh
            // 
            this.tbmakh.Location = new System.Drawing.Point(94, 25);
            this.tbmakh.Name = "tbmakh";
            this.tbmakh.Size = new System.Drawing.Size(265, 20);
            this.tbmakh.TabIndex = 1;
            // 
            // tbtenkh
            // 
            this.tbtenkh.Location = new System.Drawing.Point(94, 52);
            this.tbtenkh.Name = "tbtenkh";
            this.tbtenkh.Size = new System.Drawing.Size(265, 20);
            this.tbtenkh.TabIndex = 2;
            // 
            // tbdienthoai
            // 
            this.tbdienthoai.Location = new System.Drawing.Point(94, 106);
            this.tbdienthoai.Name = "tbdienthoai";
            this.tbdienthoai.Size = new System.Drawing.Size(265, 20);
            this.tbdienthoai.TabIndex = 4;
            // 
            // tbdiachi
            // 
            this.tbdiachi.Location = new System.Drawing.Point(94, 80);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(265, 20);
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
            this.label4.Text = "Tên NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NV";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhân Viên";
            // 
            // formNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "formNhanVien";
            this.Text = "formNhanVien";
            this.Load += new System.EventHandler(this.formNhanVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btluu;
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
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
    }
}