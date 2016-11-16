using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReuseAndProgToInterface
{
    class ComposingConsultant
    {

        public ComposingConsultant() 
        {
            this.co = new Consultant();
        }
        public ComposingConsultant(Consultant c, int sl)
        {
            this.co = c;
            this.SkillLevel = sl;
        }

        public int Id 
        {
            get{ return co.Id; }
            set { co.Id = value; }
        }

        public string Name
        {
            get{ return co.Name; }
            set { co.Name = value; }
        }

        private Consultant co;
        public int SkillLevel { get; set; }
    }
}
