using System;
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
            _listCurrencies.Add(new Currency() { Country = "USA", Name = "Dollar", Symbol = "$" });
            _listCurrencies.Add(new Currency() { Country = "EU", Name = "Euro", Symbol = "€" });
            _listCurrencies.Add(new Currency() { Country="Croatia", Name="Kuna", Symbol="kn"});
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
    }
}
