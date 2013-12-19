using Hotel.BLL;
using Hotel.COM;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// MainWondows.xaml 的交互逻辑
    /// </summary>
    public partial class MainWondows : Window
    {
        public static string SelectRoomNumber { set; get; }
        public static decimal RoomRate { set; get; }
        public static string RoomType { set; get; }
        
       
        public MainWondows()
        {
            InitializeComponent();
        }

        private void AddRoom(object sender, RoutedEventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.RoomRefresh = RoomRefresh;
            addRoom.Show();
        }
        /// <summary>
        /// 房间数据初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            dgRoom.ItemsSource = LoadRoomDataBLL.loadRoomData1();//绑定数据
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(ProcessRows));//设置datagrid 行的字体颜色
        }
        //public  void DataGrid_LoadedForAddRoom()
        //{
        //    dgRoom.ItemsSource = LoadRoomDataBLL.loadRoomData1();//绑定数据
        //    Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(ProcessRows));//设置datagrid 行的字体颜色
        //}
        private void ProcessRows()//条件函数
        {
            DataTable EmptyTable = SelectRoomStateIsEmptyBLL.SelectRoomStateIsEmpty();
            DataTable FullTable = SelectRoomStateIsFullBLL.SelectRoomStateIsFull();
            for (int i = 0; i < EmptyTable.Rows.Count; i++)
            {
                var row = dgRoom.ItemContainerGenerator.ContainerFromItem(dgRoom.Items[i]) as DataGridRow;
                row.Foreground = new SolidColorBrush(Colors.Blue);//房间为空时设置为蓝色
            }
            for (int i = EmptyTable.Rows.Count; i < EmptyTable.Rows.Count + FullTable.Rows.Count; i++)
            {
                var row = dgRoom.ItemContainerGenerator.ContainerFromItem(dgRoom.Items[i]) as DataGridRow;
                row.Foreground = new SolidColorBrush(Colors.Red);//房间为满时设置为红色
            }
        }
        public void Refresh(object sender, RoutedEventArgs e)
        {
            dgRoom.ItemsSource = LoadRoomDataBLL.loadRoomData1();
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(ProcessRows));//设置datagrid 行的字体颜色
        }
        private void DataGridRowMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                
                
                RoomShow room = (RoomShow)dgRoom.SelectedItem;
                MainWondows.SelectRoomNumber = room.RoomNumber;
                MainWondows.RoomRate = room.RoomRate;
                MainWondows.RoomType = room.RoomType;
                if (room.RoomState == "空")
                {
                    AddGuestToRoom addGuestToRoomWindow = new AddGuestToRoom();
                    addGuestToRoomWindow.windowRefresh = DataGrid_Loaded;
             
                    addGuestToRoomWindow.Show();
                }
                else
                {
                    CheckOutBillWindow checkOutBillWindow = new CheckOutBillWindow();
                    checkOutBillWindow.wondowRefresh = DataGrid_Loaded;
                    checkOutBillWindow.Show();
                }
            }
            catch { MessageBox.Show("没有选中房间！"); }
            

        }

        private void RoomControlDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            dgRoomControl.ItemsSource = LoadRoomDataBLL.loadRoomData2();//绑定数据
         

        }
        

        private void RoomRefresh(object sender, RoutedEventArgs e)
        {
            dgRoomControl.ItemsSource = LoadRoomDataBLL.loadRoomData2();
           
        }

       

        private void CheckOutBillDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            dgCheckOutBill.ItemsSource = LoadCheckOutBillDataBLL.loadCheckOutBillData(LoginWindows .WaiterName );
        }

        private void CheckOutBillDataRefresh(object sender, RoutedEventArgs e)
        {
            dgCheckOutBill.ItemsSource = LoadCheckOutBillDataBLL.loadCheckOutBillData(LoginWindows.WaiterName);
        }

        private void UserDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.UserName = LoginWindows.UserName;
            DataTable userTable=  UseUserNameSelectUserBLL.useUserNameSelectUser(user);
            DataRow row = userTable.Rows[0];
            if((string)row["Duty"]=="管理员")
            { dgUserData.ItemsSource = LoadUserDataBLL.loadUserData(); }
           
        }

        private void UserDataRefresh(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.UserName = LoginWindows.UserName;
            DataTable userTable = UseUserNameSelectUserBLL.useUserNameSelectUser(user);
            DataRow row = userTable.Rows[0];
            if ((string)row["Duty"] == "管理员")
            { dgUserData.ItemsSource = LoadUserDataBLL.loadUserData(); }
           
        }

        private void CheckInDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            dgCheckInData.ItemsSource = LoadCheckInDataBLL.loadCheckInData();
        }

        private void CheckInDataRefresh(object sender, RoutedEventArgs e)
        {
            dgCheckInData.ItemsSource = LoadCheckInDataBLL.loadCheckInData();
        }

        private void UpdateRoom(object sender, RoutedEventArgs e)
        {
            Room UpdateRoom = new Room();
            UpdateRoom.RoomNumber = MainWondows.SelectRoomNumber;
            UpdateRoom.RoomRate = MainWondows.RoomRate;
            UpdateRoom.RoomType = MainWondows.RoomType;


           
        }
        /// <summary>
        /// 添加用户  加载用户信息录入窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUser(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.UserRefresh = UserDataRefresh;
            addUserWindow.Show();
        }
       
           
            
         }   

       

       
  
   
}
