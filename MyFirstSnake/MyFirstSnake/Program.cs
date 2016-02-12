using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //рисуем точечки
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            p1.Draw(); 
            p2.Draw();

            //рисуем рамочку
            gorizontalline upline = new gorizontalline(0,78,0,'+');
            verticline leftline = new verticline(0, 24, 0, '+');
            gorizontalline downline = new gorizontalline(0, 78, 24, '+');
            verticline rightline = new verticline(0, 24, 78, '+');
            upline.Draw();
            leftline.Draw();
            downline.Draw();
            rightline.Draw();

            Console.ReadLine();
        }
    }
}
