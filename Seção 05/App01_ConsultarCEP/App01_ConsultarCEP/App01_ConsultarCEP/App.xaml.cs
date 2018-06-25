using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App01_ConsultarCEP
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //Defini a primeira página do aplicativo
            MainPage = new App01_ConsultarCEP.MainPage();

            //Podemos mudar a primeira página a qualquer momento 
            //App.Current.MainPage = "Novapagina";
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
