// This file has been autogenerated from parsing an Objective-C header file added in Xcode.

using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PhotoMania
{
	public partial class ImageViewController : UIViewController
	{
		private UIImagePickerController imagePicker = new UIImagePickerController();

		private void AttachPicture()
		{
			//WARNING: If using phone, use
			//imagePicker.SourceType = UIImagePickerControllerSourceType.Camera;
			//imagePicker.MediaTypes = UIImagePickerController.AvailableMediaTypes (UIImagePickerControllerSourceType.Camera);

			//WARNING: If using simulator, use
			imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
			imagePicker.MediaTypes = UIImagePickerController.AvailableMediaTypes (UIImagePickerControllerSourceType.PhotoLibrary);

			imagePicker.FinishedPickingMedia += Handle_FinishedPickingMedia;
			imagePicker.Canceled += Handle_Canceled;

			return;
		}


		public ImageViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.

			buttonPhotoPicker.Clicked += LoadImagePickerController;
			buttonTrashPhoto.Clicked += ClearImageView;
			buttonSendPhoto.Clicked += SendImageToWebService;

		}

		void SendImageToWebService (object sender, EventArgs e)
		{
			//TODO: Mokeeeee tu ti nastupas
			UIAlertView alert = new UIAlertView ("Image Publisher", "Do You Want To Publish Image?", null, "Cancel", "OK");
			alert.Show ();

			alert.Clicked += (object senderAlert, UIButtonEventArgs eAlert) => {

				if(eAlert.ButtonIndex == 1)
				{
					//MOKE SEND TO WEB SERVICE
					System.Console.WriteLine("ok clicked");
				}
			};


			System.Console.WriteLine (NSBundle.MainBundle.BundlePath);

		}

		void ClearImageView (object sender, EventArgs e)
		{
			this.imageView.Image = null;
		}

		void LoadImagePickerController (object sender, EventArgs e)
		{
			AttachPicture();
			NavigationController.PresentViewController(imagePicker,true,null);
		}



		protected void Handle_FinishedPickingMedia (object sender, UIImagePickerMediaPickedEventArgs e)
		{
			// determine what was selected, video or image
			bool isImage = false;
			switch(e.Info[UIImagePickerController.MediaType].ToString()) {
				case "public.image":
				Console.WriteLine("Image selected");
				isImage = true;
				break;
				case "public.video":
				Console.WriteLine("Video selected");
				break;
			}

			// get common info (shared between images and video)
			NSUrl referenceURL = e.Info[new NSString("UIImagePickerControllerReferenceUrl")] as NSUrl;
			if (referenceURL != null)
				Console.WriteLine("Url:"+referenceURL.ToString ());

			UIImage originalImage = null;
			// if it was an image, get the other image info
			if(isImage) {
				// get the original image
				originalImage = e.Info[UIImagePickerController.OriginalImage] as UIImage;
				if(originalImage != null) {
					// do something with the image
					Console.WriteLine ("got the original image");
					imageView.Image = originalImage; // display
				}
			} else { // if it's a video
				// get video url
				NSUrl mediaURL = e.Info[UIImagePickerController.MediaURL] as NSUrl;
				if(mediaURL != null) {
					Console.WriteLine(mediaURL.ToString());
				}
			}          
			// dismiss the picker
			imagePicker.DismissViewController (true, null);


			# region    ImageStore
			//-------------------------------------------------------------------------
			//image_store.ImagesMapping.Add("dasdad", originalImage);
			//-------------------------------------------------------------------------
			# endregion ImageStore

			return;
		}

		void Handle_Canceled (object sender, EventArgs e) {
			imagePicker.DismissViewController (true, null);
		}


	}
}
