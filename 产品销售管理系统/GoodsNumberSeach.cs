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
    public partial class GoodsNumberSeach : Form
    {
        public GoodsNumberSeach()
        {
            InitializeComponent();
        }

        private void GoodsNumberSeach_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“restockDataSet.GoodsInfor”中。您可以根据需要移动或删除它。
            this.goodsInforTableAdapter.Fill(this.restockDataSet.GoodsInfor);

        }
    }
}
