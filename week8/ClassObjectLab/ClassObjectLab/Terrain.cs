using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectLab
{
    public class Terrain
    {
        public int land = 0; // 0 water, 1 fire , 2 land 
        public Terrain(int newLand)
        {
            land = newLand;
        }
    }
}
