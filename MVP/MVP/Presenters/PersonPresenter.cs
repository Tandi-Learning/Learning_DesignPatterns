using MVP.Models;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public class PersonPresenter
    {
        private IPersonView _view;

        public PersonPresenter(IPersonView view)
        {
            _view = view;
        }

        public void Init()
        {
            Person person = GetPerson();
            _view.Show(person);
        }

        private Person GetPerson()
        {
            return new Person("Tandi", "Sunarto");
        }
    }
}
