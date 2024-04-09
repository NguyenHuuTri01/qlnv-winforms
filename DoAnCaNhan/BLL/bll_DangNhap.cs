using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan.BLL
{
    class bll_DangNhap
    {
        DAL.dal_DangNhap dalDangNhap;
        frm_DANGNHAP dn;
        public bll_DangNhap(frm_DANGNHAP DANGNHAP)
        {
            dalDangNhap = new DAL.dal_DangNhap();
            dn = DANGNHAP;
        }
        public void dangnhap_Click()
        {
            if (dn.txt_taikhoan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập");
                return;
            }
            else if (dn.txtpassword.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            int ketqua = (int)dalDangNhap.checkTaiKhoan(dn.txt_taikhoan.Text, dn.txtpassword.Text);
            if (ketqua >= 1)
            {
                dn.Hide();
                frm_Main frm = new frm_Main();
                frm.Show();
            }
            else MessageBox.Show("Nhập sai tên tài khoản hoặc mật khẩu!");
        }
    }
}
