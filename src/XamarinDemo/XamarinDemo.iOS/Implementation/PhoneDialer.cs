using Foundation;
using UIKit;
using Xamarin.Forms;
using XamarinDemo.iOS.Implementation;
using XamarinDemo.Interface;

[assembly: Dependency(typeof(PhoneDialer))]
namespace XamarinDemo.iOS.Implementation
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            try
            {
                return UIApplication.SharedApplication.OpenUrl(
                    new NSUrl("tel:" + number));
            }
            catch
            {
                return false;
            }
        }
    }
}
