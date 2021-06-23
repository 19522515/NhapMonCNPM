using QLThuVien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            load_datetime();
          
        }

        private void Report_Load(object sender, EventArgs e)
        {
            
            DateTime datefrom = dtp_from.Value;
            DateTime dateto = dtp_to.Value;
            this.REPORTBOOKUNRETURNTableAdapter.Fill(this.ManagerBook.REPORTBOOKUNRETURN, datefrom, dateto);
          this.reportViewer1.RefreshReport();
         
        }
        void load_datetime()
        {
            DateTime today = DateTime.Now;
            int date = - today.Day + 1;
            dtp_from.Value = today.AddDays(date);
            DateTime a = dtp_from.Value.AddMonths(1);
            a = a.AddDays(-1);
            dtp_to.Value = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report_Load(sender,e);
        }
    }
}
