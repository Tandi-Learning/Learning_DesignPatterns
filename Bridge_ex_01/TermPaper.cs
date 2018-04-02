using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_ex_01
{
    class TermPaper : IManuscript
    {
        public string Class { get; set; }
        public string Student { get; set; }
        public string Text { get; set; }
        public string References { get; set; }

        public void Print()
        {
            Console.WriteLine("Class: {0}", Class);
            Console.WriteLine("Student: {0}", Student);
            Console.WriteLine("Text: {0}", Text);
            Console.WriteLine("References: {0}", References);
            Console.WriteLine();
        }
    }
}
