using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinLocalNoti
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NotiTimePicker_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            NotificationRequest notiObj = new NotificationRequest
            {
                Title = "Testing Local Noti",
                Description = "Hello there! this is sample noti.",
                NotificationId = 100,
                Repeats = isRepeat.IsChecked ? NotificationRepeat.TimeInterval : NotificationRepeat.No,
                NotifyRepeatInterval = new TimeSpan(0, 0, 0, 10),
                NotifyTime = DateTime.Now.AddSeconds(10)
            };
            NotificationCenter.Current.Show(notiObj);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            NotificationCenter.Current.CancelAll();
        }
    }
}
