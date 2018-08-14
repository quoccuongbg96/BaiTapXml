using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using ShowXML;

namespace BaiTapXML
{
    public partial class Form1 : Form
    {
        public string ckeKieuThuocTinh;
        public string giaTri;
        public Form1()
        {
            InitializeComponent();
            txtSoSao.Items.Add("3*");
            txtSoSao.Items.Add("4*");
            txtSoSao.Items.Add("5*");

            Phe.Items.Add("Ngụy");
            Phe.Items.Add("Thục");
            Phe.Items.Add("Ngô");
            Phe.Items.Add("Hán");
            Phe.Items.Add("Hùng");

            cbBinhChung.Items.Add("Kị Binh");
            cbBinhChung.Items.Add("Bộ Binh");
            cbBinhChung.Items.Add("Cung Binh");

            for (double i = 2; i <= 4; i=i+0.5)
            {
                cbCost.Items.Add(i);
            }

            for (double i = 1; i <= 4; i++)
            {
                cbRange.Items.Add(i);
            }

            frmMain main = new frmMain();
            main.TopLevel = false;
            this.pnMain.Controls.Add(main);
            main.Show();
        }
        public void inTen(TextBox textBox)
        {
            textBox.Visible = true;
            var items = (from el in TapItem("F:\\File xml ROW\\ThongTin.xml")
                         select (string)el.Element("Ten")
                ).ToList();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            string a = "";
            foreach (var item in items)
            {
                a = a+" "+item;
                auto.Add(item);
                //txtTest.Text =a+item;
            }

            textBox.AutoCompleteCustomSource = auto;
        }
        public void loadFile()
        {
            frmMain main = new frmMain();
            main.TopLevel = false;
            this.pnMain.Controls.Add(main);
            main.Show();
        }
        public IEnumerable<XElement> TapItem(string uri)
        {

            using (XmlReader reader = XmlReader.Create(uri))
            {
                XElement ten = null;
                reader.MoveToContent();

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "ChiTiet")
                    {                      
                                ten = XElement.ReadFrom(reader) as XElement;
                               yield return ten;                    
                    }
                }
            }            
        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {         
            if (Phe.Text == "" || txtSoSao.Text == "" || txtTen.Text == "" )
            {
                MessageBox.Show("Dữ liệu trống !!!");
            }
            else
            {
                var item = (from el in TapItem("F:\\File xml ROW\\ThongTin.xml")
                            where (string)el.Element("Ten") == txtTen.Text
                            select el).ToList();
                textBox11.Text = item.ToString();
                if (item.Count >= 1)
                {
                    MessageBox.Show("Đã tồn tại !!!");
                }
                else
                {
                    XElement thongTinTuong = XElement.Load("F:\\File xml ROW\\ThongTin.xml");
                    thongTinTuong.Add(new XElement("ChiTiet", new XAttribute("Phe", Phe.Text),
                             new XElement("Ten", txtTen.Text),
                             new XElement("SoSao", txtSoSao.Text),
                             new XElement("BinhChung", cbBinhChung.Text),
                             new XElement("TamDanh", cbRange.Text),
                             new XElement("Cost", cbCost.Text)
                        ));
                    thongTinTuong.Save("F:\\File xml ROW\\ThongTin.xml");
                    loadFile();
                }
                
            }
            new frmMain().btnRefresh_Click(sender,e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            XStreamingElement Tree = new XStreamingElement("ThongTin",
                from item in TapItem("F:\\File xml ROW\\ThongTin.xml")
                where (string)item.Element("Ten") == txtTen.Text || (string)item.Element("SoSao") == txtSoSao.Text || (string)item.Attribute("Phe") == Phe.Text
                select item
                );
            textBox11.Text = Tree.ToString();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
        }
        public void sua(string kieu, string giatri)
        {
            XElement update = XElement.Load("F:\\File xml ROW\\ThongTin.xml");           
            
                var items = (from item in update.Descendants("ChiTiet")
                                  where (string)item.Element("Ten") == txtTen.Text
                                  select item.Element(kieu)).ToList();
                foreach (XElement item in items)
                {
                    item.SetValue(giatri);
                }

                update.Save("F:\\File xml ROW\\ThongTin.xml");
                loadFile();            
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if(ckeKieuThuocTinh != "Phe")
            {
                sua(ckeKieuThuocTinh, giaTri);
            }
            else
            {
                XElement update = XElement.Load("F:\\File xml ROW\\ThongTin.xml");

                var items = (from item in update.Descendants("ChiTiet")
                             where (string)item.Element("Ten") == txtTen.Text
                             select item.Attribute("Phe")).ToList();
                foreach (XAttribute item in items)
                {
                    item.SetValue(Phe.Text);
                }

                update.Save("F:\\File xml ROW\\ThongTin.xml");
                loadFile();
            }
                               
        }
        public void xoa(string ten)
        {
            XElement update = XElement.Load("F:\\File xml ROW\\ThongTin.xml");

            var items = (from item in update.Descendants("ChiTiet")
                         where (string)item.Element("Ten") == ten
                         select item).ToList();
            foreach (XElement item in items)
            {
                item.Remove();
            }
            textBox11.Text = items.ToString();
            update.Save("F:\\File xml ROW\\ThongTin.xml");

            loadFile();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa(txtTen.Text);
            loadFile();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.TopLevel = false;
            this.pnMain.Controls.Add(main);
            main.Show();   
        }     
        private void txtSoSao_TextChanged(object sender, EventArgs e)
        {
            ckeKieuThuocTinh = "SoSao";
        }

        private void Phe_TextChanged(object sender, EventArgs e)
        {
            ckeKieuThuocTinh = "Phe";
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
           DialogResult re = MessageBox.Show("Bạn chắc chắn muốn tạo lại, toàn bộ dữ liệu sẽ bị xóa !!!", "Cảnh báo",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                if (txtTen.Text != "")
                {
                    XElement tuong = (new XElement("ThongTinTuong",
                        new XElement("ChiTiet", new XAttribute("Phe", Phe.Text),
                        new XElement("Ten", txtTen.Text),
                        new XElement("SoSao", txtSoSao.Text),
                        new XElement("BinhChung", cbBinhChung.Text),
                                 new XElement("TamDanh", cbRange.Text),
                                 new XElement("Cost", cbCost.Text)
                )));
                    tuong.Save("F:\\File xml ROW\\ThongTin.xml");

                    loadFile();
                }
                else
                {
                    MessageBox.Show("Chưa có tên Tướng !!!");
                }
            }          
        }

        private void btnThuocTinh_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();

            frmThemCot them = new frmThemCot();
            them.TopLevel = false;
            this.pnMain.Controls.Add(them);
            them.Show();

            //new frmThemCot().Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            new frmChienPhap(txtTen.Text).Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             inTen(txtTen);
        }

        private void txtSoSao_SelectedIndexChanged(object sender, EventArgs e)
        {
            ckeKieuThuocTinh = "SoSao";
            giaTri = txtSoSao.Text;
        }

        private void Phe_SelectedIndexChanged(object sender, EventArgs e)
        {
            ckeKieuThuocTinh = "Phe";
            giaTri = Phe.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           new frmSoSanh().Show();
        }

        private void cbBinhChung_SelectedIndexChanged(object sender, EventArgs e)
        {
            ckeKieuThuocTinh = "BinhChung";
            giaTri = cbBinhChung.Text;
        }

        private void cbCost_SelectedIndexChanged(object sender, EventArgs e)
        {
            ckeKieuThuocTinh = "Cost";
            giaTri = cbCost.Text;
        }

        private void cbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            ckeKieuThuocTinh = "TamDanh";
            giaTri = cbRange.Text;
        }

        private void btnMoFIle_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text File (*.xml) | *.xml";
            if (op.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    if ((myStream = op.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            XElement update = XElement.Load(myStream);
                            textBox11.Text = update.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không tìm được đường dẫn" + ex.Message);
                }
            }
            
        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sa = new SaveFileDialog();
            sa.Filter = "Text File (*.xml) | *.xml";
            if (sa.ShowDialog() == DialogResult.OK)
            {
                
                Stream myStream = null;
                try
                {

                    if ((myStream = sa.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            
                            XElement update = XElement.Parse(textBox11.Text);
                            update.Save(myStream);
                            MessageBox.Show("-- Đã tạo file --");
                        }
                    }
            }
                catch (XmlException)
            {
                        MessageBox.Show("Đã tạo file rỗng!!!");
            }
        }
        }
    }
}
