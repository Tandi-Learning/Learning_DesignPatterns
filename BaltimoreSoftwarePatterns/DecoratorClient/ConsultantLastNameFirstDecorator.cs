using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClient
{
    class ConsultantLastNameFirstDecorator : Consultant
    {
        public ConsultantLastNameFirstDecorator(Consultant c)
        {
            ndc = c;
        }

        public override int Id
        {
            get { return ndc.Id; }
            set { ndc.Id = value; }
        }

        public override string Name
        {
            get
            {
                string FirstName = ndc.Name.Split()[0];
                int indexOfLastWord = ndc.Name.Split().Length - 1;
                string LastName = ndc.Name.Split()[indexOfLastWord];
                return (LastName + ", " + FirstName);
            }
            set { ndc.Name = value; }
        }

        private Consultant ndc;
    }
}
