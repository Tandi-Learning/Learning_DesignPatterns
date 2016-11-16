using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClient
{
    class ConsultantDrDecorator : Consultant
    {
        public ConsultantDrDecorator (Consultant c)
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
            get { return ("Dr. " + ndc.Name); }
            set { ndc.Name = value; }
        }

        private Consultant ndc;
    }
}
