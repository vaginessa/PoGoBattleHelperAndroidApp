using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;


namespace PoGoBattleHelper.BattleTypes
{
    public class PokeModel
    {
        public int PokeIndex { get; set; }
        public string PokeName { get; set; }

        public int BaseStamina { get; set; }
        public int BaseAttack { get; set; }
        public int BaseDefend { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
    }


    public class TypeModel
    {
        public string PokeType { get; set; }
        public string[] TakesDoubleFrom { get; set; }
        public string[] TakesHalfFrom { get; set; }
        public string[] TakesZeroFrom { get; set; }

    }




    public static class LoadModels
    {

        public static List<PokeModel> Pokes = new List<PokeModel>();

        public static List<TypeModel> Types = new List<TypeModel>();






        public static string[] GetPokeWeaknesses(string pokeName)
        {
            if (Pokes.Count == 0 | Types.Count == 0 ) { LoadPokes(); LoadTypes(); }

            var SelectedPoke = Pokes.FirstOrDefault(p => p.PokeName == pokeName);

            var TakeDoubleFrom = Types.Where(t => t.PokeType == SelectedPoke.Type1 | t.PokeType == SelectedPoke.Type2).SelectMany(t => t.TakesDoubleFrom).Distinct().OrderBy(t => t);

            return TakeDoubleFrom.ToArray();

        }

        public static string[] GetResistances(string pokeName)
        {
            if (Pokes.Count == 0 | Types.Count == 0) { LoadPokes(); LoadTypes(); }

            var SelectedPoke = Pokes.FirstOrDefault(p => p.PokeName == pokeName);

            var TakeHalfFrom = Types.Where(t => t.PokeType == SelectedPoke.Type1 | t.PokeType == SelectedPoke.Type2).SelectMany(t => t.TakesHalfFrom).Distinct().OrderBy(t => t);

            return TakeHalfFrom.ToArray();

        }

        public static string[] GetImmunities(string pokeName)
        {
            if (Pokes.Count == 0 | Types.Count == 0) { LoadPokes(); LoadTypes(); }

            var SelectedPoke = Pokes.FirstOrDefault(p => p.PokeName == pokeName);

            var TakeZeroFrom = Types.Where(t => t.PokeType == SelectedPoke.Type1 | t.PokeType == SelectedPoke.Type2).SelectMany(t => t.TakesZeroFrom).Distinct().OrderBy(t => t);

            return TakeZeroFrom.ToArray();

        }



        public static void LoadPokes()
        {
            Pokes = new List<PokeModel>;

            Pokes.Add(new PokeModel
            {
                PokeIndex = 1,
                PokeName = "Bulbasaur",
                BaseStamina = 90,
                BaseAttack = 126,
                BaseDefend = 126,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 2,
                PokeName = "Ivysaur",
                BaseStamina = 120,
                BaseAttack = 156,
                BaseDefend = 158,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 3,
                PokeName = "Venusaur",
                BaseStamina = 160,
                BaseAttack = 198,
                BaseDefend = 200,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 4,
                PokeName = "Charmander",
                BaseStamina = 78,
                BaseAttack = 128,
                BaseDefend = 108,
                Type1 = "Fire",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 5,
                PokeName = "Charmeleon",
                BaseStamina = 116,
                BaseAttack = 160,
                BaseDefend = 140,
                Type1 = "Fire",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 6,
                PokeName = "Charizard",
                BaseStamina = 156,
                BaseAttack = 212,
                BaseDefend = 182,
                Type1 = "Fire",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 7,
                PokeName = "Squirtle",
                BaseStamina = 88,
                BaseAttack = 112,
                BaseDefend = 142,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 8,
                PokeName = "Wartortle",
                BaseStamina = 118,
                BaseAttack = 144,
                BaseDefend = 176,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 9,
                PokeName = "Blastoise",
                BaseStamina = 158,
                BaseAttack = 186,
                BaseDefend = 222,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 10,
                PokeName = "Caterpie",
                BaseStamina = 90,
                BaseAttack = 62,
                BaseDefend = 66,
                Type1 = "Bug",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 11,
                PokeName = "Metapod",
                BaseStamina = 100,
                BaseAttack = 56,
                BaseDefend = 86,
                Type1 = "Bug",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 12,
                PokeName = "Butterfree",
                BaseStamina = 120,
                BaseAttack = 144,
                BaseDefend = 144,
                Type1 = "Bug",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 13,
                PokeName = "Weedle",
                BaseStamina = 80,
                BaseAttack = 68,
                BaseDefend = 64,
                Type1 = "Bug",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 14,
                PokeName = "Kakuna",
                BaseStamina = 90,
                BaseAttack = 62,
                BaseDefend = 82,
                Type1 = "Bug",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 15,
                PokeName = "Beedrill",
                BaseStamina = 130,
                BaseAttack = 144,
                BaseDefend = 130,
                Type1 = "Bug",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 16,
                PokeName = "Pidgey",
                BaseStamina = 80,
                BaseAttack = 94,
                BaseDefend = 90,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 17,
                PokeName = "Pidgeotto",
                BaseStamina = 126,
                BaseAttack = 126,
                BaseDefend = 122,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 18,
                PokeName = "Pidgeot",
                BaseStamina = 166,
                BaseAttack = 170,
                BaseDefend = 166,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 19,
                PokeName = "Rattata",
                BaseStamina = 60,
                BaseAttack = 92,
                BaseDefend = 86,
                Type1 = "Normal",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 20,
                PokeName = "Raticate",
                BaseStamina = 110,
                BaseAttack = 146,
                BaseDefend = 150,
                Type1 = "Normal",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 21,
                PokeName = "Spearow",
                BaseStamina = 80,
                BaseAttack = 102,
                BaseDefend = 78,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 22,
                PokeName = "Fearow",
                BaseStamina = 130,
                BaseAttack = 168,
                BaseDefend = 146,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 23,
                PokeName = "Ekans",
                BaseStamina = 70,
                BaseAttack = 112,
                BaseDefend = 112,
                Type1 = "Poison",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 24,
                PokeName = "Arbok",
                BaseStamina = 120,
                BaseAttack = 166,
                BaseDefend = 166,
                Type1 = "Poison",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 25,
                PokeName = "Pikachu",
                BaseStamina = 70,
                BaseAttack = 124,
                BaseDefend = 108,
                Type1 = "Electric",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 26,
                PokeName = "Raichu",
                BaseStamina = 120,
                BaseAttack = 200,
                BaseDefend = 154,
                Type1 = "Electric",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 27,
                PokeName = "Sandshrew",
                BaseStamina = 100,
                BaseAttack = 90,
                BaseDefend = 114,
                Type1 = "Ground",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 28,
                PokeName = "Sandslash",
                BaseStamina = 150,
                BaseAttack = 150,
                BaseDefend = 172,
                Type1 = "Ground",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 29,
                PokeName = "Nidoran?",
                BaseStamina = 110,
                BaseAttack = 100,
                BaseDefend = 104,
                Type1 = "Poison",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 30,
                PokeName = "Nidorina",
                BaseStamina = 140,
                BaseAttack = 132,
                BaseDefend = 136,
                Type1 = "Poison",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 31,
                PokeName = "Nidoqueen",
                BaseStamina = 180,
                BaseAttack = 184,
                BaseDefend = 190,
                Type1 = "Poison",
                Type2 = "Ground"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 32,
                PokeName = "Nidoran?",
                BaseStamina = 92,
                BaseAttack = 110,
                BaseDefend = 94,
                Type1 = "Poison",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 33,
                PokeName = "Nidorino",
                BaseStamina = 122,
                BaseAttack = 142,
                BaseDefend = 128,
                Type1 = "Poison",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 34,
                PokeName = "Nidoking",
                BaseStamina = 162,
                BaseAttack = 204,
                BaseDefend = 170,
                Type1 = "Poison",
                Type2 = "Ground"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 35,
                PokeName = "Clefairy",
                BaseStamina = 140,
                BaseAttack = 116,
                BaseDefend = 124,
                Type1 = "Fairy",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 36,
                PokeName = "Clefable",
                BaseStamina = 190,
                BaseAttack = 178,
                BaseDefend = 178,
                Type1 = "Fairy",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 37,
                PokeName = "Vulpix",
                BaseStamina = 76,
                BaseAttack = 106,
                BaseDefend = 118,
                Type1 = "Fire",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 38,
                PokeName = "Ninetales",
                BaseStamina = 146,
                BaseAttack = 176,
                BaseDefend = 194,
                Type1 = "Fire",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 39,
                PokeName = "Jigglypuff",
                BaseStamina = 230,
                BaseAttack = 98,
                BaseDefend = 54,
                Type1 = "Normal",
                Type2 = "Fairy"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 40,
                PokeName = "Wigglytuff",
                BaseStamina = 280,
                BaseAttack = 168,
                BaseDefend = 108,
                Type1 = "Normal",
                Type2 = "Fairy"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 41,
                PokeName = "Zubat",
                BaseStamina = 80,
                BaseAttack = 88,
                BaseDefend = 90,
                Type1 = "Poison",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 42,
                PokeName = "Golbat",
                BaseStamina = 150,
                BaseAttack = 164,
                BaseDefend = 164,
                Type1 = "Poison",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 43,
                PokeName = "Oddish",
                BaseStamina = 90,
                BaseAttack = 134,
                BaseDefend = 130,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 44,
                PokeName = "Gloom",
                BaseStamina = 120,
                BaseAttack = 162,
                BaseDefend = 158,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 45,
                PokeName = "Vileplume",
                BaseStamina = 150,
                BaseAttack = 202,
                BaseDefend = 190,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 46,
                PokeName = "Paras",
                BaseStamina = 70,
                BaseAttack = 122,
                BaseDefend = 120,
                Type1 = "Bug",
                Type2 = "Grass"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 47,
                PokeName = "Parasect",
                BaseStamina = 120,
                BaseAttack = 162,
                BaseDefend = 170,
                Type1 = "Bug",
                Type2 = "Grass"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 48,
                PokeName = "Venonat",
                BaseStamina = 120,
                BaseAttack = 108,
                BaseDefend = 118,
                Type1 = "Bug",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 49,
                PokeName = "Venomoth",
                BaseStamina = 140,
                BaseAttack = 172,
                BaseDefend = 154,
                Type1 = "Bug",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 50,
                PokeName = "Diglett",
                BaseStamina = 20,
                BaseAttack = 108,
                BaseDefend = 86,
                Type1 = "Ground",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 51,
                PokeName = "Dugtrio",
                BaseStamina = 70,
                BaseAttack = 148,
                BaseDefend = 140,
                Type1 = "Ground",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 52,
                PokeName = "Meowth",
                BaseStamina = 80,
                BaseAttack = 104,
                BaseDefend = 94,
                Type1 = "Normal",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 53,
                PokeName = "Persian",
                BaseStamina = 130,
                BaseAttack = 156,
                BaseDefend = 146,
                Type1 = "Normal",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 54,
                PokeName = "Psyduck",
                BaseStamina = 100,
                BaseAttack = 132,
                BaseDefend = 112,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 55,
                PokeName = "Golduck",
                BaseStamina = 160,
                BaseAttack = 194,
                BaseDefend = 176,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 56,
                PokeName = "Mankey",
                BaseStamina = 80,
                BaseAttack = 122,
                BaseDefend = 96,
                Type1 = "Fighting",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 57,
                PokeName = "Primeape",
                BaseStamina = 130,
                BaseAttack = 178,
                BaseDefend = 150,
                Type1 = "Fighting",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 58,
                PokeName = "Growlithe",
                BaseStamina = 110,
                BaseAttack = 156,
                BaseDefend = 110,
                Type1 = "Fire",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 59,
                PokeName = "Arcanine",
                BaseStamina = 180,
                BaseAttack = 230,
                BaseDefend = 180,
                Type1 = "Fire",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 60,
                PokeName = "Poliwag",
                BaseStamina = 80,
                BaseAttack = 108,
                BaseDefend = 98,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 61,
                PokeName = "Poliwhirl",
                BaseStamina = 130,
                BaseAttack = 132,
                BaseDefend = 132,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 62,
                PokeName = "Poliwrath",
                BaseStamina = 180,
                BaseAttack = 180,
                BaseDefend = 202,
                Type1 = "Water",
                Type2 = "Fighting"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 63,
                PokeName = "Abra",
                BaseStamina = 50,
                BaseAttack = 110,
                BaseDefend = 76,
                Type1 = "Psychic",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 64,
                PokeName = "Kadabra",
                BaseStamina = 80,
                BaseAttack = 150,
                BaseDefend = 112,
                Type1 = "Psychic",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 65,
                PokeName = "Alakazam",
                BaseStamina = 110,
                BaseAttack = 186,
                BaseDefend = 152,
                Type1 = "Psychic",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 66,
                PokeName = "Machop",
                BaseStamina = 140,
                BaseAttack = 118,
                BaseDefend = 96,
                Type1 = "Fighting",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 67,
                PokeName = "Machoke",
                BaseStamina = 160,
                BaseAttack = 154,
                BaseDefend = 144,
                Type1 = "Fighting",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 68,
                PokeName = "Machamp",
                BaseStamina = 180,
                BaseAttack = 198,
                BaseDefend = 180,
                Type1 = "Fighting",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 69,
                PokeName = "Bellsprout",
                BaseStamina = 100,
                BaseAttack = 158,
                BaseDefend = 78,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 70,
                PokeName = "Weepinbell",
                BaseStamina = 130,
                BaseAttack = 190,
                BaseDefend = 110,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 71,
                PokeName = "Victreebel",
                BaseStamina = 160,
                BaseAttack = 222,
                BaseDefend = 152,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 72,
                PokeName = "Tentacool",
                BaseStamina = 80,
                BaseAttack = 106,
                BaseDefend = 136,
                Type1 = "Water",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 73,
                PokeName = "Tentacruel",
                BaseStamina = 160,
                BaseAttack = 170,
                BaseDefend = 196,
                Type1 = "Water",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 74,
                PokeName = "Geodude",
                BaseStamina = 80,
                BaseAttack = 106,
                BaseDefend = 118,
                Type1 = "Rock",
                Type2 = "Ground"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 75,
                PokeName = "Graveler",
                BaseStamina = 110,
                BaseAttack = 142,
                BaseDefend = 156,
                Type1 = "Rock",
                Type2 = "Ground"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 76,
                PokeName = "Golem",
                BaseStamina = 160,
                BaseAttack = 176,
                BaseDefend = 198,
                Type1 = "Rock",
                Type2 = "Ground"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 77,
                PokeName = "Ponyta",
                BaseStamina = 100,
                BaseAttack = 168,
                BaseDefend = 138,
                Type1 = "Fire",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 78,
                PokeName = "Rapidash",
                BaseStamina = 130,
                BaseAttack = 200,
                BaseDefend = 170,
                Type1 = "Fire",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 79,
                PokeName = "Slowpoke",
                BaseStamina = 180,
                BaseAttack = 110,
                BaseDefend = 110,
                Type1 = "Water",
                Type2 = "Psychic"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 80,
                PokeName = "Slowbro",
                BaseStamina = 190,
                BaseAttack = 184,
                BaseDefend = 198,
                Type1 = "Water",
                Type2 = "Psychic"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 81,
                PokeName = "Magnemite",
                BaseStamina = 50,
                BaseAttack = 128,
                BaseDefend = 138,
                Type1 = "Electric",
                Type2 = "Steel"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 82,
                PokeName = "Magneton",
                BaseStamina = 100,
                BaseAttack = 186,
                BaseDefend = 180,
                Type1 = "Electric",
                Type2 = "Steel"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 83,
                PokeName = "Farfetch'd",
                BaseStamina = 104,
                BaseAttack = 138,
                BaseDefend = 132,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 84,
                PokeName = "Doduo",
                BaseStamina = 70,
                BaseAttack = 126,
                BaseDefend = 96,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 85,
                PokeName = "Dodrio",
                BaseStamina = 120,
                BaseAttack = 182,
                BaseDefend = 150,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 86,
                PokeName = "Seel",
                BaseStamina = 130,
                BaseAttack = 104,
                BaseDefend = 138,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 87,
                PokeName = "Dewgong",
                BaseStamina = 180,
                BaseAttack = 156,
                BaseDefend = 192,
                Type1 = "Water",
                Type2 = "Ice"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 88,
                PokeName = "Grimer",
                BaseStamina = 160,
                BaseAttack = 124,
                BaseDefend = 110,
                Type1 = "Poison",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 89,
                PokeName = "Muk",
                BaseStamina = 210,
                BaseAttack = 180,
                BaseDefend = 188,
                Type1 = "Poison",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 90,
                PokeName = "Shellder",
                BaseStamina = 60,
                BaseAttack = 120,
                BaseDefend = 112,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 91,
                PokeName = "Cloyster",
                BaseStamina = 100,
                BaseAttack = 196,
                BaseDefend = 196,
                Type1 = "Water",
                Type2 = "Ice"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 92,
                PokeName = "Gastly",
                BaseStamina = 60,
                BaseAttack = 136,
                BaseDefend = 82,
                Type1 = "Ghost",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 93,
                PokeName = "Haunter",
                BaseStamina = 90,
                BaseAttack = 172,
                BaseDefend = 118,
                Type1 = "Ghost",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 94,
                PokeName = "Gengar",
                BaseStamina = 120,
                BaseAttack = 204,
                BaseDefend = 156,
                Type1 = "Ghost",
                Type2 = "Poison"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 95,
                PokeName = "Onix",
                BaseStamina = 70,
                BaseAttack = 90,
                BaseDefend = 186,
                Type1 = "Rock",
                Type2 = "Ground"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 96,
                PokeName = "Drowzee",
                BaseStamina = 120,
                BaseAttack = 104,
                BaseDefend = 140,
                Type1 = "Psychic",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 97,
                PokeName = "Hypno",
                BaseStamina = 170,
                BaseAttack = 162,
                BaseDefend = 196,
                Type1 = "Psychic",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 98,
                PokeName = "Krabby",
                BaseStamina = 60,
                BaseAttack = 116,
                BaseDefend = 110,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 99,
                PokeName = "Kingler",
                BaseStamina = 110,
                BaseAttack = 178,
                BaseDefend = 168,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 100,
                PokeName = "Voltorb",
                BaseStamina = 80,
                BaseAttack = 102,
                BaseDefend = 124,
                Type1 = "Electric",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 101,
                PokeName = "Electrode",
                BaseStamina = 120,
                BaseAttack = 150,
                BaseDefend = 174,
                Type1 = "Electric",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 102,
                PokeName = "Exeggcute",
                BaseStamina = 120,
                BaseAttack = 110,
                BaseDefend = 132,
                Type1 = "Grass",
                Type2 = "Psychic"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 103,
                PokeName = "Exeggutor",
                BaseStamina = 190,
                BaseAttack = 232,
                BaseDefend = 164,
                Type1 = "Grass",
                Type2 = "Psychic"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 104,
                PokeName = "Cubone",
                BaseStamina = 100,
                BaseAttack = 102,
                BaseDefend = 150,
                Type1 = "Ground",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 105,
                PokeName = "Marowak",
                BaseStamina = 120,
                BaseAttack = 140,
                BaseDefend = 202,
                Type1 = "Ground",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 106,
                PokeName = "Hitmonlee",
                BaseStamina = 100,
                BaseAttack = 148,
                BaseDefend = 172,
                Type1 = "Fighting",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 107,
                PokeName = "Hitmonchan",
                BaseStamina = 100,
                BaseAttack = 138,
                BaseDefend = 204,
                Type1 = "Fighting",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 108,
                PokeName = "Lickitung",
                BaseStamina = 180,
                BaseAttack = 126,
                BaseDefend = 160,
                Type1 = "Normal",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 109,
                PokeName = "Koffing",
                BaseStamina = 80,
                BaseAttack = 136,
                BaseDefend = 142,
                Type1 = "Poison",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 110,
                PokeName = "Weezing",
                BaseStamina = 130,
                BaseAttack = 190,
                BaseDefend = 198,
                Type1 = "Poison",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 111,
                PokeName = "Rhyhorn",
                BaseStamina = 160,
                BaseAttack = 110,
                BaseDefend = 116,
                Type1 = "Ground",
                Type2 = "Rock"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 112,
                PokeName = "Rhydon",
                BaseStamina = 210,
                BaseAttack = 166,
                BaseDefend = 160,
                Type1 = "Ground",
                Type2 = "Rock"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 113,
                PokeName = "Chansey",
                BaseStamina = 500,
                BaseAttack = 40,
                BaseDefend = 60,
                Type1 = "Normal",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 114,
                PokeName = "Tangela",
                BaseStamina = 130,
                BaseAttack = 164,
                BaseDefend = 152,
                Type1 = "Grass",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 115,
                PokeName = "Kangaskhan",
                BaseStamina = 210,
                BaseAttack = 142,
                BaseDefend = 178,
                Type1 = "Normal",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 116,
                PokeName = "Horsea",
                BaseStamina = 60,
                BaseAttack = 122,
                BaseDefend = 100,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 117,
                PokeName = "Seadra",
                BaseStamina = 110,
                BaseAttack = 176,
                BaseDefend = 150,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 118,
                PokeName = "Goldeen",
                BaseStamina = 90,
                BaseAttack = 112,
                BaseDefend = 126,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 119,
                PokeName = "Seaking",
                BaseStamina = 160,
                BaseAttack = 172,
                BaseDefend = 160,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 120,
                PokeName = "Staryu",
                BaseStamina = 60,
                BaseAttack = 130,
                BaseDefend = 128,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 121,
                PokeName = "Starmie",
                BaseStamina = 120,
                BaseAttack = 194,
                BaseDefend = 192,
                Type1 = "Water",
                Type2 = "Psychic"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 122,
                PokeName = "Mr. Mime",
                BaseStamina = 80,
                BaseAttack = 154,
                BaseDefend = 196,
                Type1 = "Psychic",
                Type2 = "Fairy"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 123,
                PokeName = "Scyther",
                BaseStamina = 140,
                BaseAttack = 176,
                BaseDefend = 180,
                Type1 = "Bug",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 124,
                PokeName = "Jynx",
                BaseStamina = 130,
                BaseAttack = 172,
                BaseDefend = 134,
                Type1 = "Ice",
                Type2 = "Psychic"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 125,
                PokeName = "Electabuzz",
                BaseStamina = 130,
                BaseAttack = 198,
                BaseDefend = 160,
                Type1 = "Electric",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 126,
                PokeName = "Magmar",
                BaseStamina = 130,
                BaseAttack = 214,
                BaseDefend = 158,
                Type1 = "Fire",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 127,
                PokeName = "Pinsir",
                BaseStamina = 130,
                BaseAttack = 184,
                BaseDefend = 186,
                Type1 = "Bug",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 128,
                PokeName = "Tauros",
                BaseStamina = 150,
                BaseAttack = 148,
                BaseDefend = 184,
                Type1 = "Normal",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 129,
                PokeName = "Magikarp",
                BaseStamina = 40,
                BaseAttack = 42,
                BaseDefend = 84,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 130,
                PokeName = "Gyarados",
                BaseStamina = 190,
                BaseAttack = 192,
                BaseDefend = 196,
                Type1 = "Water",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 131,
                PokeName = "Lapras",
                BaseStamina = 260,
                BaseAttack = 186,
                BaseDefend = 190,
                Type1 = "Water",
                Type2 = "Ice"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 132,
                PokeName = "Ditto",
                BaseStamina = 96,
                BaseAttack = 110,
                BaseDefend = 110,
                Type1 = "Normal",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 133,
                PokeName = "Eevee",
                BaseStamina = 110,
                BaseAttack = 114,
                BaseDefend = 128,
                Type1 = "Normal",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 134,
                PokeName = "Vaporeon",
                BaseStamina = 260,
                BaseAttack = 186,
                BaseDefend = 168,
                Type1 = "Water",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 135,
                PokeName = "Jolteon",
                BaseStamina = 130,
                BaseAttack = 192,
                BaseDefend = 174,
                Type1 = "Electric",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 136,
                PokeName = "Flareon",
                BaseStamina = 130,
                BaseAttack = 238,
                BaseDefend = 178,
                Type1 = "Fire",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 137,
                PokeName = "Porygon",
                BaseStamina = 130,
                BaseAttack = 156,
                BaseDefend = 158,
                Type1 = "Normal",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 138,
                PokeName = "Omanyte",
                BaseStamina = 70,
                BaseAttack = 132,
                BaseDefend = 160,
                Type1 = "Rock",
                Type2 = "Water"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 139,
                PokeName = "Omastar",
                BaseStamina = 140,
                BaseAttack = 180,
                BaseDefend = 202,
                Type1 = "Rock",
                Type2 = "Water"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 140,
                PokeName = "Kabuto",
                BaseStamina = 60,
                BaseAttack = 148,
                BaseDefend = 142,
                Type1 = "Rock",
                Type2 = "Water"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 141,
                PokeName = "Kabutops",
                BaseStamina = 120,
                BaseAttack = 190,
                BaseDefend = 190,
                Type1 = "Rock",
                Type2 = "Water"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 142,
                PokeName = "Aerodactyl",
                BaseStamina = 160,
                BaseAttack = 182,
                BaseDefend = 162,
                Type1 = "Rock",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 143,
                PokeName = "Snorlax",
                BaseStamina = 320,
                BaseAttack = 180,
                BaseDefend = 180,
                Type1 = "Normal",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 144,
                PokeName = "Articuno",
                BaseStamina = 180,
                BaseAttack = 198,
                BaseDefend = 242,
                Type1 = "Ice",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 145,
                PokeName = "Zapdos",
                BaseStamina = 180,
                BaseAttack = 232,
                BaseDefend = 194,
                Type1 = "Electric",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 146,
                PokeName = "Moltres",
                BaseStamina = 180,
                BaseAttack = 242,
                BaseDefend = 194,
                Type1 = "Fire",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 147,
                PokeName = "Dratini",
                BaseStamina = 82,
                BaseAttack = 128,
                BaseDefend = 110,
                Type1 = "Dragon",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 148,
                PokeName = "Dragonair",
                BaseStamina = 122,
                BaseAttack = 170,
                BaseDefend = 152,
                Type1 = "Dragon",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 149,
                PokeName = "Dragonite",
                BaseStamina = 182,
                BaseAttack = 250,
                BaseDefend = 212,
                Type1 = "Dragon",
                Type2 = "Flying"
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 150,
                PokeName = "Mewtwo",
                BaseStamina = 212,
                BaseAttack = 284,
                BaseDefend = 202,
                Type1 = "Psychic",
                Type2 = ""
            });
            Pokes.Add(new PokeModel
            {
                PokeIndex = 151,
                PokeName = "Mew",
                BaseStamina = 200,
                BaseAttack = 220,
                BaseDefend = 220,
                Type1 = "Psychic",
                Type2 = ""
            });
        }

        public static void LoadTypes()
        {
            Types = new List<TypeModel>;

            Types.Add(new TypeModel
            {
                PokeType = "Bug",
                TakesDoubleFrom = new List<string> {
                "Rock",
                "Flying",
                "Fire"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Ground",
                "Grass",
                "Fighting"
            }.ToArray(),
                TakesZeroFrom = new List<string>
                {

                }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Dark",
                TakesDoubleFrom = new List<string> {
                "Fighting",
                "Fairy",
                "Bug"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Ghost",
                "Dark"
            }.ToArray(),
                TakesZeroFrom = new List<string> { "Psychic" }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Dragon",
                TakesDoubleFrom = new List<string> {
                "Ice",
                "Fairy",
                "Dragon"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Water",
                "Grass",
                "Fire",
                "Electric"
            }.ToArray(),
                TakesZeroFrom = new List<string>
                {

                }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Electric",
                TakesDoubleFrom = new List<string> { "Ground" }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Steel",
                "Flying",
                "Electric"
            }.ToArray(),
                TakesZeroFrom = new List<string>
                {

                }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Fairy",
                TakesDoubleFrom = new List<string> {
                "Steel",
                "Poison"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Fighting",
                "Dark",
                "Bug"
            }.ToArray(),
                TakesZeroFrom = new List<string> { "Dragon" }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Fighting",
                TakesDoubleFrom = new List<string> {
                "Psychic",
                "Flying",
                "Fairy"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Rock",
                "Dark",
                "Bug"
            }.ToArray(),
                TakesZeroFrom = new List<string>
                {

                }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Fire",
                TakesDoubleFrom = new List<string> {
                "Water",
                "Rock",
                "Ground"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Steel",
                "Ice",
                "Grass",
                "Fire",
                "Fairy",
                "Bug"
            }.ToArray(),
                TakesZeroFrom = new List<string>
                {

                }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Flying",
                TakesDoubleFrom = new List<string> {
                "Rock",
                "Ice",
                "Electric"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Grass",
                "Fighting",
                "Bug"
            }.ToArray(),
                TakesZeroFrom = new List<string> { "Ground" }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Ghost",
                TakesDoubleFrom = new List<string> {
                "Ghost",
                "Dark"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Poison",
                "Bug",
                "Normal"
            }.ToArray(),
                TakesZeroFrom = new List<string>
                {

                }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Grass",
                TakesDoubleFrom = new List<string> {
                "Poison",
                "Ice",
                "Flying",
                "Fire",
                "Bug"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Water",
                "Ground",
                "Grass",
                "Electric"
            }.ToArray(),
                TakesZeroFrom = new List<string>
                {

                }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Ground",
                TakesDoubleFrom = new List<string> {
                "Water",
                "Ice",
                "Grass"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Rock",
                "Poison"
            }.ToArray(),
                TakesZeroFrom = new List<string> { "Electric" }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Ice",
                TakesDoubleFrom = new List<string> {
                "Steel",
                "Rock",
                "Fire",
                "Fighting"
            }.ToArray(),
                TakesHalfFrom = new List<string> { "Ground" }.ToArray(),
                TakesZeroFrom = new List<string>
                {

                }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Normal",
                TakesDoubleFrom = new List<string> { "Fighting" }.ToArray(),
                TakesHalfFrom = new List<string>
                {

                }.ToArray(),
                TakesZeroFrom = new List<string> { "Ghost" }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Poison",
                TakesDoubleFrom = new List<string> {
                "Psychic",
                "Ground"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Poison",
                "Grass",
                "Fighting",
                "Fairy",
                "Bug"
            }.ToArray(),
                TakesZeroFrom = new List<string>
                {

                }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Psychic",
                TakesDoubleFrom = new List<string> {
                "Ghost",
                "Dark",
                "Bug"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Rock",
                "Fighting"
            }.ToArray(),
                TakesZeroFrom = new List<string>
                {

                }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Rock",
                TakesDoubleFrom = new List<string> {
                "Water",
                "Steel",
                "Ground",
                "Grass",
                "Fighting"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Poison",
                "Normal",
                "Flying",
                "Fire"
            }.ToArray(),
                TakesZeroFrom = new List<string>
                {

                }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Steel",
                TakesDoubleFrom = new List<string> {
                "Ground",
                "Fire",
                "Fighting"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Steel",
                "Rock",
                "Poison",
                "Ice",
                "Ground",
                "Grass",
                "Flying",
                "Fairy",
                "Dragon",
                "Bug"
            }.ToArray(),
                TakesZeroFrom = new List<string> { "Poison" }.ToArray()
            });
            Types.Add(new TypeModel
            {
                PokeType = "Water",
                TakesDoubleFrom = new List<string> {
                "Ground",
                "Fairy"
            }.ToArray(),
                TakesHalfFrom = new List<string> {
                "Water",
                "Steel",
                "Ice",
                "Fire"
            }.ToArray(),
                TakesZeroFrom = new List<string>
                {

                }.ToArray()
            });
        }
    }
}


