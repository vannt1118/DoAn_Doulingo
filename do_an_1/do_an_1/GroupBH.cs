using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace do_an_1
{
    public class GroupBH : List<BaiHoc>
    {
        public int MaChang { get; set; }
        public GroupBH(int machang, List<BaiHoc> bhs)
        {
            MaChang = machang;
            for (int i = 0; i < bhs.Count; i++)
            {
                this.Add(bhs[i]);
            }
        }
    }
}
