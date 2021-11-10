using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class RectParallelepiped
    {
        private int A { get; set; }
        private int B { get; set; }
        private int H { get; set; }

        public RectParallelepiped(int a, int b, int h)
        {
            A = a;
            B = b;
            H = h;
            Counter();
        }
        private static int CubeCount { get; set; }
        private static int TotalCount { get; set; }
        public int SqareParallelepiped()
        {
            return 2 * (A * B + B * H + A * H);
        }
        public int VolumeParallelepiped()
        {
            return A * B * H;
        }
        public void OutputParams()
        {
            Console.WriteLine($"Сторона №1: {A}, Сторона №2: {B}, Высота: {H}");
        }
        public static void CountParallelepiped()
        {
            Console.WriteLine($"Общее кол-во: {TotalCount}, Кол-во кубов: {CubeCount}"); 
        }
        public void Counter()
        {
            if (A == B && A == H && B == H)
            {
                CubeCount++;
            }
            TotalCount++;
        }
    }
}
