using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xL, int xR, int y, char sym)
        {
            pList = new List<Points>();
            for(int x = xL; x <= xR; x++)
            {
                Points p = new Points(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
