using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Models;

namespace LibraryManagement.Models
{
    public class DSPhieuTra
    {
        public int stt { get; set; }
        public string borrowSlipCode;
        public string recvSlipCode { get; set; }
        public string readerCode { get; set; }
        public string readerName { get; set; }
        public string email;
        public string returnDate { get; set; }
        public int lateReturnDays;
        public long fineThisPeriod { get; set; }
        public string totalFine;
        public List<TraSach> returnBooks;
        public List<string> specBookCodes;

        public DSPhieuTra() 
        { 
            returnBooks = new List<TraSach>();
            specBookCodes = new List<string> { };
        }

        public DSPhieuTra(string borrowSlipCode, string readerCode, string readerName, string returnDate, string totalFine, string fineThisPeriod = "", List<TraSach> chosenBooks = null)
        {
            this.borrowSlipCode = borrowSlipCode;
            this.readerCode = readerCode;
            this.readerName = readerName;
            this.returnDate = returnDate;
            if(fineThisPeriod != "")
            {
                this.fineThisPeriod = long.Parse(fineThisPeriod);
            }
            this.totalFine = totalFine;

            if(chosenBooks != null)
            {
                returnBooks = new List<TraSach>();
                foreach (TraSach book in chosenBooks)
                {
                    returnBooks.Add(new TraSach(book));
                }
            }
        }
    }
}
