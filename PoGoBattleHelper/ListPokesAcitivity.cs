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
using Android.Util;

namespace PoGoBattleHelper
{
    [Activity(Label = "ListPokesAcitivity")]
    public class ListPokesAcitivity : ListActivity
    {
        string[] items;
        string TAG = "PoGo BH ListPokes";
        protected override void OnCreate(Bundle bundle)
        {
            Log.Debug(TAG, "OnCreate");
            base.OnCreate(bundle);
            Log.Debug(TAG, "Set Bundle");

            var lastPoke = Intent.GetStringExtra("lastPoke");

            Log.Debug(TAG, "Loading Pokes");
            BattleTypes.LoadModels.LoadPokes();
            Log.Debug(TAG, "Pokes Loaded");

            items = BattleTypes.LoadModels.pokes.Select(p => p.PokeName).OrderBy(p => p).ToArray();

            ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);

            this.ListView.SetSelection(Intent.GetIntExtra("ScrollX", 0));
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("poke", l.GetItemAtPosition(position).ToString());

            Log.Debug(TAG, "ListView.FirstVisiblePosition: {0}", this.ListView.FirstVisiblePosition);
            intent.PutExtra("ScrollX", this.ListView.FirstVisiblePosition);

            intent.PutExtra("ScrollY", this.ListView.ScrollY);

            SetResult(Result.Ok, intent);
            Finish();
        }


    }
}