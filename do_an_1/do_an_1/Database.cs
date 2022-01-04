using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace do_an_1
{
    public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool CreateDatabase()
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                connect.CreateTable<User>();
                connect.CreateTable<Truyen>();
                connect.CreateTable<BaiHoc>();
                connect.CreateTable<GroupBH>();
                connect.CreateTable<GroupTruyen>();
                return true;
            }
            catch
            {
                return false;
            }
        }
        // Lấy dữ liệu:
        public User LayNd(string ten)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                return connect.Table<User>().FirstOrDefault(t => t.TenND == ten || t.Email == ten);
            }
            catch
            {
                return null;
            }
        }

        public List<User> LayNguoidung()
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                return connect.Table<User>().ToList();
            }
            catch
            {
                return null;
            }
        }
        public bool XacThuc(string ten, string mk)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                var data = connect.Table<User>();
                var d1 = data.Where(x => (x.TenND == ten || x.Email == ten) && x.MatKhau == mk).FirstOrDefault();
                if (d1 != null)
                {
                    return true;
                }

                else
                    return false;

            }
            catch
            {
                return false;
            }

        }

       
        public bool TonTai(string ten, string email)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                var data = connect.Table<User>();
                var d1 = data.Where(x => x.TenND == ten || x.Email == email).FirstOrDefault();
                if (d1 != null)
                {
                    return true;
                }

                else
                    return false;

            }
            catch
            {
                return false;
            }
        }

        public List<BaiHoc> LayBaiHocTheoChang(int machang)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                return connect.Query<BaiHoc>("select * from BaiHoc where MaChang=" + machang.ToString());
            }
            catch
            {
                return null;
            }
        }
        public List<BaiHoc> LayBaiHocTheoND(int mand)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                return connect.Query<BaiHoc>("select * from BaiHoc where MaND=" + mand.ToString());
            }
            catch
            {
                return null;
            }
        }

        public List<Truyen> LayTruyenTheoNhom(int manhom)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                return connect.Query<Truyen>("select * from Truyen where MaNhom=" + manhom.ToString());
            }
            catch
            {
                return null;
            }
        }

        public List<BaiHoc> LayBaiHoc()
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                return connect.Table<BaiHoc>().ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<Truyen> LayTruyen()
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                return connect.Table<Truyen>().ToList();
            }
            catch
            {
                return null;
            }
        }
        // Thêm
        public bool ThemNguoidung(User nd)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                connect.Insert(nd);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool ThemBaiHoc(BaiHoc bh)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                connect.Insert(bh);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ThemTruyen(Truyen tr)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                connect.Insert(tr);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Sửa dữ liệu
        public bool SuaNguoiDung(User nd)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "ql.db"));
                connect.Update(nd);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
