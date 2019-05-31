using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_CSDL
{
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void DeleteBook_Load(object sender, EventArgs e)
        {
            string sql = @"select DauSach.MaSach, LoaiSach.TenLoai, DauSach.NhaXuatBan, DauSach.TacGia, DauSach.TieuDe 
                            from DauSach, LoaiSach 
                            where DauSach.MaLoai = LoaiSach.MaLoai";

            dgvListBook.Columns.Add("MaSach", "Mã Sách");
            dgvListBook.Columns.Add("TenLoai", "Tên Loại");
            dgvListBook.Columns.Add("NhaXuatBan", "Nhà Xuất Bản");
            dgvListBook.Columns.Add("TacGia", "Tác Giả");
            dgvListBook.Columns.Add("TieuDe", "Tiêu Đề");

            dgvListBook.Columns["MaSach"].DataPropertyName = "MaSach";
            dgvListBook.Columns["TenLoai"].DataPropertyName = "TenLoai";
            dgvListBook.Columns["NhaXuatBan"].DataPropertyName = "NhaXuatBan";
            dgvListBook.Columns["TacGia"].DataPropertyName = "TacGia";
            dgvListBook.Columns["TieuDe"].DataPropertyName = "TieuDe";

            dgvListBook.Columns["Masach"].Width = 100;
            dgvListBook.Columns["TenLoai"].Width = 250;
            dgvListBook.Columns["NhaXuatBan"].Width = 200;
            dgvListBook.Columns["TacGia"].Width = 100;
            dgvListBook.Columns["TieuDe"].Width = 250;

            dgvListBook.RowHeadersVisible = false;
            dgvListBook.AllowUserToAddRows = false;

            DataTable dt = DataProvider.LoadCSDL(sql);
            dgvListBook.DataSource = dt;
            dgvListBook.ReadOnly = true;
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            string sql = @"select DauSach.MaSach, LoaiSach.TenLoai, DauSach.NhaXuatBan, DauSach.TacGia, DauSach.TieuDe 
                            from DauSach, LoaiSach 
                            where DauSach.MaLoai = LoaiSach.MaLoai";
            dgvListBook.DataSource = DataProvider.LoadCSDL(sql);
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                string MaSach = dgvListBook.CurrentRow.Cells[0].Value.ToString();

                string sql = @"delete from DauSach where DauSach.MaSach = '" + MaSach + "'";
                int Result = DataProvider.Change(sql);
                if (Result > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Có thể do mã sách đã trùng, bạn hãy kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
