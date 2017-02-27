using MVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views
{
    public interface IPersonView
    {
        void Show(Person person);
    }
}
