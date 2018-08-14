using System;
using System.Collections;
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
    public partial class frmThemCot : Form
    {
        public frmThemCot()
        {
            InitializeComponent();
            cbThuocTinh.Items.Add("Công");
            cbThuocTinh.Items.Add("Thủ");
            cbThuocTinh.Items.Add("Mưu");
            cbThuocTinh.Items.Add("Tốc");
            cbThuocTinh.Items.Add("Phá");

        }
        public void load()
        {
            XElement tree = new XElement("ChiTiet",
                    from el in new Form1().TapItem("F:\\File xml ROW\\ThongTin.xml")
                    where (string)el.Element("Ten") == txtTen.Text
                    select el
                    );         
            txtTest.Text = tree.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var ten = (from el in new Form1().TapItem("F:\\File xml ROW\\ThongTin.xml")
                       where (string)el.Element("Ten") == txtTen.Text
                       select el
                ).ToList();

            if (ten.Count >= 1)
            {
                XElement ThongTin = XElement.Load("F:\\File xml ROW\\ThongTin.xml");
                        #region thêm
                var Items = (from el in ThongTin.Descendants()
                                     where (string)el.Element("Ten") == txtTen.Text
                                     select el);
                        foreach (var item in Items)
                        {
                            item.Add(new XElement(cbThuocTinh.Text, txtDuLieu.Text));
                            MessageBox.Show("Thành Công");
                        }
                        ThongTin.Save("F:\\File xml ROW\\ThongTin.xml");
                        load();
                        #endregion
            }
            else
            {
                MessageBox.Show("Không tồn tại tướng này !!!");
            }
            load();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }
        public void sua(string thuoctinh, string ten)
        {
            XElement thongtin = XElement.Load("F:\\File xml ROW\\ThongTin.xml");

            var items = (from el in thongtin.Descendants("ChiTiet")
                         where (string)el.Element("Ten") == ten
                         select el.Element(thuoctinh)
                       ).ToList();
            
            foreach (var item in items)
            {
                    item.SetValue(txtDuLieu.Text);
                MessageBox.Show("-- Thành Công --");
            }
            thongtin.Save("F:\\File xml ROW\\ThongTin.xml");
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sua(cbThuocTinh.Text,txtTen.Text);
        }       
        private void btnXem_Click(object sender, EventArgs e)
        {
            var ten = (from el in new Form1().TapItem("F:\\File xml ROW\\ThongTin.xml")
                       where (string)el.Element("Ten") == txtTen.Text
                       select el
              ).ToList();

            if (ten.Count >= 1)
            {
                load();
            }
            else
            {
                txtTest.Text = "Không tồn tại tướng '"+txtTen.Text.ToUpper()+"'";
            }
           
        }

        private void frmThemCot_Load(object sender, EventArgs e)
        {

           //new Form1().inTen(txtTen);
        }
    }
}
