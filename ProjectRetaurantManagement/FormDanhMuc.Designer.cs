namespace ProjectRetaurantManagement
{
    partial class FormDanhMuc
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
            this.dataGridViewLoaiMonAn = new System.Windows.Forms.DataGridView();
            this.buttonSuaLoaiMonAn = new System.Windows.Forms.Button();
            this.buttonXoaLoaiMonAn = new System.Windows.Forms.Button();
            this.buttonThemLoaiMonAn = new System.Windows.Forms.Button();
            this.textBoxTenLoaiMonAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaLoaiMonAn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoaiMonAn
            // 
            this.dataGridViewLoaiMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiMonAn.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLoaiMonAn.Name = "dataGridViewLoaiMonAn";
            this.dataGridViewLoaiMonAn.Size = new System.Drawing.Size(392, 386);
            this.dataGridViewLoaiMonAn.TabIndex = 3;
            // 
            // buttonSuaLoaiMonAn
            // 
            this.buttonSuaLoaiMonAn.Location = new System.Drawing.Point(269, 404);
            this.buttonSuaLoaiMonAn.Name = "buttonSuaLoaiMonAn";
            this.buttonSuaLoaiMonAn.Size = new System.Drawing.Size(75, 23);
            this.buttonSuaLoaiMonAn.TabIndex = 7;
            this.buttonSuaLoaiMonAn.Text = "Sửa";
            this.buttonSuaLoaiMonAn.UseVisualStyleBackColor = true;
            this.buttonSuaLoaiMonAn.Click += new System.EventHandler(this.buttonSuaLoaiMonAn_Click);
            // 
            // buttonXoaLoaiMonAn
            // 
            this.buttonXoaLoaiMonAn.Location = new System.Drawing.Point(157, 404);
            this.buttonXoaLoaiMonAn.Name = "buttonXoaLoaiMonAn";
            this.buttonXoaLoaiMonAn.Size = new System.Drawing.Size(75, 23);
            this.buttonXoaLoaiMonAn.TabIndex = 8;
            this.buttonXoaLoaiMonAn.Text = "Xóa";
            this.buttonXoaLoaiMonAn.UseVisualStyleBackColor = true;
            this.buttonXoaLoaiMonAn.Click += new System.EventHandler(this.buttonXoaLoaiMonAn_Click);
            // 
            // buttonThemLoaiMonAn
            // 
            this.buttonThemLoaiMonAn.Location = new System.Drawing.Point(42, 404);
            this.buttonThemLoaiMonAn.Name = "buttonThemLoaiMonAn";
            this.buttonThemLoaiMonAn.Size = new System.Drawing.Size(75, 23);
            this.buttonThemLoaiMonAn.TabIndex = 9;
            this.buttonThemLoaiMonAn.Text = "Thêm";
            this.buttonThemLoaiMonAn.UseVisualStyleBackColor = true;
            this.buttonThemLoaiMonAn.Click += new System.EventHandler(this.buttonThemLoaiMonAn_Click);
            // 
            // textBoxTenLoaiMonAn
            // 
            this.textBoxTenLoaiMonAn.Location = new System.Drawing.Point(551, 110);
            this.textBoxTenLoaiMonAn.Name = "textBoxTenLoaiMonAn";
            this.textBoxTenLoaiMonAn.Size = new System.Drawing.Size(193, 20);
            this.textBoxTenLoaiMonAn.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên loại món ăn";
            // 
            // textBoxMaLoaiMonAn
            // 
            this.textBoxMaLoaiMonAn.Location = new System.Drawing.Point(551, 37);
            this.textBoxMaLoaiMonAn.Name = "textBoxMaLoaiMonAn";
            this.textBoxMaLoaiMonAn.Size = new System.Drawing.Size(193, 20);
            this.textBoxMaLoaiMonAn.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã loại món ăn";
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTenLoaiMonAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMaLoaiMonAn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSuaLoaiMonAn);
            this.Controls.Add(this.buttonXoaLoaiMonAn);
            this.Controls.Add(this.buttonThemLoaiMonAn);
            this.Controls.Add(this.dataGridViewLoaiMonAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhMuc";
            this.Text = "FormDanhMuc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoaiMonAn;
        private System.Windows.Forms.Button buttonSuaLoaiMonAn;
        private System.Windows.Forms.Button buttonXoaLoaiMonAn;
        private System.Windows.Forms.Button buttonThemLoaiMonAn;
        private System.Windows.Forms.TextBox textBoxTenLoaiMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaLoaiMonAn;
        private System.Windows.Forms.Label label1;
    }
}