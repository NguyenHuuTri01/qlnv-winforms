using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCaNhan.BLL
{
    class bll_QLNV
    {
        DAL.dal_QLNV dalQLNV;
        frm_QLNV qlnv;
        public bll_QLNV(frm_QLNV QLNV)
        {
            dalQLNV = new DAL.dal_QLNV();
            qlnv = QLNV;
        }
        public void loadPB()
        {
            qlnv.cb_phongban.DataSource = dalQLNV.LoadPB();
            qlnv.cb_phongban.DisplayMember = "TENPHONGBAN";
            qlnv.cb_phongban.ValueMember = "MAPHONGBAN";
        }
        public void loadNhanVien()
        {
            qlnv.dataGridView1.DataSource = dalQLNV.LoadNhanVien();
        }
        public void themNhanVien()
        {
            dalQLNV.themNV(qlnv.txt_MSNV.Text, qlnv.txt_Hoten.Text, qlnv.dateTimePicker1.Value, qlnv.txt_Diachi.Text, qlnv.cb_phongban.SelectedValue, qlnv.txt_gioitinh.Text);
        }
        public void capnhatNhanVien()
        {
            dalQLNV.capnhatNV(qlnv.txt_Hoten.Text, qlnv.dateTimePicker1.Value, qlnv.txt_Diachi.Text, qlnv.cb_phongban.SelectedValue, qlnv.txt_gioitinh.Text, qlnv.txt_MSNV.Text);
        }
        public void xoaNhanVien()
        {
            dalQLNV.xoaNV(qlnv.txt_MSNV.Text);
        }
        public void datagrid_cellclick()
        {
            qlnv.txt_MSNV.Text = qlnv.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            qlnv.txt_Hoten.Text = qlnv.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            qlnv.dateTimePicker1.Text = qlnv.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            qlnv.cb_phongban.SelectedValue = qlnv.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            qlnv.txt_Diachi.Text = qlnv.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            qlnv.txt_gioitinh.Text = qlnv.dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        public void demNhanVien()
        {
            qlnv.txt_Dem.Text = dalQLNV.demNV().ToString();
        }
        public void timNhanVien()
        {
            qlnv.dataGridView1.DataSource = dalQLNV.timNV(qlnv.txt_Tim.Text);
        }
    }
}
