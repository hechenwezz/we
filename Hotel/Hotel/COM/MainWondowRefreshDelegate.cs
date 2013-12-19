using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hotel.COM
{
    /// <summary>
    /// 使用委托 在窗体之间传递 方法
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void MainWondowRefreshDelegate(object sender, RoutedEventArgs e);
  
}
