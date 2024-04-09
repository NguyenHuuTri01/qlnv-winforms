using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan.DAL
{
    class dal_DoiPass
    {
        LopDungChung lopchung;
        public dal_DoiPass()
        {
            lopchung = new LopDungChung();
        }
        public void dalDoiPass(string matkhau, string xnmatkhau, string email)
        {
            if (matkhau != xnmatkhau)
            {
                MessageBox.Show("Xác nhận lại pass chính xác!");
                return;
            }
            if (!lopchung.IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            string sqlDoiPass = "update TAIKHOAN set MatKhau = '"+ matkhau + "' where Email = '"+email+"'";
            lopchung.Nonquery(sqlDoiPass);
        }
    }
}
