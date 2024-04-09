using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan
{
    public partial class frm_DoiPass : Form
    {
        BLL.bll_DoiPass blldoipass;
        public frm_DoiPass()
        {
            InitializeComponent();
            blldoipass = new BLL.bll_DoiPass(this);
        }

        private void pbpass1_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = !txt_Password.UseSystemPasswordChar;
        }

        private void pbRePass_Click(object sender, EventArgs e)
        {
            txt_ResPassword.UseSystemPasswordChar = !txt_ResPassword.UseSystemPasswordChar;
        }

        private void btn_Dangki_Click(object sender, EventArgs e)
        {
            blldoipass.bllDoiPass();
        }
    }
}
