using System;

using Android.Graphics;
using Android.Widget;
using Effects.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("XamarinWorkShopINTEC")]
[assembly: ExportEffect(typeof(MyAndroidLabelFontEffect),"FontEffect")]
namespace Effects.Droid
{
   public class MyAndroidLabelFontEffect: PlatformEffect
    {
        Typeface oldFont;

        protected override void OnAttached()
        {
            if (Element is Label == false)
            {
                return;
            }

            var label = (TextView)Control;
            oldFont = label.Typeface;
            label.Typeface = Typeface.CreateFromAsset(Android.App.Application.Context.Assets, "Ancherr.ttf");
        }
        protected override void OnDetached()
        {
            if(oldFont != null)
            {
                var label = (TextView)Control;
                label.Typeface = oldFont;
            }
        }
    }
}