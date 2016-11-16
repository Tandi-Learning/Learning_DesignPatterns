using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClient
{
    class ProjectFactory : IIdAndNameFactory
    {
        public IIdAndNameProduct CreateObject()
        {
            return new ProjectProduct { Id = 1, Name = "eLove" };
        }
    }
}
