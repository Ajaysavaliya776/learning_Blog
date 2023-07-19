using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Blog.View
{	
	public partial class MainPage : ContentPage
	{	
		public MainPage ()
		{
			InitializeComponent ();
            Xamarin.Forms.PlatformConfiguration.iOSSpecific.Page.SetUseSafeArea(this, true);
        }
	}
}

