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
            this.LoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotaTb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiHang,
            this.Matb,
            this.MotaTb,
            this.Gia,
            this.BH});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 499);
            this.dataGridView1.TabIndex = 0;
            // 
            // LoaiHang
            // 
            this.LoaiHang.HeaderText = "Loại/Hãng";
            this.LoaiHang.MinimumWidth = 6;
            this.LoaiHang.Name = "LoaiHang";
            this.LoaiHang.Width = 175;
            // 
            // Matb
            // 
            this.Matb.HeaderText = "Mã thiết bị";
            this.Matb.MinimumWidth = 6;
            this.Matb.Name = "Matb";
            this.Matb.Width = 125;
            // 
            // MotaTb
            // 
            this.MotaTb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MotaTb.HeaderText = "Mô tả thiết bị";
            this.MotaTb.MinimumWidth = 6;
            this.MotaTb.Name = "MotaTb";
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // BH
            // 
            this.BH.HeaderText = "BH";
            this.BH.MinimumWidth = 6;
            this.BH.Name = "BH";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matb;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotaTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn BH;
    }
}