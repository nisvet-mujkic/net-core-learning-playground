using System;
using System.Text;
using static System.Math;

namespace CSharpInDepth_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This text needs truncating.";
            StringBuilder stringBuilder = new StringBuilder(text)
            {
                Length = 10,
                [9] = '\u2026'
            };
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(stringBuilder);

            //int[] niz = new[] { 1, 2, 3, 4, 5 };
            //int? broj = niz?[8];
            //Console.WriteLine(broj ?? 0);

            string[] poruke = {"You can catch this", "You can catch this too", "This won't be caught"};

            foreach (var p in poruke)
            {
                try
                {
                    throw new Exception(p);
                }
                catch (Exception e) when (e.Message.Contains("catch"))
                {
                    Console.WriteLine($"Caught {e.Message}");
                }
            }

            Console.ReadLine();
        }

        static Point PolarToCartesian(double degrees, double magnitude)
        {
            double radians = degrees * PI / 180;
            return new Point(Cos(radians) * magnitude, Sin(radians) * magnitude);
        }
    }
}
