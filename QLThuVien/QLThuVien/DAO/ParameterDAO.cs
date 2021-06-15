using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.DAO
{
    public class ParameterDAO
    {
        private static ParameterDAO instance;

        public static ParameterDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ParameterDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public List<ParaMeters> GetListParameter()
        {
            List<ParaMeters> list = new List<ParaMeters>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from thamso").Tables[0];
            foreach (DataRow item in data.Rows)

            {
                ParaMeters a = new ParaMeters(item);
                list.Add(a);
            }
            return list;
        }
        public void UpdateParameter(int min_age, int max_age, int max_borrow, int fine)
        {
           if (min_age >max_age)
            {
                MessageBox.Show("Độ tuổi tối thiểu phải nhỏ hơn độ tuổi tối đa");
            }
           else
            {
                int a = DataProvider.Instance.ExecutenonQuery("update thamso set giatrithamso = " + min_age + " where mathamso = 1");
                int b = DataProvider.Instance.ExecutenonQuery("update thamso set giatrithamso = " + max_age + " where mathamso = 2");
                int c = DataProvider.Instance.ExecutenonQuery("update thamso set giatrithamso = " + max_borrow + " where mathamso = 3");
                int d = DataProvider.Instance.ExecutenonQuery("update thamso set giatrithamso = " + fine + " where mathamso = 4");
                if (a<=0)
                {

                    MessageBox.Show("Cập nhật độ tuổi tối thiểu không thành công");
                }
                if (b <= 0)
                {

                    MessageBox.Show("Cập nhật độ tuổi tối đa không thành công");
                }
                if (c <= 0)
                {

                    MessageBox.Show("Cập nhật số ngày mượn tối đa không thành công");
                }
                if (d <= 0)
                {

                    MessageBox.Show("Cập nhật giá tiền phạt trễ/ngày không thành công");
                }
                if (a>0 && b>0 && c>0 && d>0)
                {
                    MessageBox.Show("Cập nhật tất cả thành công");
                }    
            }    
        }
    }
}
