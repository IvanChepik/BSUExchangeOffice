using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel.Models;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Operation
    {
        public int Id { get; set; }
        public DateTime DateOfOperation { get; set; }
        public ExchangeRate RateOperation { get; set; }

        public int? OperationId { get; set; }
        public virtual Operation Operations { get; set; }

        public int? CashierId { get; set; }
        public virtual Cashier Cashiers { get; set; }

        public int? DateRateId { get; set; }
        public virtual DateRate DateRates { get; set; }

        public int? PersonId { get; set; }
        public virtual Person Persons { get; set; }
    }
}
