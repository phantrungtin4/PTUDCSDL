namespace DoAn_PTUDQL1
{
    partial class TraCuuPhong
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
            this.btnKiemTra = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtMaPhong = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnDSTrong = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnYCHopDong = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(474, 54);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(90, 25);
            this.btnKiemTra.TabIndex = 0;
            this.btnKiemTra.Values.Text = "Kiểm Tra ";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(101, 59);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Mã Phòng :";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(180, 56);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(266, 23);
            this.txtMaPhong.TabIndex = 2;
            this.txtMaPhong.Text = "kryptonTextBox1";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(33, 102);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Size = new System.Drawing.Size(742, 312);
            this.kryptonDataGridView1.TabIndex = 3;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(286, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(169, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "DANH SÁCH PHÒNG TRỐNG";
            // 
            // btnDSTrong
            // 
            this.btnDSTrong.Location = new System.Drawing.Point(610, 54);
            this.btnDSTrong.Name = "btnDSTrong";
            this.btnDSTrong.Size = new System.Drawing.Size(165, 25);
            this.btnDSTrong.TabIndex = 5;
            this.btnDSTrong.Values.Text = "Danh Sách Phòng Trống";
            // 
            // btnYCHopDong
            // 
            this.btnYCHopDong.Location = new System.Drawing.Point(296, 442);
            this.btnYCHopDong.Name = "btnYCHopDong";
            this.btnYCHopDong.Size = new System.Drawing.Size(124, 46);
            this.btnYCHopDong.TabIndex = 17;
            this.btnYCHopDong.Values.Text = "Yêu cầu hợp đồng";
            // 
            // TraCuuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.btnYCHopDong);
            this.Controls.Add(this.btnDSTrong);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnKiemTra);
            this.Name = "TraCuuPhong";
            this.Text = "TraCuuPhong";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnKiemTra;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMaPhong;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDSTrong;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnYCHopDong;
    }
}