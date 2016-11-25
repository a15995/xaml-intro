using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
}