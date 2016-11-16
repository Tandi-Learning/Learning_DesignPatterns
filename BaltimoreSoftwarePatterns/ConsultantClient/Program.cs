using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultantClient
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Consultant Client\n\n");
        
        // client uses exisitng classes
        // direct/explicit constructor of Consultant
        // direct/explicit print of System.out
        Console.WriteLine("client uses exisitng classes\n");
        Console.WriteLine("direct/explicit constructor of Consultant\n");
        Console.WriteLine("direct/explicit WriteLine of Console\n");

        Consultant c = new Consultant { Id = 1, Name = "John Smith" };
        Console.WriteLine("Id = {0} Name = {1}\n", c.Id, c.Name);

        }
    }
}
