using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        public Direction direction;

        public Snake(Points tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Points>();
            for(int i = 0; i<length; i++)
            {
                Points p = new Points( tail );
                p.Move( i, direction );
                pList.Add( p );
            }
        }

        internal void Move()
        {
            Points tail = pList.First();
            pList.Remove( tail );
            Points head = GetNextPoints();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Points GetNextPoints()
        {
            Points head = pList.Last();
            Points nextPoints = new Points(head);
            nextPoints.Move(1, direction);
            return nextPoints;
        }
    }
}
