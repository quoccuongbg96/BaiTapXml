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
    
    public partial class frmChienPhap_Suamoi : Form
    {
        public string kieuChienPhap;
        public frmChienPhap_Suamoi(string _ten)
        {
            InitializeComponent();
            lbTen.Text = _ten;
            cbLoaiCp.Items.Add("BasicSkill");
            cbLoaiCp.Items.Add("Skillsplitted");
            cbLoaiCp.Items.Add("Study");
        }
        public void Sua(string kieuChienPhap, string giaTri)
        {
            try
            {
                XElement thongtin = XElement.Load("F:\\File xml ROW\\ThongTin.xml");

                var items = (from el in thongtin.Descendants()
                             where (string)el.Element("Ten") == lbTen.Text
                             select el
                    );
                foreach (var item in items)
                {
                    item.Element(kieuChienPhap).SetAttributeValue("TênCP", txtTenCP.Text);
                    item.Element(kieuChienPhap).SetValue(giaTri);
                    MessageBox.Show("-- Sửa " + kieuChienPhap + " thành công --");
                }

                thongtin.Save("F:\\File xml ROW\\ThongTin.xml");
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Chưa thêm chiến pháp này !!!");
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Sua(cbLoaiCp.Text,txtNoidungCP.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmChienPhap(lbTen.Text).Show();
        }

        private void cbLoaiCp_SelectedIndexChanged(object sender, EventArgs e)
        {
            kieuChienPhap = cbLoaiCp.SelectedItem.ToString();
        }
    }
}
