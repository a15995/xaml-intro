using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlSamples
{
    class MyMarkupExtension : IMarkupExtension
    {
        public int A { get; set; }
        public int B { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return "Mine tal er: " + (A + B);
        }
    }

    static class AppConstants
    {
        public static readonly Thickness PagePadding =
            new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0);

        public static readonly Font TitleFont =
            Font.SystemFontOfSize(Device.OnPlatform(35, 40, 50), FontAttributes.Bold);

        public static readonly Color BackgroundColor =
            Device.OnPlatform(Color.White, Color.Black, Color.Black);

        public static readonly Color ForegroundColor =
            Device.OnPlatform(Color.Black, Color.White, Color.White);
    }

    public class App : Xamarin.Forms.Application
    {
        public App()
        {
<<<<<<< HEAD
            MainPage = new ListViewDemoPage();
=======
            MainPage = new InterfacePage();
>>>>>>> 7adefa46a2d9e80eaa95c26cc22c19030920cc17
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
