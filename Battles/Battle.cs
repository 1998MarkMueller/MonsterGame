using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Battle
    {
        //////////////////////////////////////////////////////////////////////////////

        public static int yourPartyPokemonSelected = 0;
    
        public static MonsterStat yourPokemon = Party.yourParty[yourPartyPokemonSelected];

        public static string yourPokemonName = yourPokemon.name;
        public static string yourPokemonGender = checkGender(yourPokemon);
        public static int yourPokemonLvl = yourPokemon.lvl;
        public static int yourPokemonExp = yourPokemon.exp;
        public static int yourPokmeonHP = yourPokemon.currHP;
        public static int yourPokemonMaxHP = yourPokemon.maxHP;
        public static System.Drawing.Bitmap yourPokemonImage = yourPokemon.imgB;
        public static Types[] yourPokemonType = yourPokemon.type;
        public static Moves[] yourPokemonMoves = yourPokemon.move;

        //////////////////////////////////////////////////////////////////////////////

        public static int enemyPartyPokemonSelected = 0;

        public static MonsterStat enemyPokemon = Party.enemyParty[enemyPartyPokemonSelected];

        public static string enemyPokemonName = enemyPokemon.name;
        public static string enemyPokemonGender = checkGender(enemyPokemon);
        public static int enemyPokemonLvl = enemyPokemon.lvl;
        public static int enemyPokemonExp = enemyPokemon.exp;
        public static int enemyPokmeonHP = enemyPokemon.currHP;
        public static int enemyPokemonMaxHP = enemyPokemon.maxHP;
        public static System.Drawing.Bitmap enemyPokemonImage = enemyPokemon.imgF;
        public static Types[] enemyPokemonType = enemyPokemon.type;
        public static Moves[] enemyPokemonMoves = enemyPokemon.move;

        //////////////////////////////////////////////////////////////////////////////

        public static string checkGender(MonsterStat pok)
        {
            if (pok.isMale)
            {
                return "♂";
            }
            else {
                return "♀";
            }
        }
    }
}
