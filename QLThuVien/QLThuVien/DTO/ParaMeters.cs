using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class ParaMeters
    {
        private int idParameter;
        private string nameParameter;
        private int valueParameter;

        public ParaMeters (int idParameter, string nameParameter, int valueParameter)
        {
            this.idParameter = idParameter;
            this.nameParameter = nameParameter;
            this.valueParameter = valueParameter;
        }

        public ParaMeters(DataRow row)
        {
            this.idParameter = Convert.ToInt32(row["mathamso"]);
            this.nameParameter = row["tenthamso"].ToString();
            this.valueParameter = Convert.ToInt32(row["giatrithamso"]);
        }

        public int IdParameter { get => idParameter; set => idParameter = value; }
        public string NameParameter { get => nameParameter; set => nameParameter = value; }
        public int ValueParameter { get => valueParameter; set => valueParameter = value; }
       
    }
}
