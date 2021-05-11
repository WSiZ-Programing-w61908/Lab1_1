// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Calc
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField wText { get; set; }

		[Outlet]
		AppKit.NSTextField xText { get; set; }

		[Outlet]
		AppKit.NSTextField yText { get; set; }

		[Outlet]
		AppKit.NSTextField zText { get; set; }

		[Action ("ExitClick:")]
		partial void ExitClick (Foundation.NSObject sender);

		[Action ("MultiplicationClick:")]
		partial void MultiplicationClick (Foundation.NSObject sender);

		[Action ("SumClick:")]
		partial void SumClick (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (wText != null) {
				wText.Dispose ();
				wText = null;
			}

			if (xText != null) {
				xText.Dispose ();
				xText = null;
			}

			if (yText != null) {
				yText.Dispose ();
				yText = null;
			}

			if (zText != null) {
				zText.Dispose ();
				zText = null;
			}
		}
	}
}
