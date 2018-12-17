using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel.Models;
using System.Threading.Tasks;

namespace DomainModel
{
    public class DateRate
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<ExchangeRate> Rates { get; set; }
        public virtual ICollection<Operation> Operations { get; set; }
        
    }
}
