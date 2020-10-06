using System;
using System.Collections.Generic;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicVsObject();
        }

        static void DynamicVsObject()
        {
            //object x = "10";
            //Console.WriteLine(x);
            //Console.WriteLine(x.GetType());
            //x = 10;
            //Console.WriteLine(x);
            //Console.WriteLine(x.GetType());

            //x = x + 10;
            //Console.WriteLine(Math.Max(x,x));

            //var x = "10";
            //Console.WriteLine(x.GetType());
            
            //x = x + 10;
            //Console.WriteLine(x);

            // x = 10;

            // dynamic x = "ABC";
            // Console.WriteLine(x.Substring(0, 1));
            
            // x = 10;
            // Console.WriteLine(x.Substring(0, 1));

            //Console.WriteLine( ReturnDynamic("test"));

            // foreach (var @dynamic in ReturnMoreDynamics())
            // {
            //     Console.WriteLine(@dynamic.GetType());
            // }
            
            // dynamic x = "test";
            // x.Z = 10;
            // Console.WriteLine(x.Z);

            // dynamic z = "test";
            // Print(z);
            // z = 10;
            // Print(z);
        }
        
        public static dynamic ReturnDynamic(dynamic z)
        {
            return z.Substring(0, 1);
        }

        public static IEnumerable<dynamic> ReturnMoreDynamics()
        {
            yield return "Test";
            yield return 10;
            yield return 10.1;
        }

        public static void Print(string s)
        {
            Console.WriteLine($"string {s}");
        }
        
        public static void Print(dynamic s)
        {
            Console.WriteLine($"dynamic {s}");
        }
    }
}