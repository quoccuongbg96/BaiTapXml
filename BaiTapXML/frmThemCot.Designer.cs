namespace BaiTapXML
{
    partial class frmThemCot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemCot));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuLieu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbThuocTinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thuộc Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dữ Liệu";
            // 
            // txtDuLieu
            // 
            this.txtDuLieu.Location = new System.Drawing.Point(108, 131);
            this.txtDuLieu.Name = "txtDuLieu";
            this.txtDuLieu.Size = new System.Drawing.Size(177, 20);
            this.txtDuLieu.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(29, 177);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbThuocTinh
            // 
            this.cbThuocTinh.FormattingEnabled = true;
            this.cbThuocTinh.Location = new System.Drawing.Point(108, 77);
            this.cbThuocTinh.Name = "cbThuocTinh";
            this.cbThuocTinh.Size = new System.Drawing.Size(177, 21);
            this.cbThuocTinh.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTen.Location = new System.Drawing.Point(108, 23);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(177, 20);
            this.txtTen.TabIndex = 8;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(175, 177);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(308, 60);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(460, 140);
            this.txtTest.TabIndex = 10;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(308, 21);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(216, 23);
            this.btnXem.TabIndex = 11;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // frmThemCot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 237);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbThuocTinh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDuLieu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemCot";
            this.Text = "Thuộc Tính";
            this.Load += new System.EventHandler(this.frmThemCot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuLieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbThuocTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnXem;
    }
}