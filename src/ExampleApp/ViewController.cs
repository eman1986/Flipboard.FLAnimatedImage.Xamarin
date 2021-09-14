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

            try
            {
                // var urlString = "https://c.tenor.com/GZw_HxkxMl4AAAAC/betty-white-it-works.gif";
                // var url = new NSUrl(urlString);
                //var imageData = NSData.FromUrl(url);

                // var path = NSBundle.MainBundle.PathForResource("success", "gif");
                // var data = NSData.FromFile(path);

                var image = new FLAnimatedImage(NSData.FromUrl(NSUrl.FromString("https://c.tenor.com/GZw_HxkxMl4AAAAC/betty-white-it-works.gif")));
                var aiv = new FLAnimatedImageView
                {
                    AnimatedImage = image
                };

                //View.AddSubview(aiv);

                //ivGif = aiv;

                ivGif.AnimatedImage = image;

                //ivGif.SetImage(NSUrl.FromString("https://c.tenor.com/GZw_HxkxMl4AAAAC/betty-white-it-works.gif"), null, SDWebImageOptions.RefreshCached);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
