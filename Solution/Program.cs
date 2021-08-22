using System;
using System.Collections.Generic;
using System.Linq;

namespace Beast_Mode
{
    class Program
    {
        static dynamic solve()
        {
            return "Hello World!!!";
        }

        static void Main(string[] args)
        {
            long T = long.Parse(Console.ReadLine());

            for (int case_number = 1; case_number <= T; ++case_number)
            { 
                Console.WriteLine("Case #" + case_number + ": " + solve());
            }
        }
    }
}