using System;
using Xamarin.Forms;

namespace XamarinDemo
{
    public partial class XamlBasicDemoPage : ContentPage
    {
        public XamlBasicDemoPage()
        {
            InitializeComponent();
        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            LblShow.Text = e.NewValue.ToString("F2");
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            LblShow.Text = "The button labeled '" + ((Button) sender).Text + "' has been clicked!";
        }
    }
}
