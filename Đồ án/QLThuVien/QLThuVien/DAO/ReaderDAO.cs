using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.DTO;

namespace QLThuVien.DAO
{
    public class ReaderDAO
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
        private ReaderDAO() { }
        // lay danh sach ban doc
        public List<Reader> LoadReaderList()
        {
                List<Reader> readerList = new List<Reader>();
                DataSet data = DataProvider.Instance.ExecuteQuery("USP_GetReaderList");
                DataTable datatable = data.Tables[0];
                foreach (DataRow item in datatable.Rows)
                {
                    Reader reader = new Reader(item);
                    readerList.Add(reader);
                }
                return readerList;
        }
    }
}
