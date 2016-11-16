using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClient
{
    class ConsultantSkillLevelPropDecorator : Consultant
    {
        public ConsultantSkillLevelPropDecorator(Consultant c)
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
            get { return ndc.Name; }
            set { ndc.Name = value; }
        }


        public int SkillLevel { get; set; }

        private Consultant ndc;
    }
}
