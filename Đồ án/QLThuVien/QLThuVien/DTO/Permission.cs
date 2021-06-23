using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class Permission
    {
        private int idPermission;
        private string namePermission;
        public Permission (int idPermission, string namePermission)
        {
            this.idPermission = idPermission;
            this.namePermission = namePermission;
        }
        public Permission (DataRow row)
        {
            this.idPermission = Convert.ToInt32(row["MAQUYEN"]);
            this.namePermission = row["TENQUYEN"].ToString();
        }
        public int IdPermission { get => idPermission; set => idPermission = value; }
        public string NamePermission { get => namePermission; set => namePermission = value; }
    }
}
