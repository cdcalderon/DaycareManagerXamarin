using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DaycareManager
{
	public partial class KidDetailPage : ContentPage
	{
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			DisplayAlert("re","ew","ewer");
		}

		public KidDetailPage(Kid kid)
		{
			if (kid == null)
			{
				throw new ArgumentNullException();
			}

			BindingContext = kid;

			InitializeComponent();
		}
	}
}
