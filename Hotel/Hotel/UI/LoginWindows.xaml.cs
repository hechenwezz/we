using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hotel.BLL;
using System.Data;
using Hotel.COM;

namespace Hotel.UI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindows : Window
    {
        public static string UserName { set; get; }
        public static string WaiterName { set; get; }
        public LoginWindows()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 用户登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSuer_Click(object sender, RoutedEventArgs e)
        {
          
            User user = new User();
            if (tbxUserName.Text == "" || pwbPassword.Password == "")
            {
                lbReminder.Content = "用户名或密码不能为空，请输入！";
            }
            else
            {
                user.UserName = tbxUserName.Text;
                user.Password = pwbPassword.Password;


                DataTable table = LoginBll.Login(user);

                if (table.Rows.Count <= 0)
                {
                    lbReminder.Content = "用户名不存在，请查证后再输入！";
                    return;
                }
                if (table.Rows.Count > 1)
                {
                    lbReminder.Content = "有多个用户存在，请联系管理员！";
                    return;
                }
                DataRow row = table.Rows[0];
                string dataUserPasswod = (string)row["Password"];
                if (dataUserPasswod != user.Password)
                {
                    lbReminder.Content = "密码错误，请查证后再输入！";
                }
                else
                {
                    UserName = user .UserName ;
                    MainWondows mainWindows = new MainWondows();

                    DataTable userTable = UseUserNameSelectUserBLL.useUserNameSelectUser(user);
                    DataRow userRow = userTable.Rows[0];
                    WaiterName  = (string)userRow["Name"];

                    mainWindows.Show();
                    LoginWindow.Close();
                }
            }
        }
        /// <summary>
        /// 加载登陆窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private void Windows_Loaded(object sender, RoutedEventArgs e)
        {
            if (TestDatabaseLinkBLL.TestDatabaseLink() == false)
            {
                MessageBox.Show("无法连接数据库，请检查数据库服务是否开启！");
                Environment.Exit(0);//强制关闭应用程序
            }
        }
    }
}
