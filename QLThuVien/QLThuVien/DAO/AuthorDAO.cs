using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    public class AuthorDAO
    {
        private static AuthorDAO instance;

        public static AuthorDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthorDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public List<Author> GetListAuthor()
        {
            List<Author> list = new List<Author>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from tacgia").Tables[0];
            foreach (DataRow item in data.Rows)
            {
                Author author = new Author(item);
                list.Add(author);
            }
            return list;
        }
    }
}
