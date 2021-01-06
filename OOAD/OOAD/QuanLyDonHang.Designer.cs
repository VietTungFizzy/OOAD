namespace OOAD
{
    partial class QuanLyDonHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sua_btn = new System.Windows.Forms.Button();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.them_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongtinlienhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Tenkhachhang,
            this.thongtinlienhe,
            this.loaiii,
            this.MaDonHang});
            this.dataGridView1.Location = new System.Drawing.Point(290, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(720, 372);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Loại đơn hàng",
            "  Trực tiếp",
            "  Hợp đồng",
            "\t"});
            this.listBox1.Location = new System.Drawing.Point(49, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 372);
            this.listBox1.TabIndex = 8;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // sua_btn
            // 
            this.sua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_btn.Location = new System.Drawing.Point(604, 42);
            this.sua_btn.Name = "sua_btn";
            this.sua_btn.Size = new System.Drawing.Size(110, 53);
            this.sua_btn.TabIndex = 7;
            this.sua_btn.Text = "Sửa";
            this.sua_btn.UseVisualStyleBackColor = true;
            this.sua_btn.Click += new System.EventHandler(this.sua_btn_Click);
            // 
            // xoa_btn
            // 
            this.xoa_btn.Enabled = false;
            this.xoa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_btn.Location = new System.Drawing.Point(447, 41);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(110, 53);
            this.xoa_btn.TabIndex = 6;
            this.xoa_btn.Text = "Xóa";
            this.xoa_btn.UseVisualStyleBackColor = true;
            this.xoa_btn.Click += new System.EventHandler(this.xoa_btn_Click);
            // 
            // them_btn
            // 
            this.them_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_btn.Location = new System.Drawing.Point(75, 42);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(146, 50);
            this.them_btn.TabIndex = 5;
            this.them_btn.Text = "Thêm(TT)";
            this.them_btn.UseVisualStyleBackColor = true;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(276, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thêm(HD)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Tenkhachhang
            // 
            this.Tenkhachhang.DataPropertyName = "TENKHACHHANG";
            this.Tenkhachhang.HeaderText = "Tên khách hàng";
            this.Tenkhachhang.MinimumWidth = 6;
            this.Tenkhachhang.Name = "Tenkhachhang";
            this.Tenkhachhang.Width = 125;
            // 
            // thongtinlienhe
            // 
            this.thongtinlienhe.DataPropertyName = "THONGTINLIENHE";
            this.thongtinlienhe.HeaderText = "Thông tin liên hệ";
            this.thongtinlienhe.MinimumWidth = 6;
            this.thongtinlienhe.Name = "thongtinlienhe";
            this.thongtinlienhe.Width = 125;
            // 
            // loaiii
            // 
            this.loaiii.DataPropertyName = "LOAI";
            this.loaiii.HeaderText = "Loại";
            this.loaiii.MinimumWidth = 6;
            this.loaiii.Name = "loaiii";
            this.loaiii.Width = 125;
            // 
            // MaDonHang
            // 
            this.MaDonHang.DataPropertyName = "MADDONHANG";
            this.MaDonHang.HeaderText = "Mã Đơn Hàng";
            this.MaDonHang.MinimumWidth = 6;
            this.MaDonHang.Name = "MaDonHang";
            this.MaDonHang.Width = 125;
            // 
            // QuanLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sua_btn);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.them_btn);
            this.Name = "QuanLyDonHang";
            this.Text = "QuanLyDonHang";
            this.Load += new System.EventHandler(this.QuanLyDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sua_btn;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn thongtinlienhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiii;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonHang;
    }
}