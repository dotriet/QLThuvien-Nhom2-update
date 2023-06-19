using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class BaoCaoTheoLoai
    {
        public int stt { get; set; }
        public string categoryName { get; set; }
        public int numsOfBorrowings { get; set; }
        public string rate { get; set; }
        public BaoCaoTheoLoai() { }

        public BaoCaoTheoLoai(string categoryName, int numsOfBorrowings)
        {
            this.categoryName = categoryName;
            this.numsOfBorrowings = numsOfBorrowings;
        }
    }
}
