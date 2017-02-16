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
     
        public MonsterStat bulbasaur = new MonsterStat(1, "Bulbasaur", false, 5, 15, 5, 0, 5, new string[] { Types.type[0] }, new string[] { Moves.moves[0], Moves.moves[1], Moves.moves[2], Moves.moves[3] }, Regions.region[0], Battles.Properties.Resources.bulbasaurFront, Battles.Properties.Resources.bulbasaurBack);
        public MonsterStat squirtle = new MonsterStat(1, "Squirtle", true, 6, 16, 1, 69, 5, new string[] { Types.type[0] }, new string[] { Moves.moves[1], Moves.moves[3], Moves.moves[4], Moves.moves[5] }, Regions.region[0], Battles.Properties.Resources.squirtleFront, Battles.Properties.Resources.squirtleBack);

        public MonsterList() {
            listOfPokemon = new MonsterStat[] { bulbasaur, squirtle};
        }

        public string name()
        {
            return bulbasaur.name;
        } 

    }
}
