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
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void UpdateBook_Load(object sender, EventArgs e)
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

            // Hiển thị tên Loại sách
            string sql2 = @"select * from LoaiSach";
            cmbTenLoai.DataSource = DataProvider.LoadCSDL(sql2);
            cmbTenLoai.DisplayMember = "TenLoai";
            cmbTenLoai.ValueMember = "MaLoai";
            cmbMaLoai.Text = cmbTenLoai.SelectedValue.ToString();

            cmbMaLoai.Enabled = false;
            txtMaSach.Enabled = false;
        }

        private void cmbTenLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMaLoai.Text = cmbTenLoai.SelectedValue.ToString();
        }

        private void cmbTenLoai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbMaLoai.Text = cmbTenLoai.SelectedValue.ToString();
        }

        private void dgvListBook_SelectionChanged(object sender, EventArgs e)
        {
            txtMaSach.Text = dgvListBook.CurrentRow.Cells[0].Value.ToString();
            cmbTenLoai.Text = dgvListBook.CurrentRow.Cells[1].Value.ToString();
            txtNhaXuatBan.Text = dgvListBook.CurrentRow.Cells[2].Value.ToString();
            txtTacGia.Text = dgvListBook.CurrentRow.Cells[3].Value.ToString();
            txtTieuDe.Text = dgvListBook.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"update DauSach 
                                set MaLoai = '" + cmbMaLoai.Text + "', NhaXuatBan = '" + txtNhaXuatBan.Text + "', TieuDe = N'" + txtTieuDe.Text + "', TacGia = '" + txtTacGia.Text + "' where MaSach = '" + txtMaSach.Text + "'";
                int Result = DataProvider.Change(sql);
                if (Result > 0)
                {
                    MessageBox.Show("Bạn đã Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Có thể đã xảy ra lỗi gì đó, bạn hãy kiểm tra lại.");
            }

        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            string sql = @"select DauSach.MaSach, LoaiSach.TenLoai, DauSach.NhaXuatBan, DauSach.TacGia, DauSach.TieuDe 
                            from DauSach, LoaiSach 
                            where DauSach.MaLoai = LoaiSach.MaLoai";
            dgvListBook.DataSource = DataProvider.LoadCSDL(sql);
        }
    }
}
