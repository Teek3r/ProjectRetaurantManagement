namespace ProjectRetaurantManagement
{
    partial class FormThucAn
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
            this.dataGridViewMonAn = new System.Windows.Forms.DataGridView();
            this.buttonSuaMonAn = new System.Windows.Forms.Button();
            this.buttonXoaMonAn = new System.Windows.Forms.Button();
            this.buttonThemMonAn = new System.Windows.Forms.Button();
            this.textBoxMaMonAn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTenMonAn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMaLoaiMonAn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMonAn
            // 
            this.dataGridViewMonAn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMonAn.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMonAn.Location = new System.Drawing.Point(18, 18);
            this.dataGridViewMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewMonAn.Name = "dataGridViewMonAn";
            this.dataGridViewMonAn.RowHeadersWidth = 62;
            this.dataGridViewMonAn.Size = new System.Drawing.Size(543, 802);
            this.dataGridViewMonAn.TabIndex = 16;
            // 
            // buttonSuaMonAn
            // 
            this.buttonSuaMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonSuaMonAn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaMonAn.ForeColor = System.Drawing.Color.White;
            this.buttonSuaMonAn.Location = new System.Drawing.Point(396, 829);
            this.buttonSuaMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSuaMonAn.Name = "buttonSuaMonAn";
            this.buttonSuaMonAn.Size = new System.Drawing.Size(180, 62);
            this.buttonSuaMonAn.TabIndex = 17;
            this.buttonSuaMonAn.Text = "Sửa";
            this.buttonSuaMonAn.UseVisualStyleBackColor = false;
            this.buttonSuaMonAn.Click += new System.EventHandler(this.buttonSuaMonAn_Click);
            // 
            // buttonXoaMonAn
            // 
            this.buttonXoaMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonXoaMonAn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaMonAn.ForeColor = System.Drawing.Color.White;
            this.buttonXoaMonAn.Location = new System.Drawing.Point(207, 829);
            this.buttonXoaMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonXoaMonAn.Name = "buttonXoaMonAn";
            this.buttonXoaMonAn.Size = new System.Drawing.Size(180, 62);
            this.buttonXoaMonAn.TabIndex = 18;
            this.buttonXoaMonAn.Text = "Xóa";
            this.buttonXoaMonAn.UseVisualStyleBackColor = false;
            this.buttonXoaMonAn.Click += new System.EventHandler(this.buttonXoaMonAn_Click);
            // 
            // buttonThemMonAn
            // 
            this.buttonThemMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonThemMonAn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemMonAn.ForeColor = System.Drawing.Color.White;
            this.buttonThemMonAn.Location = new System.Drawing.Point(18, 829);
            this.buttonThemMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonThemMonAn.Name = "buttonThemMonAn";
            this.buttonThemMonAn.Size = new System.Drawing.Size(180, 62);
            this.buttonThemMonAn.TabIndex = 19;
            this.buttonThemMonAn.Text = "Thêm";
            this.buttonThemMonAn.UseVisualStyleBackColor = false;
            this.buttonThemMonAn.Click += new System.EventHandler(this.buttonThemMonAn_Click);
            // 
            // textBoxMaMonAn
            // 
            this.textBoxMaMonAn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaMonAn.Location = new System.Drawing.Point(864, 18);
            this.textBoxMaMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMaMonAn.Name = "textBoxMaMonAn";
            this.textBoxMaMonAn.Size = new System.Drawing.Size(288, 42);
            this.textBoxMaMonAn.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label5.Location = new System.Drawing.Point(614, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 35);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã món ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(614, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 35);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên món ăn";
            // 
            // textBoxTenMonAn
            // 
            this.textBoxTenMonAn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenMonAn.Location = new System.Drawing.Point(864, 109);
            this.textBoxTenMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTenMonAn.Name = "textBoxTenMonAn";
            this.textBoxTenMonAn.Size = new System.Drawing.Size(288, 42);
            this.textBoxTenMonAn.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label6.Location = new System.Drawing.Point(614, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 35);
            this.label6.TabIndex = 20;
            this.label6.Text = "Đơn giá";
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDonGia.Location = new System.Drawing.Point(864, 198);
            this.textBoxDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(288, 42);
            this.textBoxDonGia.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label7.Location = new System.Drawing.Point(614, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 35);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mã loại món ăn";
            // 
            // textBoxMaLoaiMonAn
            // 
            this.textBoxMaLoaiMonAn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaLoaiMonAn.Location = new System.Drawing.Point(864, 286);
            this.textBoxMaLoaiMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMaLoaiMonAn.Name = "textBoxMaLoaiMonAn";
            this.textBoxMaLoaiMonAn.Size = new System.Drawing.Size(288, 42);
            this.textBoxMaLoaiMonAn.TabIndex = 21;
            // 
            // FormThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 937);
            this.Controls.Add(this.textBoxMaLoaiMonAn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDonGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTenMonAn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaMonAn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSuaMonAn);
            this.Controls.Add(this.buttonXoaMonAn);
            this.Controls.Add(this.buttonThemMonAn);
            this.Controls.Add(this.dataGridViewMonAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormThucAn";
            this.Text = "FormThucAn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewMonAn;
        private System.Windows.Forms.Button buttonSuaMonAn;
        private System.Windows.Forms.Button buttonXoaMonAn;
        private System.Windows.Forms.Button buttonThemMonAn;
        private System.Windows.Forms.TextBox textBoxMaMonAn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTenMonAn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMaLoaiMonAn;
    }
}