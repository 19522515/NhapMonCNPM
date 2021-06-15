using QLThuVien.DAO;
using QLThuVien.DTO;
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
    public partial class FParameter : Form
    {
        public FParameter()
        {
            InitializeComponent();
            load_textbox();
        }

        void load_textbox()
        {
            List<ParaMeters> list = ParameterDAO.Instance.GetListParameter();
            num_min_age.Value = Convert.ToInt32(list[0].ValueParameter);
            num_max_age.Value = Convert.ToInt32(list[1].ValueParameter);
            num_max_borrow.Value = Convert.ToInt32(list[2].ValueParameter);
            num_fine.Value = Convert.ToInt32(list[3].ValueParameter);
        }
        void Update()
        {
            int min_age = Convert.ToInt32(num_min_age.Value);
            int max_age = Convert.ToInt32(num_max_age.Value);
            int max_borrow = Convert.ToInt32(num_max_borrow.Value);
            int fine = Convert.ToInt32(num_fine.Value);
            ParameterDAO.Instance.UpdateParameter(min_age, max_age, max_borrow, fine);

        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
