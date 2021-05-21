
namespace QLThuVien
{
    partial class Flogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbdangnhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbmk = new System.Windows.Forms.Label();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.lbdangnhap);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 50);
            this.panel1.TabIndex = 1;
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(202, 12);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(412, 29);
            this.tb_username.TabIndex = 1;
            // 
            // lbdangnhap
            // 
            this.lbdangnhap.AutoSize = true;
            this.lbdangnhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdangnhap.Location = new System.Drawing.Point(13, 12);
            this.lbdangnhap.Name = "lbdangnhap";
            this.lbdangnhap.Size = new System.Drawing.Size(162, 22);
            this.lbdangnhap.TabIndex = 0;
            this.lbdangnhap.Text = "Tên đăng nhập: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_password);
            this.panel2.Controls.Add(this.lbmk);
            this.panel2.Location = new System.Drawing.Point(12, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 50);
            this.panel2.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(202, 12);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(412, 29);
            this.tb_password.TabIndex = 2;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmk.Location = new System.Drawing.Point(16, 12);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(107, 22);
            this.lbmk.TabIndex = 0;
            this.lbmk.Text = "Mật khẩu: ";
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangnhap.Location = new System.Drawing.Point(356, 124);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(112, 38);
            this.bt_dangnhap.TabIndex = 3;
            this.bt_dangnhap.Text = "Đăng nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = true;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_exit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Location = new System.Drawing.Point(514, 124);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(112, 38);
            this.bt_exit.TabIndex = 4;
            this.bt_exit.Text = "Thoát";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // Flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 178);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Flogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Flogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbdangnhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Button bt_exit;
    }
}

