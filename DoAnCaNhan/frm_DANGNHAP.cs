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

namespace DoAnCaNhan
{
    public partial class frm_DANGNHAP : Form
    {
        BLL.bll_DangNhap bllDangNhap;
        public frm_DANGNHAP()
        {
            InitializeComponent();
            bllDangNhap = new BLL.bll_DangNhap(this);
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            bllDangNhap.dangnhap_Click();
        }

        private void link_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (frm_QUENPASS form = new frm_QUENPASS())
            {
                form.ShowDialog();
            }
            this.Show();

        }

        private void link_dangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (frm_DANGKI form = new frm_DANGKI())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đóng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void pbpass_Click(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = !txtpassword.UseSystemPasswordChar;
        }
    }
    
}
