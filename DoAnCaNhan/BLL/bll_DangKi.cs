using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan.BLL
{
    class bll_DangKi
    {
        DAL.dal_DangKi dalDangKi;
        frm_DANGKI dk;
        public bll_DangKi(frm_DANGKI DANGKI)
        {
            dalDangKi = new DAL.dal_DangKi();
            dk = DANGKI;
        }
        public void dangki_Click()
        {
            dalDangKi.dalDangKi(dk.txt_tenTK.Text, dk.txt_Password.Text, dk.txt_ResPassword.Text, dk.txt_Email.Text);
        }
    }
}
