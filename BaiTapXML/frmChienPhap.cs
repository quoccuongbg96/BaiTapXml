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
    public partial class frmChienPhap : Form
    {
        public frmChienPhap(string _ten)
        {
            InitializeComponent();
           txtTen.Text = _ten;
        }

        private void frmChienPhap_Load(object sender, EventArgs e)
        {
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                XElement thongtin = XElement.Load("F:\\File xml ROW\\ThongTin.xml");
                var items = (from el in thongtin.Descendants()
                             where (string)el.Element("Ten") == txtTen.Text
                             select el
                    ).ToList();
                foreach (var item in items)
                {
                    lbBasicSkillTen.Text = item.Element("BasicSkill").Attribute("TênCP").Value;
                    lbBasicSkillNoiDung.Text = item.Element("BasicSkill").Value;

                    lbSkillsplittedTen.Text = item.Element("Skillsplitted").Attribute("TênCP").Value;
                    lbSkillsplittedNoiDung.Text = item.Element("Skillsplitted").Value;

                    lbStudyNoiDung.Text = item.Element("Study").Value;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Chưa thêm chiến pháp cho "+txtTen.Text);
            }
            
  
        }     
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }       

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Chưa xác định tướng cần sửa !!!");
            }
            else
            {
                new frmChienPhap_Suamoi(txtTen.Text).Show();
                this.Hide();
            }
        }

        private void btnTimCP_Click(object sender, EventArgs e)
        {
            XElement thongtin = XElement.Load("F:\\File xml ROW\\ThongTin.xml");
            var items = (from el in thongtin.Descendants()
                         where (string)el.Attribute("TênCP") == txtTenCP.Text
                         select el.Name
                ).ToList();
            foreach (var item in items)
            {
                if(item == "BasicSkill")
                {
                    lbBasicSkillTen.Text = txtTenCP.Text;
                    var itemSkill = (from el in thongtin.Descendants()
                                          where (string)el.Attribute("TênCP") == txtTenCP.Text
                                          select (string)el).ToList();
                    foreach (var Skill in itemSkill)
                    {
                        lbBasicSkillNoiDung.Text = Skill;
                    }
                    lbSkillsplittedTen.Text = "";
                    lbSkillsplittedNoiDung.Text = "";
                    lbStudyNoiDung.Text = "";
                }
                if (item == "Skillsplitted")
                {
                    lbSkillsplittedTen.Text = txtTenCP.Text;
                    var itemSkill = (from el in thongtin.Descendants()
                                           where (string)el.Attribute("TênCP") == txtTenCP.Text
                                           select (string)el).ToList();
                    foreach (var Skill in itemSkill)
                    {
                        lbSkillsplittedNoiDung.Text = Skill;
                    }
                    lbBasicSkillTen.Text = "";
                    lbBasicSkillNoiDung.Text = "";
                    lbStudyNoiDung.Text = "";
                }
                if (item == "Study")
                {
                    var itemSkill = (from el in thongtin.Descendants()
                                     where (string)el.Attribute("TênCP") == txtTenCP.Text
                                     select (string)el).ToList();
                    foreach (var Skill in itemSkill)
                    {
                        lbStudyNoiDung.Text = Skill;
                    }
                    lbBasicSkillTen.Text = "";
                    lbBasicSkillNoiDung.Text = "";
                    lbSkillsplittedTen.Text = "";
                    lbSkillsplittedNoiDung.Text = "";
                }

                var itemsTen = (from el in thongtin.Descendants()
                             where (string)el.Element(item) == lbBasicSkillNoiDung.Text
                             select (string)el.Element("Ten")
                    ).ToList();
                foreach (var itemTen in itemsTen)
                {
                    txtTen.Text = itemTen;
                }
               
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Chưa xác định tướng cần thêm !!!");
            }
            else
            {
                new frmChienPhap_Themmoi(txtTen.Text).Show();
                this.Hide();
            }
        }
    }
}
