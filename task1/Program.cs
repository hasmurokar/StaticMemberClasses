using System;

namespace task1
{ 
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            var arrayPoint = new Point[5];
            for (int i = 0; i < arrayPoint.Length; i++)
            {
                var x = rnd.Next(-100, 100);
                var y = rnd.Next(-100, 100);
                arrayPoint[i] = new Point(x, y);
            }
            foreach (var item in arrayPoint)
            {
                item.OutputPointCoord();
            }
            Point.OutputPointCount();
            Console.ReadLine();
            

        }
    }
}
