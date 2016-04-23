using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //Рисование рамки
            HorizontalLine lineUp = new HorizontalLine(0, 78, 0, '+');
            VerticalLine lineLeft = new VerticalLine(0, 24, 0, '+');
            VerticalLine lineRight = new VerticalLine(0, 24, 78, '+');
            HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '+');
            lineUp.Draw();
            lineLeft.Draw();
            lineRight.Draw();
            lineDown.Draw();

            //Рисование точек
            Points p = new Points(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if ( key.Key == ConsoleKey.LeftArrow )
                        snake.direction = Direction.LEFT;
                    else if ( key.Key == ConsoleKey.RightArrow )
                        snake.direction = Direction.RIGHT;
                    else if ( key.Key == ConsoleKey.DownArrow )
                        snake.direction = Direction.DOWN;
                    else if ( key.Key == ConsoleKey.UpArrow )
                        snake.direction = Direction.UP;
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine();
        }
    }
}
