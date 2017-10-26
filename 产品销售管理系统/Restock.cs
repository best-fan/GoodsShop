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
    public partial class Restock : Form
    {
        private DataSet dataSet = new DataSet();
        private SqlDataAdapter dataAdapter;
        public Restock()
        {
            InitializeComponent();
        }

        private void Restock1_Load(object sender, EventArgs e)
        {
            GoodsNamCbo.Items.Clear(); 
            //建立数据库连接
            SqlConnection con = Database.connect.Clink();
            string GoodsName = string.Format("select * from [GoodsInfor]");
            SqlCommand com = new SqlCommand(GoodsName, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {

                GoodsNamCbo.Items.Add(dr["GoodsName".ToString()]);

            }
            dr.Close();
            con.Close();
           // GoodsNamCbo.Sorted = true;  //列表排序
            //GoodsNamCbo.Items.Add("请选择");
            GoodsNamCbo.Items.Insert(0, "请选择");
            GoodsNamCbo.SelectedIndex = 0;




            // dataGridView 中添加数据  
            string dataAdd = "select GoodsId,GoodsName,BuyPrice,GoodsNumber from [GoodsInfor]";
            dataAdapter = new SqlDataAdapter(dataAdd, con);
            dataAdapter.Fill(dataSet, "GoodsInfor");
            dataGridView1.DataSource = dataSet.Tables["GoodsInfor"];
        }

        private void GoodsNamCbo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AddNumbtxt.Clear();
            AddNametet.Clear();
            if (GoodsNamCbo.SelectedIndex ==0)
            {
                GoodsId.Text = "";
                GoodsType.Text = "";
                GoodsPlace.Text = "";
                BuyPrice.Text = "";
                PurchaseDate.Text = "";
                GoodsNumtxt.Clear();
                pictureBox1.Image = null;
            }
            else
            {
                SqlConnection con = Database.connect.Clink();
                string GooodsInforAdd = string.Format("select * from [GoodsInfor] where GoodsName='{0}' ", GoodsNamCbo.SelectedItem.ToString());
                SqlCommand com = new SqlCommand(GooodsInforAdd, con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                GoodsId.Text = dr["GoodsId"].ToString();
                GoodsType.Text = dr["GoodsType"].ToString();
                GoodsPlace.Text = dr["GoodsPlace"].ToString();
                GoodsNumtxt.Text = dr["GoodsNumber"].ToString();
                BuyPrice.Text = dr["BuyPrice"].ToString();
                
                PurchaseDate.Text = DateTime.Now.ToLongDateString() + "\t" + DateTime.Now.ToLongTimeString();
                AddNametet.Text = Database.connect.user;
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

        private void AddButt_Click(object sender, EventArgs e)
        {
            if (AddNumbtxt.Text == string.Empty)
            {
                MessageBox.Show("添加数量不能为空");
            }
            else
            {

                SqlConnection con = Database.connect.Clink();//打开数据库连接;
                String RestockInfor = String.Format("insert into RestockInfor( GoodsId,GoodsName,PurchaseNumber,WriteName,PurchaseDate) values('{0}','{1}','{2}','{3}','{4}')", GoodsId.Text.Trim(), GoodsNamCbo.SelectedItem.ToString(), Convert.ToInt32(AddNumbtxt.Text), AddNametet.Text.Trim(), PurchaseDate.Text.Trim());
                SqlCommand Add = new SqlCommand(RestockInfor, con);
                Add.ExecuteNonQuery();
                int addNum = Convert.ToInt32(Convert.ToInt32( GoodsNumtxt.Text) +Convert.ToInt32( AddNumbtxt.Text));
                String GoodsNumber = String.Format(("update GoodsInfor set GoodsNumber='{0}' where GoodsId='{1}'"), addNum, GoodsId.Text.Trim());
                SqlCommand Update = new SqlCommand(GoodsNumber, con);
                Update.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("添加成功", "提示");
            }
        }
        private void AddNumbtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        //编辑的dataGridView单元格
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                e.Control.KeyPress += new KeyPressEventHandler(AddNum_KeyPress);
            }
        }
        //判断用户的输入
        private void AddNum_KeyPress(object sender,KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(dataGridView1.Rows[1].Cells[5].Value.ToString());
            //int rows = dataGridView1.Rows.Count;//获取行数
            //int cell = dataGridView1.ColumnCount;//获取列数
            //for (int i = 0; i < rows; i++)
            //{

            //    for (int j = 0; j <cell; j++)
            //    {
                   
            //        if (dataGridView1.Rows[i].Cells[j].Value!=null && dataGridView1.Rows[i].Cells[j].Value.ToString()!="")
            //        {
            //            string sd = dataGridView1.Rows[i].Cells[j].Value.ToString();//获取指定单元格值
            //            MessageBox.Show(sd);
            //        }
            //    }
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
