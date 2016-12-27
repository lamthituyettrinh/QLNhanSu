namespace management
{
    partial class frmPhongban
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
            this.dgvPhongban = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.rdbten = new System.Windows.Forms.RadioButton();
            this.rdbma = new System.Windows.Forms.RadioButton();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongban)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhongban
            // 
            this.dgvPhongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongban.Location = new System.Drawing.Point(12, 173);
            this.dgvPhongban.Name = "dgvPhongban";
            this.dgvPhongban.Size = new System.Drawing.Size(402, 218);
            this.dgvPhongban.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.rdbten);
            this.groupBox1.Controls.Add(this.rdbma);
            this.groupBox1.Controls.Add(this.txtnhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(46, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm phòng ban";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(117, 101);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            //this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // rdbten
            // 
            this.rdbten.AutoSize = true;
            this.rdbten.Location = new System.Drawing.Point(192, 71);
            this.rdbten.Name = "rdbten";
            this.rdbten.Size = new System.Drawing.Size(90, 24);
            this.rdbten.TabIndex = 5;
            this.rdbten.Text = "Theo tên";
            this.rdbten.UseVisualStyleBackColor = true;
            // 
            // rdbma
            // 
            this.rdbma.AutoSize = true;
            this.rdbma.Checked = true;
            this.rdbma.Location = new System.Drawing.Point(24, 71);
            this.rdbma.Name = "rdbma";
            this.rdbma.Size = new System.Drawing.Size(89, 24);
            this.rdbma.TabIndex = 4;
            this.rdbma.TabStop = true;
            this.rdbma.Text = "Theo mã";
            this.rdbma.UseVisualStyleBackColor = true;
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(101, 25);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(100, 26);
            this.txtnhap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập";
            // 
            // frmPhongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPhongban);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPhongban";
            this.Text = "frmPhongban";
            this.Load += new System.EventHandler(this.frmPhongban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongban)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongban;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.RadioButton rdbten;
        private System.Windows.Forms.RadioButton rdbma;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.Label label3;
    }
}