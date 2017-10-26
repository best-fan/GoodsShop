using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 产品销售管理系统
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Selectpanel.Visible = false;
            GoodsInfpanel.Visible = false;
            toolStripLabel7.Text = "欢迎用户:" + Database.connect.user + "\n" +  DateTime.Now.ToLongDateString();
            //toolStripStatusLabel1.Text = "欢迎" + Database.connect.user + "用户登录";
            //toolStripStatusLabel3.Text= "登陆时间：" + DateTime.Now;
            if (Database.connect.userType=="员工")
            {
                会员管理ToolStripMenuItem.Enabled = false;
                用户管理ToolStripMenuItem.Enabled = false;
                数据备份ToolStripMenuItem.Enabled = false;
                ChangeButt.Enabled = false;
            }
           
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            login log = new login();
            log.Show();
            this.Hide();

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Selectpanel.Visible = true;        
           
         
        }
        //修改密码 lable
        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword();
            frm.ShowDialog();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword();
            frm.ShowDialog();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            LockForm frm = new LockForm();
            frm.ShowDialog();
        }

        private void 商品录入ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GoodsAdd frm = new GoodsAdd();
            frm.ShowDialog();
        }

        private void 商品录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsAdd frm = new GoodsAdd();
            frm.ShowDialog();
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {

            InputTexbox.Focus();
        }

        //Selectpanel查询
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = Database.connect.Clink();//打开数据库连接;
            String GoodsSecl = String.Format(("select * from GoodsInfor where GoodsName ='{0}' or GoodsId = '{1}'"), InputTexbox.Text.Trim(), InputTexbox.Text.Trim());
            //创建数据适配器
            SqlDataAdapter da = new SqlDataAdapter(GoodsSecl, con);
            //创建满足条件的数据集
            DataSet ds = new DataSet();
            da.Fill(ds);
            //判断商品是否存在
            if (ds.Tables[0].Rows.Count != 0)
            {
                //显示  商品信息 Panel
                GoodsInfpanel.Visible = true; 
                string sqlPro = string.Format("select * from [GoodsInfor] where GoodsId='{0}' or GoodsName = '{1}'", InputTexbox.Text.Trim(),InputTexbox.Text.Trim());
                SqlCommand com1 = new SqlCommand(sqlPro, con);
                SqlDataReader dr = com1.ExecuteReader();
                dr.Read();
                GoodsId.Text = dr["GoodsId"].ToString();
                GoodsName.Text = dr["GoodsName"].ToString();
                GoodsType.Text = dr["GoodsType"].ToString();
                GoodsPlace.Text= dr["GoodsPlace"].ToString();
                SelingPrice.Text= dr["SelingPrice"].ToString();
                GoodsNumber.Text = dr["GoodsNumber"].ToString();
                Other.Text= dr["Other"].ToString();
                BuyPri= dr["BuyPrice"].ToString();
                PicUrl = dr["PictureUrl"].ToString();
                dr.Close();
                con.Close();
                if ( PicUrl=="不存在")
                { }
                else
                {
                    pictureBox1.Image = Image.FromFile(PicUrl);
                }
              
            }
            else
            {
                MessageBox.Show("对不起,该商品不存在", "提示");
            }
            
           // Selectpanel.Visible = false;         
        }
        public String PicUrl, BuyPri;//声明字段保存图片路径；

        //GoodsInfpanel  显示
        private void GoodsInfpanel_VisibleChanged(object sender, EventArgs e)
        {
            ChangePicLinkLab.Visible = false;
            BuyPriceLable.Visible =false; 
            BuyPriceTex.Visible = false;
            label1.Location = new Point(900, 270);
        }

        private void 返回button1_Click(object sender, EventArgs e)
        {
            InputTexbox.Clear();
            GoodsInfpanel.Visible = false;
            ChangeButt.Text = "修改";
        }
        private void 修改button2_Click(object sender, EventArgs e)
        {
            //textbox  是否可读***********************************
            GoodsName.ReadOnly = false;
            Other.ReadOnly = false;
            SelingPrice.ReadOnly = false;
            BuyPriceTex.ReadOnly = false;
            if (ChangeButt.Text == "修改")
            {
                ChangePicLinkLab.Visible = true;
                BuyPriceLable.Visible = true;
                BuyPriceTex.Visible = true;
                BuyPriceTex.Text = BuyPri;
                ChangeButt.Text = "保存修改";
            }
         else   
             if(ChangeButt.Text == "保存修改")
            {
                if(PicUrl==string.Empty)
                {
                    PicUrl = "不存在";
                }
                SqlConnection con = Database.connect.Clink();//打开数据库连接;
                String GoodsAdd = String.Format(("update GoodsInfor set GoodsName='{0}', BuyPrice='{1}' ,SelingPrice='{2}', Other='{3}',PictureUrl='{4}' where GoodsId='{5}'"), GoodsName.Text.Trim(), BuyPriceTex.Text.Trim(), SelingPrice.Text.Trim(), Other.Text.Trim(), PicUrl.Trim(), InputTexbox.Text.Trim());
                //创建数据适配器
                SqlCommand com = new SqlCommand(GoodsAdd, con);
                com.ExecuteNonQuery();
                con.Close(); 
                ChangeButt.Text = "修改";
                MessageBox.Show("修改成功", "提示");
                ChangePicLinkLab.Visible = false; ;
                GoodsName.ReadOnly = true;
                Other.ReadOnly = true;
                SelingPrice.ReadOnly = true;
                BuyPriceTex.ReadOnly = true;

            }
        }

        private void ChangePicLinkLab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                return;
            }
            else
            {
                PicUrl = path;
                pictureBox1.Image = Image.FromFile(path);//显示图片
            }
        }

        private void 进货录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restock from = new Restock();
            from.ShowDialog();
        }

        private void 进货查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestockSeach from = new RestockSeach();
            from.ShowDialog();
          
        }

        private void 用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Database.connect.userType=="员工")
            {
                MessageBox.Show("用户名：" + Database.connect.user + "\n账户类型：普通员工" + "\n您可享有系统的基本功能","用户信息",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("用户名：" + Database.connect.user + "\n账户类型：管理员" + "\n您可享有系统的全部功能", "用户信息", MessageBoxButtons.OK);
            }
        }
        //返回主界面
        private void BackLinklab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InputTexbox.Clear();
            Selectpanel.Visible = false;
        }

        private void GoodsInfpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            //如果输入的不是数字键、Backspace键(删除8)(46.)，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)46 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void BuyPriceTex_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键、Backspace键(删除8)(46.)，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)46 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void GoodsNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键、Backspace键(删除8)(46.)，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) &&e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void 商品查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selectpanel.Visible = true;
        }

        private void 商品销售ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsSeling from = new GoodsSeling();
            from.ShowDialog();
        }

        private void 销售查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelingSeach form = new SelingSeach();
            form.ShowDialog();
        }

        private void 库存查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsNumberSeach form = new GoodsNumberSeach();
            form.ShowDialog();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUser form = new AllUser();
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text="当前时间："+DateTime.Now.ToLongTimeString();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Process.Start("http://besttimes.sinaapp.com/");
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void 记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("软件制作人：小樊,\n软件为测试阶段，功能还待完善\n功能完善版\n请联系作者\n软件版本：V15.11.21");
        }
        //库存查询
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            GoodsNumberSeach form = new GoodsNumberSeach();
            form.ShowDialog();
        }
        
        private void InputTexbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断用户输入的是否为回车
            if (e.KeyChar != (char)13)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

       

        private void InputTexbox_KeyDown(object sender, KeyEventArgs e)
        {
            //判断用户是否按下回车
            if (e.KeyCode==Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            GoodsSeling form = new GoodsSeling();
            form.ShowDialog();
        }
       

    }
}
