using System;

namespace pat.a1001
{
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            string input = Console.ReadLine();
            string[] inputlist = input.Split(' ');
            int a = int.Parse(inputlist[0]);
            int b = int.Parse(inputlist[1]);
            int c = a + b;
            Console.WriteLine(c.ToString("#,0"));
        }
    }
}
