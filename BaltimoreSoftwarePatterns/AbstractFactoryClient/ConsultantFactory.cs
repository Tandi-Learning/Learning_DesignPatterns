using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClient
{
    class ConsultantFactory : IIdAndNameFactory
    {
        public IIdAndNameProduct CreateObject()
        {
            return new ConsultantProduct { Id = 1, Name = "John Smith" };
        }
    }
}
