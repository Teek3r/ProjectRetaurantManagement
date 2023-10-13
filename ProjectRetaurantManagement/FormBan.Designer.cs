namespace ProjectRetaurantManagement
{
    partial class FormBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBan = new System.Windows.Forms.DataGridView();
            this.buttonSuaBan = new System.Windows.Forms.Button();
            this.buttonXoaBan = new System.Windows.Forms.Button();
            this.buttonThemBan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTenBan = new System.Windows.Forms.TextBox();
            this.textBoxMaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBan
            // 
            this.dataGridViewBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewBan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(125)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(125)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBan.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBan.Name = "dataGridViewBan";
            this.dataGridViewBan.RowHeadersWidth = 62;
            this.dataGridViewBan.Size = new System.Drawing.Size(362, 521);
            this.dataGridViewBan.TabIndex = 3;
            // 
            // buttonSuaBan
            // 
            this.buttonSuaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonSuaBan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaBan.ForeColor = System.Drawing.Color.White;
            this.buttonSuaBan.Location = new System.Drawing.Point(258, 557);
            this.buttonSuaBan.Name = "buttonSuaBan";
            this.buttonSuaBan.Size = new System.Drawing.Size(120, 40);
            this.buttonSuaBan.TabIndex = 4;
            this.buttonSuaBan.Text = "Sửa";
            this.buttonSuaBan.UseVisualStyleBackColor = false;
            this.buttonSuaBan.Click += new System.EventHandler(this.buttonSuaBan_Click);
            // 
            // buttonXoaBan
            // 
            this.buttonXoaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonXoaBan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaBan.ForeColor = System.Drawing.Color.White;
            this.buttonXoaBan.Location = new System.Drawing.Point(132, 557);
            this.buttonXoaBan.Name = "buttonXoaBan";
            this.buttonXoaBan.Size = new System.Drawing.Size(120, 40);
            this.buttonXoaBan.TabIndex = 5;
            this.buttonXoaBan.Text = "Xóa";
            this.buttonXoaBan.UseVisualStyleBackColor = false;
            this.buttonXoaBan.Click += new System.EventHandler(this.buttonXoaBan_Click);
            // 
            // buttonThemBan
            // 
            this.buttonThemBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonThemBan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemBan.ForeColor = System.Drawing.Color.White;
            this.buttonThemBan.Location = new System.Drawing.Point(6, 557);
            this.buttonThemBan.Name = "buttonThemBan";
            this.buttonThemBan.Size = new System.Drawing.Size(120, 40);
            this.buttonThemBan.TabIndex = 6;
            this.buttonThemBan.Text = "Thêm";
            this.buttonThemBan.UseVisualStyleBackColor = false;
            this.buttonThemBan.Click += new System.EventHandler(this.buttonThemBan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(470, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã bàn";
            // 
            // textBoxTenBan
            // 
            this.textBoxTenBan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenBan.Location = new System.Drawing.Point(588, 113);
            this.textBoxTenBan.Name = "textBoxTenBan";
            this.textBoxTenBan.Size = new System.Drawing.Size(149, 30);
            this.textBoxTenBan.TabIndex = 7;
            // 
            // textBoxMaBan
            // 
            this.textBoxMaBan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaBan.Location = new System.Drawing.Point(588, 38);
            this.textBoxMaBan.Name = "textBoxMaBan";
            this.textBoxMaBan.Size = new System.Drawing.Size(149, 30);
            this.textBoxMaBan.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(470, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên bàn";
            // 
            // FormBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 609);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTenBan);
            this.Controls.Add(this.textBoxMaBan);
            this.Controls.Add(this.buttonSuaBan);
            this.Controls.Add(this.buttonXoaBan);
            this.Controls.Add(this.buttonThemBan);
            this.Controls.Add(this.dataGridViewBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBan";
            this.Text = "FormBan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBan;
        private System.Windows.Forms.Button buttonSuaBan;
        private System.Windows.Forms.Button buttonXoaBan;
        private System.Windows.Forms.Button buttonThemBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTenBan;
        private System.Windows.Forms.TextBox textBoxMaBan;
        private System.Windows.Forms.Label label3;
    }
}