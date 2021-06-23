using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class Payment
    {
		private int idPayment;
		private int idStaff;
		private int idReader;
		private int collectedAmount;
		private DateTime datePayment;
		private string notePayment;
        public Payment(int idPayment, int idStaff, int idReader,int collectedAmount, DateTime datePayment,string notePayment)
        {
            this.idPayment = idPayment;
            this.idStaff = idStaff;
            this.idReader = idReader;
            this.collectedAmount = collectedAmount;
            this.datePayment = datePayment;
            this.notePayment = notePayment;
        }
        public int IdPayment { get => idPayment; set => idPayment = value; }
        public int IdStaff { get => idStaff; set => idStaff = value; }
        public int IdReader { get => idReader; set => idReader = value; }
        public int CollectedAmount { get => collectedAmount; set => collectedAmount = value; }
        public DateTime DatePayment { get => datePayment; set => datePayment = value; }
        public string NotePayment { get => notePayment; set => notePayment = value; }
    }
}
