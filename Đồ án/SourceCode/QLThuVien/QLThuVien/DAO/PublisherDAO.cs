using QLThuVien.DAO;
using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien
{
    public class PublisherDAO
    {
        private static PublisherDAO instance;

        public static PublisherDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PublisherDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public List<Publisher> GetListPublisher()
        {
            List<Publisher> list = new List<Publisher>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from nhaxuatban").Tables[0];
            foreach (DataRow item in data.Rows)
            {
                Publisher pub = new Publisher(item);
                list.Add(pub);
            }
            return list;
        }
    }
}
