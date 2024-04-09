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
    public partial class frm_QLNV : Form
    {
        LopDungChung lopchung;
        BLL.bll_QLNV bllQLNV;
        public frm_QLNV()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bllQLNV = new BLL.bll_QLNV(this);
        }


        private void frm_QLNV_Load(object sender, EventArgs e)
        {
            LoadPB();
            LoadDataGridView();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {

            bllQLNV.themNhanVien();
            LoadDataGridView();
        }   
        private void LoadDataGridView()
        {
            bllQLNV.loadNhanVien();
        }

        private void LoadPB()
        {
            bllQLNV.loadPB();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            bllQLNV.xoaNhanVien();
            LoadDataGridView();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            bllQLNV.capnhatNhanVien();
            LoadDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bllQLNV.datagrid_cellclick();
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            bllQLNV.demNhanVien();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            bllQLNV.timNhanVien();
        }
        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đóng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadPB();
            LoadDataGridView();
        }
    }
}
