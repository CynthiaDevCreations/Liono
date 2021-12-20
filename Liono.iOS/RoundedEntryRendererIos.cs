using CoreGraphics;
using Liono;
using Liono.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryRendererIos))]
namespace Liono.iOS
{
    public class RoundedEntryRendererIos : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 20;
                Control.Layer.BorderWidth = 1f;
                Control.Layer.BorderColor = Color.FromHex("0F11B5").ToCGColor();
                Control.Layer.BackgroundColor = Color.White.ToCGColor();
                Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 5, 0));
                Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
            }
        }
    }
}