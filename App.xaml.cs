﻿using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HappinessFoundation.Services;
using HappinessFoundation.Views;
using HappinessFoundation.Views.Login;

namespace HappinessFoundation
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        //To debug on Android emulators run the web backend against .NET Core not IIS
        //If using other emulators besides stock Google images you may need to adjust the IP address
        public static string AzureBackendUrl =
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        public static bool UseMockDataStore = true;

        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjQ2NDI3QDMxMzgyZTMxMmUzMEJrbk9pUzZEQ2VPN3FsMTdLblFQdUpKZkFQNXBUYWxHdVhpNlVsZkg3TTg9");
            
            InitializeComponent();

            MainPage = new LoginWithSocialIconPage();

            //if (UseMockDataStore)
            //    DependencyService.Register<MockDataStore>();
            //else
            //    DependencyService.Register<AzureDataStore>();
            //MainPage = new MainPage();
        }

         

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
