using System;

using AppKit;
using Foundation;

namespace Calc
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void SumClick(Foundation.NSObject sender)
        {
            wText.IntValue = xText.IntValue + yText.IntValue + zText.IntValue;
        }

        partial void MultiplicationClick(Foundation.NSObject sender)
        {
            wText.IntValue = xText.IntValue * yText.IntValue * zText.IntValue;
        }

        partial void ExitClick(Foundation.NSObject sender)
        {
            //this.View.Window?.Close();
        }
    }
}
