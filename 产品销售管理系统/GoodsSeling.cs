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
    public partial class GoodsSeling : Form
    {
        public GoodsSeling()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoodsSeling_Load(object sender, EventArgs e)
        {
            AddNametet.Text = Database.connect.user;
            GoodsNameCmbo.Items.Clear();
            GoodsNameCmbo.Items.Add("请选择");
            GoodsNameCmbo.SelectedIndex = 0;
            SqlConnection con = Database.connect.Clink();//新建数据库连接
            string GoodsSeach = string.Format("select * from [GoodsInfor]");
            SqlCommand com = new SqlCommand(GoodsSeach, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                GoodsNameCmbo.Items.Add(dr["GoodsName".ToString()]);

            }
            dr.Close();
            con.Close();
        }


       private   void GoodsNameCmbo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (GoodsNameCmbo.SelectedIndex == 0)
            {
                GoodsId.Text = "";
                GoodsType.Text = "";
                GoodsPlace.Text = "";
                GoodsNumber.Text = "";
                SelingPrice.Text = "";
                Other.Text = "";
                BuyNumbtxt.Text = "";
                pictureBox1.Image =null ;
            }
            else
            {
                SqlConnection con = Database.connect.Clink();
                string GooodsInforAdd = string.Format("select * from [GoodsInfor] where GoodsName='{0}' ", GoodsNameCmbo.SelectedItem.ToString());
                SqlCommand com = new SqlCommand(GooodsInforAdd, con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                GoodsId.Text = dr["GoodsId"].ToString();
                GoodsType.Text = dr["GoodsType"].ToString();
                GoodsPlace.Text = dr["GoodsPlace"].ToString();
                GoodsNumber.Text = dr["GoodsNumber"].ToString();
                SelingPrice.Text = dr["SelingPrice"].ToString();
                Other.Text= dr["Other"].ToString();
                if (dr["PictureUrl"].ToString() == "不存在")
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(dr["PictureUrl"].ToString());
                }
                dr.Close(); 
                con.Close();
            }
        }

        private void Seachbutten_Click(object sender, EventArgs e)
        {
            if (SearchTxt.Text == string.Empty.Trim())
            {
                MessageBox.Show("商品名称不能为空", "搜索出错");
            }
            else    {
                SqlConnection con = Database.connect.Clink();
                string selStr = string.Format("select * from [GoodsInfor] where GoodsName='{0}'", SearchTxt.Text.Trim());
                //创建数据适配器
                SqlDataAdapter da = new SqlDataAdapter(selStr, con);
                //创建满足条件的数据集
                DataSet ds = new DataSet();
                da.Fill(ds);
                //如果不为空，则商品存在
                if (ds.Tables[0].Rows.Count != 0)
                {
                    GoodsNameCmbo.Text = SearchTxt.Text.Trim();
                    GoodsNameCmbo_SelectionChangeCommitted(sender,e);//调用GoodsNameCmbo_SelectionChangeCommitted事件



                }
                else
                {
                    MessageBox.Show("该商品不存在", "搜索提示");
                    SearchTxt.Clear();
                    SearchTxt.Focus();
                }
                con.Close();
                    }
        }
        public int OnePrice = 0, AllPrice;//存储价格************
        private void AddButt_Click(object sender, EventArgs e)
        {
            if (BuyNumbtxt.Text == string.Empty)
            {
                MessageBox.Show("请填写购买数量","购买提醒");
            }
            else if(GoodsNameCmbo.SelectedIndex == 0)
            {
                MessageBox.Show("请选择一个商品", "购买提醒");
            }
            else if (Convert.ToInt32(BuyNumbtxt.Text) > Convert.ToInt32(GoodsNumber.Text)&&Convert.ToInt32( BuyNumbtxt.Text)>0)
            {
                MessageBox.Show("你购买的商品个数不正确!!","购买失败");
            }
            else
            {
                if (MessageBox.Show("商品名称：" + GoodsNameCmbo.Text + "\n商品数量:\t" + BuyNumbtxt.Text + "\n请确认购买信息是否正确", "购买提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    //点击确定      
                    ListViewItem list = listView1.Items.Add((listView1.Items.Count + 1) + "");
                    OnePrice = Convert.ToInt32(SelingPrice.Text) * Convert.ToInt32(BuyNumbtxt.Text);
                    AllPrice += OnePrice;
                    list.SubItems[0].Text = GoodsId.Text;
                    list.SubItems.Add(GoodsNameCmbo.Text);
                    list.SubItems.Add(GoodsType.Text);
                    list.SubItems.Add(SelingPrice.Text);
                    list.SubItems.Add(BuyNumbtxt.Text);
                    list.SubItems.Add(OnePrice.ToString("F2"));
                    list.SubItems.Add(AllPrice.ToString("F2"));
                    list.SubItems.Add(AddNametet.Text);
                    list.EnsureVisible();
                    textBox1.Text = AllPrice.ToString("F2");
                    textBox2.Focus();

                }
                else
                {

                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count==0)
            {
                MessageBox.Show("您的商品还未提交至商品结算列表中");
            }
            else if(textBox2.Text.Trim()==string.Empty)
            {
                MessageBox.Show("请输入实收款");
                textBox2.Focus();
            }
            else if (Convert.ToInt32(textBox2.Text) >= AllPrice)
            {
                DateTime dt = DateTime.Now;
               
                textBox3.Text = (Convert.ToInt32(textBox2.Text) - AllPrice).ToString("F2");//计算 找零
                List<string> list = new List<string>();
                foreach (ListViewItem it in listView1.Items)
                {
                    string GoodsId= it.SubItems[0].Text.ToString().Trim();
                    string GoodName = it.SubItems[1].Text.ToString().Trim();
                    string GoodsType = it.SubItems[2].Text.ToString();
                    string SelingPrice = it.SubItems[3].Text.ToString().Trim();
                    string BuyNumber = it.SubItems[4].Text.ToString();
                    string PayPrice = it.SubItems[5].Text.ToString().Trim();
                    string AddName = AddNametet.Text.ToString();
                    string time =dt.GetDateTimeFormats('f')[0].ToString() ;
                    //链接数据库**********
                    SqlConnection con = Database.connect.Clink();
                    string SelingAdd = string.Format("insert into GoodsSeling values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", GoodsId, GoodName, GoodsType, SelingPrice, BuyNumber, PayPrice, AddName, time);
                    SqlCommand com = new SqlCommand(SelingAdd, con);
                    com.ExecuteNonQuery();
                    string GooodsInforSel= string.Format("select * from [GoodsInfor] where GoodsName='{0}'", GoodsNameCmbo.Text.ToString());
                    SqlCommand com1 = new SqlCommand(GooodsInforSel, con);
                    SqlDataReader dr = com1.ExecuteReader();
                    dr.Read();
                    int  Number= Convert.ToInt32(dr["GoodsNumber"].ToString()) - Convert.ToInt32( BuyNumber);//商品剩余数量
                    dr.Close();
                    string GooodsInforUpdate = string.Format("update GoodsInfor set GoodsNumber='{0}' where GoodsId='{1}' ",Number.ToString(),GoodsId);
                    SqlCommand com2 = new SqlCommand(GooodsInforUpdate, con);
                    com2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("恭喜您,结算成功");

                }
              
            }
            else
            {
                MessageBox.Show("对不起，实收款不对哟···");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断用户输入的是否为数字、BackSpace键
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            //判断用户是否按下回车
            if (e.KeyCode == Keys.Enter)
            {
                Seachbutten_Click(sender, e);
            }
        }

        private void BuyNumbtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断用户输入的是否为数字、BackSpace键
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

     
    }
}
