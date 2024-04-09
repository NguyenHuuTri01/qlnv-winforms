using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DoAnCaNhan
{
    public partial class frm_DANGKI : Form
    {
        BLL.bll_DangKi bllDangki;
        public frm_DANGKI()
        {
            InitializeComponent();
            bllDangki = new BLL.bll_DangKi(this);
        }
        private void btn_Dangki_Click(object sender, EventArgs e)
        {
            bllDangki.dangki_Click();
        }

        private void pbpass1_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = !txt_Password.UseSystemPasswordChar;
        }

        private void pbRePass_Click(object sender, EventArgs e)
        {
            txt_ResPassword.UseSystemPasswordChar = !txt_ResPassword.UseSystemPasswordChar;
        }
    }
}
