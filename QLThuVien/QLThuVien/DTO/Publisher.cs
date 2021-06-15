using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class Publisher
    {
        private int idPublisher;
        private string namePublisher;

        public Publisher(int idPublisher, string namePublisher)
        {
            this.idPublisher = idPublisher;
            this.namePublisher = namePublisher;
        }
        public Publisher(DataRow row)
        {
            this.idPublisher = Convert.ToInt32(row["manhaxuatban"]);
            this.namePublisher = row["tennhaxuatban"].ToString();
        }
        public int IdPublisher { get => idPublisher; set => idPublisher = value; }
        public string NamePublisher { get => namePublisher; set => namePublisher = value; }
    }
}
