using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSnake
{
    class gorizontalline : Figura
    {
            public gorizontalline(int xLeft, int xRight, int y, char sym)
        {
            plist = new List<Point>();
            for (int x= xLeft; x<=xRight; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
      }
}
