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
    /// AddGuestToRoom.xaml 的交互逻辑
    /// </summary>
    public  partial  class AddGuestToRoom : Window
    {
        public static int NumberOfPeaple {set ;get ;}
        public static Guid FirstGuestId { set; get; }
        public MainWondowRefreshDelegate windowRefresh;
        public AddGuestToRoom()
        {
            InitializeComponent();
        }

        private void btAddGuest_Click(object sender, RoutedEventArgs e)
        {
           
            Guest guest = new Guest();
            guest.Id = Guid.NewGuid();
            guest.Name = tbName.Text;
            if (rbMan .IsChecked==true&&rbWoman .IsChecked ==false )
	        {
		       guest .Sex ="男";
	         }
            else if (rbMan.IsChecked ==false &&rbWoman .IsChecked ==true )
	        {
		      guest .Sex ="女";
	         }
            else
	        {
                    MessageBox .Show ("请选择性别！");
	         }
            guest.TelephoneNumber = tbTelephoneNumber.Text;
            guest.Address = tbAddress.Text;
            guest.IdentityCardNumber = tbIdentityCardNumber.Text ;
            AddGuestBLL.addGuest(guest);

            CheckIn checkIn = new CheckIn();
            checkIn.Id = Guid.NewGuid();
            checkIn.RoomNumber = MainWondows.SelectRoomNumber;
            checkIn.GuestName = guest.Name;
            checkIn.Date = System.DateTime.Now;
            checkIn.IdentityCardNumber = guest.IdentityCardNumber;
            checkIn.Address = guest.Address;
            checkIn.TelephoneNumber = guest.TelephoneNumber;
            AddCheckInBLL.addCheckIn(checkIn);
            tbAddress.Text = "";
            tbIdentityCardNumber.Text = "";
            tbName.Text = "";
            tbTelephoneNumber.Text  = "";
            NumberOfPeaple++;
            if (NumberOfPeaple ==1)
            {
                FirstGuestId = guest.Id;
            };
            lbNumberOfPeaple.Content  = NumberOfPeaple;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NumberOfPeaple>0)
            {
                
                AddCheckInBillWindow addCheckInBillWindow = new AddCheckInBillWindow();
                addCheckInBillWindow.windowRefresh = windowRefresh;
                addCheckInBillWindow.Show();
         
                addGuestToRoomWindow.Close();

            }
            else
            {
                lbNumberOfPeaple.Content = "请添加客人！";
            }
           
        }
    }
}
