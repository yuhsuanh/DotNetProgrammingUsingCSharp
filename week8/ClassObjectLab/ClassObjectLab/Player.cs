using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectLab
{
    class Player
    {
        public int strength=5;
        public void Check(Terrain terrain)
        {
            //switch +98
            switch (terrain.land)
            {
                case 0:  //water 
                    strength--;
                    break;
                case 1:  //fire 
                    strength=1; 
                    break;
                case 2:  //water 
                    strength++; 
                    break;
                default:
                    break;
            }
        }
    }
}
