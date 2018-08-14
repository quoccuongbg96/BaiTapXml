namespace BaiTapXML
{
    partial class frmChienPhap_Suamoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChienPhap_Suamoi));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtNoidungCP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenCP = new System.Windows.Forms.TextBox();
            this.Tên = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLoaiCp = new System.Windows.Forms.ComboBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(327, 238);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(153, 39);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(119, 238);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(153, 39);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtNoidungCP
            // 
            this.txtNoidungCP.Location = new System.Drawing.Point(119, 141);
            this.txtNoidungCP.Multiline = true;
            this.txtNoidungCP.Name = "txtNoidungCP";
            this.txtNoidungCP.Size = new System.Drawing.Size(361, 77);
            this.txtNoidungCP.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nội dung \r\nChiến Pháp";
            // 
            // txtTenCP
            // 
            this.txtTenCP.Location = new System.Drawing.Point(119, 98);
            this.txtTenCP.Name = "txtTenCP";
            this.txtTenCP.Size = new System.Drawing.Size(179, 20);
            this.txtTenCP.TabIndex = 13;
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(12, 101);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(84, 13);
            this.Tên.TabIndex = 12;
            this.Tên.Text = "Tên Chiến Pháp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loại Chiến Pháp";
            // 
            // cbLoaiCp
            // 
            this.cbLoaiCp.FormattingEnabled = true;
            this.cbLoaiCp.Location = new System.Drawing.Point(119, 54);
            this.cbLoaiCp.Name = "cbLoaiCp";
            this.cbLoaiCp.Size = new System.Drawing.Size(149, 21);
            this.cbLoaiCp.TabIndex = 10;
            this.cbLoaiCp.SelectedIndexChanged += new System.EventHandler(this.cbLoaiCp_SelectedIndexChanged);
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(33, 19);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(35, 13);
            this.lbTen.TabIndex = 9;
            this.lbTen.Text = "label1";
            // 
            // frmChienPhap_Suamoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 289);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtNoidungCP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenCP);
            this.Controls.Add(this.Tên);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLoaiCp);
            this.Controls.Add(this.lbTen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChienPhap_Suamoi";
            this.Text = "Sửa thuộc tính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtNoidungCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenCP;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLoaiCp;
        private System.Windows.Forms.Label lbTen;
    }
}