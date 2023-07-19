using System;
using System.Collections.Generic;
using Blog.Model;
using Xamarin.Forms;

namespace Blog.View
{	
	public partial class PostPage : ContentPage
	{	
		public PostPage ()
		{
			InitializeComponent ();
            Xamarin.Forms.PlatformConfiguration.iOSSpecific.Page.SetUseSafeArea(this, true);
        }

        public PostPage(Item item)
        {
            InitializeComponent();
            Xamarin.Forms.PlatformConfiguration.iOSSpecific.Page.SetUseSafeArea(this, true);

            webView.Source = item.ItemLink;
        }
    }
}

