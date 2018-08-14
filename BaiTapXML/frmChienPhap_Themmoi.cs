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
    public partial class frmChienPhap_Themmoi : Form
    {
        public string kieuCp;
        public frmChienPhap_Themmoi(string _ten)
        {
            
            InitializeComponent();
            lbTen.Text = _ten;
            cbLoaiCp.Items.Add("BasicSkill");
            cbLoaiCp.Items.Add("Skillsplitted");
            cbLoaiCp.Items.Add("Study");
        }
        public void themCP(string kieuCP,string tenCP,string noidungCP)
        {
            XElement thongTin = XElement.Load("F:\\File xml ROW\\ThongTin.xml");
            var items = (from el in thongTin.Descendants()
                         where (string)el.Element("Ten") == lbTen.Text
                         select el
                );
            try
            {
                foreach (var item in items)
                {
                    if (item.Element(kieuCp).Name == kieuCp)
                    {
                        MessageBox.Show("Chiến pháp đã tồn tại !!!");
                    }
                   
                }
            }
            catch (NullReferenceException)
            {
                if (cbLoaiCp.Text != "" || txtTenCP.Text != "")
                {
                    foreach (var item in items)
                    {
                        item.Add(new XElement(kieuCP, new XAttribute("TênCP", tenCP), noidungCP));
                        MessageBox.Show("-- Thêm Thành Công --");
                    }
                    thongTin.Save("F:\\File xml ROW\\ThongTin.xml");
                }
                else
                {
                    MessageBox.Show("Hãy điền đủ dữ liệu");
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            themCP(kieuCp, txtTenCP.Text, txtNoidungCP.Text);
        }

        private void cbLoaiCp_SelectedIndexChanged(object sender, EventArgs e)
        {
            kieuCp = cbLoaiCp.SelectedItem.ToString();
            if(cbLoaiCp.SelectedItem.ToString() == "Study")
            {
                txtTenCP.Hide();
                Tên.Text = "↓↓↓  Điền Tất Cả Xuống Phía Dưới  ↓↓↓";
                lbchuthich.Text = "(Skill Nên Học)";
            }
            else if(cbLoaiCp.SelectedItem.ToString() == "BasicSkill")
            {
                txtTenCP.Show();
                Tên.Text = "Tên Chiến Pháp";
                lbchuthich.Text = "(Skill Mặc Định)";
            }
            else if (cbLoaiCp.SelectedItem.ToString() == "Skillsplitted")
            {
                txtTenCP.Show();
                Tên.Text = "Tên Chiến Pháp";
                lbchuthich.Text = "(Skill Tách Được)";
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmChienPhap(lbTen.Text).Show();
        }
    }
}
