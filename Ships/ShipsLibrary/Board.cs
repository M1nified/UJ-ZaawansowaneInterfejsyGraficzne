using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsLibrary
{
    public class Board
    {
        int x = 10;
        int y = 10;

        Field[,] fields;
        Ship[] ships = new Ship[10];

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Board()
        {
            fields = new Field[x, y];

            PopulateFields();
        }
        public Board(int x, int y)
        {
            this.x = x;
            this.y = y;

            fields = new Field[x, y];

            PopulateFields();
        }

        private void PopulateFields()
        {
            for(int xx = 0; xx < x; xx++)
            {
                for(int yy = 0; yy < y; yy++)
                {
                    fields[xx, yy] = new Field(xx, yy);
                }
            }
        }

        public bool WillHit(int x, int y)
        {
            var ship = FindShip(x, y);
            if(ship == null)
            {
                return false;
            }
            return true;
        }

        public bool Hit(int x, int y)
        {
            var ship = FindShip(x, y);
            if(ship == null)
            {
                return false;
            }
            var field = fields[x, y];
            ship.Hit(field);
            return true;
        }

        private Ship FindShip(int x, int y)
        {
            var field = fields[x, y];
            var ship = FindShip(field);
            return ship;
        }

        private Ship FindShip(Field field)
        {
            foreach (var ship in ships)
            {
                if (ship.WillHit(field))
                    return ship;
            }
            return null;
        }

    }
}
