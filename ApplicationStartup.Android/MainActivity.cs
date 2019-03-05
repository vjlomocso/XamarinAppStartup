using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;

namespace ApplicationStartup.Droid
{
    [Activity(Label = "ApplicationStartup", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    // ReSharper disable once UnusedMember.Global
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            Forms.SetFlags("FastRenderers_Experimental");
            Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
    }
}