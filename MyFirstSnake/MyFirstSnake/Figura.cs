﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSnake
{
    class Figura
    {
        protected List<Point> plist;

        public void Draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
        }
}
