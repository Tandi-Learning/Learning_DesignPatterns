using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReuseAndProgToInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reuse & Prog to Interface\n\n");

        // client uses exisitng class
        Console.WriteLine("Client uses exsiting class\n");
        Consultant c = new Consultant { Id = 1, Name = "John Smith" };       
        Console.WriteLine("Id = {0} Name = {1}\n\n", c.Id, c.Name);
        
        // reuse consultant class via inheritance
        Console.WriteLine("reuse consultant class via inheritance\n");
        InheritingConsultant ic = new InheritingConsultant {Id = 1, Name = "John Smith", SkillLevel = 2 };
        Console.WriteLine("Id = {0} Name = {1} Skill Level = {2}\n\n",
                ic.Id, ic.Name, ic.SkillLevel);

        // reuse consultant class via composition
        // passing in individual fields or an object
        Console.WriteLine("reuse consultant class via composition\n");
        Console.WriteLine("passing in individual fields or an object\n");
        ComposingConsultant cc = new ComposingConsultant {Id = 1, Name = "John Smith", SkillLevel = 2 };       
        Console.WriteLine("Id = {0} Name = {1} Skill Level = {2}\n",
                cc.Id, cc.Name, cc.SkillLevel);
        
        ComposingConsultant cc2 = new ComposingConsultant(c, 2);
        Console.WriteLine("Id = {0} Name = {1} Skill Level = {2}\n\n",
                cc.Id, cc.Name, cc.SkillLevel);

        // program to an interface, not implementation
        Console.WriteLine("program to an interface, not implementation\n");
        IIdAndName[] iidandnamearray = 
        { 
            new LineOfBusiness {Id = 1, Name = "Medical" },
            new Project { Id = 1, Name = "eLove"}
        };
        
        // reusable desging with any IIdAndMame object
        foreach (IIdAndName iidandname in iidandnamearray)
            Console.WriteLine("Id = {0} Name = {1}\n",
                    iidandname.Id, iidandname.Name);
        }
    }
}
