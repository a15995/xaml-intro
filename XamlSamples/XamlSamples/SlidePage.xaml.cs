using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamlSamples
{
    public partial class SlidePage : ContentPage
    {
        private SimpleViewModel svm;
        private IntScaleValueConverter intScaleConverter = new IntScaleValueConverter();

        public SlidePage(SimpleViewModel svm)
        {
            this.svm = svm;
            InitializeComponent();
            BindingContext = svm;
            slider1.SetBinding<SimpleViewModel>(Slider.ValueProperty, vm => vm.MyValue, BindingMode.TwoWay, intScaleConverter);
            slider2.SetBinding<SimpleViewModel>(Slider.ValueProperty, vm => vm.MyValue, BindingMode.TwoWay);
        }
    }
}
