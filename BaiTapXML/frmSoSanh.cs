using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BaiTapXML
{
    public partial class frmSoSanh : Form
    {
        public int congTuong1, thuTuong1, muuTuong1, tocTuong1;
        public int congTuong2, thuTuong2, muuTuong2, tocTuong2;
        public frmSoSanh()
        {
            InitializeComponent();
        }
        public void Nhap(string tenTuong1, string tenTuong2)
        {
            var tuong1 = (from el in new Form1().TapItem("F:\\File xml ROW\\ThongTin.xml")
                          where (string)el.Element("Ten") == tenTuong1
                          select el
               );
            foreach (var item in tuong1)
            {
                congTuong1 = int.Parse((string)item.Element("Công"));
                thuTuong1 = int.Parse((string)item.Element("Thủ"));
                muuTuong1 = int.Parse((string)item.Element("Mưu"));
                tocTuong1 = int.Parse((string)item.Element("Tốc"));
            }

            var tuong2 = (from el in new Form1().TapItem("F:\\File xml ROW\\ThongTin.xml")
                          where (string)el.Element("Ten") == tenTuong2
                          select el
                );
            foreach (var item in tuong2)
            {
                congTuong2 = int.Parse((string)item.Element("Công"));
                thuTuong2 = int.Parse((string)item.Element("Thủ"));
                muuTuong2 = int.Parse((string)item.Element("Mưu"));
                tocTuong2 = int.Parse((string)item.Element("Tốc"));
            }           
        }
        public void SoSanh(string tenTuong1, string tenTuong2, Label lb, int chiSo1, int chiSo2, string kieu)
        {
            if (chiSo1 > chiSo2)
            {
                lb.Text = kieu + " " + tenTuong1 + " ( " + chiSo1 + " ) > " + tenTuong2 + " ( " + chiSo2 + " ) ";
            }
            else if (chiSo1 == chiSo2)
            {
                lb.Text = kieu + " " + tenTuong1 + " ( " + chiSo1 + " ) = " + tenTuong2 + " ( " + chiSo2 + " ) ";
            }
            else
            {
                lb.Text = kieu + " " + tenTuong1 + " ( " + chiSo1 + " ) < " + tenTuong2 + " ( " + chiSo2 + " ) ";
            }
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            Nhap(txtTuong1.Text,txtTuong2.Text);
            SoSanh(txtTuong1.Text, txtTuong2.Text, lbToc, tocTuong1,tocTuong2,"Tốc");
            SoSanh(txtTuong1.Text, txtTuong2.Text, lbCong, congTuong1, congTuong2, "Công");
            SoSanh(txtTuong1.Text, txtTuong2.Text, lbThu, thuTuong1, thuTuong2, "Thủ");
            SoSanh(txtTuong1.Text, txtTuong2.Text, lbMuu, muuTuong1, muuTuong2, "Mưu");
            SoSanh(txtTuong1.Text, txtTuong2.Text, lbPha, muuTuong1, muuTuong2, "Phá");
        }
    }
}
