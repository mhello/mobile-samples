// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_StandardControls.Screens.iPhone.Buttons {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("ButtonsScreen_iPhone")]
	public partial class ButtonsScreen_iPhone {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIButton __mt_btnOne;
		
		private MonoTouch.UIKit.UIButton __mt_btnTwo;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnOne")]
		private MonoTouch.UIKit.UIButton btnOne {
			get {
				this.__mt_btnOne = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnOne")));
				return this.__mt_btnOne;
			}
			set {
				this.__mt_btnOne = value;
				this.SetNativeField("btnOne", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnTwo")]
		private MonoTouch.UIKit.UIButton btnTwo {
			get {
				this.__mt_btnTwo = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnTwo")));
				return this.__mt_btnTwo;
			}
			set {
				this.__mt_btnTwo = value;
				this.SetNativeField("btnTwo", value);
			}
		}
	}
}
