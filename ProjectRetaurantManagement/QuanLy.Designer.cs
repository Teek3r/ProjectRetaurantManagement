using System.Drawing;
using System.Windows.Forms;

namespace ProjectRetaurantManagement
{
    partial class formQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuanLy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTaiKhoan = new System.Windows.Forms.Button();
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.buttonThucAn = new System.Windows.Forms.Button();
            this.buttonDanhMuc = new System.Windows.Forms.Button();
            this.buttonQuanLyBan = new System.Windows.Forms.Button();
            this.buttonBan = new System.Windows.Forms.Button();
            this.panelXuly = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelXuly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonTaiKhoan);
            this.panel1.Controls.Add(this.buttonThongKe);
            this.panel1.Controls.Add(this.buttonThucAn);
            this.panel1.Controls.Add(this.buttonDanhMuc);
            this.panel1.Controls.Add(this.buttonQuanLyBan);
            this.panel1.Controls.Add(this.buttonBan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 461);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectRetaurantManagement.Properties.Resources.restaurant;
            this.pictureBox1.Location = new System.Drawing.Point(31, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTaiKhoan
            // 
            this.buttonTaiKhoan.AutoSize = true;
            this.buttonTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonTaiKhoan.FlatAppearance.BorderSize = 0;
            this.buttonTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.buttonTaiKhoan.Location = new System.Drawing.Point(0, 335);
            this.buttonTaiKhoan.Name = "buttonTaiKhoan";
            this.buttonTaiKhoan.Size = new System.Drawing.Size(166, 42);
            this.buttonTaiKhoan.TabIndex = 2;
            this.buttonTaiKhoan.Text = "Tài khoản";
            this.buttonTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTaiKhoan.UseVisualStyleBackColor = false;
            this.buttonTaiKhoan.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.AutoSize = true;
            this.buttonThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonThongKe.FlatAppearance.BorderSize = 0;
            this.buttonThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKe.ForeColor = System.Drawing.Color.White;
            this.buttonThongKe.Location = new System.Drawing.Point(0, 298);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(166, 42);
            this.buttonThongKe.TabIndex = 2;
            this.buttonThongKe.Text = "Thống kê";
            this.buttonThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThongKe.UseVisualStyleBackColor = false;
            this.buttonThongKe.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonThucAn
            // 
            this.buttonThucAn.AutoSize = true;
            this.buttonThucAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonThucAn.FlatAppearance.BorderSize = 0;
            this.buttonThucAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThucAn.ForeColor = System.Drawing.Color.White;
            this.buttonThucAn.Location = new System.Drawing.Point(0, 187);
            this.buttonThucAn.Name = "buttonThucAn";
            this.buttonThucAn.Size = new System.Drawing.Size(166, 42);
            this.buttonThucAn.TabIndex = 2;
            this.buttonThucAn.Text = "Thức ăn";
            this.buttonThucAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThucAn.UseVisualStyleBackColor = false;
            this.buttonThucAn.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDanhMuc
            // 
            this.buttonDanhMuc.AutoSize = true;
            this.buttonDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonDanhMuc.FlatAppearance.BorderSize = 0;
            this.buttonDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDanhMuc.ForeColor = System.Drawing.Color.White;
            this.buttonDanhMuc.Location = new System.Drawing.Point(0, 261);
            this.buttonDanhMuc.Name = "buttonDanhMuc";
            this.buttonDanhMuc.Size = new System.Drawing.Size(166, 42);
            this.buttonDanhMuc.TabIndex = 2;
            this.buttonDanhMuc.Text = "Danh mục";
            this.buttonDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDanhMuc.UseVisualStyleBackColor = false;
            this.buttonDanhMuc.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonQuanLyBan
            // 
            this.buttonQuanLyBan.AutoSize = true;
            this.buttonQuanLyBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonQuanLyBan.FlatAppearance.BorderSize = 0;
            this.buttonQuanLyBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLyBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyBan.ForeColor = System.Drawing.Color.White;
            this.buttonQuanLyBan.Location = new System.Drawing.Point(0, 150);
            this.buttonQuanLyBan.Name = "buttonQuanLyBan";
            this.buttonQuanLyBan.Size = new System.Drawing.Size(166, 42);
            this.buttonQuanLyBan.TabIndex = 2;
            this.buttonQuanLyBan.Text = "Quản lý bàn";
            this.buttonQuanLyBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuanLyBan.UseVisualStyleBackColor = false;
            this.buttonQuanLyBan.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBan
            // 
            this.buttonBan.AutoSize = true;
            this.buttonBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonBan.FlatAppearance.BorderSize = 0;
            this.buttonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBan.ForeColor = System.Drawing.Color.White;
            this.buttonBan.Location = new System.Drawing.Point(0, 224);
            this.buttonBan.Name = "buttonBan";
            this.buttonBan.Size = new System.Drawing.Size(166, 42);
            this.buttonBan.TabIndex = 2;
            this.buttonBan.Text = "Bàn";
            this.buttonBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBan.UseVisualStyleBackColor = false;
            this.buttonBan.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelXuly
            // 
            this.panelXuly.Controls.Add(this.pictureBox2);
            this.panelXuly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelXuly.Location = new System.Drawing.Point(166, 0);
            this.panelXuly.Name = "panelXuly";
            this.panelXuly.Size = new System.Drawing.Size(718, 461);
            this.panelXuly.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::ProjectRetaurantManagement.Properties.Resources.platter_2009590;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(718, 461);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // formQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelXuly);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelXuly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQuanLyBan;
        private System.Windows.Forms.Button buttonThucAn;
        private System.Windows.Forms.Button buttonBan;
        private System.Windows.Forms.Button buttonDanhMuc;
        private System.Windows.Forms.Button buttonThongKe;
        private System.Windows.Forms.Button buttonTaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Panel panelXuly;
        private PictureBox pictureBox2;
    }
}