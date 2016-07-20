using System;

using UIKit;

namespace GuessIt
{
	public partial class BullsEyeViewController : UIViewController
	{
		public BullsEyeViewController() : base("BullsEyeViewController", null)
		{
		}

		partial void UIButton1mN47B69_TouchUpInside(UIButton sender)
		{
			DismissViewController(true, completionHandler: null);
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


