namespace ProjectRetaurantManagement
{
    partial class FormQuanLyBan
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
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.cbLoaiMon = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.cbChangeTable = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.flpTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTable.Location = new System.Drawing.Point(13, 13);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(516, 660);
            this.flpTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemMon);
            this.panel1.Controls.Add(this.nudSoLuong);
            this.panel1.Controls.Add(this.cbMon);
            this.panel1.Controls.Add(this.cbLoaiMon);
            this.panel1.Location = new System.Drawing.Point(574, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 142);
            this.panel1.TabIndex = 1;
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThemMon.Location = new System.Drawing.Point(209, 3);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(176, 94);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSoLuong.Location = new System.Drawing.Point(3, 71);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(200, 26);
            this.nudSoLuong.TabIndex = 1;
            this.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbMon
            // 
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(3, 37);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(200, 28);
            this.cbMon.TabIndex = 0;
            // 
            // cbLoaiMon
            // 
            this.cbLoaiMon.FormattingEnabled = true;
            this.cbLoaiMon.Location = new System.Drawing.Point(3, 3);
            this.cbLoaiMon.Name = "cbLoaiMon";
            this.cbLoaiMon.Size = new System.Drawing.Size(200, 28);
            this.cbLoaiMon.TabIndex = 0;
            this.cbLoaiMon.SelectedIndexChanged += new System.EventHandler(this.cbLoaiMon_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstBill);
            this.panel2.Location = new System.Drawing.Point(574, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 331);
            this.panel2.TabIndex = 1;
            // 
            // lstBill
            // 
            this.lstBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstBill.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstBill.GridLines = true;
            this.lstBill.HideSelection = false;
            this.lstBill.Location = new System.Drawing.Point(3, 3);
            this.lstBill.Name = "lstBill";
            this.lstBill.Size = new System.Drawing.Size(382, 312);
            this.lstBill.TabIndex = 0;
            this.lstBill.UseCompatibleStateImageBehavior = false;
            this.lstBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTongTien);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnChangeTable);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Controls.Add(this.cbChangeTable);
            this.panel3.Location = new System.Drawing.Point(574, 498);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 182);
            this.panel3.TabIndex = 1;
            // 
            // txbTongTien
            // 
            this.txbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTongTien.Location = new System.Drawing.Point(4, 141);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(200, 26);
            this.txbTongTien.TabIndex = 4;
            this.txbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn bàn";
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnChangeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChangeTable.Location = new System.Drawing.Point(210, 3);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(176, 76);
            this.btnChangeTable.TabIndex = 2;
            this.btnChangeTable.Text = "Chuyển bàn";
            this.btnChangeTable.UseVisualStyleBackColor = false;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThanhToan.Location = new System.Drawing.Point(210, 85);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(176, 94);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // cbChangeTable
            // 
            this.cbChangeTable.FormattingEnabled = true;
            this.cbChangeTable.Location = new System.Drawing.Point(4, 51);
            this.cbChangeTable.Name = "cbChangeTable";
            this.cbChangeTable.Size = new System.Drawing.Size(200, 28);
            this.cbChangeTable.TabIndex = 0;
            // 
            // FormQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormQuanLyBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuanLyBan";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbLoaiMon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ComboBox cbChangeTable;
        private System.Windows.Forms.ListView lstBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}