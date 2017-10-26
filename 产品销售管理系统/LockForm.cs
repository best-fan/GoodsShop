using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 产品销售管理系统
{
    public partial class LockForm : Form
    {
        public LockForm()
        {
            InitializeComponent();
        }

        private void LockForm_Load(object sender, EventArgs e)
        {
            label4.Text = Database.connect.user;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forgetpassword from = new Forgetpassword();
            from.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()==Database.connect.password.Trim())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("对不起，您输入的密码有误");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

    }
}
