using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLi_CuaHangThachCao
{
   
    public class HangHoa
    {
        public string MaHang {get;set;}
        public string TenHang { get; set; }
        public string MaChatLieu { get; set; }
        public string SoLuong { get; set; }
        public string DonGiaNhap { get; set; }
        public string DonGiaBan { get; set; }

        
    }
   
}
