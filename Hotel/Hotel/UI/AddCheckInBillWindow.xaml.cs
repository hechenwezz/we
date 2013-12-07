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
    /// AddCheckInBillWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddCheckInBillWindow : Window
    {
        public static Guid BillNumber { set; get; }
        public static string  GuestName { set; get; }
        public static string WaiterName { set; get; }

        public AddCheckInBillWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            Guest guest=new Guest ();
            guest.Id =AddGuestToRoom.FirstGuestId ;
            DataTable table=UseIdSelectGuestBLL.useIdSelectGuest (guest );
            DataRow row=table .Rows[0];
          
            lbBillNumber.Content = BillNumber=Guid.NewGuid();
            lbRoomNumber.Content = MainWondows.SelectRoomNumber;
            lbNumberOfPeaple.Content = AddGuestToRoom.NumberOfPeaple;
            lbRoomRate.Content = MainWondows.RoomRate;

            User user = new User();
            user.UserName = LoginWindows.UserName;
            DataTable userTable = UseUserNameSelectUserBLL .useUserNameSelectUser (user );
            DataRow userRow = userTable.Rows[0];
            lbWaiterName.Content = WaiterName = (string)userRow["Name"];
            lbGuestName.Content = GuestName = (string)row["Name"];
            lbDate.Content = System.DateTime.Now;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckInBill checkInBill = new CheckInBill();

            checkInBill.Id = Guid.NewGuid();
            checkInBill.BillNumber = BillNumber;
            checkInBill.RoomNumber = MainWondows.SelectRoomNumber;
            checkInBill.GuestName = GuestName;
            checkInBill.NumberOfPeaple =Convert .ToString ( AddGuestToRoom.NumberOfPeaple);
            checkInBill.RoomRate = MainWondows.RoomRate;
            if (Convert .ToDecimal ( tbAmountPaid.Text)>=MainWondows.RoomRate)
            {
                 checkInBill.AmountPaid =Convert .ToDecimal ( tbAmountPaid.Text);
                 checkInBill.WaiterName = WaiterName;
                 checkInBill.Date = System.DateTime.Now;
                 AddCheckInBillBLL.addCheckInBill(checkInBill);
                 tbAmountPaid.Text = "";
                 UpdateRoomBLL.updateRoomIsFull(checkInBill.RoomNumber);
                 addCheckInBill.Close();
                 AddGuestToRoom.NumberOfPeaple = 0;
            }
            else
            {
                lbNews.Content = "请输入一个大于或等于房价的金额！";
            }
            
        }

      
    }
}
