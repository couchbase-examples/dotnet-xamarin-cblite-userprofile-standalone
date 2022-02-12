using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UserProfileDemo.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Replace(@"\UserProfileDemo.UITests\bin\Debug", "");
                path = path.Replace(@"file:\", "");
                path = $"{path}\\UserProfileDemo.Android\\bin\\debug\\com.couchbase.userprofiledemo.apk";

                return ConfigureApp
                    .Android
                    .ApkFile(path)
                    .StartApp();
            }
           
            return ConfigureApp
                .iOS
                .AppBundle("../UserProfileDemo.iOS/bin/iPhone/Debug/UserProfileDemo.app")
                .StartApp();
        }
    }
}