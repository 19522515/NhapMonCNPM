
namespace QLThuVien
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.REPORTBOOKUNRETURNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ManagerBook = new QLThuVien.ManagerBook();
            this.REPORTBOOKUNRETURNTableAdapter = new QLThuVien.ManagerBookTableAdapters.REPORTBOOKUNRETURNTableAdapter();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTBOOKUNRETURNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerBook)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // REPORTBOOKUNRETURNBindingSource
            // 
            this.REPORTBOOKUNRETURNBindingSource.DataMember = "REPORTBOOKUNRETURN";
            this.REPORTBOOKUNRETURNBindingSource.DataSource = this.ManagerBook;
            // 
            // ManagerBook
            // 
            this.ManagerBook.DataSetName = "ManagerBook";
            this.ManagerBook.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // REPORTBOOKUNRETURNTableAdapter
            // 
            this.REPORTBOOKUNRETURNTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1893, 1000);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tình hình mượn sách theo thể loại";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.dtp_to);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.dtp_from);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1887, 100);
            this.panel2.TabIndex = 1;
            // 
            // dtp_from
            // 
            this.dtp_from.Location = new System.Drawing.Point(200, 28);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(299, 29);
            this.dtp_from.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(56, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 29);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Từ ngày:";
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(1510, 31);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(299, 29);
            this.dtp_to.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1366, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 29);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Đến ngày:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(777, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.REPORTBOOKUNRETURNBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLThuVien.ReportBook.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 109);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1885, 885);
            this.reportViewer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1901, 1034);
            this.tabControl1.TabIndex = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1035);
            this.Controls.Add(this.tabControl1);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.REPORTBOOKUNRETURNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerBook)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource REPORTBOOKUNRETURNBindingSource;
        private ManagerBook ManagerBook;
        private ManagerBookTableAdapters.REPORTBOOKUNRETURNTableAdapter REPORTBOOKUNRETURNTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.TabControl tabControl1;
    }
}