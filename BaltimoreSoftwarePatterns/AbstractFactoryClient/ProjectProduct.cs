using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClient
{
    class ProjectProduct : IIdAndNameProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
