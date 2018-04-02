using System;
using System.Collections.Generic;

namespace Bridge_ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Manuscript> documents = new List<Manuscript>();

            documents.Add(AddSampleFAQ(new StandardFormatter()));
            documents.Add(AddSampleBook(new BackwardsFormatter()));
            documents.Add(AddSampleTermPaper(new FancyFormatter()));

            foreach(var document in documents) {
                document.Print();
            }
        }

        private static FAQ AddSampleFAQ(IMyFormatter formatter)
        {
            return new FAQ(formatter)
            {
                Title = "The Bridge Pattern FAQ",
                Questions = new List<FAQQuestion> {
                    new FAQQuestion {
                        Question = "What is it ?",
                        Answer = "A design pattern"
                    },
                    new FAQQuestion {
                        Question = "When do we use it ?",
                        Answer = "When you need to seperate abstraction from implementation"
                    }
                }
            };
        }

        private static Book AddSampleBook(IMyFormatter formatter)
        {
            return new Book(formatter)
            {
                Title = "Learning Patterns",
                Author = "Tandi Sunarto",
                Text = "To cure the impostor syndrome"

            };
        }

        private static TermPaper AddSampleTermPaper(IMyFormatter formatter)
        {
            return new TermPaper(formatter)
            {
                Class = "Design Patterns",
                Student = "Impostor Syndrome",
                Text = "Blah blah blah",
                References = "GOF"
            };
        }
    }
}
