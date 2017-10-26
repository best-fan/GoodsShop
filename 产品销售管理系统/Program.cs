using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 产品销售管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
         //   Application.Run(new GoodsSeling());
            //Application.Run(new Main());
            //Application.Run(new Restock());
            //Application.Run(new GoodsAdd());
        }

    }
}
