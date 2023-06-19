using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class DSPhieuMuon
    {
        public int stt { get; set; }
        public string slipCode { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string email;
        public string borrowDate { get; set; }
        public string returnDate { get; set; }
        public string amount;
        public List<Sach> chosenBooks;

        public DSPhieuMuon()
        {
            slipCode = "";
            code = "";
            name = "";
            email = "";
            borrowDate = "";
            returnDate = "";
            amount = "";
            chosenBooks = new List<Sach>();
        }
        public DSPhieuMuon(string slipCode, string code, string name,string email, string borrowDate, string returnDate, string amount, List<Sach> selectedBooks)
        {
            this.slipCode = slipCode;
            this.code = code;
            this.name = name;
            this.email = email;
            this.borrowDate = borrowDate;
            this.returnDate = returnDate;
            this.amount = amount;
            chosenBooks = new List<Sach>();

            foreach (Sach book in selectedBooks)
            {
                Sach copy = new Sach(book);
                chosenBooks.Add(copy);
            }
        }
    }
}
