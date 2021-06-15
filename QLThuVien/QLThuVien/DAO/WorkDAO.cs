using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    public class WorkDAO
    {
        private static WorkDAO instance;

        public static WorkDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WorkDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public List<Work> GetListWork()
        {
            List<Work> list = new List<Work>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from congviec").Tables[0];
            foreach (DataRow item in data.Rows)
            {
                Work work = new Work(item);
                list.Add(work);
            }
            return list;
        }
    }
}
