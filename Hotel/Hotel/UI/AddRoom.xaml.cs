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
    /// AddRoom.xaml 的交互逻辑
    /// </summary>
    public partial class AddRoom : Window
    {
        public AddRoom()
        {
            InitializeComponent();
        }
        public MainWondowRefreshDelegate RoomRefresh;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Room room = new Room();
            room.Id = Guid.NewGuid();
            room.RoomNumber = tbRoomNumber.Text;
            room.RoomRate =Convert .ToDecimal ( tbRoomRate.Text);
            room.RoomType = tbRoomType.Text;
            room.RoomState = "空";

            AddRoomBLL.addRoom(room);
            

            tbRoomNumber.Text = "";
            tbRoomRate.Text = "";
            tbRoomType.Text = "";
            RoomRefresh(sender, e);
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            addRomWindow.Close();
           
        }
    }
}
