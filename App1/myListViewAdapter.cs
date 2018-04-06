using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    class myListViewAdapter: BaseAdapter<string>
    {
        private List<string> objItems;
        private Context objContext;

        public myListViewAdapter(Context context, List<string> items)
        {
            objContext = context;
            objItems = items;
        }
    }
}