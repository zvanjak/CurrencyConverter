using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class CurrencyConversionRate
    {
        // point in time for which we are defining conversion rate
        public DateTime Moment { get; set; }
        public Currency FromCurrency { get; set; }
        public Currency ToCurrency { get; set; }
        public float ConversionFactor { get; set; }
    }
}
