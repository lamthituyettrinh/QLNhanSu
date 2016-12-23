namespace management
{
    partial class BangCong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaCong = new System.Windows.Forms.TextBox();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dgvBangCong = new System.Windows.Forms.DataGridView();
            this.cbbMaLuong = new System.Windows.Forms.ComboBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.btTongCong = new System.Windows.Forms.Button();
            this.lbTongCong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangCong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Công :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số ngày :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = " Mã Lương :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaCong
            // 
            this.txtMaCong.Location = new System.Drawing.Point(125, 25);
            this.txtMaCong.Name = "txtMaCong";
            this.txtMaCong.Size = new System.Drawing.Size(144, 20);
            this.txtMaCong.TabIndex = 4;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(125, 77);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(144, 20);
            this.txtSoNgay.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(396, 25);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(144, 20);
            this.txtSoLuong.TabIndex = 6;
            // 
            // dgvBangCong
            // 
            this.dgvBangCong.BackgroundColor = System.Drawing.Color.Cyan;
            this.dgvBangCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangCong.Location = new System.Drawing.Point(0, 163);
            this.dgvBangCong.Name = "dgvBangCong";
            this.dgvBangCong.Size = new System.Drawing.Size(552, 135);
            this.dgvBangCong.TabIndex = 8;
            this.dgvBangCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangCong_CellClick);
            // 
            // cbbMaLuong
            // 
            this.cbbMaLuong.FormattingEnabled = true;
            this.cbbMaLuong.Location = new System.Drawing.Point(396, 80);
            this.cbbMaLuong.Name = "cbbMaLuong";
            this.cbbMaLuong.Size = new System.Drawing.Size(143, 21);
            this.cbbMaLuong.TabIndex = 11;
            // 
            // btLuu
            // 
            this.btLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(51, 304);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(83, 46);
            this.btLuu.TabIndex = 12;
            this.btLuu.Text = "LƯU";
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Location = new System.Drawing.Point(230, 303);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(83, 46);
            this.btHuy.TabIndex = 13;
            this.btHuy.Text = "HỦY";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btDong
            // 
            this.btDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDong.Location = new System.Drawing.Point(406, 304);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(83, 46);
            this.btDong.TabIndex = 15;
            this.btDong.Text = "ĐÓNG";
            this.btDong.UseVisualStyleBackColor = false;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btTongCong
            // 
            this.btTongCong.BackColor = System.Drawing.Color.Aqua;
            this.btTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTongCong.ForeColor = System.Drawing.Color.Black;
            this.btTongCong.Location = new System.Drawing.Point(138, 112);
            this.btTongCong.Name = "btTongCong";
            this.btTongCong.Size = new System.Drawing.Size(131, 34);
            this.btTongCong.TabIndex = 18;
            this.btTongCong.Text = "Tính Tổng Công:";
            this.btTongCong.UseVisualStyleBackColor = false;
            this.btTongCong.Click += new System.EventHandler(this.btTongCong_Click);
            // 
            // lbTongCong
            // 
            this.lbTongCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongCong.Location = new System.Drawing.Point(294, 115);
            this.lbTongCong.Name = "lbTongCong";
            this.lbTongCong.Size = new System.Drawing.Size(246, 31);
            this.lbTongCong.TabIndex = 19;
            this.lbTongCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BangCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(552, 361);
            this.Controls.Add(this.lbTongCong);
            this.Controls.Add(this.btTongCong);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.cbbMaLuong);
            this.Controls.Add(this.dgvBangCong);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtSoNgay);
            this.Controls.Add(this.txtMaCong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BangCong";
            this.Text = "BangCong";
            this.Load += new System.EventHandler(this.BangCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaCong;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dgvBangCong;
        private System.Windows.Forms.ComboBox cbbMaLuong;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btTongCong;
        private System.Windows.Forms.Label lbTongCong;
    }
}