using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
        protected List<Points> pList;

        public void Draw()
        {
            foreach (Points p in pList)
            {
                p.Draw();
            }
        }
    }
}
