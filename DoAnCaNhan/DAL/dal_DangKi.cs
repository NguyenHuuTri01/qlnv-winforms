using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan.DAL
{
    class dal_DangKi
    {
        LopDungChung lopchung;
        public dal_DangKi()
        {
            lopchung = new LopDungChung();
        }
        public void dalDangKi(string tentk, string password,string rePassword, string email)
        {
            if (password != rePassword)
            {
                MessageBox.Show("Xác nhận lại pass chính xác!");
                return;
            }
            if (!lopchung.IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            checkuser_dangki(tentk, password, email);
        }
        public void checkuser_dangki(string tentk, string password, string email)
        {
            string checkuser = "select count(*) from TAIKHOAN where TenTaiKhoan = '" + tentk + "'";
            if ((int)lopchung.Scalar(checkuser) > 0)
            {
                MessageBox.Show("Tên tài khoản đã được đăng kí");
            }
            else
            {
                string sqldangki = "insert into TAIKHOAN values('" + tentk + "', '" + password + "','" + email + "')";
                lopchung.Nonquery(sqldangki);
            }
        }
    }
}
