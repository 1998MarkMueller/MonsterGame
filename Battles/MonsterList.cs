using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class MonsterList
    {
        public static MonsterStat[] listOfPokemon;
     
        public MonsterStat bulbasaur = new MonsterStat(1, "Bulbasaur", false, 5, 15, 5, 0, 5, new Types[] { TypeList.Grass } , new Moves[] { MoveList.leechSeed, MoveList.vineWhip, MoveList.tackle, MoveList.scratch }, Regions.region[0], Battles.Properties.Resources.bulbasaurFront, Battles.Properties.Resources.bulbasaurBack);
        public MonsterStat squirtle = new MonsterStat(1, "Squirtle", true, 6, 16, 1, 9, 5, new Types[] { TypeList.Water }, new Moves[] { MoveList.waterGun, MoveList.bubble, MoveList.tackle, MoveList.scratch}, Regions.region[0], Battles.Properties.Resources.squirtleFront, Battles.Properties.Resources.squirtleBack);
        public MonsterStat charmander = new MonsterStat(1, "Charmander", true, 8, 23, 20, 69, 5, new Types[] { TypeList.Fire }, new Moves[] { MoveList.flameThrower, MoveList.ember, MoveList.tackle, MoveList.scratch }, Regions.region[0], Battles.Properties.Resources.charmanderFront, Battles.Properties.Resources.charmanderBack);

        public MonsterList() {
            listOfPokemon = new MonsterStat[] { bulbasaur, squirtle, charmander};
        }

        public string name()
        {
            return bulbasaur.name;
        } 

    }
}
