﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace FutureRecommenderApp
{
    [Activity(Label = "FutureRecommenderApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}
