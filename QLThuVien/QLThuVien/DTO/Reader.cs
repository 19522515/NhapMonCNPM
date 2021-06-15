using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class Reader
    {
		private int idReader;
        private string nameReader;
        private string addressReader;
        private string emailReader;
        private int idWorkReader;
        private DateTime dobReader;
        private string sexReader;
        private string phonenumberReader;
        private DateTime createdAt;
        private int debt;

        public Reader(int idReader,	string nameReader,	string addressReader	,string emailReader,	int idWorkReader,DateTime dobReader,	string sexReader,string phonenumberReader,DateTime createdAt,	int debt)
        {
            this.idReader = idReader;
            this.nameReader = nameReader;
            this.addressReader = addressReader;
            this.emailReader = emailReader;
            this.IdWorkReader = idWorkReader;
            this.dobReader = dobReader;
            this.sexReader = sexReader;
            this.phonenumberReader = phonenumberReader;
            this.createdAt = createdAt;
            this.debt = debt;
        }
        public Reader(DataRow row)
        {
            this.idReader = Convert.ToInt32(row["madocgia"]);
            this.nameReader = row["hoten"].ToString();
            this.addressReader = row["diachi"].ToString();
            this.emailReader = row["email"].ToString();
            this.IdWorkReader = Convert.ToInt32(row["macongviec"]);
            this.dobReader = Convert.ToDateTime(row["ngaysinh"]);
            this.sexReader = row["gioitinh"].ToString();
            this.phonenumberReader = row["sodienthoai"].ToString();
            this.createdAt = Convert.ToDateTime(row["ngaytaothe"]);
            this.debt = Convert.ToInt32(row["sono"]);
        }
        public int IdReader { get => idReader; set => idReader = value; }
        public string NameReader { get => nameReader; set => nameReader = value; }
        public string AddressReader { get => addressReader; set => addressReader = value; }
        public string EmailReader { get => emailReader; set => emailReader = value; }
        public int IdWorkReader { get => idWorkReader; set => idWorkReader = value; }
        public DateTime DobReader { get => dobReader; set => dobReader = value; }
        public string SexReader { get => sexReader; set => sexReader = value; }
        public string PhonenumberReader { get => phonenumberReader; set => phonenumberReader = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public int Debt { get => debt; set => debt = value; }
    }
}
