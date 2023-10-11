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
            this.dataGridViewBan = new System.Windows.Forms.DataGridView();
            this.buttonSuaBan = new System.Windows.Forms.Button();
            this.buttonXoaBan = new System.Windows.Forms.Button();
            this.buttonThemBan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTenBan = new System.Windows.Forms.TextBox();
            this.textBoxMaBan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBan
            // 
            this.dataGridViewBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBan.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBan.Name = "dataGridViewBan";
            this.dataGridViewBan.Size = new System.Drawing.Size(446, 386);
            this.dataGridViewBan.TabIndex = 3;
            // 
            // buttonSuaBan
            // 
            this.buttonSuaBan.Location = new System.Drawing.Point(286, 404);
            this.buttonSuaBan.Name = "buttonSuaBan";
            this.buttonSuaBan.Size = new System.Drawing.Size(75, 23);
            this.buttonSuaBan.TabIndex = 4;
            this.buttonSuaBan.Text = "Sửa";
            this.buttonSuaBan.UseVisualStyleBackColor = true;
            this.buttonSuaBan.Click += new System.EventHandler(this.buttonSuaBan_Click);
            // 
            // buttonXoaBan
            // 
            this.buttonXoaBan.Location = new System.Drawing.Point(174, 404);
            this.buttonXoaBan.Name = "buttonXoaBan";
            this.buttonXoaBan.Size = new System.Drawing.Size(75, 23);
            this.buttonXoaBan.TabIndex = 5;
            this.buttonXoaBan.Text = "Xóa";
            this.buttonXoaBan.UseVisualStyleBackColor = true;
            this.buttonXoaBan.Click += new System.EventHandler(this.buttonXoaBan_Click);
            // 
            // buttonThemBan
            // 
            this.buttonThemBan.Location = new System.Drawing.Point(59, 404);
            this.buttonThemBan.Name = "buttonThemBan";
            this.buttonThemBan.Size = new System.Drawing.Size(75, 23);
            this.buttonThemBan.TabIndex = 6;
            this.buttonThemBan.Text = "Thêm";
            this.buttonThemBan.UseVisualStyleBackColor = true;
            this.buttonThemBan.Click += new System.EventHandler(this.buttonThemBan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã bàn";
            // 
            // textBoxTenBan
            // 
            this.textBoxTenBan.Location = new System.Drawing.Point(608, 102);
            this.textBoxTenBan.Name = "textBoxTenBan";
            this.textBoxTenBan.Size = new System.Drawing.Size(149, 20);
            this.textBoxTenBan.TabIndex = 7;
            // 
            // textBoxMaBan
            // 
            this.textBoxMaBan.Location = new System.Drawing.Point(608, 38);
            this.textBoxMaBan.Name = "textBoxMaBan";
            this.textBoxMaBan.Size = new System.Drawing.Size(149, 20);
            this.textBoxMaBan.TabIndex = 8;
            // 
            // FormBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTenBan;
        private System.Windows.Forms.TextBox textBoxMaBan;
    }
}