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
            if (await DisplayAlert("Alert", "Would you like to call " + txtPhoneNumber.Text, "OK", "Cancel"))
            {
                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null)
                {
                    dialer.Dial(txtPhoneNumber.Text);
                }
            }
        }
    }
}
