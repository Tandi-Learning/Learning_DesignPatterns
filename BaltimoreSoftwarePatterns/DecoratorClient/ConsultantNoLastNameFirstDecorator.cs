using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClient
{
    class ConsultantNoLastNameFirstDecorator : Consultant
    {
        public ConsultantNoLastNameFirstDecorator(Consultant c)
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
                string LastName = ndc.Name.Split(',')[0];
                int indexOfLastWord = ndc.Name.Split(',').Length - 1;
                string FirstName = ndc.Name.Split(',')[indexOfLastWord].Trim();
                return (FirstName + " " + LastName);
            }
            set { ndc.Name = value; }
        }

        private Consultant ndc;
    }
}
