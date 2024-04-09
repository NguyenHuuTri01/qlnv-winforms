using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCaNhan.BLL
{
    class bll_DoiPass
    {
        DAL.dal_DoiPass dalDoiPass;
        frm_DoiPass dp;
        public bll_DoiPass(frm_DoiPass DANGKI)
        {
            dalDoiPass = new DAL.dal_DoiPass();
            dp = DANGKI;
        }
        public void bllDoiPass()
        {
            dalDoiPass.dalDoiPass(dp.txt_Password.Text,dp.txt_ResPassword.Text,dp.txt_Email.Text);
        }
    }
}
