using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan.BLL
{
    class bll_QuenPass
    {
        DAL.dal_QuenPass dalQuenPass;
        frm_QUENPASS quenpass;
        public bll_QuenPass(frm_QUENPASS QUENPASS)
        {
            dalQuenPass = new DAL.dal_QuenPass();
            quenpass = QUENPASS;
        }
        public void quenpass_Click()
        {
            if (quenpass.txt_Emaill.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng kí!");
                return;
            }
            int check = dalQuenPass.checkEmail(quenpass.txt_Emaill.Text);
            if (check == 0)
            {
                quenpass.lb_pass.Text = "Email chưa được đăng kí ";
                return;
            }
            else
            {
                quenpass.datagrid.DataSource = dalQuenPass.loadThongTinTaiKhoan(quenpass.txt_Emaill.Text);
            }
        }
    }
}
