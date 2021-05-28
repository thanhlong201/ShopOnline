using ShopOnLineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn.Models.BUS
{
    public class ShopOnlineBUS
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new ShopOnLineConnectionDB();
            return db.Query<SanPham>("select * from  SanPham where TinhTrang = 0");
        }
        public static SanPham ChiTiet(String a)
        {
            var db = new ShopOnLineConnectionDB();
            return db.SingleOrDefault<SanPham>("select * from  SanPham where MaSanPham = @0",a);
        }

    }
}