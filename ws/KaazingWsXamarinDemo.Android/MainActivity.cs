﻿/**
 * Copyright (c) 2007-2013, Kaazing Corporation. All rights reserved.
 */

using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace KaazingWsXamarinDemo
{
	[Activity(Label = "KaazingWsXamarinDemo.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}
	}


}
