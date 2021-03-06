﻿using System;
using System.Collections.Generic;
using System.Linq;
using BadgeView.iOS;
using Foundation;
using UIKit;

namespace BadgeViewExample.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            CircleViewRenderer.Initialize();
            return base.FinishedLaunching(app, options);
        }
    }
}
