using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClient
{
    public interface IIdAndNameProduct // abstract product
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
