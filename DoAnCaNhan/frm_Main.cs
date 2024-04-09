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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QLNV frmQLNV = new frm_QLNV();
            frmQLNV.MdiParent = this;
            frmQLNV.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DoiPass frmDoiPass = new frm_DoiPass();
            frmDoiPass.MdiParent = this;
            frmDoiPass.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_DANGNHAP frmdangnhap = new frm_DANGNHAP();
            frmdangnhap.Show();
        }
    }
}
