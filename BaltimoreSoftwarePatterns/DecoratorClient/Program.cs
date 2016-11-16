using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Client\n\n");

            // client uses exisitng class
            Console.WriteLine("Client uses exsiting class\n");
            Consultant c = new Consultant { Id = 1, Name = "John Smith" };
            Console.WriteLine("Id = {0} Name = {1}\n\n", c.Id, c.Name);

            // client uses skill level prop decorator class
            Console.WriteLine("Client uses skill level prop decorator class\n");
            ConsultantSkillLevelPropDecorator cslpd = new ConsultantSkillLevelPropDecorator(c);
            cslpd.SkillLevel = 2;
            Console.WriteLine("Id = {0} Name = {1} SkillLevel = {2}\n\n",
                    cslpd.Id, cslpd.Name, cslpd.SkillLevel);

            // client uses last name first decorator class
            Console.WriteLine("Client uses last name first decorator class\n");
            ConsultantLastNameFirstDecorator clnfd = new ConsultantLastNameFirstDecorator(c);
            Console.WriteLine("Id = {0} Name = {1}\n\n", clnfd.Id, clnfd.Name);

            // client uses no last name first decorator class (detaches responsibility)
            Console.WriteLine("client uses no last name first decorator classes (detaches responsibility)\n");
            ConsultantNoLastNameFirstDecorator cnlnfd = new ConsultantNoLastNameFirstDecorator(clnfd);
            Console.WriteLine("Id = {0} Name = {1}\n\n", cnlnfd.Id, cnlnfd.Name);

            // client uses Dr decorator class
            Console.WriteLine("Client uses Dr decorator class decorator class\n");
            ConsultantDrDecorator cdrd = new ConsultantDrDecorator(c);
            Console.WriteLine("Id = {0} Name = {1}\n\n", cdrd.Id, cdrd.Name);

            // client uses both last name first & Dr decorator classes
            Console.WriteLine("Client uses both last name first & Dr decorator classes\n");
            ConsultantDrDecorator clnfdrd = new ConsultantDrDecorator(clnfd);       
            Console.WriteLine("Id = {0} Name = {1}\n\n", clnfdrd.Id, clnfdrd.Name);


            // client uses an array of decorator class objects
            Console.WriteLine("Client uses an array of decorator class objects\n");
            Consultant[] ConsultantArray = 
            {
                new Consultant { Id = 1, Name = "John Smith" },
                new ConsultantLastNameFirstDecorator(new Consultant{ Id = 2, Name = "Sam Daniel"} ),
                new ConsultantDrDecorator(new Consultant { Id = 3, Name = "Sue Jones"} ),
                new ConsultantSkillLevelPropDecorator(new Consultant { Id = 4, Name = "Mary Ann Smith"} )
            };
        
            // reusable desging with any Consultant object
            foreach (Consultant co in ConsultantArray)
                Console.WriteLine("Id = {0} Name = {1}\n", co.Id, co.Name);
        }
    }
}
