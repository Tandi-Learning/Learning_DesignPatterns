using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClient
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Abstract Factory Client\n\n");
        
        // client uses exisitng constructor directly/explicitly
        Console.WriteLine("client uses exisitng constructor directly/explicitly\n");
        Consultant c = new Consultant { Id = 1, Name = "John Smith" };
        Console.WriteLine("Id = {0} Name = {1}\n\n", c.Id, c.Name);

        // client configures create context with a concrete factory object (consultant factory)
        // client uses context method (CreateObject) 
        // client uses only IIdAndNameProduct objects
        Console.WriteLine("client configures create context with a concrete factory object (consultant factory)\n");
        Console.WriteLine("client uses context method (CreateObject)\n");
        Console.WriteLine("client uses only IIdAndNameProduct objects\n");

        IIdAndNameProduct coc = CreatingObjectContext.CreateObject<ConsultantFactory>(new ConsultantFactory());
        Console.WriteLine("Id = {0} Name = {1}\n", coc.Id, coc.Name);


        Console.WriteLine();
        // client configures create context with a concrete factory object (project factory)
        // client uses context method (CreateObjectFromFactory) 
        // client uses only IIdAndNameProduct objects
        Console.WriteLine("client configures create context with a concrete factory object (project factory)\n");
        Console.WriteLine("client uses context method (CreateObject)\n");
        Console.WriteLine("client uses only IIdAndNameProduct objects\n");

        IIdAndNameProduct coc2 = CreatingObjectContext.CreateObject(new ProjectFactory());
        Console.WriteLine("Id = {0} Name = {1}\n", coc2.Id, coc2.Name);

        }
    }
}
