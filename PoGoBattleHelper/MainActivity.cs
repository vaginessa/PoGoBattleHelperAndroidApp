using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Util;
using System.Linq;

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

            SetContentView(Resource.Layout.Main);

            BattleTypes.LoadModels.LoadPokes();
            BattleTypes.LoadModels.LoadTypes();

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
                //ListView zeroFromList = FindViewById<ListView>(Resource.Id.ZeroFromListView);

                var poke = data.GetStringExtra("poke");

                scrollX = data.GetIntExtra("ScrollX", 0);
                scrollY = data.GetIntExtra("ScrollY", 0);

                button.SetText(string.Format("Defending Pokemon: {0}", poke), TextView.BufferType.Normal);

                var effectiveAgainstTypes = BattleTypes.LoadModels.GetWeaknesses(poke);
                doubleFromList.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, effectiveAgainstTypes);

                var resistantAgainstTypes = BattleTypes.LoadModels.GetResistances(poke);
                halfFromList.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, resistantAgainstTypes);

                var pokeModel = BattleTypes.LoadModels.pokes.FirstOrDefault(p => p.PokeName == poke);

                TextView type1TextView = FindViewById<TextView>(Resource.Id.Type1Text);
                TextView type2TextView = FindViewById<TextView>(Resource.Id.Type2Text);

                type1TextView.Text = pokeModel.Type1;
                type2TextView.Text = pokeModel.Type2;

                selectedPoke = poke;
            }
        }

    }
}

