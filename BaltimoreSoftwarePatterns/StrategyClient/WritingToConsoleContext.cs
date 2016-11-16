using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyClient
{
    class WritingToConsoleContext
    {
        public WritingToConsoleContext (DWriteToConsoleStrategy s)
        {
            this.strategy = s;
        }

        public void WriteToConsole(int i, string s)
        {
            strategy.Invoke(i, s);
        }


        private DWriteToConsoleStrategy strategy;
    }
}
