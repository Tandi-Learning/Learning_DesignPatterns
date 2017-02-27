using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastUpdated { get; set; }

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            LastUpdated = DateTime.Now;
        }
    }
}
