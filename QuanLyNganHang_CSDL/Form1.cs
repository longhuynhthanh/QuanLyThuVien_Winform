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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql1 = @"select DauSach.MaSach, LoaiSach.TenLoai, DauSach.TieuDe 
                            from DauSach, LoaiSach 
                            where DauSach.MaLoai = LoaiSach.MaLoai";
            
            cmbMaSach.Enabled = false;


            cmbTieuDe.DataSource = DataProvider.LoadCSDL(sql1);
            cmbTieuDe.DisplayMember = "TieuDe";
            cmbTieuDe.ValueMember = "MaSach";

            cmbMaSach.Text = cmbTieuDe.SelectedValue.ToString();

            cmbMaSach.DataSource = DataProvider.LoadCSDL(sql1);
            cmbMaSach.DisplayMember = "MaSach";
            cmbMaSach.ValueMember = "TieuDe";
            cmbTieuDe.Text = cmbMaSach.SelectedValue.ToString();

            string sql2 = @"select * 
                            from Lop";

            cmbTenLop.DataSource = DataProvider.LoadCSDL(sql2);
            cmbTenLop.DisplayMember = "TenLop";
            cmbTenLop.ValueMember = "MaLop";
            cmbMaLop.Text = cmbTenLop.SelectedValue.ToString();
            cmbMaLop.Enabled = false;


            // Hiển thị tên trên datagidview
            dgvDanhSach.Columns.Add("MaPhieuMuon", "Mã Phiếu Mượn");
            dgvDanhSach.Columns.Add("TieuDe", "Tiêu Đề");
            dgvDanhSach.Columns.Add("MaSV", "Mã Sinh Viên");
            dgvDanhSach.Columns.Add("TenSV", "Tên Sinh Viên");
            dgvDanhSach.Columns.Add("TenLop", "Tên Lớp");
            dgvDanhSach.Columns.Add("Email", "Email");
            dgvDanhSach.Columns.Add("SDT", "SDT");
            dgvDanhSach.Columns.Add("NgayMuon", "Ngày Mượn");
            dgvDanhSach.Columns.Add("NgayTra", "Ngày Trả");

            dgvDanhSach.Columns["MaPhieuMuon"].DataPropertyName = "MaPhieuMuon";
            dgvDanhSach.Columns["TieuDe"].DataPropertyName = "TieuDe";
            dgvDanhSach.Columns["MaSV"].DataPropertyName = "MaSV";
            dgvDanhSach.Columns["TenSV"].DataPropertyName = "TenSV";
            dgvDanhSach.Columns["TenLop"].DataPropertyName = "TenLop";
            dgvDanhSach.Columns["Email"].DataPropertyName = "Email";
            dgvDanhSach.Columns["SDT"].DataPropertyName = "SDT";
            dgvDanhSach.Columns["NgayMuon"].DataPropertyName = "NgayMuon";
            dgvDanhSach.Columns["NgayTra"].DataPropertyName = "NgayTra";

            // Chỉnh độ rộng cho cột
            dgvDanhSach.Columns["MaPhieuMuon"].Width = 100;
            dgvDanhSach.Columns["TieuDe"].Width = 250;
            dgvDanhSach.Columns["MaSV"].Width = 100;
            dgvDanhSach.Columns["TenSV"].Width = 200;
            dgvDanhSach.Columns["TenLop"].Width = 200;
            dgvDanhSach.Columns["Email"].Width = 200;
            dgvDanhSach.Columns["SDT"].Width = 150;
            dgvDanhSach.Columns["NgayMuon"].Width = 150;
            dgvDanhSach.Columns["NgayTra"].Width = 150;

            // Chỉ được đọc trên datadrigview
            dgvDanhSach.ReadOnly = true;



            string sql3 = @"select PhieuMuonChiTiet.MaPhieuMuon, DauSach.TieuDe, PhieuMuon.MaSV, TheSinhVien.TenSV, Lop.TenLop, TheSinhVien.Email, TheSinhVien.SDT, PhieuMuon.NgayMuon, PhieuMuon.NgayTra 
                            from PhieuMuonChiTiet, PhieuMuon, TheSinhVien, DauSach, Lop
                            where PhieuMuonChiTiet.MaSach = DauSach.MaSach and PhieuMuonChiTiet.MaPhieuMuon = PhieuMuon.MaPhieuMuon and PhieuMuon.MaSV = TheSinhVien.MaSV and TheSinhVien.MaLop = Lop.MaLop";

            dgvDanhSach.RowHeadersVisible = false;
            dgvDanhSach.AllowUserToAddRows = false;

            DataTable dt = DataProvider.LoadCSDL(sql3);

            dgvDanhSach.DataSource = dt;

            // Chỉnh lại hiển thị trên datetime Picker
            dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            dtpNgayMuon.Format = DateTimePickerFormat.Custom;

            dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            dtpNgayTra.Format = DateTimePickerFormat.Custom;

        }


        private void cmbTieuDe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbMaSach.Text = cmbTieuDe.SelectedValue.ToString();
        }

        private void cmbTieuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMaSach.Text = cmbTieuDe.SelectedValue.ToString();
        }

        private void cmbTenLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbMaLop.Text = cmbTenLop.SelectedValue.ToString();
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMaLop.Text = cmbTenLop.SelectedValue.ToString();
        }

        private void btnLoadCSDL_Click(object sender, EventArgs e)
        {
            string sql3 = @"select PhieuMuonChiTiet.MaPhieuMuon, DauSach.TieuDe, PhieuMuon.MaSV, TheSinhVien.TenSV, Lop.TenLop, TheSinhVien.Email, TheSinhVien.SDT, PhieuMuon.NgayMuon, PhieuMuon.NgayTra 
                            from PhieuMuonChiTiet, PhieuMuon, TheSinhVien, DauSach, Lop
                            where PhieuMuonChiTiet.MaSach = DauSach.MaSach and PhieuMuonChiTiet.MaPhieuMuon = PhieuMuon.MaPhieuMuon and PhieuMuon.MaSV = TheSinhVien.MaSV and TheSinhVien.MaLop = Lop.MaLop";

            DataTable dt = DataProvider.LoadCSDL(sql3);

            dgvDanhSach.DataSource = dt;
        }

        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            txtMaPhieuMuon.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            cmbTieuDe.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            txtMaSV.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            txtTenSV.Text = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
            cmbTenLop.Text = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvDanhSach.CurrentRow.Cells[5].Value.ToString();
            txtSdt.Text = dgvDanhSach.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Mã SV", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
            }
            else if (txtTenSV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Tên Sinh Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSV.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Email", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
            else if (txtSdt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào SĐT", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
            }
            else if (txtMaPhieuMuon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào mã phiếu mượn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieuMuon.Focus();
            }
            else
            {
                try
                {
                    string sql1 = @"INSERT INTO TheSinhVien(MaSV, MaLop, TenSV, Email, SDT) 
                                    values ('" + txtMaSV.Text + "', '" + cmbMaLop.Text + "', N'" + txtTenSV.Text + "', '" + txtEmail.Text + "', '" + txtSdt.Text + "')";
                    string sql2 = @"INSERT INTO PhieuMuon(MaPhieuMuon, MaSV, TinhTrang, NgayTra, NgayMuon) 
                                    values('" + txtMaPhieuMuon.Text + "', '" + txtMaSV.Text + "', 0, '" + /*dtpNgayTra.Value.ToString() +*/ "' , '" /* dtpNgayMuon.Value.ToString() */+ "' )";
                    string sql3 = @"INSERT INTO PhieuMuonChiTiet(MaPhieuMuon, MaSach, GhiChu)   
                                    values ('" + txtMaPhieuMuon.Text + "', '" + cmbMaSach.Text + "', N'Không có thông tin gì')";
                    string sql4 = @"select * from TheSinhVien";
                    string sql5 = @"select * from PhieuMuon";
                    int Result1;
                    int Result2;
                    int Result3;
                    bool check1 = false;
                    bool check2 = false;
                    DataTable dt = DataProvider.LoadCSDL(sql4);
                    DataTable dt2 = DataProvider.LoadCSDL(sql5);
                    int SoLuong = dt.Rows.Count;
                    for (int i = 0; i < SoLuong; i++)
                    {
                        string MaSo = dt.Rows[i][0].ToString();
                        if (txtMaSV.Text == MaSo)
                        {
                            check1 = true;
                        }
                    }
                    int SoLuong2 = dt2.Rows.Count;
                    for (int i = 0; i < SoLuong2; i++)
                    {
                        string MaPhieuMuon = dt2.Rows[i][0].ToString();
                        if (txtMaPhieuMuon.Text == MaPhieuMuon)
                        {
                            check2 = true;
                        }
                    }
                    if (check1 == false)
                    {
                        Result1 = DataProvider.Change(sql1);
                        Result2 = DataProvider.Change(sql2);
                        Result3 = DataProvider.Change(sql3);
                        if (Result1 > 0 && Result2 > 0 && Result3 > 0)
                        {
                            MessageBox.Show("Bạn đã thêm thành công");
                        }
                    }
                    else if (check1 == true && check2 == false)
                    {
                        Result2 = DataProvider.Change(sql2);
                        Result3 = DataProvider.Change(sql3);

                        if (Result2 > 0 && Result3 > 0)
                        {
                            MessageBox.Show("Thêm thành công");
                        }
                    }
                    else if (check1 == true && check2 == true)
                    {
                        Result3 = DataProvider.Change(sql3);
                        if (Result3 > 0)
                        {
                            MessageBox.Show("Thêm thành công");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Bị lỗi gì rồi bạn hãy kiểm tra lại");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.RowCount > 0)
            {
                try
                {
                    string sql1 = @"delete from PhieuMuonChiTiet where PhieuMuonChiTiet.MaPhieuMuon = '" + txtMaPhieuMuon.Text + "' and PhieuMuonChiTiet.MaSach = '" + cmbMaSach.Text + "'";

                    string sql4 = @"select * from PhieuMuonChiTiet";

                    int Result = DataProvider.Change(sql1);
                    int Result2;
                    bool check = false;
                    string MaPhieuMuon = txtMaPhieuMuon.Text;
                    string MaSV = txtMaSV.Text;

                    string sql2 = @"delete from PhieuMuon where PhieuMuon.MaPhieuMuon = '" + MaPhieuMuon + "'";
                    string sql3 = @"delete from TheSinhVien where TheSinhVien.MaSV = '" + MaSV + "'";

                    DataTable dt = DataProvider.LoadCSDL(sql4);
                    int SoLuong = dt.Rows.Count;
                    for (int i = 0; i < SoLuong; i++)
                    {
                        if (dt.Rows[i][0].ToString() == MaPhieuMuon)
                        {
                            check = true;
                            break;
                        }
                    }
                    if (Result > 0 && check == true)
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                    }
                    else if (Result > 0 && check == false)
                    {
                        Result2 = DataProvider.Change(sql2);
                        int Result3 = DataProvider.Change(sql3);
                        if (Result2 > 0 && Result3 > 0)
                        {
                            MessageBox.Show("Bạn đã xóa thành công");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Có gì đó không ổn, bạn hãy kiểm tra lại");
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertBook_Click(object sender, EventArgs e)
        {
            InsertBook insertbook = new InsertBook();
            insertbook.ShowDialog();
            string sql1 = @"select DauSach.MaSach, LoaiSach.TenLoai, DauSach.TieuDe 
                            from DauSach, LoaiSach
                            where DauSach.MaLoai = LoaiSach.MaLoai";
            cmbTieuDe.DataSource = DataProvider.LoadCSDL(sql1);
            cmbTieuDe.DisplayMember = "TieuDe";
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBook deletebook = new DeleteBook();
            deletebook.ShowDialog();
            string sql1 = @"select DauSach.MaSach, LoaiSach.TenLoai, DauSach.TieuDe 
                            from DauSach, LoaiSach 
                            where DauSach.MaLoai = LoaiSach.MaLoai";
            cmbTieuDe.DataSource = DataProvider.LoadCSDL(sql1);
            cmbTieuDe.DisplayMember = "TieuDe";
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            UpdateBook updatebook = new UpdateBook();
            updatebook.ShowDialog();
            string sql1 = @"select DauSach.MaSach, LoaiSach.TenLoai, DauSach.TieuDe 
                            from DauSach, LoaiSach 
                            where DauSach.MaLoai = LoaiSach.MaLoai";
            cmbTieuDe.DataSource = DataProvider.LoadCSDL(sql1);
            cmbTieuDe.DisplayMember = "TieuDe";
        }
    }
}
