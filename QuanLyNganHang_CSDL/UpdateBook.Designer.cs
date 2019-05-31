namespace QuanLyThuVien_CSDL
{
    partial class UpdateBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoadDB = new System.Windows.Forms.Button();
            this.dgvListBook = new System.Windows.Forms.DataGridView();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTenLoai = new System.Windows.Forms.ComboBox();
            this.cmbMaLoai = new System.Windows.Forms.ComboBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadDB);
            this.groupBox2.Controls.Add(this.dgvListBook);
            this.groupBox2.Controls.Add(this.btnUpdateBook);
            this.groupBox2.Location = new System.Drawing.Point(68, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 329);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sách Hiện Có Trong Thư Viện";
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.BackColor = System.Drawing.Color.White;
            this.btnLoadDB.Location = new System.Drawing.Point(6, 198);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(163, 70);
            this.btnLoadDB.TabIndex = 15;
            this.btnLoadDB.Text = "Load Database";
            this.btnLoadDB.UseVisualStyleBackColor = false;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // dgvListBook
            // 
            this.dgvListBook.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBook.GridColor = System.Drawing.Color.Black;
            this.dgvListBook.Location = new System.Drawing.Point(173, 25);
            this.dgvListBook.MultiSelect = false;
            this.dgvListBook.Name = "dgvListBook";
            this.dgvListBook.ReadOnly = true;
            this.dgvListBook.Size = new System.Drawing.Size(805, 298);
            this.dgvListBook.TabIndex = 0;
            this.dgvListBook.SelectionChanged += new System.EventHandler(this.dgvListBook_SelectionChanged);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.White;
            this.btnUpdateBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateBook.Location = new System.Drawing.Point(6, 73);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(163, 70);
            this.btnUpdateBook.TabIndex = 12;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTenLoai);
            this.groupBox1.Controls.Add(this.cmbMaLoai);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTieuDe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNhaXuatBan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(68, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 197);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách ";
            // 
            // cmbTenLoai
            // 
            this.cmbTenLoai.FormattingEnabled = true;
            this.cmbTenLoai.Location = new System.Drawing.Point(714, 49);
            this.cmbTenLoai.Name = "cmbTenLoai";
            this.cmbTenLoai.Size = new System.Drawing.Size(233, 28);
            this.cmbTenLoai.TabIndex = 25;
            this.cmbTenLoai.SelectedIndexChanged += new System.EventHandler(this.cmbTenLoai_SelectedIndexChanged);
            this.cmbTenLoai.SelectionChangeCommitted += new System.EventHandler(this.cmbTenLoai_SelectionChangeCommitted);
            // 
            // cmbMaLoai
            // 
            this.cmbMaLoai.FormattingEnabled = true;
            this.cmbMaLoai.Location = new System.Drawing.Point(447, 49);
            this.cmbMaLoai.Name = "cmbMaLoai";
            this.cmbMaLoai.Size = new System.Drawing.Size(164, 28);
            this.cmbMaLoai.TabIndex = 24;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(785, 121);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(5);
            this.txtTacGia.Multiline = true;
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(164, 29);
            this.txtTacGia.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tác Giả";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuDe.Location = new System.Drawing.Point(458, 121);
            this.txtTieuDe.Margin = new System.Windows.Forms.Padding(5);
            this.txtTieuDe.Multiline = true;
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(228, 29);
            this.txtTieuDe.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tiêu Đề";
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Location = new System.Drawing.Point(173, 118);
            this.txtNhaXuatBan.Margin = new System.Windows.Forms.Padding(5);
            this.txtNhaXuatBan.Multiline = true;
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(164, 29);
            this.txtNhaXuatBan.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nhà Xuất Bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Loại";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(173, 46);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaSach.Multiline = true;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(164, 29);
            this.txtMaSach.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã Sách";
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1151, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UpdateBook";
            this.Text = "UpdateBook";
            this.Load += new System.EventHandler(this.UpdateBook_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoadDB;
        private System.Windows.Forms.DataGridView dgvListBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTenLoai;
        private System.Windows.Forms.ComboBox cmbMaLoai;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label1;
    }
}