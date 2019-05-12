using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsLibrary
{
    class Field
    {
        int x;
        int y;

        bool destroyed = false;

        public Field(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Hit()
        {
            this.destroyed = true;
        }

        public bool IsDestroyed()
        {
            return this.destroyed;
        }

    }
}
