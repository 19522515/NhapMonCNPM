
namespace QLThuVien
{
    partial class fReaderManager
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
            this.btnBack = new System.Windows.Forms.Button();
            this.quanLiThuVienDataSet1 = new QLThuVien.QuanLiThuVienDataSet();
            this.labelHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvReader = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBookRentedNum = new System.Windows.Forms.TextBox();
            this.btnDetailBook4Rented = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbJob = new System.Windows.Forms.TextBox();
            this.txbBirthday = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiThuVienDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReader)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(21, 19);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 38);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // quanLiThuVienDataSet1
            // 
            this.quanLiThuVienDataSet1.DataSetName = "QuanLiThuVienDataSet";
            this.quanLiThuVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.Location = new System.Drawing.Point(267, 13);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(361, 44);
            this.labelHeading.TabIndex = 0;
            this.labelHeading.Text = "Danh sách bạn đọc";
            this.labelHeading.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvReader);
            this.panel1.Controls.Add(this.labelHeading);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(43, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 695);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtgvReader
            // 
            this.dtgvReader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvReader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvReader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReader.Location = new System.Drawing.Point(21, 78);
            this.dtgvReader.Name = "dtgvReader";
            this.dtgvReader.RowHeadersWidth = 51;
            this.dtgvReader.RowTemplate.Height = 24;
            this.dtgvReader.Size = new System.Drawing.Size(885, 597);
            this.dtgvReader.TabIndex = 2;
            this.dtgvReader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1033, 33);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1519, 33);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1307, 33);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 38);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelCard);
            this.panel2.Location = new System.Drawing.Point(1033, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 639);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbGender);
            this.panel3.Controls.Add(this.txbPhoneNumber);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbBookRentedNum);
            this.panel3.Controls.Add(this.btnDetailBook4Rented);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txbEmail);
            this.panel3.Controls.Add(this.txbName);
            this.panel3.Controls.Add(this.txbJob);
            this.panel3.Controls.Add(this.txbBirthday);
            this.panel3.Controls.Add(this.txbAddress);
            this.panel3.Controls.Add(this.txbID);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 545);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "NAM",
            "NU",
            "KHAC"});
            this.cbGender.Location = new System.Drawing.Point(129, 112);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 24);
            this.cbGender.TabIndex = 23;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(129, 426);
            this.txbPhoneNumber.Multiline = true;
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(439, 22);
            this.txbPhoneNumber.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số điện thoại";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txbBookRentedNum
            // 
            this.txbBookRentedNum.Location = new System.Drawing.Point(129, 471);
            this.txbBookRentedNum.Multiline = true;
            this.txbBookRentedNum.Name = "txbBookRentedNum";
            this.txbBookRentedNum.Size = new System.Drawing.Size(86, 46);
            this.txbBookRentedNum.TabIndex = 21;
            // 
            // btnDetailBook4Rented
            // 
            this.btnDetailBook4Rented.Location = new System.Drawing.Point(292, 471);
            this.btnDetailBook4Rented.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetailBook4Rented.Name = "btnDetailBook4Rented";
            this.btnDetailBook4Rented.Size = new System.Drawing.Size(202, 46);
            this.btnDetailBook4Rented.TabIndex = 6;
            this.btnDetailBook4Rented.Text = "Chi tiết sách mượn";
            this.btnDetailBook4Rented.UseVisualStyleBackColor = true;
            this.btnDetailBook4Rented.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 48);
            this.label10.TabIndex = 20;
            this.label10.Text = "Số sách \r\nđã mượn";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(129, 154);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(442, 22);
            this.txbEmail.TabIndex = 19;
            this.txbEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(129, 68);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(439, 22);
            this.txbName.TabIndex = 18;
            this.txbName.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txbJob
            // 
            this.txbJob.Location = new System.Drawing.Point(129, 204);
            this.txbJob.Name = "txbJob";
            this.txbJob.Size = new System.Drawing.Size(442, 22);
            this.txbJob.TabIndex = 17;
            this.txbJob.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txbBirthday
            // 
            this.txbBirthday.Location = new System.Drawing.Point(372, 23);
            this.txbBirthday.Name = "txbBirthday";
            this.txbBirthday.Size = new System.Drawing.Size(143, 22);
            this.txbBirthday.TabIndex = 16;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(129, 250);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(448, 155);
            this.txbAddress.TabIndex = 12;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(129, 21);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(86, 22);
            this.txbID.TabIndex = 11;
            this.txbID.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ngày sinh";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Giới tính";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Công việc";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên độc giả";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã độc giả";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCard.Location = new System.Drawing.Point(237, 23);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(174, 32);
            this.labelCard.TabIndex = 2;
            this.labelCard.Text = "Thẻ độc giả";
            this.labelCard.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // fReaderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fReaderManager";
            this.Text = "Quản lý bạn đọc";
            this.Load += new System.EventHandler(this.Readers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLiThuVienDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReader)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private QuanLiThuVienDataSet quanLiThuVienDataSet1;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbJob;
        private System.Windows.Forms.TextBox txbBirthday;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDetailBook4Rented;
        private System.Windows.Forms.TextBox txbBookRentedNum;
        private System.Windows.Forms.DataGridView dtgvReader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.ComboBox cbGender;
    }
}