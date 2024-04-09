using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCaNhan.DAL
{
    class dal_QuenPass
    {
        LopDungChung lopchung;
        public dal_QuenPass()
        {
            lopchung = new LopDungChung();
        }
        public int checkEmail(string email)
        {
            string sqlCheck = "select count(*) from TAIKHOAN where EMAIL = '" + email + "'";
            int ketqua = (int)lopchung.Scalar(sqlCheck);
            return ketqua;
        }
        public DataTable loadThongTinTaiKhoan(string email)
        {
            string sqlGetPass = "select * from TAIKHOAN where Email = '" + email + "'";
            return lopchung.LoadData(sqlGetPass);
        }
    }
}
