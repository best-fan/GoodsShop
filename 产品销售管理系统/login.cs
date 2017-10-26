using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 产品销售管理系统
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 注册按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registered reg = new Registered();
            reg.Show();
        }
        /// <summary>
        /// 登陆按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            //判断用户名或密码是否为空；
            if (textBox1.Text.Trim() == string.Empty || textBox2.Text.Trim()== string.Empty)
            {
                MessageBox.Show("用户名、密码不能为空","登陆提示");
                textBox1.Focus();
            }

            else
            {   
                SqlConnection con = Database.connect.Clink();//新建数据库连接
                string sqlstr = string.Format("select * from [Login] where UserId='{0}' and PassWord='{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
                //创建满足条件的数据集
                DataSet ds = new DataSet();
                da.Fill(ds);
                //判断是否存在用户信息
                if (ds.Tables[0].Rows.Count != 0)
                {
                    SqlCommand com1 = new SqlCommand(sqlstr, con);
                    SqlDataReader dr = com1.ExecuteReader();
                    dr.Read();
                    Database.connect.userType= dr["Power"].ToString().Trim();
                    //储存用户名 和密码；
                    Database.connect.user = textBox1.Text;
                    Database.connect.password = textBox2.Text;
                    MessageBox.Show("登陆成功");
                    con.Close();
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，登陆失败！","登陆提示");
                    textBox1.SelectAll();
                    textBox1.Focus();
                }
            }

        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox1.Text = Database.connect.user;
            textBox1.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Forgetpassword form = new Forgetpassword();
            form.Show();

        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//关闭程序
        }

        private void login_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
