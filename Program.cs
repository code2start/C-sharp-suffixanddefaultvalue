using System;

namespace suffixanddefaultvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Console.WriteLine("Hello World!");
            float f1 = 5.3f;
            Console.WriteLine(f1);
            uint f2 = 33334455u;
            Console.WriteLine(f2);
            decimal f3 = 444.2334m;
            */
            int i = default(int);
            Console.WriteLine(i);
            sbyte f4 = default(sbyte);
            Console.WriteLine(f4);
            //c# v 7.1
            double f5 = default;
            Console.WriteLine(f5);
        }
    }
}
