using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_ex_01
{
    public abstract class Manuscript
    {
        protected readonly IMyFormatter formatter;
        public Manuscript(IMyFormatter formatter)
        {
            this.formatter = formatter;
        }
        public abstract void Print();
    }
}
