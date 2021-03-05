﻿using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/// <summary>
///  This class loads an ImageSource from the local directory specified.
/// </summary>
namespace NYC_Inspections
{
    [ContentProperty(nameof(Source))]
    internal class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            return imageSource;
        }
    }
}