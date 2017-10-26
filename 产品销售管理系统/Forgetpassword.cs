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
    public partial class Forgetpassword : Form
    {
        public Forgetpassword()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 返回按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            login form = new login();
            form.Show();
        }
        public string Answer, PassWord;//存储用户设置的答案、密码；
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("用户名不能为空");
            }
            else
            {
                
                SqlConnection con = Database.connect.Clink();//新建数据库连接
                string sqlstr = string.Format("select count(*) from [Login] where UserId='{0}'", textBox1.Text);
                SqlCommand com = new SqlCommand(sqlstr, con);
                int count = (int)com.ExecuteScalar();
                if (count > 0)//判断用户是否存在
                {
                    //返回用户设置的问题、答案、密码；
                    string sqlPro = string.Format("select Problem,Answer,PassWord from [Login] where UserId='{0}'", textBox1.Text);
                    SqlCommand com1 = new SqlCommand(sqlPro, con);
                    SqlDataReader dr = com1.ExecuteReader();
                    dr.Read();
                    textBox2.Text = dr["Problem"].ToString();
                    Answer = dr["Answer"].ToString();
                    PassWord = dr["PassWord"].ToString();
                    button1.Enabled = true; //启用找回按钮                   
                }
                else
                {
                    MessageBox.Show("该用户不存在");
                }
            }
        }
        /// <summary>
        /// 找回按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() == Answer.Trim())
            {
                string str = "用户名：" + textBox1.Text + "\t\t\n密码：" + PassWord + "\t\t\n请妥善保管好您的用户信息！！";
                MessageBox.Show(str);
                Database.connect.user = textBox1.Text.Trim();

                
            }
            else
            {
                MessageBox.Show("答案错误！");
            }

        }
    }
}
