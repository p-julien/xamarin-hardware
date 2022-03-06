﻿using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Hardware.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
                return ConfigureApp.Android.InstalledApp("com.companyname.hardware").StartApp();

            return ConfigureApp.iOS.StartApp();
        }
    }
}