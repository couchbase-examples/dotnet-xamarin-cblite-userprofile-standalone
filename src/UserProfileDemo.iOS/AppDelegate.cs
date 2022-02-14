﻿using Foundation;
using UIKit;

namespace UserProfileDemo.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
#if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start();
#endif

            global::Xamarin.Forms.Forms.Init();

            // tag::activate[]
            // Couchbase.Lite.Support.iOS.Activate(); // deprecated command removed in 3.0
            // end::activate[]

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
