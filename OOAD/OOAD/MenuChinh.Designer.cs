namespace OOAD
{
    partial class MenuChinh
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
            this.bt_QLTTDH = new System.Windows.Forms.Button();
            this.bt_KTKNCC = new System.Windows.Forms.Button();
            this.bt_BaoGia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_QLTTDH
            // 
            this.bt_QLTTDH.Location = new System.Drawing.Point(271, 302);
            this.bt_QLTTDH.Name = "bt_QLTTDH";
            this.bt_QLTTDH.Size = new System.Drawing.Size(259, 57);
            this.bt_QLTTDH.TabIndex = 7;
            this.bt_QLTTDH.Text = "Quản lý thông tin đơn hàng";
            this.bt_QLTTDH.UseVisualStyleBackColor = true;
            this.bt_QLTTDH.Click += new System.EventHandler(this.bt_QLTTDH_Click);
            // 
            // bt_KTKNCC
            // 
            this.bt_KTKNCC.Location = new System.Drawing.Point(271, 203);
            this.bt_KTKNCC.Name = "bt_KTKNCC";
            this.bt_KTKNCC.Size = new System.Drawing.Size(259, 57);
            this.bt_KTKNCC.TabIndex = 6;
            this.bt_KTKNCC.Text = "Kiểm tra khả năng cung cấp";
            this.bt_KTKNCC.UseVisualStyleBackColor = true;
            this.bt_KTKNCC.Click += new System.EventHandler(this.bt_KTKNCC_Click);
            // 
            // bt_BaoGia
            // 
            this.bt_BaoGia.Location = new System.Drawing.Point(271, 92);
            this.bt_BaoGia.Name = "bt_BaoGia";
            this.bt_BaoGia.Size = new System.Drawing.Size(259, 57);
            this.bt_BaoGia.TabIndex = 5;
            this.bt_BaoGia.Text = "Báo Giá";
            this.bt_BaoGia.UseVisualStyleBackColor = true;
            // 
            // MenuChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_QLTTDH);
            this.Controls.Add(this.bt_KTKNCC);
            this.Controls.Add(this.bt_BaoGia);
            this.Name = "MenuChinh";
            this.Text = "MenuChinh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_QLTTDH;
        private System.Windows.Forms.Button bt_KTKNCC;
        private System.Windows.Forms.Button bt_BaoGia;
    }
}