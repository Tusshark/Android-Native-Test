using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<string> lstData;
        private ListView myLisyView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // set your view from  the mainlayout resource
            SetContentView(Resource.Layout.Main);
            myLisyView = FindViewById<ListView>(Resource.Id.lstView);
            lstData = new List<string>();
            lstData.Add("First Item"); lstData.Add("Second Item"); lstData.Add("Third Item");
            ArrayAdapter<string> objArrayAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, lstData);

            myLisyView.Adapter = objArrayAdapter;
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

