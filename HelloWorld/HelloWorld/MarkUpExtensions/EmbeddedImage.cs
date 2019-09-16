using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.MarkUpExtensions
{
    [ContentProperty("ResouceId")]
    class EmbeddedImage : IMarkupExtension
    {
      
        public string ResouceId { get; set; }

        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ResouceId)){
                return null;
            }

            return ImageSource.FromResource(ResouceId);
        }
    }
}
