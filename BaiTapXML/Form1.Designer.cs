namespace BaiTapXML
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRange = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCost = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBinhChung = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Phe = new System.Windows.Forms.ComboBox();
            this.txtSoSao = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThuocTinh = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLuuFile = new System.Windows.Forms.Button();
            this.btnMoFIle = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(434, 17);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(320, 427);
            this.textBox11.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(12, 181);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 30);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 364);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Xóa bảng";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(118, 181);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 29);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(70, 27);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(222, 20);
            this.txtTen.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Số Sao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRange);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbCost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbBinhChung);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Phe);
            this.groupBox1.Controls.Add(this.txtSoSao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 152);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbRange
            // 
            this.cbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRange.FormattingEnabled = true;
            this.cbRange.Location = new System.Drawing.Point(306, 114);
            this.cbRange.Name = "cbRange";
            this.cbRange.Size = new System.Drawing.Size(69, 21);
            this.cbRange.TabIndex = 24;
            this.cbRange.SelectedIndexChanged += new System.EventHandler(this.cbRange_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tầm đánh";
            // 
            // cbCost
            // 
            this.cbCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCost.FormattingEnabled = true;
            this.cbCost.Location = new System.Drawing.Point(182, 114);
            this.cbCost.Name = "cbCost";
            this.cbCost.Size = new System.Drawing.Size(42, 21);
            this.cbCost.TabIndex = 22;
            this.cbCost.SelectedIndexChanged += new System.EventHandler(this.cbCost_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "COST";
            // 
            // cbBinhChung
            // 
            this.cbBinhChung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBinhChung.FormattingEnabled = true;
            this.cbBinhChung.Location = new System.Drawing.Point(273, 66);
            this.cbBinhChung.Name = "cbBinhChung";
            this.cbBinhChung.Size = new System.Drawing.Size(102, 21);
            this.cbBinhChung.TabIndex = 20;
            this.cbBinhChung.SelectedIndexChanged += new System.EventHandler(this.cbBinhChung_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Binh chủng";
            // 
            // Phe
            // 
            this.Phe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Phe.FormattingEnabled = true;
            this.Phe.Location = new System.Drawing.Point(69, 66);
            this.Phe.Name = "Phe";
            this.Phe.Size = new System.Drawing.Size(102, 21);
            this.Phe.TabIndex = 18;
            this.Phe.SelectedIndexChanged += new System.EventHandler(this.Phe_SelectedIndexChanged);
            // 
            // txtSoSao
            // 
            this.txtSoSao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSoSao.FormattingEnabled = true;
            this.txtSoSao.Location = new System.Drawing.Point(69, 114);
            this.txtSoSao.Name = "txtSoSao";
            this.txtSoSao.Size = new System.Drawing.Size(47, 21);
            this.txtSoSao.TabIndex = 17;
            this.txtSoSao.SelectedIndexChanged += new System.EventHandler(this.txtSoSao_SelectedIndexChanged);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(229, 180);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(340, 180);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 30);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 69);
            this.button1.TabIndex = 19;
            this.button1.Text = "Load File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThuocTinh
            // 
            this.btnThuocTinh.Location = new System.Drawing.Point(297, 229);
            this.btnThuocTinh.Name = "btnThuocTinh";
            this.btnThuocTinh.Size = new System.Drawing.Size(114, 69);
            this.btnThuocTinh.TabIndex = 20;
            this.btnThuocTinh.Text = "Thuộc Tính";
            this.btnThuocTinh.UseVisualStyleBackColor = true;
            this.btnThuocTinh.Click += new System.EventHandler(this.btnThuocTinh_Click);
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.Red;
            this.btnTao.Location = new System.Drawing.Point(12, 410);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(171, 34);
            this.btnTao.TabIndex = 21;
            this.btnTao.Text = "Tạo Mới";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 69);
            this.button2.TabIndex = 22;
            this.button2.Text = "Chiến Pháp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLuuFile
            // 
            this.btnLuuFile.Location = new System.Drawing.Point(240, 410);
            this.btnLuuFile.Name = "btnLuuFile";
            this.btnLuuFile.Size = new System.Drawing.Size(171, 34);
            this.btnLuuFile.TabIndex = 23;
            this.btnLuuFile.Text = "Lưu FIle";
            this.btnLuuFile.UseVisualStyleBackColor = true;
            this.btnLuuFile.Click += new System.EventHandler(this.btnLuuFile_Click);
            // 
            // btnMoFIle
            // 
            this.btnMoFIle.Location = new System.Drawing.Point(240, 364);
            this.btnMoFIle.Name = "btnMoFIle";
            this.btnMoFIle.Size = new System.Drawing.Size(171, 34);
            this.btnMoFIle.TabIndex = 24;
            this.btnMoFIle.Text = "Mở File";
            this.btnMoFIle.UseVisualStyleBackColor = true;
            this.btnMoFIle.Click += new System.EventHandler(this.btnMoFIle_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(399, 34);
            this.button5.TabIndex = 25;
            this.button5.Text = "So Sánh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(434, 17);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(796, 441);
            this.pnMain.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 467);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnMoFIle);
            this.Controls.Add(this.btnLuuFile);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnThuocTinh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.textBox11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Thông Tin Tướng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThuocTinh;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLuuFile;
        private System.Windows.Forms.Button btnMoFIle;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox txtSoSao;
        private System.Windows.Forms.ComboBox Phe;
        private System.Windows.Forms.ComboBox cbRange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBinhChung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnMain;
    }
}

