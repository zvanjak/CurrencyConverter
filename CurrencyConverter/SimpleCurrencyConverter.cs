using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class SimpleCurrencyConverter
    {
        List<Currency> _listCurrencies = new List<Currency>();
        List<CurrencyConversionRate> _listConversionRates = new List<CurrencyConversionRate>(); 

        public void Init()
        {
            InitializeCurrencies();         // initialize list of currencies

            InitializeExchangeRates();      // initialize list of exchange rates
        }

        private void InitializeCurrencies()
        {
            _listCurrencies.Add(new Currency() { Country = "USA",           Name = "Dollar",    ISOSymbol = "USD",  Symbol = "$" });
            _listCurrencies.Add(new Currency() { Country = "Australia",     Name = "Dollar",    ISOSymbol = "AUD",  Symbol = "$" });
            _listCurrencies.Add(new Currency() { Country = "Belarus",       Name = "Ruble",     ISOSymbol = "BYN",  Symbol = "Br" });
            _listCurrencies.Add(new Currency() { Country = "Brazil",        Name = "Real",      ISOSymbol = "BRL",  Symbol = "R$" });
            _listCurrencies.Add(new Currency() { Country = "Canada",        Name = "Dollar",    ISOSymbol = "CAD",  Symbol = "$" });
            _listCurrencies.Add(new Currency() { Country = "Chile",         Name = "Peso",      ISOSymbol = "CLP",  Symbol = "$" });
            _listCurrencies.Add(new Currency() { Country = "China",         Name = "Yuan",      ISOSymbol = "CNY",  Symbol = "¥" });
            _listCurrencies.Add(new Currency() { Country = "Columbia",      Name = "Peso",      ISOSymbol = "COP",  Symbol = "$" });
            _listCurrencies.Add(new Currency() { Country = "Croatia",       Name = "Kuna",      ISOSymbol = "HRK",  Symbol = "kn" });
            _listCurrencies.Add(new Currency() { Country = "Egypt",         Name = "Pound",     ISOSymbol = "EGP",  Symbol = "£" });
            _listCurrencies.Add(new Currency() { Country = "EU",            Name = "Euro",      ISOSymbol = "EUR",  Symbol = "€" });
            _listCurrencies.Add(new Currency() { Country = "Hong Kong",     Name = "Dollar",    ISOSymbol = "HKD",  Symbol = "$" });
            _listCurrencies.Add(new Currency() { Country = "India",         Name = "Rupee",     ISOSymbol = "INR",  Symbol = "" });
            _listCurrencies.Add(new Currency() { Country = "Indonesia",     Name = "Rupiah",    ISOSymbol = "IDR",  Symbol = "RP" });
            _listCurrencies.Add(new Currency() { Country = "Israel",        Name = "Shekel",    ISOSymbol = "ILS",  Symbol = "₪" });
            _listCurrencies.Add(new Currency() { Country = "Japan",         Name = "Yen",       ISOSymbol = "JPY",  Symbol = "¥" });
            _listCurrencies.Add(new Currency() { Country = "South Korea",   Name = "Won",       ISOSymbol = "KRW",  Symbol = "₩" });
            _listCurrencies.Add(new Currency() { Country = "Malaysia",      Name = "Ringgit",   ISOSymbol = "MYR",  Symbol = "RM" });
            _listCurrencies.Add(new Currency() { Country = "Mexico",        Name = "Peso",      ISOSymbol = "MXN",  Symbol = "$" });
            _listCurrencies.Add(new Currency() { Country = "New Zealand",   Name = "Dollar",    ISOSymbol = "NZD",  Symbol = "$" });
            _listCurrencies.Add(new Currency() { Country = "Nigeria",       Name = "Naira",     ISOSymbol = "NGN",  Symbol = "₦" });
            _listCurrencies.Add(new Currency() { Country = "Norway",        Name = "Krone",     ISOSymbol = "NOK",  Symbol = "kr" });
            _listCurrencies.Add(new Currency() { Country = "Pakistan",      Name = "Rupee",     ISOSymbol = "PKR",  Symbol = "₨" });
            _listCurrencies.Add(new Currency() { Country = "Phillipines",   Name = "Peso",      ISOSymbol = "PHP",  Symbol = "₱" });
            _listCurrencies.Add(new Currency() { Country = "Russia",        Name = "Ruble",     ISOSymbol = "RUB",  Symbol = "₽" });
            _listCurrencies.Add(new Currency() { Country = "Saudi Arabia",  Name = "Rial",      ISOSymbol = "SAR",  Symbol = "﷼" });
            _listCurrencies.Add(new Currency() { Country = "Serbia",        Name = "Dinar",     ISOSymbol = "RSD",  Symbol = "Дин" });
            _listCurrencies.Add(new Currency() { Country = "Singapore",     Name = "Dollar",    ISOSymbol = "SGD",  Symbol = "$" });
            _listCurrencies.Add(new Currency() { Country = "South Africa",  Name = "Rand",      ISOSymbol = "ZAR",  Symbol = "R" });
            _listCurrencies.Add(new Currency() { Country = "Switzerland",   Name = "Franc",     ISOSymbol = "CHF",  Symbol = "CHF" });
            _listCurrencies.Add(new Currency() { Country = "Thailand",      Name = "Baht",      ISOSymbol = "THB",  Symbol = "฿" });
            _listCurrencies.Add(new Currency() { Country = "Turkey",        Name = "Lira",      ISOSymbol = "TRY",  Symbol = "" });
            _listCurrencies.Add(new Currency() { Country = "Ukraine",       Name = "Hryvnia",   ISOSymbol = "UAH",  Symbol = "₴" });
            _listCurrencies.Add(new Currency() { Country = "United Kingdom",Name = "Pound",     ISOSymbol = "GBP",  Symbol = "£" });
            _listCurrencies.Add(new Currency() { Country = "Uruguay",       Name = "Peso",      ISOSymbol = "TRY",  Symbol = "" });
            _listCurrencies.Add(new Currency() { Country = "Turkey",        Name = "Lira",      ISOSymbol = "UYU",  Symbol = "$U" });

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
            Currency from = _listCurrencies.Find(a => a.Name == inCurrencyNameFrom);
            Currency to   = _listCurrencies.Find(a => a.Name == inCurrencyNameTo);

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
            Currency from = _listCurrencies.Find(a => a.Name == inCurrencyNameFrom);
            Currency to = _listCurrencies.Find(a => a.Name == inCurrencyNameTo);

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
            Currency from = _listCurrencies.Find(a => a.Name == inCurrencyNameFrom);
            Currency to = _listCurrencies.Find(a => a.Name == inCurrencyNameTo);

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
