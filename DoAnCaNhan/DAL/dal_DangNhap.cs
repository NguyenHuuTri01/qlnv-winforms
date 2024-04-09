using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCaNhan.DAL
{
    class dal_DangNhap
    {
        LopDungChung lopchung;
        public dal_DangNhap()
        {
            lopchung = new LopDungChung();
        }
        public int checkTaiKhoan(string taikhoan, string password)
        {
            string sqlDangNhap = "select count (*) from TAIKHOAN where TenTaiKhoan = '" + taikhoan + "'and MatKhau = '" + password + "'";
            int ketqua = (int)lopchung.Scalar(sqlDangNhap);
            return ketqua;
        }
    }
}
