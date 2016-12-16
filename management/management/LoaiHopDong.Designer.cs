namespace management
{
    partial class LoaiHopDong
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
            this.txtMaLoaiHD = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.dgvLoaiHD = new System.Windows.Forms.DataGridView();
            this.btHuy = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại hợp đồng : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên :  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaLoaiHD
            // 
            this.txtMaLoaiHD.Location = new System.Drawing.Point(200, 28);
            this.txtMaLoaiHD.Name = "txtMaLoaiHD";
            this.txtMaLoaiHD.Size = new System.Drawing.Size(286, 20);
            this.txtMaLoaiHD.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(200, 65);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(286, 20);
            this.txtTen.TabIndex = 3;
            // 
            // btLuu
            // 
            this.btLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(49, 269);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(83, 46);
            this.btLuu.TabIndex = 13;
            this.btLuu.Text = "LƯU";
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // dgvLoaiHD
            // 
            this.dgvLoaiHD.BackgroundColor = System.Drawing.Color.Cyan;
            this.dgvLoaiHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiHD.Location = new System.Drawing.Point(0, 95);
            this.dgvLoaiHD.Name = "dgvLoaiHD";
            this.dgvLoaiHD.Size = new System.Drawing.Size(496, 154);
            this.dgvLoaiHD.TabIndex = 14;
            this.dgvLoaiHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiHD_CellClick);
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Location = new System.Drawing.Point(200, 269);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(83, 46);
            this.btHuy.TabIndex = 15;
            this.btHuy.Text = "HỦY";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btDong
            // 
            this.btDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDong.Location = new System.Drawing.Point(345, 269);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(83, 46);
            this.btDong.TabIndex = 16;
            this.btDong.Text = "ĐÓNG";
            this.btDong.UseVisualStyleBackColor = false;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // LoaiHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(496, 327);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.dgvLoaiHD);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMaLoaiHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoaiHopDong";
            this.Text = "LoaiHopDong";
            this.Load += new System.EventHandler(this.LoaiHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoaiHD;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.DataGridView dgvLoaiHD;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btDong;
    }
}