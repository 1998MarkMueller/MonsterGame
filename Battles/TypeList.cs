using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class TypeList
    {   //no, fi, fl, po, gr, ro, bu, gh, st, fir, wa, gra, el, ps, ic, dr, da, fa
        public static Types Normal = new Types(1,1,1,1,1,.5,1,0,.5,1,1,1,1,1,1,1,1,1);
        public static Types Fight = new Types(2,1,.5,.5,1,2,.5,0,2,1,1,1,1,.5,2,1,2,.5);
        public static Types Flying = new Types(1,2,1,1,1,.5,2,1,.5,1,1,2,.5,1,1,1,1,1);
        public static Types Poison = new Types(1,1,1,.5,.5,.5,1,.5,0,1,1,2,1,1,1,1,1,2);
        public static Types Ground = new Types(1,1,0,2,1,2,.5,1,2,2,1,.5,2,1,1,1,1,1);
        public static Types Rock = new Types(1,.5,2,1,.5,1,2,1,.5,2,1,1,1,1,2,1,1,1);
        public static Types Bug = new Types(1,.5,.5,.5,1,1,1,.5,.5,.5,1,2,1,2,1,1,2,.5);
        public static Types Ghost = new Types(0,1,1,1,1,1,1,2,1,1,1,1,1,2,1,1,.5,1);
        public static Types Steel = new Types(1,1,1,1,1,2,1,1,.5,.5,.5,1,.5,1,2,1,1,2);
        public static Types Fire = new Types(1,1,1,1,1,.5,2,1,2,.5,.5,2,1,1,2,.5,1,1);
        public static Types Water = new Types(1,1,1,1,2,2,1,1,1,2,.5,.5,1,1,1,.5,1,1);
        public static Types Grass = new Types(1,1,.5,.5,2,2,.5,1,.5,.5,2,.5,1,1,1,.5,1,1);
        public static Types Electric = new Types(1,1,2,1,0,1,1,1,1,1,2,.5,.5,1,1,.5,1,1);
        public static Types Psychic = new Types(1,2,1,2,1,1,1,1,.5,1,1,1,1,.5,1,1,0,1);
        public static Types Ice = new Types(1,1,2,1,2,1,1,1,.5,.5,.5,2,1,1,.5,2,1,1);
        public static Types Dragon = new Types(1,1,1,1,1,1,1,1,.5,1,1,1,1,1,1,2,1,0);
        public static Types Dark = new Types(1,.5,1,1,1,1,1,2,1,1,1,1,1,2,1,1,.5,.5);
        public static Types Fair = new Types(1,2,1,.5,1,1,1,1,.5,.5,1,1,1,1,1,2,2,1);
    }
}
