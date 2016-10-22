using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DaycareManager
{
	public partial class KidListPage : ContentPage
	{
		
		public KidListPage()
		{
			InitializeComponent();
			kidList.ItemsSource = new List<Kid>
			{
				new Kid {FirstName = "Carlos", LastName = "Calderon", Age = 3},
				new Kid {FirstName = "Sofia", LastName = "Calderon", Age = 13}
			};
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var kid = e.SelectedItem as Kid;
			Navigation.PushAsync(new KidDetailPage(kid));
		}
	}

	public class Kid
	{
		public string FirstName{ get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public DateTime DateOfBirth { get; set;}
	}
}
