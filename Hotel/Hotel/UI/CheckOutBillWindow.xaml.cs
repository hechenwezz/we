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
    /// CheckOutBillWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CheckOutBillWindow : Window
    {
        public CheckOutBill checkOutBill = new CheckOutBill();
        public CheckOutBillWindow()
        {
            InitializeComponent();
        }

        private void CheckOutBill_Loaded(object sender, RoutedEventArgs e)
        {
           
           DataTable checkInBill= UseRoomNumberSelectCheckInBillBLL.UseRoomNumberSelectCheckInBill(MainWondows.SelectRoomNumber);
           DataRow row = checkInBill.Rows[0];
           checkOutBill.Id = Guid .NewGuid ();
           lbBillNumber.Content= checkOutBill.BillNumber = (Guid )row["BillNumber"];
           lbRoomNumber .Content  = checkOutBill.RoomNumber = MainWondows.SelectRoomNumber;
           lbGuestName .Content = checkOutBill.GuestName = (string)row["GuestName"];
           lbNumberOfPeaple .Content = checkOutBill.NumberOfPeaple = (string)row["NumberOfPeaple"];
           lbRoomRate .Content = checkOutBill.RoomRate = MainWondows.RoomRate;
           lbConsumPionPaid .Content = checkOutBill.ConsumptionPaid = (decimal)row["AmountPaid"] - MainWondows.RoomRate;
           lbDate .Content = checkOutBill.Date = System.DateTime.Now;
            
            User user=new User ();
            user .UserName =LoginWindows .UserName ;
            DataTable usertable = UseUserNameSelectUserBLL.useUserNameSelectUser(user);
            DataRow userRow = usertable.Rows[0];
            lbWaiterName .Content =  checkOutBill.WaiterName =(string ) userRow["Name"];

            checkOutBill.CheckInBillTableId = (Guid)row["Id"];
          
           
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddCheckOutBillBLL.addCheckOutBill(checkOutBill);
            UpdateRoomBLL.updateRoomIsEmpty(MainWondows.SelectRoomNumber);
            checkOutBillWindow.Close();

        }
    }
}
