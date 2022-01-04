using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace do_an_1
{
    public class Truyen
    {
        [PrimaryKey, AutoIncrement]
        public int MaTruyen { get; set; }
        public string TenTruyen { get; set; }
        public int MaNhom { get; set; }
        public string Hinh { get; set; }
    }
}
