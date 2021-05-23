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
        public Reader(string id, string name,string address, string job, string email, string gender, string phoneNumber, DateTime birthday)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.Job = job;
            this.Email = email;
            this.Gender = gender;
            this.PhoneNumber = phoneNumber;
            this.Birthday = birthday;
        }
        private string iD;
        private string name;
        private string address;
        private string job;
        private string email;
        private string gender;
        private string phoneNumber;
        private DateTime birthday;
        public Reader(DataRow row)
        {
            this.ID = row["MADOCGIA"].ToString();
            this.Name = row["HOTEN"].ToString();
            this.Address = row["DIACHI"].ToString();
            this.Email = row["EMAIL"].ToString();
            this.Job = row["CONGVIEC"].ToString();
            this.Birthday = Convert.ToDateTime(row["NGAYSINH"]);
            this.Gender = row["GIOITINH"].ToString();
            this.PhoneNumber = row["SODIENTHOAI"].ToString();
           
        }
        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Job { get => job; set => job = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
    }
}
