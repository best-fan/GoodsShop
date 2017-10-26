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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入原始密码");
                textBox1.SelectAll();
                textBox1.Focus();
            }

            else
            {
               //判断密码是否相等
                if (textBox1.Text.Trim()==Database.connect.password)
                {
                    if(string.IsNullOrEmpty( textBox2.Text.Trim())|| string.IsNullOrEmpty(textBox3.Text.Trim()))
                    {

                        MessageBox.Show("新密码不能为空");
                    }
                    else
                    {
                        if(textBox2.Text==textBox3.Text)
                        {
                            SqlConnection con = Database.connect.Clink();//新建数据库连接
                            string sqlchange = string.Format("update Login set PassWord='{0}' where UserId='{1}'", textBox2.Text, Database.connect.user);
                            SqlCommand com = new SqlCommand(sqlchange, con);
                            SqlDataReader sr = com.ExecuteReader();
                            con.Close();
                            MessageBox.Show("密码修改成功；");
                            Database.connect.password = textBox2.Text; 
                            this.Close();
                            
                          
                        }
                        else
                        {
                            MessageBox.Show("您输入的两次新密码不一致");
                        }

                       
                    }
                }
                else
                {
                    MessageBox.Show("原始密码错误;");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
