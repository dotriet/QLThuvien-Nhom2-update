﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Sach
    {
        public int stt { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string author { get; set; }
        public string specCode;

        public Sach()
        {
            code = "";
            name = "";
            category = "";
            author = "";
            specCode = "";
        }
        public Sach(Sach book)
        {
            this.stt = book.stt;
            this.code = book.code;
            this.name = book.name;
            this.category = book.category;
            this.author = book.author;
            this.specCode = book.specCode;
        }
        public Sach(int stt, string code, string name, string catagory, string author, string specCode)
        {
            this.stt = stt;
            this.code = code;
            this.name = name;
            this.category = catagory;
            this.author = author;
            this.specCode = specCode;
        }
    }
}
