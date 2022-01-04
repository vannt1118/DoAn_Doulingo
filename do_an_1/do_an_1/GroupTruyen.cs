using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace do_an_1
{
    public class GroupTruyen : List<Truyen>
    {
        public string TenNhom { get; set; }
        public GroupTruyen(string tennhom, List<Truyen> trs)
        {
            TenNhom = tennhom;
            for (int i = 0; i < trs.Count; i++)
            {
                this.Add(trs[i]);
            }

        }
    }
}
