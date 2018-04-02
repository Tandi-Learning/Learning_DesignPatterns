using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_ex_01
{
    public class FAQ : Manuscript
    {
        public FAQ(IMyFormatter formatter) : base(formatter)
        {
        }

        public string Title { get; set; }
        public List<FAQQuestion> Questions { get; set; }

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));
            foreach(var question in Questions)
            {
                Console.WriteLine(formatter.Format(">> Q", question.Question));
                Console.WriteLine(formatter.Format(">> A", question.Answer));
            }
            
            Console.WriteLine();
        }
    }

    public class FAQQuestion
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
