namespace OOAD
{
    partial class BaoGiaTrucTiep
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
            this.MaLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiHang,
            this.TenNhaSanXuat,
            this.MaHangHoa,
            this.MoTa,
            this.Gia,
            this.ThoiGianBaoHanh});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 499);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaLoaiHang
            // 
            this.MaLoaiHang.DataPropertyName = "MaLoaiHang";
            this.MaLoaiHang.HeaderText = "Loại";
            this.MaLoaiHang.MinimumWidth = 6;
            this.MaLoaiHang.Name = "MaLoaiHang";
            this.MaLoaiHang.Width = 125;
            // 
            // TenNhaSanXuat
            // 
            this.TenNhaSanXuat.DataPropertyName = "MaNhaSanXuat";
            this.TenNhaSanXuat.HeaderText = "Hãng";
            this.TenNhaSanXuat.MinimumWidth = 6;
            this.TenNhaSanXuat.Name = "TenNhaSanXuat";
            this.TenNhaSanXuat.Width = 125;
            // 
            // MaHangHoa
            // 
            this.MaHangHoa.DataPropertyName = "MaHangHoa";
            this.MaHangHoa.HeaderText = "Mã thiết bị";
            this.MaHangHoa.MinimumWidth = 6;
            this.MaHangHoa.Name = "MaHangHoa";
            this.MaHangHoa.Width = 125;
            // 
            // MoTa
            // 
            this.MoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả thiết bị";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // ThoiGianBaoHanh
            // 
            this.ThoiGianBaoHanh.DataPropertyName = "ThoiGianBaoHanh";
            this.ThoiGianBaoHanh.HeaderText = "BH";
            this.ThoiGianBaoHanh.MinimumWidth = 6;
            this.ThoiGianBaoHanh.Name = "ThoiGianBaoHanh";
            this.ThoiGianBaoHanh.Width = 125;
            // 
            // BaoGiaTrucTiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 499);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BaoGiaTrucTiep";
            this.Text = "Báo giá trực tiếp";
            this.Load += new System.EventHandler(this.BaoGiaTrucTiep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBaoHanh;
    }
}