using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Workspace;

namespace DoAn_PTUDQL1
{
    partial class DangNhap
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
            this.btnDangKy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnDangNhap = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(181, 250);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(92, 36);
            this.btnDangKy.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Values.Text = "ĐĂNG KÝ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Values.Text = "Tên đăng nhập :";
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Values.Text = "Mật khẩu  :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(141, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(236, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(141, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(236, 23);
            this.txtUsername.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(159, 165);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(139, 61);
            this.btnDangNhap.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.btnDangNhap.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnDangNhap.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Values.Text = "ĐĂNG NHẬP";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 307);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangKy);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDangKy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonLabel2;
        private KryptonLabel label1;
        private KryptonLabel label2;
        private KryptonTextBox txtPassword;
        private KryptonTextBox txtUsername;
        private KryptonButton btnDangNhap;
        private UserUC userUC;
    }
}

