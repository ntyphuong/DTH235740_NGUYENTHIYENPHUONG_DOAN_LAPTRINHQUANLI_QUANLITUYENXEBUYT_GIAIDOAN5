using MySql.Data.MySqlClient;
using quanLiXeBuyt.DuLieu;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace quanLiXeBuyt.GiaoDien
{
    public partial class ucQuanLyXe : UserControl
    {
        KetNoiCSDL db = new KetNoiCSDL();
        int busID_DangChon = -1;

        public ucQuanLyXe()
        {
            InitializeComponent();
            LoadDataXe();
        }

        private void LoadDataXe()
        {
            string sql = "SELECT * FROM Buses";
            dgvXe.DataSource = db.LayDuLieu(sql);

            dgvXe.Columns["BusID"].HeaderText = "Mã Xe";
            dgvXe.Columns["LicensePlate"].HeaderText = "Biển Số Xe";
            dgvXe.Columns["Status"].HeaderText = "Trạng Thái";
        }
        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvXe.Rows[e.RowIndex];
                busID_DangChon = Convert.ToInt32(row.Cells["BusID"].Value);
                txtBienSo.Text = row.Cells["LicensePlate"].Value.ToString();
                cboTrangThai.Text = row.Cells["Status"].Value.ToString();

                string tenFileAnh = row.Cells["ImagePath"].Value.ToString();
                if (!string.IsNullOrEmpty(tenFileAnh))
                {
                    string fullPath = System.IO.Path.Combine(Application.StartupPath, "images", tenFileAnh);
                    if (System.IO.File.Exists(fullPath))
                    {
                        // Dùng cách này để không bị khóa file ảnh khi đang mở
                        using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                        {
                            picXeBus.Image = Image.FromStream(fs);
                        }
                    }
                    else { picXeBus.Image = null; }
                }
                else { picXeBus.Image = null; }
            }
        }
        private void btnThemXe_Click_1(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Buses (LicensePlate, Status) VALUES (@plate, @status)";
            MySqlParameter[] p = {
                new MySqlParameter("@plate", txtBienSo.Text),
                new MySqlParameter("@status", cboTrangThai.Text)
            };

            if (db.ThucThi(sql, p) > 0)
            {
                MessageBox.Show("Thêm xe mới thành công!");
                LoadDataXe();
            }
        }

        private void btnXoaXe_Click_1(object sender, EventArgs e)
        {
            if (busID_DangChon == -1) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa xe này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM Buses WHERE BusID = @id";
                MySqlParameter[] p = { new MySqlParameter("@id", busID_DangChon) };

                if (db.ThucThi(sql, p) > 0)
                {
                    LoadDataXe();
                    busID_DangChon = -1;
                }
            }
        }

        private void btnSuaXe_Click_1(object sender, EventArgs e)
        {
            if (busID_DangChon == -1) return;

            string sql = "UPDATE Buses SET LicensePlate = @plate, Status = @status, ImagePath = @img WHERE BusID = @id";

            MySqlParameter[] p = {
            new MySqlParameter("@plate", txtBienSo.Text),
            new MySqlParameter("@status", cboTrangThai.Text),
            new MySqlParameter("@img", picXeBus.Tag != null ? picXeBus.Tag.ToString() : ""),
            new MySqlParameter("@id", busID_DangChon)
        };

            if (db.ThucThi(sql, p) > 0)
            {
                MessageBox.Show("Cập nhật thông tin và ảnh thành công!");
                LoadDataXe();
            }
        }
        private void picXeBus_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh xe buýt";
                ofd.Filter = "Image Files(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 1. Hiển thị ảnh tạm thời lên PictureBox để bà xem trước
                    picXeBus.Image = Image.FromFile(ofd.FileName);

                    // 2. Lấy đường dẫn thư mục images trong project của bà
                    // Nó sẽ tìm đến thư mục thực tế trên ổ cứng
                    string projectPath = Application.StartupPath; // Thư mục bin/Debug
                    string folderPath = System.IO.Path.Combine(projectPath, "images");

                    // Tạo thư mục images nếu chưa tồn tại (đề phòng thôi)
                    if (!System.IO.Directory.Exists(folderPath))
                    {
                        System.IO.Directory.CreateDirectory(folderPath);
                    }

                    // 3. Tạo tên file mới để tránh trùng (ví dụ: bus_68A33553.jpg)
                    string fileName = "bus_" + txtBienSo.Text.Replace("-", "").Replace(".", "") + System.IO.Path.GetExtension(ofd.FileName);
                    string savePath = System.IO.Path.Combine(folderPath, fileName);

                    // 4. Copy ảnh từ máy vào thư mục images của dự án
                    try
                    {
                        System.IO.File.Copy(ofd.FileName, savePath, true); // true là để ghi đè nếu trùng tên

                        // Lưu cái 'fileName' này vào biến tạm hoặc TextBox ẩn để tí nữa Update vào Database
                        picXeBus.Tag = fileName; // Tui mượn tạm thuộc tính Tag để cất cái tên file nhé
                        MessageBox.Show("Đã chọn ảnh và lưu vào hệ thống!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi lưu ảnh: " + ex.Message);
                    }
                }
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }        
    }
}