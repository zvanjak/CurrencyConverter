using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyConverter.Common;

namespace CurrencyConverter
{
    public class SimpleCurrencyConverter
    {
        List<Currency> _listCurrencies = new List<Currency>();
        List<CurrencyConversionRate> _listConversionRates = new List<CurrencyConversionRate>();

        public List<Currency> ListCurrencies
        {
            get { return _listCurrencies; }
        }

        public void Init()
        {
            InitializeCurrencies();         // initialize list of currencies

            InitializeExchangeRates();      // initialize list of exchange rates
        }

        private void InitializeCurrencies()
        {
            ListCurrencies.Add(new Currency() { Country = "USA",           Name = "Dollar",    LongName = "US Dollar",             ISOSymbol = "USD",  Symbol = "$" });
            ListCurrencies.Add(new Currency() { Country = "Australia",     Name = "Dollar",    LongName = "Australian Dollar",     ISOSymbol = "AUD",  Symbol = "$" });
            ListCurrencies.Add(new Currency() { Country = "Brazil",        Name = "Real",      LongName = "Brazilian Real",        ISOSymbol = "BRL",  Symbol = "R$" });
            ListCurrencies.Add(new Currency() { Country = "Canada",        Name = "Dollar",    LongName = "Canadian Dollar",       ISOSymbol = "CAD",  Symbol = "$" });
            ListCurrencies.Add(new Currency() { Country = "Chile",         Name = "Peso",      LongName = "Chilean Peso",          ISOSymbol = "CLP",  Symbol = "$" });
            ListCurrencies.Add(new Currency() { Country = "China",         Name = "Yuan",      LongName = "Chinese Yuan Renminbi", ISOSymbol = "CNY",  Symbol = "¥" });
            ListCurrencies.Add(new Currency() { Country = "Columbia",      Name = "Peso",      LongName = "Colombian Peso",        ISOSymbol = "COP",  Symbol = "$" });
            ListCurrencies.Add(new Currency() { Country = "Croatia",       Name = "Kuna",      LongName = "Croatian Kuna",         ISOSymbol = "HRK",  Symbol = "kn" });
            ListCurrencies.Add(new Currency() { Country = "EU",            Name = "Euro",      LongName = "Euro",                  ISOSymbol = "EUR",  Symbol = "€" });
            ListCurrencies.Add(new Currency() { Country = "Hong Kong",     Name = "Dollar",    LongName = "Hong Kong Dollar",      ISOSymbol = "HKD",  Symbol = "$" });
            ListCurrencies.Add(new Currency() { Country = "India",         Name = "Rupee",     LongName = "Indian Rupee",          ISOSymbol = "INR",  Symbol = "" });
            ListCurrencies.Add(new Currency() { Country = "Indonesia",     Name = "Rupiah",    LongName = "Indonesian Rupiah",     ISOSymbol = "IDR",  Symbol = "RP" });
            ListCurrencies.Add(new Currency() { Country = "Israel",        Name = "Shekel",    LongName = "Israeli Shekel",        ISOSymbol = "ILS",  Symbol = "₪" });
            ListCurrencies.Add(new Currency() { Country = "Japan",         Name = "Yen",       LongName = "Japanese Yen",          ISOSymbol = "JPY",  Symbol = "¥" });
            ListCurrencies.Add(new Currency() { Country = "South Korea",   Name = "Won",       LongName = "South Korean Won",      ISOSymbol = "KRW",  Symbol = "₩" });
            ListCurrencies.Add(new Currency() { Country = "Malaysia",      Name = "Ringgit",   LongName = "Malaysian Ringgit",     ISOSymbol = "MYR",  Symbol = "RM" });
            ListCurrencies.Add(new Currency() { Country = "Mexico",        Name = "Peso",      LongName = "Mexican Peso",          ISOSymbol = "MXN",  Symbol = "$" });
            ListCurrencies.Add(new Currency() { Country = "New Zealand",   Name = "Dollar",    LongName = "New Zealand Dollar",    ISOSymbol = "NZD",  Symbol = "$" });
            ListCurrencies.Add(new Currency() { Country = "Norway",        Name = "Krone",     LongName = "Norwegian Krone",       ISOSymbol = "NOK",  Symbol = "kr" });
            ListCurrencies.Add(new Currency() { Country = "Pakistan",      Name = "Rupee",     LongName = "Pakistani Rupee",       ISOSymbol = "PKR",  Symbol = "₨" });
            ListCurrencies.Add(new Currency() { Country = "Phillipines",   Name = "Peso",      LongName = "Philippine Peso",       ISOSymbol = "PHP",  Symbol = "₱" });
            ListCurrencies.Add(new Currency() { Country = "Russia",        Name = "Ruble",     LongName = "Russian Ruble",         ISOSymbol = "RUB",  Symbol = "₽" });
            ListCurrencies.Add(new Currency() { Country = "Saudi Arabia",  Name = "Rial",      LongName = "Saudi Arabian Riyal",   ISOSymbol = "SAR",  Symbol = "﷼" });
            ListCurrencies.Add(new Currency() { Country = "Singapore",     Name = "Dollar",    LongName = "Singapore Dollar",      ISOSymbol = "SGD",  Symbol = "$" });
            ListCurrencies.Add(new Currency() { Country = "South Africa",  Name = "Rand",      LongName = "South African Rand",    ISOSymbol = "ZAR",  Symbol = "R" });
            ListCurrencies.Add(new Currency() { Country = "Switzerland",   Name = "Franc",     LongName = "Swiss Franc",           ISOSymbol = "CHF",  Symbol = "CHF" });
            ListCurrencies.Add(new Currency() { Country = "Thailand",      Name = "Baht",      LongName = "Thai Baht",             ISOSymbol = "THB",  Symbol = "฿" });
            ListCurrencies.Add(new Currency() { Country = "Turkey",        Name = "Lira",      LongName = "Turkish Lira",          ISOSymbol = "TRY",  Symbol = "" });
            ListCurrencies.Add(new Currency() { Country = "United Kingdom",Name = "Pound",     LongName = "British Pound",         ISOSymbol = "GBP",  Symbol = "£" });

        }

        private void InitializeExchangeRates()
        {
            // Dollars to Kuna
            AddConversionRate(new DateTime(2016, 6, 1), "Dollar", "Kuna", 6.693657f);
            AddConversionRate(new DateTime(2016, 7, 1), "Dollar", "Kuna", 6.739179f);
            AddConversionRate(new DateTime(2016, 8, 1), "Dollar", "Kuna", 6.710826f);
            AddConversionRate(new DateTime(2016, 9, 1), "Dollar", "Kuna", 6.690581f);
            AddConversionRate(new DateTime(2016, 10, 1), "Dollar", "Kuna", 6.701386f);
            AddConversionRate(new DateTime(2016, 11, 1), "Dollar", "Kuna", 6.827300f);
            AddConversionRate(new DateTime(2016, 12, 1), "Dollar", "Kuna", 7.054304f);

            AddConversionRate(new DateTime(2016, 6, 1), "Euro", "Kuna", 7.459411f);
            AddConversionRate(new DateTime(2016, 8, 1), "Euro", "Kuna", 7.455057f);
            AddConversionRate(new DateTime(2016, 10, 1), "Euro", "Kuna", 7.488799f);
            AddConversionRate(new DateTime(2016, 12, 1), "Euro", "Kuna", 7.512834f);
        }

        public bool AddConversionRate(DateTime inMoment, string inCurrencyNameFrom, string inCurrencyNameTo, float inConversionRate)
        {
            Currency from = ListCurrencies.Find(a => a.Name == inCurrencyNameFrom);
            Currency to   = ListCurrencies.Find(a => a.Name == inCurrencyNameTo);

            if (from == null || to == null)
            {
                // wrong currencies
                return false;
            }

            // TODO - check for the entry with same values already in the list

            _listConversionRates.Add(new CurrencyConversionRate() { FromCurrency = from, ToCurrency = to, Moment = inMoment, ConversionFactor = inConversionRate});

            return true;
        }

        public float GetRateForDate(DateTime inDate, string inCurrencyNameFrom, string inCurrencyNameTo )
        {
            Currency from = ListCurrencies.Find(a => a.Name == inCurrencyNameFrom);
            Currency to = ListCurrencies.Find(a => a.Name == inCurrencyNameTo);

            if (from == null || to == null)
            {
                // wrong currencies
                return 0.0f;
            }

            // first, find all available rates between those two currencies
            List<CurrencyConversionRate> listRatesSorted = _listConversionRates.Where(rate => rate.FromCurrency == @from && rate.ToCurrency == to).ToList();

            // sorting list of rates by date
            List<CurrencyConversionRate> listRatesSortedSorted = listRatesSorted.OrderBy(o => o.Moment).ToList();

            float returnRate = listRatesSorted[0].ConversionFactor;


            if (inDate <= listRatesSorted[0].Moment)
                returnRate = listRatesSorted[0].ConversionFactor;
            else if (inDate > listRatesSorted[listRatesSorted.Count - 1].Moment)
                returnRate = listRatesSorted[listRatesSorted.Count - 1].ConversionFactor;
            else
            {
                for (int i = 0; i < listRatesSorted.Count - 1; i++)
                {
                    if (listRatesSorted[i + 1].Moment == inDate)
                        return listRatesSorted[i + 1].ConversionFactor;

                    if (listRatesSorted[i].Moment < inDate && inDate < listRatesSorted[i + 1].Moment)
                    {
                        // izvest ćemo linearnu interpolaciju
                        long x1 = listRatesSorted[i].Moment.Ticks;
                        long x2 = listRatesSorted[i + 1].Moment.Ticks;
                        float y1 = listRatesSorted[i].ConversionFactor;
                        float y2 = listRatesSorted[i + 1].ConversionFactor;

                        float x = inDate.Ticks;

                        returnRate = (y2 - y1) / (x2 - x1) * (x - x1) + y1;
                    }
                }
            }

            return returnRate;
        }
        public float Convert(float inAmount, DateTime inDate, string inCurrencyNameFrom, string inCurrencyNameTo)
        {
            Currency from = ListCurrencies.Find(a => a.Name == inCurrencyNameFrom);
            Currency to = ListCurrencies.Find(a => a.Name == inCurrencyNameTo);

            if (from == null || to == null)
            {
                // wrong currencies
                return 0.0f;
            }

            float rate = GetRateForDate(inDate, inCurrencyNameFrom, inCurrencyNameTo);

            return inAmount * rate;
        }
    }
}
