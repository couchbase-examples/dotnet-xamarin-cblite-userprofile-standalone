using Android.App;
using Android.Content.PM;
using Android.OS;

namespace UserProfileDemo.Droid
{
    [Activity(
        Label = "UserProfileDemo",
        Icon = "@mipmap/icon",
        Theme = "@style/MainTheme",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // tag::activate[]
            Couchbase.Lite.Support.Droid.Activate(this);
            // end::activate[]

            LoadApplication(new App());
        }
    }
}