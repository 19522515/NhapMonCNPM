using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class Work
    {
        private int idWork;
        private string typeWork;
        public Work (DataRow row)
        {
            this.idWork = Convert.ToInt32(row["macongviec"]);
            this.typeWork = row["Loaicongviec"].ToString();
        }
        public Work(int idWork, string typeWork)
        {
            this.idWork = idWork;
            this.typeWork = typeWork;
        }
        public int IdWork { get => idWork; set => idWork = value; }
        public string TypeWork { get => typeWork; set => typeWork = value; }
    }
}
