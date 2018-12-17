using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DomainModel
{
    public class Cashier 
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Operation> Operations { get; set; }

        public override string ToString()
        {
            return Login;
        }
    }
}
