using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Utils;

namespace UserProfileDemo.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            if (platform == Platform.Android)
            {
                switch (System.Environment.OSVersion.Platform)
                {
                    case PlatformID.WinCE:
                    case PlatformID.Win32S:
                    case PlatformID.Win32NT:
                    case PlatformID.Win32Windows:
                        {
                            path = path.Replace(@"file:\", "");
                            path = path.Replace(@"\UserProfileDemo.UITests\bin\Debug", "");
                            path = $"{path}\\UserProfileDemo.Android\\bin\\debug\\com.couchbase.userprofiledemo.apk";
                            break;
                        }
                    default:
                        {
                            path = path.Replace(@"file:", "");
                            path = path.Replace(@"UserProfileDemo.UITests/bin/Debug", "");
                            path = $"{path}UserProfileDemo.Android/bin/debug/com.couchbase.userprofiledemo.apk";
                            break;
                        }
                }
                return ConfigureApp
                    .Android
                    .ApkFile(path)
                    .StartApp(Xamarin.UITest.Configuration.AppDataMode.Clear);
            }
            //set path for iOS
            //path = path.Replace(@"file:", "");
            //path = path.Replace(@"UserProfileDemo.UITests/bin/Debug", "");
            //path = $"{path}UserProfileDemo.iOS/bin/iPhoneSimulator/debug/UserProfileDemo.iOS.app";
            return ConfigureApp
                .iOS
                .DeviceIdentifier("6BF159BD-E4DB-4073-8957-CB9E04D584D5") //uncomment for testing on local simulator
                .PreferIdeSettings()
                .Debug()
                .WaitTimes(new WaitTimes())
                //.AppBundle(path)
                .InstalledApp("com.couchbase.UserProfileDemo")
                .StartApp(Xamarin.UITest.Configuration.AppDataMode.Clear);
        }
    }
}

internal class WaitTimes : IWaitTimes
{
    public TimeSpan WaitForTimeout => new TimeSpan(0, 0, 10);

    public TimeSpan GestureWaitTimeout => new TimeSpan(0, 0, 10);

    public TimeSpan GestureCompletionTimeout => new TimeSpan(0, 0, 10);
}