using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class ExchangeRate
    {
        public int Id { get; set; }
        public Currencies FromCurrecies { get; set; }
        public Currencies ToCurrencies { get; set; }
        public decimal Coef { get; set; }
        public virtual ICollection<Operation> Operations  { get; set; }

        public int? DateRateId { get; set; }     
        public virtual DateRate DateRate { get; set; }
    }
}
