using Hotel.BLL;
using Hotel.COM;
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
using System.Windows.Shapes;

namespace Hotel.UI
{
    /// <summary>
    /// AddUserWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public AddUserWindow()
        {
            InitializeComponent();
        }
        public  MainWondowRefreshDelegate UserRefresh;
        private void Button_Click(object sender, RoutedEventArgs e)

        {
            User user = new User();
            user.Id = Guid.NewGuid();
            user.Name = tbName.Text;
            user.IdentityCardNumber = tbIdentityCardNumber.Text;
            if (rbMan.IsChecked == true && rbWoman.IsChecked == false)
            {
                user.Sex = "男";
            }
            else if (rbMan.IsChecked == false && rbWoman.IsChecked == true)
            {
                user.Sex = "女";
            }
            else
            {
                lbMessge.Content ="请选择性别！";
            }
            user.Address = tbAddress.Text;
            user.Duty = "服务员";
            user.UserName = tbUeserName.Text;
            user.Password = tbPassword.Text;

            AddUserBLL.addUser(user);
            UserRefresh(sender, e);
            tbName.Text = "";
            tbIdentityCardNumber.Text = "";
            tbAddress.Text = "";
            tbUeserName.Text = "";
            tbPassword.Text = "";


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            addUserWindow.Close();
        }
    }
}
