using Flipboard.FLAnimatedImage.Xamarin;
using Foundation;
using System;
using UIKit;

namespace ExampleApp
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {

            base.ViewDidLoad();


            var urlString = "https://c.tenor.com/GZw_HxkxMl4AAAAC/betty-white-it-works.gif";
            var url = new NSUrl(urlString);
            var imageData = NSData.FromUrl(url);
            var imageData3 = new FLAnimatedImage(imageData);

            ivGif.AnimatedImage = imageData3;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
