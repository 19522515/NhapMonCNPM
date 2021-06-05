
namespace QLThuVien
{
    partial class FManagerStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel48 = new System.Windows.Forms.Panel();
            this.panel58 = new System.Windows.Forms.Panel();
            this.cb_permission = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.bt_del_mnr = new System.Windows.Forms.Button();
            this.bt_update_mnr = new System.Windows.Forms.Button();
            this.bt_add_mnr = new System.Windows.Forms.Button();
            this.panel49 = new System.Windows.Forms.Panel();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.panel51 = new System.Windows.Forms.Panel();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.panel52 = new System.Windows.Forms.Panel();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.panel53 = new System.Windows.Forms.Panel();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.panel54 = new System.Windows.Forms.Panel();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.panel55 = new System.Windows.Forms.Panel();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.panel56 = new System.Windows.Forms.Panel();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.panel57 = new System.Windows.Forms.Panel();
            this.tb_idstaff = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.panel48.SuspendLayout();
            this.panel58.SuspendLayout();
            this.panel49.SuspendLayout();
            this.panel51.SuspendLayout();
            this.panel52.SuspendLayout();
            this.panel53.SuspendLayout();
            this.panel54.SuspendLayout();
            this.panel55.SuspendLayout();
            this.panel56.SuspendLayout();
            this.panel57.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel48
            // 
            this.panel48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel48.Controls.Add(this.panel58);
            this.panel48.Controls.Add(this.bt_del_mnr);
            this.panel48.Controls.Add(this.bt_update_mnr);
            this.panel48.Controls.Add(this.bt_add_mnr);
            this.panel48.Controls.Add(this.panel49);
            this.panel48.Controls.Add(this.panel51);
            this.panel48.Controls.Add(this.panel52);
            this.panel48.Controls.Add(this.panel53);
            this.panel48.Controls.Add(this.panel54);
            this.panel48.Controls.Add(this.panel55);
            this.panel48.Controls.Add(this.panel56);
            this.panel48.Controls.Add(this.panel57);
            this.panel48.Location = new System.Drawing.Point(1, 2);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(1582, 428);
            this.panel48.TabIndex = 2;
            // 
            // panel58
            // 
            this.panel58.Controls.Add(this.cb_permission);
            this.panel58.Controls.Add(this.label48);
            this.panel58.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel58.Location = new System.Drawing.Point(224, 183);
            this.panel58.Name = "panel58";
            this.panel58.Size = new System.Drawing.Size(609, 39);
            this.panel58.TabIndex = 46;
            // 
            // cb_permission
            // 
            this.cb_permission.FormattingEnabled = true;
            this.cb_permission.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_permission.Location = new System.Drawing.Point(249, 5);
            this.cb_permission.Name = "cb_permission";
            this.cb_permission.Size = new System.Drawing.Size(348, 29);
            this.cb_permission.TabIndex = 6;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label48.Location = new System.Drawing.Point(21, 10);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(84, 24);
            this.label48.TabIndex = 3;
            this.label48.Text = "Chức vụ:";
            // 
            // bt_del_mnr
            // 
            this.bt_del_mnr.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_del_mnr.Location = new System.Drawing.Point(778, 244);
            this.bt_del_mnr.Name = "bt_del_mnr";
            this.bt_del_mnr.Size = new System.Drawing.Size(165, 38);
            this.bt_del_mnr.TabIndex = 45;
            this.bt_del_mnr.Text = "Xóa";
            this.bt_del_mnr.UseVisualStyleBackColor = true;
            this.bt_del_mnr.Click += new System.EventHandler(this.bt_del_mnr_Click);
            // 
            // bt_update_mnr
            // 
            this.bt_update_mnr.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update_mnr.Location = new System.Drawing.Point(1338, 244);
            this.bt_update_mnr.Name = "bt_update_mnr";
            this.bt_update_mnr.Size = new System.Drawing.Size(165, 38);
            this.bt_update_mnr.TabIndex = 44;
            this.bt_update_mnr.Text = "Cập nhật";
            this.bt_update_mnr.UseVisualStyleBackColor = true;
            this.bt_update_mnr.Click += new System.EventHandler(this.bt_update_mnr_Click);
            // 
            // bt_add_mnr
            // 
            this.bt_add_mnr.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_mnr.Location = new System.Drawing.Point(245, 244);
            this.bt_add_mnr.Name = "bt_add_mnr";
            this.bt_add_mnr.Size = new System.Drawing.Size(165, 38);
            this.bt_add_mnr.TabIndex = 43;
            this.bt_add_mnr.Text = "Thêm ";
            this.bt_add_mnr.UseVisualStyleBackColor = true;
            this.bt_add_mnr.Click += new System.EventHandler(this.bt_add_mnr_Click);
            // 
            // panel49
            // 
            this.panel49.Controls.Add(this.tb_phone);
            this.panel49.Controls.Add(this.label39);
            this.panel49.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel49.Location = new System.Drawing.Point(906, 101);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(609, 39);
            this.panel49.TabIndex = 42;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(249, 5);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(348, 29);
            this.tb_phone.TabIndex = 10;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label39.Location = new System.Drawing.Point(21, 10);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(116, 24);
            this.label39.TabIndex = 3;
            this.label39.Text = "Số điện thoại";
            // 
            // panel51
            // 
            this.panel51.Controls.Add(this.tb_account);
            this.panel51.Controls.Add(this.label41);
            this.panel51.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel51.Location = new System.Drawing.Point(906, 148);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(609, 39);
            this.panel51.TabIndex = 40;
            // 
            // tb_account
            // 
            this.tb_account.Location = new System.Drawing.Point(249, 5);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(348, 29);
            this.tb_account.TabIndex = 9;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label41.Location = new System.Drawing.Point(21, 10);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(96, 24);
            this.label41.TabIndex = 3;
            this.label41.Text = "Tài khoản:";
            // 
            // panel52
            // 
            this.panel52.Controls.Add(this.cb_sex);
            this.panel52.Controls.Add(this.label42);
            this.panel52.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel52.Location = new System.Drawing.Point(906, 56);
            this.panel52.Name = "panel52";
            this.panel52.Size = new System.Drawing.Size(609, 39);
            this.panel52.TabIndex = 39;
            // 
            // cb_sex
            // 
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_sex.Location = new System.Drawing.Point(249, 7);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(348, 29);
            this.cb_sex.TabIndex = 5;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label42.Location = new System.Drawing.Point(21, 10);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(89, 24);
            this.label42.TabIndex = 3;
            this.label42.Text = "Giới tính:";
            // 
            // panel53
            // 
            this.panel53.Controls.Add(this.tb_email);
            this.panel53.Controls.Add(this.label43);
            this.panel53.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel53.Location = new System.Drawing.Point(906, 8);
            this.panel53.Name = "panel53";
            this.panel53.Size = new System.Drawing.Size(609, 42);
            this.panel53.TabIndex = 38;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(249, 7);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(348, 29);
            this.tb_email.TabIndex = 9;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label43.Location = new System.Drawing.Point(21, 10);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(65, 24);
            this.label43.TabIndex = 3;
            this.label43.Text = "Email:";
            // 
            // panel54
            // 
            this.panel54.Controls.Add(this.tb_address);
            this.panel54.Controls.Add(this.label44);
            this.panel54.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel54.Location = new System.Drawing.Point(224, 138);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(609, 39);
            this.panel54.TabIndex = 37;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(249, 3);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(348, 29);
            this.tb_address.TabIndex = 8;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label44.Location = new System.Drawing.Point(21, 10);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(76, 24);
            this.label44.TabIndex = 3;
            this.label44.Text = "Địa chỉ:";
            // 
            // panel55
            // 
            this.panel55.Controls.Add(this.dtp_dob);
            this.panel55.Controls.Add(this.label45);
            this.panel55.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel55.Location = new System.Drawing.Point(224, 93);
            this.panel55.Name = "panel55";
            this.panel55.Size = new System.Drawing.Size(609, 39);
            this.panel55.TabIndex = 36;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Location = new System.Drawing.Point(249, 5);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(348, 29);
            this.dtp_dob.TabIndex = 4;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label45.Location = new System.Drawing.Point(21, 10);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 24);
            this.label45.TabIndex = 3;
            this.label45.Text = "Ngày sinh:";
            // 
            // panel56
            // 
            this.panel56.Controls.Add(this.tb_name);
            this.panel56.Controls.Add(this.label46);
            this.panel56.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel56.Location = new System.Drawing.Point(224, 48);
            this.panel56.Name = "panel56";
            this.panel56.Size = new System.Drawing.Size(609, 39);
            this.panel56.TabIndex = 35;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(249, 7);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(348, 29);
            this.tb_name.TabIndex = 6;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label46.Location = new System.Drawing.Point(21, 10);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(94, 24);
            this.label46.TabIndex = 3;
            this.label46.Text = "Họ và tên:";
            // 
            // panel57
            // 
            this.panel57.Controls.Add(this.tb_idstaff);
            this.panel57.Controls.Add(this.label47);
            this.panel57.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel57.Location = new System.Drawing.Point(224, 3);
            this.panel57.Name = "panel57";
            this.panel57.Size = new System.Drawing.Size(609, 39);
            this.panel57.TabIndex = 34;
            // 
            // tb_idstaff
            // 
            this.tb_idstaff.Location = new System.Drawing.Point(249, 5);
            this.tb_idstaff.Name = "tb_idstaff";
            this.tb_idstaff.ReadOnly = true;
            this.tb_idstaff.Size = new System.Drawing.Size(348, 29);
            this.tb_idstaff.TabIndex = 5;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label47.Location = new System.Drawing.Point(21, 10);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(124, 24);
            this.label47.TabIndex = 3;
            this.label47.Text = "Mã nhân viên:";
            // 
            // dgv_staff
            // 
            this.dgv_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_staff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_staff.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_staff.Location = new System.Drawing.Point(1, 308);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowHeadersWidth = 48;
            this.dgv_staff.Size = new System.Drawing.Size(1582, 445);
            this.dgv_staff.TabIndex = 3;
            this.dgv_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellClick);
            // 
            // FManagerStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 755);
            this.Controls.Add(this.dgv_staff);
            this.Controls.Add(this.panel48);
            this.Name = "FManagerStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.panel48.ResumeLayout(false);
            this.panel58.ResumeLayout(false);
            this.panel58.PerformLayout();
            this.panel49.ResumeLayout(false);
            this.panel49.PerformLayout();
            this.panel51.ResumeLayout(false);
            this.panel51.PerformLayout();
            this.panel52.ResumeLayout(false);
            this.panel52.PerformLayout();
            this.panel53.ResumeLayout(false);
            this.panel53.PerformLayout();
            this.panel54.ResumeLayout(false);
            this.panel54.PerformLayout();
            this.panel55.ResumeLayout(false);
            this.panel55.PerformLayout();
            this.panel56.ResumeLayout(false);
            this.panel56.PerformLayout();
            this.panel57.ResumeLayout(false);
            this.panel57.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel48;
        private System.Windows.Forms.Panel panel58;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button bt_del_mnr;
        private System.Windows.Forms.Button bt_update_mnr;
        private System.Windows.Forms.Button bt_add_mnr;
        private System.Windows.Forms.Panel panel49;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panel51;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel52;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Panel panel54;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Panel panel55;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Panel panel56;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Panel panel57;
        private System.Windows.Forms.TextBox tb_idstaff;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.ComboBox cb_permission;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.Panel panel53;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label43;
    }
}