namespace QuanLyThuVien_CSDL
{
    partial class DeleteBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadDB = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.dgvListBook = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadDB);
            this.groupBox1.Controls.Add(this.btnDeleteBook);
            this.groupBox1.Controls.Add(this.dgvListBook);
            this.groupBox1.Location = new System.Drawing.Point(14, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(946, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sách Hiện Có Trong Thư Viện";
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.BackColor = System.Drawing.Color.White;
            this.btnLoadDB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadDB.Location = new System.Drawing.Point(8, 169);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(125, 70);
            this.btnLoadDB.TabIndex = 14;
            this.btnLoadDB.Text = "Load Database";
            this.btnLoadDB.UseVisualStyleBackColor = false;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.White;
            this.btnDeleteBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteBook.Location = new System.Drawing.Point(8, 68);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(125, 70);
            this.btnDeleteBook.TabIndex = 13;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // dgvListBook
            // 
            this.dgvListBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBook.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvListBook.Location = new System.Drawing.Point(139, 27);
            this.dgvListBook.Name = "dgvListBook";
            this.dgvListBook.Size = new System.Drawing.Size(799, 267);
            this.dgvListBook.TabIndex = 0;
            // 
            // DeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(974, 409);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DeleteBook";
            this.Text = "DeleteBook";
            this.Load += new System.EventHandler(this.DeleteBook_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnLoadDB;
    }
}