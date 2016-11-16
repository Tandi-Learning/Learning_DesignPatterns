using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyClient
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Strategy Client\n\n");

        // client uses exisitng WriteLine() method directly/explicitly
        Console.WriteLine("client uses exisitng printf method directly/explicitly\n");
        Consultant c = new Consultant { Id = 1, Name = "John Smith" };
        Console.WriteLine("Id = {0} Name = {1}\n\n", c.Id, c.Name);

        // client configures context with a concrete strategy object (console default)
        // client uses context method (WriteToConsole) 
        Console.WriteLine("client configures context with a concrete strategy method (console default)\n");
        Console.WriteLine("client uses context method (WriteToConsole)\n");
        WritingToConsoleContext wtcc = new WritingToConsoleContext(Strategies.ConsoleDefaultStrategy);     
        wtcc.WriteToConsole(c.Id, c.Name);
        
        Console.WriteLine("\n");
        // client configures context with a concrete strategy object (console color)
        // client uses context method (WriteToConsole) 
        Console.WriteLine("client configures context with a concrete strategy method (console color)\n");
        Console.WriteLine("client uses context method (WriteToConsole)\n");
        WritingToConsoleContext wtcc2 = new WritingToConsoleContext(Strategies.ConsoleColorStrategy);     
        wtcc2.WriteToConsole(c.Id, c.Name);
        }
    }
}
