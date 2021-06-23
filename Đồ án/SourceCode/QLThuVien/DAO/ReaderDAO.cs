using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    class ReaderDAO
    {
        private static ReaderDAO instance;

        public static ReaderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReaderDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public List<Reader> GetListReader()
        {
            List<Reader> list = new List<Reader>();
            string query = "EXEC USP_GETLISTREADER";
            DataTable data = DataProvider.Instance.ExecuteQuery(query).Tables[0];
            foreach (DataRow item in data.Rows)
            {
                Reader reader = new Reader(item);
                list.Add(reader);
            }
            return list;
        }

        public DataTable GetListReader2()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Exec GETLISTREADER").Tables[0];
            return data;
        }

        public List<Reader> GetListReaderFromBillBorrow()
        {
            List<Reader> list = new List<Reader>();
            string query = "EXEC USP_GETLISTIDREADERFROMBILLBORROW";
            DataTable data = DataProvider.Instance.ExecuteQuery(query).Tables[0];
            foreach (DataRow item in data.Rows)
            {
                Reader reader = new Reader(item);
                list.Add(reader);
            }
            return list;
        }
        public bool InsertReader(string name, string address, string email, int idwork, DateTime dob, string sex, string phone, DateTime datecreate, int debt)
        {
            string query = string.Format("EXEC INSERTREADER @NAME = N'{0}', @ADDRESS = N'{1}', @EMAIL = N'{2}',  @IDWORK = {3}, @DOB = '{4}', @SEX =N'{5}', @PHONE = '{6}', @DATECREATE = '{7}', @DEBT = {8}",name, address, email, idwork, dob, sex, phone, datecreate, debt);
            int data = DataProvider.Instance.ExecutenonQuery(query);
            return data > 0;
        }

        public bool updateReader(int idreader, string name, string address, string email, int idwork, DateTime dob, string sex, string phone, DateTime datecreate, int debt)
        {
            string query = string.Format("EXEC UPDATEREADER @idreader = {9}, @NAME = N'{0}', @ADDRESS = N'{1}', @EMAIL = N'{2}',  @IDWORK = {3}, @DOB = '{4}', @SEX =N'{5}', @PHONE = '{6}', @DATECREATE = '{7}', @DEBT = {8}", name, address, email, idwork, dob, sex, phone, datecreate, debt, idreader);
            int data = DataProvider.Instance.ExecutenonQuery(query);
            return data > 0;
        }

       public   bool deleteReader(int idreader)
        {
            string query = "EXEC DELREADER @IDREADER = " + idreader;
            int data = DataProvider.Instance.ExecutenonQuery(query);
            return data > 0;
        }





    }
}
