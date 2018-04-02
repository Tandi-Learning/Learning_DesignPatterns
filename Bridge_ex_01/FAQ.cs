using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_ex_01
{
    class FAQ
    {
        public string Title { get; set; }
        public List<FAQQuestion> Questions { get; set; }

        public void Print()
        {
            Console.WriteLine("Title: {0}", Title);
            foreach(var question in Questions)
            {
                Console.WriteLine(">> Q: {0}", question.Question);
                Console.WriteLine(">> A: {0}", question.Answer);
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
