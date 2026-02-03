using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace quanLiXeBuyt.DuLieu
{
    public class KetNoiCSDL
    {
        // Thay mật khẩu MySQL của bạn vào đây
        private string chuoiKetNoi = "Server=localhost;Database=QuanLyXeBuyt;Uid=root;Pwd=123456;Charset=utf8mb4";

        public MySqlConnection LayKetNoi()
        {
            return new MySqlConnection(chuoiKetNoi);
        }

        // Hàm lấy dữ liệu (đổ vào DataGridView, ComboBox...)
        public DataTable LayDuLieu(string sql)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = LayKetNoi())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Hàm thực thi (Thêm, Xóa, Sửa)
        public int ThucThi(string sql, MySqlParameter[] thamSo = null)
        {
            using (MySqlConnection conn = LayKetNoi())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (thamSo != null) cmd.Parameters.AddRange(thamSo);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}