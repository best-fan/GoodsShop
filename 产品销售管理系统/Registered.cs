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
    public partial class Registered : Form
    {
        public Registered()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = Database.connect.Clink();
            string selStr = string.Format("select * from [Login] where UserId='{0}'", usertextbox.Text);
            //创建数据适配器
            SqlDataAdapter da = new SqlDataAdapter(selStr, con);
            //创建满足条件的数据集
            DataSet ds = new DataSet();
            da.Fill(ds);
            //如果数据集不为空，则用户名已经存在
            if (ds.Tables[0].Rows.Count != 0)//判读用户是否存在
            {
                MessageBox.Show("对不起，该用户已存在", "注册信息");
                con.Close();
                return;
            }
            else if (usertextbox.Text.Trim() == "" || passtextBox.Text.Trim() == "")//判断用户名、密码是否为空
            {
                MessageBox.Show("用户名或密码不能为空！", "注册信息");
            }
            else if (que_texbox.Text.Trim() == "" || ans_texbox.Text.Trim() == "")//判断安全问题、答案是否为空
            {
                MessageBox.Show("安全问题、答案不能为空", "注册信息");
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)//判断用户类型是否选定
            {
                MessageBox.Show("请选择用户类型", "注册信息");
            }

            else if (passtextBox.Text == passtextBox1.Text)//判断密码是否相等
            {
                string Type;
                if (radioButton1.Checked == true)// 判断用户类型
                {
                    Type = radioButton1.Text;

                }
                else
                {
                    Type = radioButton2.Text;
                }
                string add = string.Format("insert into Login( UserId,PassWord,Power,Problem,Answer) values('{0}','{1}','{2}','{3}','{4}')", usertextbox.Text.Trim(), passtextBox.Text.Trim(), Type.Trim(), que_texbox.Text.Trim(), ans_texbox.Text.Trim());
                SqlCommand com = new SqlCommand(add, con);
                com.ExecuteNonQuery();
                con.Close();
                Database.connect.user = usertextbox.Text.ToString();
                MessageBox.Show("注册成功！点击确定，返回登录界面。", "提示");
                this.Hide();
                login f1 = new login();
                f1.Show();
            }
            else
            {
                MessageBox.Show("密码错误，请检查两次密码是否一致", "注册信息");
            }
        }

        private void Registered_Load(object sender, EventArgs e)
        {
            SqlConnection con = Database.connect.Clink();
            SqlCommand mycmd = new SqlCommand("select count(*)from Login where Power='管理员'", con);
            int Numb = Convert.ToInt32(mycmd.ExecuteScalar());
            if (Numb>= 3)
            {
                radioButton2.Enabled = false;
                radioButton1.Checked = true;
            }

            con.Close();
        }
    }
}
