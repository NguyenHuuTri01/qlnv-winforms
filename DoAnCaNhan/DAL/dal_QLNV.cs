using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCaNhan.DAL
{
    class dal_QLNV
    {
        LopDungChung lopchung;
        public dal_QLNV()
        {
            lopchung = new LopDungChung();
        }
        public DataTable LoadPB()
        {
            string sqlloadPB = "select * from PHONGBAN";
            return lopchung.LoadData(sqlloadPB);
        }
        public DataTable LoadNhanVien()
        {
            string sqlNV = "select * from NHANVIEN";
            return lopchung.LoadData(sqlNV);
        }
        public void themNV(string msnv, string hoten, DateTime ngaysinh, string diachi, object maphongban, string gioitinh)
        {
            string sqlThem = "insert into NHANVIEN values('" + msnv + "', N'" + hoten + "',  Convert(Datetime,'" + ngaysinh + "',103), N'" + diachi + "','" + maphongban + "',N'" + gioitinh + "')";
            lopchung.Nonquery(sqlThem);
        }
        public void capnhatNV(string hoten, DateTime ngaysinh, string diachi, object maphongban, string gioitinh, string msnv)
        {
            string sqlSua = "update NHANVIEN set HOTEN = N'" + hoten +
                "',MAPHONGBAN = '" + maphongban +
                "',DIACHI = N'" + diachi +
                "',NGAYSINH = Convert(Datetime,'" + ngaysinh+ "',103)" +
                "',GIOITINH = N'" + gioitinh +
                "' where MSNV = '" + msnv + "'";
            lopchung.Nonquery(sqlSua);
        }
        public void xoaNV(string msnv)
        {
            string sqlXoa = "delete from NHANVIEN where MSNV = '" + msnv + "'";
            lopchung.Nonquery(sqlXoa);
        }
        public int demNV()
        {
            string sqlDem = "select count (*) from NHANVIEN";
            return (int)lopchung.Scalar(sqlDem);
        }
        public DataTable timNV(string msnv)
        {
            string sqlTim = "select * from NHANVIEN where MSNV like '%" + msnv + "%' ";
            return lopchung.LoadData(sqlTim);
        }
    }
}
