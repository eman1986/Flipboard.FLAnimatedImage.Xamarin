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

                // var path = NSBundle.MainBundle.PathForResource("success", "gif");
                // var data = NSData.FromFile(path);

                var image = new FLAnimatedImage(NSData.FromUrl(NSUrl.FromString("https://c.tenor.com/GZw_HxkxMl4AAAAC/betty-white-it-works.gif")));
                var aiv = new FLAnimatedImageView
                {
                    AnimatedImage = image
                };

                ivGif.AnimatedImage = image;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
