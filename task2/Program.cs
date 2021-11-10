using System;

namespace task2
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            var parrArray = new RectParallelepiped[6];
            for (int i = 0; i < parrArray.Length; i++)
            {
                var a = rnd.Next(1, 10);
                var b = rnd.Next(1, 10);
                var h = rnd.Next(1, 10);
                parrArray[i] = new RectParallelepiped(a, b, h);
            }

            foreach (var item in parrArray)
            {
                item.OutputParams();
            }

            RectParallelepiped.CountParallelepiped();

            Console.ReadLine();
        }
    }
}
