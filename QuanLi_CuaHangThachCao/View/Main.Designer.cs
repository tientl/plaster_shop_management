namespace QuanLi_CuaHangThachCao
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnGhiNo = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaiKhoan);
            this.groupBox1.Controls.Add(this.btnKho);
            this.groupBox1.Controls.Add(this.btnGhiNo);
            this.groupBox1.Controls.Add(this.btnNhanVien);
            this.groupBox1.Controls.Add(this.btnHangHoa);
            this.groupBox1.Controls.Add(this.btnHoaDon);
            this.groupBox1.Controls.Add(this.button1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnTaiKhoan
            // 
            resources.ApplyResources(this.btnTaiKhoan, "btnTaiKhoan");
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnKho
            // 
            resources.ApplyResources(this.btnKho, "btnKho");
            this.btnKho.Name = "btnKho";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnGhiNo
            // 
            resources.ApplyResources(this.btnGhiNo, "btnGhiNo");
            this.btnGhiNo.Name = "btnGhiNo";
            this.btnGhiNo.UseVisualStyleBackColor = true;
            this.btnGhiNo.Click += new System.EventHandler(this.btnGhiNo_Click);
            // 
            // btnNhanVien
            // 
            resources.ApplyResources(this.btnNhanVien, "btnNhanVien");
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnHangHoa
            // 
            resources.ApplyResources(this.btnHangHoa, "btnHangHoa");
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.UseVisualStyleBackColor = true;
            this.btnHangHoa.Click += new System.EventHandler(this.btnChiTietHD_Click);
            // 
            // btnHoaDon
            // 
            resources.ApplyResources(this.btnHoaDon, "btnHoaDon");
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnKhach_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnGhiNo;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button button1;
    }
}

