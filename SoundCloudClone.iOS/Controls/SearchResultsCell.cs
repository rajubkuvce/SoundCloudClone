// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace SoundCloudClone.iOS.Controls
{
	public partial class SearchResultsCell : UITableViewCell
	{
		public SearchResultsCell (IntPtr handle) : base (handle)
		{
		}

		public void Update(string result)
        {
			Name.Text = result;
        }
	}
}