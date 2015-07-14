using System;

using Xamarin.Forms;

namespace groupingSampleListView
{
	public class App : Application
	{
		public App ()
		{
			// Adjust commenting to choose which method to use
			//MainPage = new GroupedListCode ();
			MainPage = new GroupedListXaml();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

