using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace PoGoBattleHelper
{
    [Activity(Label = "PokemonGo Battle Helper", MainLauncher = true, Icon = "@drawable/icon1")]
    public class MainActivity : Activity
    {
        string TAG = "PoGo BH Main";
        string selectedPoke = "";

        int scrollX = 0;
        int scrollY = 0;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.SelectPokeButton);

            button.Click += delegate {
                var intent = new Intent(this, typeof(ListPokesAcitivity));
                intent.PutExtra("lastPoke", selectedPoke);
                intent.PutExtra("ScrollX", scrollX);
                intent.PutExtra("ScrollY", scrollY);
                StartActivityForResult(intent, 0);
            };

        }


        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok)
            {
                Button button = FindViewById<Button>(Resource.Id.SelectPokeButton);
                ListView doubleFromList = FindViewById<ListView>(Resource.Id.DoubleFromListView);
                ListView halfFromList = FindViewById<ListView>(Resource.Id.HalfFromListView);
                ListView zeroFromList = FindViewById<ListView>(Resource.Id.ZeroFromListView);

                var poke = data.GetStringExtra("poke");

                scrollX = data.GetIntExtra("ScrollX", 0);
                scrollY = data.GetIntExtra("ScrollY", 0);

                button.SetText(string.Format("Defending Pokemon: {0}", poke), TextView.BufferType.Normal);

                var doubleFromTypes = BattleTypes.LoadModels.GetPokeWeaknesses(poke);
                doubleFromList.Adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, doubleFromTypes);

                var halfFromTypes = BattleTypes.LoadModels.GetResistances(poke);
                halfFromList.Adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, halfFromTypes);

                var zeroFromTypes = BattleTypes.LoadModels.GetImmunities(poke);
                zeroFromList.Adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, zeroFromTypes);
            }
        }

    }
}

