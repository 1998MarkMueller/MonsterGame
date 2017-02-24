using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Party
    {
        public static MonsterStat[] yourParty = new MonsterStat[] { MonsterList.listOfPokemon[0] , MonsterList.listOfPokemon[1], MonsterList.listOfPokemon[2]};
        public static MonsterStat[] enemyParty = new MonsterStat[] { MonsterList.listOfPokemon[1] };
        public Party(MonsterList pok)
        {
            //party[0] = MonsterList.listOfPokemon[0];
        }
    }
}
