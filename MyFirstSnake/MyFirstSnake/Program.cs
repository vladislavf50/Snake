using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //рисуем точечки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, direction.RIGHT);
            snake.Draw();
            snake.Move();

            //рисуем рамочку
            gorizontalline upline = new gorizontalline(0,78,0,'+');
            verticline leftline = new verticline(0, 24, 0, '+');
            gorizontalline downline = new gorizontalline(0, 78, 24, '+');
            verticline rightline = new verticline(0, 24, 78, '+');
            upline.Draw();
            leftline.Draw();
            downline.Draw();
            rightline.Draw();

            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();


        }
    }
}
