using System;

using Xamarin.Forms;

namespace builtInCellsListView
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			//MainPage = new ListViewCode ();
			MainPage = new ListViewXaml ();
		}

		protected override void OnStart()
		{


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

