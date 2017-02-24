using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Moves
    {
        

        Types moveType;
        public string moveName;
        int movePower;
        bool canDoSpecial;

        public Moves(Types _moveType, string _moveName, int _movePower, bool _canDoSpecial)
        {
            moveType = _moveType;
            moveName = _moveName;
            movePower = _movePower;
            canDoSpecial = _canDoSpecial;
        }
    }
}
