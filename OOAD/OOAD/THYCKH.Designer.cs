namespace OOAD
{
    partial class THYCKH
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenCoQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVienGhiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVienThucHien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(164, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(293, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "Đang xử lý",
            "Không thể xử lý",
            "Xử lý thành công",
            ""});
            this.listBox1.Location = new System.Drawing.Point(12, 158);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 304);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenCoQuan,
            this.HoVaTen,
            this.MaNhanVienGhiNhan,
            this.MaNhanVienThucHien,
            this.KetQua});
            this.dataGridView1.Location = new System.Drawing.Point(248, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(635, 372);
            this.dataGridView1.TabIndex = 4;
            // 
            // TenCoQuan
            // 
            this.TenCoQuan.DataPropertyName = "TenCoQuan";
            this.TenCoQuan.HeaderText = "Cơ quan";
            this.TenCoQuan.MinimumWidth = 6;
            this.TenCoQuan.Name = "TenCoQuan";
            this.TenCoQuan.Width = 125;
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "HoVaTen";
            this.HoVaTen.HeaderText = "Người liên hệ";
            this.HoVaTen.MinimumWidth = 6;
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.Width = 125;
            // 
            // MaNhanVienGhiNhan
            // 
            this.MaNhanVienGhiNhan.DataPropertyName = "MaNhanVienGhiNhan";
            this.MaNhanVienGhiNhan.HeaderText = "Nhân viên ghi nhận";
            this.MaNhanVienGhiNhan.MinimumWidth = 6;
            this.MaNhanVienGhiNhan.Name = "MaNhanVienGhiNhan";
            this.MaNhanVienGhiNhan.Width = 125;
            // 
            // MaNhanVienThucHien
            // 
            this.MaNhanVienThucHien.DataPropertyName = "MaNhanVienThucHien";
            this.MaNhanVienThucHien.HeaderText = "Nhân viên thực hiện";
            this.MaNhanVienThucHien.MinimumWidth = 6;
            this.MaNhanVienThucHien.Name = "MaNhanVienThucHien";
            this.MaNhanVienThucHien.Width = 125;
            // 
            // KetQua
            // 
            this.KetQua.DataPropertyName = "KetQua";
            this.KetQua.HeaderText = "Tình Trạng";
            this.KetQua.MinimumWidth = 6;
            this.KetQua.Name = "KetQua";
            this.KetQua.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tình trạng";
            // 
            // THYCKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "THYCKH";
            this.Text = "THYCKH";
            this.Load += new System.EventHandler(this.THYCKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCoQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVienGhiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVienThucHien;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetQua;
    }
}