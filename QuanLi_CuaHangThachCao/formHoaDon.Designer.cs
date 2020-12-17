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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DateTimePicker dateTimePicker1;
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.btthoat = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.thsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dbCuaHangThachCaoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbxTenHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listSanPham = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dbCuaHangThachCaoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new System.Drawing.Point(125, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(178, 20);
            dateTimePicker1.TabIndex = 44;
            dateTimePicker1.Value = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(707, 368);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(80, 28);
            this.btthoat.TabIndex = 38;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(707, 416);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(80, 28);
            this.Reload.TabIndex = 32;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(707, 318);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(80, 28);
            this.btxoa.TabIndex = 31;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // thsua
            // 
            this.thsua.Location = new System.Drawing.Point(707, 268);
            this.thsua.Name = "thsua";
            this.thsua.Size = new System.Drawing.Size(80, 28);
            this.thsua.TabIndex = 30;
            this.thsua.Text = "Sửa";
            this.thsua.UseVisualStyleBackColor = true;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(371, 102);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 28);
            this.btthem.TabIndex = 29;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hóa Đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hDBanBindingSource
            // 
            this.hDBanBindingSource.DataMember = "HDBan";
            this.hDBanBindingSource.DataSource = this.dbCuaHangThachCaoDataSetBindingSource;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tên Hàng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(125, 151);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(178, 20);
            this.txtSoLuong.TabIndex = 41;
            // 
            // cbxTenHang
            // 
            this.cbxTenHang.FormattingEnabled = true;
            this.cbxTenHang.Location = new System.Drawing.Point(125, 114);
            this.cbxTenHang.Name = "cbxTenHang";
            this.cbxTenHang.Size = new System.Drawing.Size(178, 21);
            this.cbxTenHang.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Số Lượng";
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // listSanPham
            // 
            this.listSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listSanPham.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listSanPham.Location = new System.Drawing.Point(50, 216);
            this.listSanPham.Name = "listSanPham";
            this.listSanPham.Size = new System.Drawing.Size(616, 285);
            this.listSanPham.TabIndex = 43;
            this.listSanPham.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ngày Mua";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // formHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 567);
            this.Controls.Add(dateTimePicker1);
            this.Controls.Add(this.listSanPham);
            this.Controls.Add(this.cbxTenHang);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.thsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.label1);
            this.Name = "formHoaDon";
            this.Text = "formHoaDon";
            this.Load += new System.EventHandler(this.formHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbCuaHangThachCaoDataSetBindingSource)).EndInit();          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button thsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dbCuaHangThachCaoDataSetBindingSource;
        
        private System.Windows.Forms.BindingSource hDBanBindingSource;
        
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbxTenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}