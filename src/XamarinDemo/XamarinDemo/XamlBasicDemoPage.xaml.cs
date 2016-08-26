using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            lblShow.Text = e.NewValue.ToString("F2");
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            lblShow.Text = "The button labeled '" + ((Button) sender).Text + "' has been clicked!";
        }
    }
}
