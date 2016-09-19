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
            string phoneNumber = TxtPhoneNumber.Text;
            if (await DisplayAlert("Alert", "Would you like to call " + phoneNumber, "OK", "Cancel"))
            {
                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null)
                {
                    App.PhoneNumbers.Add(phoneNumber);
                    dialer.Dial(phoneNumber);
                }
            }
        }

        async void BtnCallHistory_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CallHistoryPage());
        }

        async void BtnXamlBasic_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XamlBasicDemoPage());
        }

        async void BtnXamlBasicBinding_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XamlBasicBindingDemo());
        }
    }
}
