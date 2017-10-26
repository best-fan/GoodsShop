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
    public partial class AllUser : Form
    {
        private DataSet dataSet = new DataSet();
        private SqlDataAdapter dataAdapter;
        public AllUser()
        {
            InitializeComponent();
        }

        private void AllUser_Load(object sender, EventArgs e)
        {
            string dataAdd = "select * from Login";
            SqlConnection con = Database.connect.Clink();
            dataAdapter = new SqlDataAdapter(dataAdd, con);
            dataAdapter.Fill(dataSet, "Login");
            dataGridView1.DataSource = dataSet.Tables["Login"];

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //int rowindex = this.dataGridView1.CurrentCell.RowIndex; //选中所选行
            //string code = this.dataGridView1[1, rowindex].Value.ToString();//获取选中行的第二个单元格值
            //MessageBox.Show(code);
            DialogResult resulrt = MessageBox.Show("是否保存修改", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (resulrt == DialogResult.Yes)
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter); 
                dataAdapter.Update(dataSet, "Login");
                MessageBox.Show("更新成功！");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            dt.Rows.Clear();
            AllUser_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
