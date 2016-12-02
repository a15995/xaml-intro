using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamlSamples
{
    public class SimpleViewModel : INotifyPropertyChanged
    {
        private double myValue = 1;
        public event PropertyChangedEventHandler PropertyChanged;

        public double MyValue
        {
            get
            {
                return myValue;
            }
            set
            {
                if (myValue != value)
                {
                    myValue = value;
                    OnPropertyChanged();
                }            
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var ev = PropertyChanged;
            if (ev != null)
            {
                ev(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    // namespace SimpleValueConverter { }
    public class IntScaleValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var myValue = (double)value;
            return myValue * 100;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var myValue = (double)value;
            if (myValue != 0)
            {
                myValue = myValue / 100;
            }
            return myValue;
        }
    }

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
            new InterfacePage();
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
