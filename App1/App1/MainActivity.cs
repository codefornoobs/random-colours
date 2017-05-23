using System;
using System.Text;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.clickMe);

            button.Click += delegate {
                
                Random rnd = new Random();
                int red = rnd.Next(0, 255);
                int green = rnd.Next(0, 255);
                int blue = rnd.Next(0, 255);

                Window.DecorView.SetBackgroundColor(Color.Rgb(red,green,blue));

                TextView txtRed = FindViewById<TextView>(Resource.Id.txtRed);
                TextView txtGreen = FindViewById<TextView>(Resource.Id.txtGreen);
                TextView txtBlue = FindViewById<TextView>(Resource.Id.txtBlue);
                TextView txtHex = FindViewById<TextView>(Resource.Id.txtHex);

                txtRed.Text = red.ToString();
                txtGreen.Text = green.ToString();
                txtBlue.Text = blue.ToString();

                string hex = $"#{red:X2}{green:X2}{blue:X2}";

                txtHex.Text = hex;
            };
        }
    }
}

