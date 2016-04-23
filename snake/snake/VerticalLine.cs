using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yU, int yD, int x, char sym)
        {
            pList = new List<Points>();
            for (int y = yU; y <= yD; y++)
            {
                Points p = new Points(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
