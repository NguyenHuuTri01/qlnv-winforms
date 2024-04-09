using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan
{
    public partial class frm_QUENPASS : Form
    {
        BLL.bll_QuenPass bllQuenPass;
        public frm_QUENPASS()
        {
            InitializeComponent();
            bllQuenPass = new BLL.bll_QuenPass(this);
        }

        private void btn_laypass_Click(object sender, EventArgs e)
        {
            bllQuenPass.quenpass_Click();
        }
    }
}
