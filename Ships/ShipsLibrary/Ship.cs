using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsLibrary
{
    class Ship
    {
        int size;
        Field [] fields;

        public Ship(int size, Field [] fields)
        {
            this.size = size;
            this.fields = fields;
        }

        public bool WillHit(Field field)
        {
            if (this.fields.Contains(field) == true)
            {
                return true;
            }
            return false;
        }

        public bool Hit(Field field)
        {
            if (this.fields.Contains(field) == true)
            {
                field.Hit();
                return true;
            }
            return false;
        }

        public bool IsDestroyed()
        {
            for(int i = 0; i<size; i++)
            {
                var field = fields[i];
                if (!field.IsDestroyed())
                    return false;
            }
            return true;
        }

    }
}
