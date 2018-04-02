using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_ex_01
{
    public class Book : Manuscript
    {
        public Book(IMyFormatter formatter) : 
            base(formatter)
        {
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public override void Print()
        {            
            Console.WriteLine(formatter.Format("Title", Title));
            Console.WriteLine(formatter.Format("Author", Author));
            Console.WriteLine(formatter.Format("Text", Text));
            Console.WriteLine();
        }
    }
}
