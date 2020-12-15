namespace DoAn_PTUDQL1
{
    partial class UserUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTraCuuPhong = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDangXuat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // btnTraCuuPhong
            // 
            this.btnTraCuuPhong.Location = new System.Drawing.Point(0, 3);
            this.btnTraCuuPhong.Name = "btnTraCuuPhong";
            this.btnTraCuuPhong.Size = new System.Drawing.Size(107, 42);
            this.btnTraCuuPhong.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnTraCuuPhong.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuPhong.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnTraCuuPhong.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnTraCuuPhong.TabIndex = 0;
            this.btnTraCuuPhong.Values.Text = "Tra Cứu Phòng";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(471, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(107, 42);
            this.btnDangXuat.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnDangXuat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnDangXuat.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Values.Text = "Đăng Xuất";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(203, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(107, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Xin Chào! ...........";
            // 
            // UserUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnTraCuuPhong);
            this.Name = "UserUC";
            this.Size = new System.Drawing.Size(581, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTraCuuPhong;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDangXuat;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}
