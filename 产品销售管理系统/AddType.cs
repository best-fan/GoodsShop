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
    public partial class AddType : Form
    {
        public AddType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty )
            {
                MessageBox.Show("输入类型不能为空", "添加提示");
                textBox1.Focus();
            }
            else
            {

                SqlConnection con = Database.connect.Clink();//打开数据库连接;
                string sqlstr = string.Format("select count(*) from TypePlace where GoodsType='{0}'", textBox1.Text.Trim());
                SqlCommand com = new SqlCommand(sqlstr, con);
                int count = (int)com.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("该类型已存在");
                    con.Close();
                }
                else
                {
                    string TypeAdd = string.Format("INSERT INTO TypePlace (GoodsType) VALUES ('{0}')", textBox1.Text.Trim());
                    SqlCommand com1 = new SqlCommand(TypeAdd, con);
                    com1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("类型添加成功");

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("输入货源地不能为空", "添加提示");
                textBox2.Focus();
            }
            else
            {

                SqlConnection con = Database.connect.Clink();//打开数据库连接;
                string sqlstr = string.Format("select count(*) from TypePlace where GoodsPlace='{0}'", textBox2.Text.Trim());
                SqlCommand com = new SqlCommand(sqlstr, con);
                int count = (int)com.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("该货源地已存在");
                    con.Close();
                }
                else
                {
                    string TypeAdd = string.Format("INSERT INTO TypePlace (GoodsPlace)VALUES ('{0}')", textBox2.Text.Trim());
                    SqlCommand com1 = new SqlCommand(TypeAdd, con);
                    com1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("货源地添加成功");

                }
            }
        }

        private void AddType_Load(object sender, EventArgs e)
        {
            if(Database.connect.AddType== "添加分类")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
        }
    }
}
