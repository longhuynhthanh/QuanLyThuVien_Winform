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
    public partial class InsertBook : Form
    {
        public InsertBook()
        {
            InitializeComponent();
        }

        private void InsertBook_Load(object sender, EventArgs e)
        {
            string sql = @"select DauSach.MaSach, LoaiSach.TenLoai, DauSach.NhaXuatBan, DauSach.TacGia, DauSach.TieuDe 
                            from DauSach, LoaiSach 
                            where DauSach.MaLoai = LoaiSach.MaLoai";

            dgvListSach.Columns.Add("MaSach", "Mã Sách");
            dgvListSach.Columns.Add("TenLoai", "Tên Loại");
            dgvListSach.Columns.Add("NhaXuatBan", "Nhà Xuất Bản");
            dgvListSach.Columns.Add("TacGia", "Tác Giả");
            dgvListSach.Columns.Add("TieuDe", "Tiêu Đề");

            dgvListSach.Columns["MaSach"].DataPropertyName = "MaSach";
            dgvListSach.Columns["TenLoai"].DataPropertyName = "TenLoai";
            dgvListSach.Columns["NhaXuatBan"].DataPropertyName = "NhaXuatBan";
            dgvListSach.Columns["TacGia"].DataPropertyName = "TacGia";
            dgvListSach.Columns["TieuDe"].DataPropertyName = "TieuDe";

            dgvListSach.Columns["Masach"].Width = 100;
            dgvListSach.Columns["TenLoai"].Width = 250;
            dgvListSach.Columns["NhaXuatBan"].Width = 200;
            dgvListSach.Columns["TacGia"].Width = 100;
            dgvListSach.Columns["TieuDe"].Width = 250;

            dgvListSach.RowHeadersVisible = false;
            dgvListSach.AllowUserToAddRows = false;

            DataTable dt = DataProvider.LoadCSDL(sql);
            dgvListSach.DataSource = dt;
            dgvListSach.ReadOnly = true;


            // Hiển thị tên Loại sách
            string sql2 = @"select * from LoaiSach";
            cmbTenLoai.DataSource = DataProvider.LoadCSDL(sql2);
            cmbTenLoai.DisplayMember = "TenLoai";
            cmbTenLoai.ValueMember = "MaLoai";
            cmbMaLoai.Text = cmbTenLoai.SelectedValue.ToString();

            cmbMaLoai.Enabled = false;
        }

        private void btnInsertDB_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Mã sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
            }
            else if (txtNhaXuatBan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Nhà Xuất Bản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhaXuatBan.Focus();
            }
            else if (txtTacGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Tên Tác Giả", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTacGia.Focus();
            }
            else if (txtTieuDe.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Tiêu Đề", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTieuDe.Focus();
            }
            else
            {
                try
                {
                    string sql = @"insert into DauSach(MaSach, MaLoai, NhaXuatBan, TieuDe, TacGia) values ('" + txtMaSach.Text + "', '" + cmbMaLoai.Text + "', '" + txtNhaXuatBan.Text + "', N'" + txtTieuDe.Text + "', '" + txtTacGia.Text + "')";
                    int Result = DataProvider.Change(sql);
                    if (Result > 0)
                    {
                        MessageBox.Show("Bạn đã thêm sách mới vào thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaSach.Clear();
                        txtNhaXuatBan.Clear();
                        txtTacGia.Clear();
                        txtTieuDe.Clear();
                        txtMaSach.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Có thể do Mã Sách đã bị trùng bạn hãy kiểm tra lại.");
                }

            }
        }

        private void cmbTenLoai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbMaLoai.Text = cmbTenLoai.SelectedValue.ToString();
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            string sql = @"select DauSach.MaSach, LoaiSach.TenLoai, DauSach.NhaXuatBan, DauSach.TacGia, DauSach.TieuDe 
                            from DauSach, LoaiSach 
                            where DauSach.MaLoai = LoaiSach.MaLoai";
            dgvListSach.DataSource = DataProvider.LoadCSDL(sql);

        }
        // Sự kiện khi click vào một dòng trên DatagridView thì sẽ hiển thị các thông tin trên textbox.
        private void dgvListSach_SelectionChanged(object sender, EventArgs e)
        {
            txtMaSach.Text = dgvListSach.CurrentRow.Cells[0].Value.ToString();
            cmbTenLoai.Text = dgvListSach.CurrentRow.Cells[1].Value.ToString();
            txtNhaXuatBan.Text = dgvListSach.CurrentRow.Cells[2].Value.ToString();
            txtTacGia.Text = dgvListSach.CurrentRow.Cells[3].Value.ToString();
            txtTieuDe.Text = dgvListSach.CurrentRow.Cells[4].Value.ToString();
        }

        private void cmbTenLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMaLoai.Text = cmbTenLoai.SelectedValue.ToString();
        }
    }
}
