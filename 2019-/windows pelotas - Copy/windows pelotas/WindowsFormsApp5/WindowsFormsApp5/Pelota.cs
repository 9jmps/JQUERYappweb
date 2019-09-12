using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Pelota
    {
        public int x;
        public int y;
        public int color;
        public int direccion;

        public Pelota()
        {
            x = 0;
            y = 0;
            color = 1;
            direccion = 0;
        }

        public Pelota(int x, int y)
        {
            this.x = x;
            this.y = y;
            color = 1;
            direccion = 0;
        }


    }
}
