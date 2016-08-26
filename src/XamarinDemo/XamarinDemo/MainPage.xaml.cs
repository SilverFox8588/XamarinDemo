using System;
using Xamarin.Forms;
using XamarinDemo.Interface;

namespace XamarinDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnCall(object s, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;
            App.PhoneNumbers.Add(phoneNumber);
            if (await DisplayAlert("Alert", "Would you like to call " + phoneNumber, "OK", "Cancel"))
            {
                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null)
                {
                    dialer.Dial(phoneNumber);
                }
            }
        }

        async void BtnCallHistory_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CallHistoryPage());
        }
    }
}
