namespace OOAD
{
    partial class BaoGia
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
            this.bt_BGTT = new System.Windows.Forms.Button();
            this.bt_BGTYC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_BGTT
            // 
            this.bt_BGTT.Location = new System.Drawing.Point(144, 76);
            this.bt_BGTT.Name = "bt_BGTT";
            this.bt_BGTT.Size = new System.Drawing.Size(259, 57);
            this.bt_BGTT.TabIndex = 0;
            this.bt_BGTT.Text = "Báo giá tất cả các sản phẩm";
            this.bt_BGTT.UseVisualStyleBackColor = true;
            this.bt_BGTT.Click += new System.EventHandler(this.bt_BGTT_Click);
            // 
            // bt_BGTYC
            // 
            this.bt_BGTYC.Location = new System.Drawing.Point(144, 187);
            this.bt_BGTYC.Name = "bt_BGTYC";
            this.bt_BGTYC.Size = new System.Drawing.Size(259, 57);
            this.bt_BGTYC.TabIndex = 1;
            this.bt_BGTYC.Text = "Báo giá theo yêu cầu";
            this.bt_BGTYC.UseVisualStyleBackColor = true;
            this.bt_BGTYC.Click += new System.EventHandler(this.bt_BGTYC_Click);
            // 
            // BaoGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 321);
            this.Controls.Add(this.bt_BGTYC);
            this.Controls.Add(this.bt_BGTT);
            this.Name = "BaoGia";
            this.Text = "Báo giá";
            this.Load += new System.EventHandler(this.BaoGia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_BGTT;
        private System.Windows.Forms.Button bt_BGTYC;
    }
}

