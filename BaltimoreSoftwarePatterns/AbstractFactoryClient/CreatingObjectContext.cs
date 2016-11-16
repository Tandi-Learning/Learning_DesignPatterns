using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClient
{
    class CreatingObjectContext
    {
        public static IIdAndNameProduct CreateObject<T>(T t) where T : IIdAndNameFactory
        {
            return t.CreateObject();
        }
    }
}
