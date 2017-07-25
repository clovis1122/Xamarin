using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;

using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CustomRenderer;
using CustomRenderer.Droid;

[assembly: ExportRenderer(typeof(UnderlinedLabel), typeof(UnderlinedAndroidLabel))]
namespace CustomRenderer.Droid
{
    class UnderlinedAndroidLabel : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (this.Control == null)
                return;

            var view = (UnderlinedLabel)Element;
            this.Control.PaintFlags = PaintFlags.UnderlineText;

            if (view.Underline)
            {
                this.Control.PaintFlags = PaintFlags.UnderlineText;
            }

        }

    }
}