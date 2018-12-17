using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Person
    {
        public int Id { get; set; }
        public int Limit { get; set; }
        public virtual ICollection<Operation> Operations { get; set; }
    }
}
