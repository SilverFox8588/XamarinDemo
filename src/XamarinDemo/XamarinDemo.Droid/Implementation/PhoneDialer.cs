using System.Linq;
using Android.Content;
using Android.Telephony;
using Xamarin.Forms;
using XamarinDemo.Droid.Implementation;
using XamarinDemo.Interface;
using Uri = Android.Net.Uri;

[assembly: Dependency(typeof(PhoneDialer))]
namespace XamarinDemo.Droid.Implementation
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            try
            {
                var context = Forms.Context;
                if (context == null)
                    return false;

                var intent = new Intent(Intent.ActionCall);
                intent.SetData(Uri.Parse("tel:" + number));

                if (IsIntentAvailable(context, intent))
                {
                    context.StartActivity(intent);
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        private static bool IsIntentAvailable(Context context, Intent intent)
        {
            var packageManager = context.PackageManager;

            var list = packageManager.QueryIntentServices(intent, 0)
                .Union(packageManager.QueryIntentActivities(intent, 0));

            if (list.Any())
            {
                return true;
            }

            var manager = TelephonyManager.FromContext(context);
            return manager.PhoneType != PhoneType.None;
        }
    }
}