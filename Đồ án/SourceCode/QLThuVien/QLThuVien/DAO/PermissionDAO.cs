using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    public class PermissionDAO
    {
        private static PermissionDAO instance;

        public static PermissionDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PermissionDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public List<Permission> GetListPermission()
        {
            List<Permission> list = new List<Permission>();
            string query = "SELECT * FROM quyenhan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query).Tables[0];
            foreach (DataRow item in data.Rows)
            {
                Permission per = new Permission(item);
                list.Add(per);
            }
            return list;
        }
    }
}
