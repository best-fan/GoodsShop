using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 产品销售管理系统
{
    public partial class GoodsAdd : Form
    {
        public GoodsAdd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GoodsId.Text.Trim() == "" || GoodsName.Text.Trim() == "" || BuyPrice.Text.Trim() == "" || SelingPrice.Text.Trim() == "")
            {
                MessageBox.Show("您填写的商品信息不完整");

            }
            else if (CboCompany.SelectedItem.ToString() == "请选择" || CboType.SelectedItem.ToString() == "请选择")
            {
                MessageBox.Show("商品产地或类型未选择");
            }
            else
            {
                SqlConnection con = Database.connect.Clink();//打开数据库连接;
                String GoodsSecl = String.Format(("select count(*) from GoodsInfor where GoodsId='{0}'"),GoodsId.Text.Trim());
                //创建数据适配器
                SqlCommand com = new SqlCommand(GoodsSecl, con);
                int count =(int) com.ExecuteScalar();
                //判断商品是否存在
                if (count > 0)
                {
                    MessageBox.Show("对不起，该商品已存在，添加失败.", "提示");
                }
                else {
                    String GoodsAdd = String.Format("insert into GoodsInfor( GoodsId,GoodsName,GoodsType,GoodsPlace,BuyPrice,SelingPrice,Other,PictureUrl,GoodsNumber) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", GoodsId.Text.Trim(), GoodsName.Text.Trim(), CboType.SelectedItem.ToString(), CboCompany.SelectedItem.ToString(), BuyPrice.Text.Trim(), SelingPrice.Text.Trim(), Other.Text.Trim(), PictureUrl.Trim(),GoodsNumber);
                    SqlCommand add = new SqlCommand(GoodsAdd, con);
                    add.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("添加成功", "提示");
                }

            }



        }
        public string PictureUrl;
        public int  GoodsNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ope = new OpenFileDialog();
            //对话框标题
            ope.Title = "请选择一张图片";
            //文件是否可以多选
            ope.Multiselect = false;
            //文件初始目录
            ope.InitialDirectory = @"C:\";
            //设置对话框的文件类型
            ope.Filter = "图片文件|*.PNG|图片文件|*.JPEG|图片类型|*.JPG";
            //展示对话框
            ope.ShowDialog();
            //获得打开文件的路径
            string path = ope.FileName;
            if (path == "")
            {
                path = "不存在";
                return;
            }
            else
            {
                PictureUrl = path;
                pictureBox1.Image = Image.FromFile(path);//显示图片
            }
        }

        //取消
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "添加分类")
            {
                Database.connect.AddType = "添加分类";
                AddType from = new AddType();
                from.ShowDialog();
                linkLabel1.Text = "刷新";
            }
            else if(linkLabel1.Text=="刷新")
            {
                ComboAdd();
                linkLabel1.Text = "添加分类";
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel2.Text == "添加货源地")
            {
                Database.connect.AddType = "添加货源地";
                AddType from = new AddType();
                from.ShowDialog();
                linkLabel2.Text = "刷新";
            }
            else if(linkLabel2.Text== "刷新")
            {
                ComboAdd();
                linkLabel2.Text = "添加货源地";
            }
        }

        public void GoodsAdd_Load(object sender, EventArgs e)
        {
            Other.Text = "";
            PictureUrl = "不存在";
            GoodsNumber = 0;
            ComboAdd();
        }
        //combox   加载项******************************
        public void ComboAdd()
        {
            CboType.Items.Clear();
            CboCompany.Items.Clear();
            
            //建立数据库连接
            SqlConnection con =Database.connect.Clink();
            string TypeAdd = string.Format("select * from [TypePlace]");
            SqlCommand com = new SqlCommand(TypeAdd, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (dr["GoodsType"].ToString() == string.Empty)
                { }
                else
                {
                    CboType.Items.Add(dr["GoodsType"].ToString());
                }
                if (dr["GoodsPlace"].ToString() == string.Empty)
                { }
                else
                {
                    CboCompany.Items.Add(dr["GoodsPlace"].ToString());
                }
            }
            dr.Close();
            con.Close();
            CboType.Sorted = true;
            CboType.Items.Insert(0, "请选择");
            CboType.SelectedItem = "请选择";
            CboCompany.Sorted = true;
            CboCompany.Items.Insert(0, "请选择");
            CboCompany.SelectedItem = "请选择";
        }

        private void BuyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是.、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)46 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void SelingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是.、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)46 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

     
    }
}
