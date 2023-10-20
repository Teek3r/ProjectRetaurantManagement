namespace ProjectRetaurantManagement
{
    partial class FormTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTaiKhoan = new System.Windows.Forms.DataGridView();
            this.buttonSuaNhanVien = new System.Windows.Forms.Button();
            this.buttonXoaNhanVien = new System.Windows.Forms.Button();
            this.buttonThemNhanVien = new System.Windows.Forms.Button();
            this.textBoxLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxChucVu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTenNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaNhanVien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTaiKhoan
            // 
            this.dataGridViewTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTaiKhoan.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTaiKhoan.Location = new System.Drawing.Point(18, 18);
            this.dataGridViewTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewTaiKhoan.Name = "dataGridViewTaiKhoan";
            this.dataGridViewTaiKhoan.RowHeadersWidth = 62;
            this.dataGridViewTaiKhoan.Size = new System.Drawing.Size(543, 802);
            this.dataGridViewTaiKhoan.TabIndex = 18;
            // 
            // buttonSuaNhanVien
            // 
            this.buttonSuaNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonSuaNhanVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaNhanVien.ForeColor = System.Drawing.Color.White;
            this.buttonSuaNhanVien.Location = new System.Drawing.Point(393, 829);
            this.buttonSuaNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSuaNhanVien.Name = "buttonSuaNhanVien";
            this.buttonSuaNhanVien.Size = new System.Drawing.Size(180, 62);
            this.buttonSuaNhanVien.TabIndex = 20;
            this.buttonSuaNhanVien.Text = "Sửa";
            this.buttonSuaNhanVien.UseVisualStyleBackColor = false;
            this.buttonSuaNhanVien.Click += new System.EventHandler(this.buttonSuaNhanVien_Click);
            // 
            // buttonXoaNhanVien
            // 
            this.buttonXoaNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonXoaNhanVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaNhanVien.ForeColor = System.Drawing.Color.White;
            this.buttonXoaNhanVien.Location = new System.Drawing.Point(204, 829);
            this.buttonXoaNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonXoaNhanVien.Name = "buttonXoaNhanVien";
            this.buttonXoaNhanVien.Size = new System.Drawing.Size(180, 62);
            this.buttonXoaNhanVien.TabIndex = 21;
            this.buttonXoaNhanVien.Text = "Xóa";
            this.buttonXoaNhanVien.UseVisualStyleBackColor = false;
            this.buttonXoaNhanVien.Click += new System.EventHandler(this.buttonXoaNhanVien_Click);
            // 
            // buttonThemNhanVien
            // 
            this.buttonThemNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonThemNhanVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemNhanVien.ForeColor = System.Drawing.Color.White;
            this.buttonThemNhanVien.Location = new System.Drawing.Point(15, 829);
            this.buttonThemNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonThemNhanVien.Name = "buttonThemNhanVien";
            this.buttonThemNhanVien.Size = new System.Drawing.Size(180, 62);
            this.buttonThemNhanVien.TabIndex = 22;
            this.buttonThemNhanVien.Text = "Thêm";
            this.buttonThemNhanVien.UseVisualStyleBackColor = false;
            this.buttonThemNhanVien.Click += new System.EventHandler(this.buttonThemNhanVien_Click);
            // 
            // textBoxLuong
            // 
            this.textBoxLuong.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLuong.Location = new System.Drawing.Point(886, 286);
            this.textBoxLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLuong.Name = "textBoxLuong";
            this.textBoxLuong.Size = new System.Drawing.Size(288, 42);
            this.textBoxLuong.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label7.Location = new System.Drawing.Point(636, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 35);
            this.label7.TabIndex = 23;
            this.label7.Text = "Lương";
            // 
            // textBoxChucVu
            // 
            this.textBoxChucVu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChucVu.Location = new System.Drawing.Point(886, 198);
            this.textBoxChucVu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxChucVu.Name = "textBoxChucVu";
            this.textBoxChucVu.Size = new System.Drawing.Size(288, 42);
            this.textBoxChucVu.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label6.Location = new System.Drawing.Point(636, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 35);
            this.label6.TabIndex = 24;
            this.label6.Text = "Chức vụ";
            // 
            // textBoxTenNhanVien
            // 
            this.textBoxTenNhanVien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenNhanVien.Location = new System.Drawing.Point(886, 109);
            this.textBoxTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTenNhanVien.Name = "textBoxTenNhanVien";
            this.textBoxTenNhanVien.Size = new System.Drawing.Size(288, 42);
            this.textBoxTenNhanVien.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label5.Location = new System.Drawing.Point(636, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 35);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tên nhân viên";
            // 
            // textBoxMaNhanVien
            // 
            this.textBoxMaNhanVien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaNhanVien.Location = new System.Drawing.Point(886, 18);
            this.textBoxMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMaNhanVien.Name = "textBoxMaNhanVien";
            this.textBoxMaNhanVien.Size = new System.Drawing.Size(288, 42);
            this.textBoxMaNhanVien.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label8.Location = new System.Drawing.Point(636, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 35);
            this.label8.TabIndex = 26;
            this.label8.Text = "Mã nhân viên";
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 937);
            this.Controls.Add(this.textBoxLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxChucVu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTenNhanVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMaNhanVien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSuaNhanVien);
            this.Controls.Add(this.buttonXoaNhanVien);
            this.Controls.Add(this.buttonThemNhanVien);
            this.Controls.Add(this.dataGridViewTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewTaiKhoan;
        private System.Windows.Forms.Button buttonSuaNhanVien;
        private System.Windows.Forms.Button buttonXoaNhanVien;
        private System.Windows.Forms.Button buttonThemNhanVien;
        private System.Windows.Forms.TextBox textBoxLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxChucVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTenNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaNhanVien;
        private System.Windows.Forms.Label label8;
    }
}