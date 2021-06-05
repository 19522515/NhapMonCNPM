using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class Staff
    {
        public Staff(int idStaff,string nameStaff,DateTime dobStaff,	string addressStaff,	string emailStaff,string sexStaff,string phonenumberStaff,string account,string password,int idPermission)
        {
            this.IdStaff =  idStaff;
            this.nameStaff = nameStaff;
            this.dobStaff = dobStaff;
            this.addressStaff =  addressStaff;
            this.emailStaff = emailStaff;
            this.sexStaff = sexStaff;
            this.phonenumberStaff = phonenumberStaff;
            this.account = account;
            this.password = password;
            this.idPermission = idPermission;
        }   

            public Staff (DataRow row)
        {
            this.IdStaff = Convert.ToInt32(row["MANV"]);
            this.nameStaff = row["tennv"].ToString();
            this.dobStaff = Convert.ToDateTime(row["ngaysinh"]);
            this.addressStaff = row["diachi"].ToString();
            this.emailStaff = row["email"].ToString();
            this.sexStaff = row["gioitinh"].ToString();
            this.phonenumberStaff = row["sodt"].ToString();
            this.account = row["taikhoan"].ToString();
            this.password = row["matkhau"].ToString();
            this.idPermission = Convert.ToInt32(row["maquyen"]);
        }
        private int idStaff;
        private string nameStaff;
        private DateTime dobStaff;
        private string addressStaff;
        private string emailStaff;
        private string sexStaff;
        private string phonenumberStaff;
        private string account;
        private string password;
        private int idPermission;

        public int IdStaff { get => idStaff; set => idStaff = value; }
        public string NameStaff { get => nameStaff; set => nameStaff = value; }
        public DateTime DobStaff { get => dobStaff; set => dobStaff = value; }
        public string AddressStaff { get => addressStaff; set => addressStaff = value; }
        public string EmailStaff { get => emailStaff; set => emailStaff = value; }
        public string SexStaff { get => sexStaff; set => sexStaff = value; }
        public string PhonenumberStaff { get => phonenumberStaff; set => phonenumberStaff = value; }
        public string Account { get => account; set => account = value; }
        public string Password { get => password; set => password = value; }
        public int IdPermission { get => idPermission; set => idPermission = value; }
    }
}
