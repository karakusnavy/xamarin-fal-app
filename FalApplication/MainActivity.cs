using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using System;

namespace FalApplication
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button take;
        EditText name, surname;
        TextView request;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);            
            SetContentView(Resource.Layout.activity_main);            
            take = FindViewById<Button>(Resource.Id.button1);
            name = FindViewById<EditText>(Resource.Id.name);
            surname = FindViewById<EditText>(Resource.Id.surname);            
            request = FindViewById<TextView>(Resource.Id.request);
            take.Click += Take_Click;
        }
        List<string> fals = new List<string>();
        bool youareaddafter = false;
        void add_fals()
        {
            if (youareaddafter==false){
                fals.Add("Hey " + name.Text + ", you are perfect a human. You are best of the " + surname.Text);
                fals.Add("Hey " + name.Text + ", you are good a human. You are best of the " + surname.Text);
                fals.Add("Hey " + name.Text + ", you are bad a human. You are best of the " + surname.Text);
                fals.Add("Hey " + name.Text + ", you are beautiful a human. You are best of the " + surname.Text);
                fals.Add("Hey " + name.Text + ", you are cringe a human. You are best of the " + surname.Text);
                fals.Add("Hey " + name.Text + ", you are smart a human. You are best of the " + surname.Text);
                fals.Add("Hey " + name.Text + ", you are handsome a human. You are best of the " + surname.Text);
            }
        }
        Random rnd = new Random();
        private void Take_Click(object sender, System.EventArgs e)
        {
            add_fals();
            request.Text = fals[rnd.Next(0,fals.Count)];
        }
    }
}