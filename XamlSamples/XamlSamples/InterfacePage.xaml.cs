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
        public int ExtraTalA { get; set; }
        public int ExtraTalB { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return "Hvor mange æbler vil jeg have? " + (ExtraTalA + ExtraTalB);
        }
    }
}