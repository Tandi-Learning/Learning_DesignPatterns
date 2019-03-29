using System;
using Repository.Data;

namespace Repository.Models
{
    public class CustomerViewModel
    {
        public string AccountNumber { get; set; }
        public DateTime ModifiedDate { get; set; }
        public SalesTerritory Territory { get; set; }
    }
}