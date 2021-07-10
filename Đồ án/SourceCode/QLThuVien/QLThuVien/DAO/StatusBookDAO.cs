using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    public class StatusBookDAO
    {
        private static StatusBookDAO instance;

        public static StatusBookDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StatusBookDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public List<StatusBook> GetListStatusBookDAO()
        {
            List<StatusBook> list = new List<StatusBook>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from hientrang").Tables[0];
            foreach(DataRow item in data.Rows)
            {
                StatusBook stt = new StatusBook(item);
                list.Add(stt);
            }
            return list;
        }
    }
}
