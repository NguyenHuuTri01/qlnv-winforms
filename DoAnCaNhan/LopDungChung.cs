using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace DoAnCaNhan
{
    class LopDungChung
    {
        
        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AppUser\SaveCode\LT_UngDung\DoAnCaNhan\DoAnCaNhan\QLNHANVIEN.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(chuoiketnoi);
        }
        public DataTable LoadData(string sqlData)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlData, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void Nonquery(string sql)
        {
            
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            try
            {          
                int ketqua = comm.ExecuteNonQuery();
                if (ketqua >=1)
                {
                    MessageBox.Show(" thành công");
                }
                else
                {
                    MessageBox.Show(" Chưa có mã ");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Trùng mã");
            }
            conn.Close();
        }
        public object Scalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return email == addr.Address;
            }
            catch
            {
                return false;
            }
        }
    }
    
}