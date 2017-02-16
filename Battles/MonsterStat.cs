using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class MonsterStat
    {
        public int ID;
        public string name;
        public bool isMale;
        public int lvl;
        public int maxHP, currHP;
        public int exp;
        public int speed;
        public string[] type;
        public string[] move;
        public string region;
        public System.Drawing.Bitmap imgF;
        public System.Drawing.Bitmap imgB;

        public MonsterStat(int _ID, string _name, bool _isMale, int _lvl, int _maxHP, int _currHP, int _exp, int _speed, string[] _type, string[] _move, string _region, System.Drawing.Bitmap _imgF, System.Drawing.Bitmap _imgB)
        {
            ID = _ID;
            name = _name;
            isMale = _isMale;
            lvl = _lvl;
            maxHP = _maxHP;
            currHP = _currHP;
            exp = _exp;
            speed = _speed;
            type = _type;
            move = _move;
            region = _region;
            imgF = _imgF;
            imgB = _imgB;
        }

    }
}
