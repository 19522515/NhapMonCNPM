using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    public class CategoryDAO

    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from THELOAISACH").Tables[0];
            foreach (DataRow item in data.Rows)
            {
                Category cate = new Category(item);
                list.Add(cate);
            }
            return list;
        }


    }
}
