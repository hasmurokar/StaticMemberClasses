using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Point
    {
        private int X { get; set; }
        private int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            CountingQuarter();
        }
        private static int FirstQuarter { get; set; }
        private static int SecondQuarter { get; set; }
        private static int ThirdQuarter { get; set; }
        private static int FourthQuarter { get; set; }
        private static int CountOfPoint { get; set; }

        public void OutputPointCoord()
        {
            Console.WriteLine($"Коорд. точки Х: {X}, Коорд. точки Y: {Y}");
        }
        public static void OutputPointCount()
        {
            Console.WriteLine($"Кол-во точек в 1 коорд. четверти: {FirstQuarter}");
            Console.WriteLine($"Кол-во точек в 2 коорд. четверти: {SecondQuarter}");
            Console.WriteLine($"Кол-во точек в 3 коорд. четверти: {ThirdQuarter}");
            Console.WriteLine($"Кол-во точек в 4 коорд. четверти: {FourthQuarter}");
            Console.WriteLine($"Общее кол-во точек: {CountOfPoint}");
        }
        private void CountingQuarter()
        {
            if (X > 0 && Y > 0)
            {
                FirstQuarter++;
                CountOfPoint++;

            }
            else if (X > 0 && Y < 0)
            {
                SecondQuarter++;
                CountOfPoint++;
            }
            else if (X < 0 && Y < 0)
            {
                ThirdQuarter++;
                CountOfPoint++;
            }
            else if (X < 0 && Y > 0)
            {
                FourthQuarter++;
                CountOfPoint++;
            }
            else
            {
                CountOfPoint++;
            }
        }
    }
}
