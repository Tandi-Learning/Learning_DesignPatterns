                                                                                                                                                                                                                                                                                                                                                                                                                                                                          using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyClient
{
    class Strategies
    {
        public static void ConsoleDefaultStrategy (int i, string s)
        {
            Console.WriteLine("Id = {0} Name = {1}\n\n", i, s);
        }

        public static void ConsoleColorStrategy (int i, string s)
        {
            Console.BackgroundColor = ConsoleColor.Red; 
            Console.WriteLine("Id={0, 10} Name={1, 10}", i, s);
            Console.ResetColor();
        }
    }
}
