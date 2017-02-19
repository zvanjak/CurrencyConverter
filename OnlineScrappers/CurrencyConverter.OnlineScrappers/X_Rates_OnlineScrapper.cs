using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyConverter.Common;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace CurrencyConverter.OnlineScrappers
{
    public class X_Rates_OnlineScrapper
    {
        private static List<CurrencyConversionRate> GetRatesForDateFromWebsite_X_Rates(List<Currency> inListCurrencies, string inForCurr, int inDay, int inMonth, int inYear)
        {
            List<CurrencyConversionRate> retList = new List<CurrencyConversionRate>();

            ScrapingBrowser Browser = new ScrapingBrowser();
            Browser.AllowAutoRedirect = true; // Browser has settings you can access in setup
            Browser.AllowMetaRedirect = true;

            string url = "http://www.x-rates.com/historical/?from=" + inForCurr + "&amount=1&date=" + inYear.ToString() + "-" + inMonth.ToString("D2") + "-" + inDay.ToString("D2");

            WebPage PageResult = Browser.NavigateToPage(new Uri(url));

            List<string> Names = new List<string>();
            var Table = PageResult.Html.CssSelect(".ratesTable");

            if (Table.Count() > 0)
            {
                var myTable = Table.ElementAt(1);

                foreach (var row in myTable.SelectNodes("tbody/tr"))
                {
                    var nameCurrTo = row.SelectNodes("td")[0].InnerText;
                    var value = row.SelectNodes("td")[1].InnerText;
                    var invertedValue = row.SelectNodes("td")[2].InnerText;

                    // find that currency by long name
                    var toCurrency = inListCurrencies.FirstOrDefault(p => p.LongName == nameCurrTo);
                    if (toCurrency != null)
                    {
                        CurrencyConversionRate newRate = new CurrencyConversionRate();

                        Currency from = inListCurrencies.Find(a => a.ISOSymbol == inForCurr);

                        newRate.FromCurrency = from;
                        newRate.ToCurrency = toCurrency;
                        newRate.ConversionFactor = Convert.ToSingle(value);
                        newRate.Moment = new DateTime(inYear, inMonth, inDay);

                        Console.WriteLine(nameCurrTo + " " + value + " " + invertedValue);

                        retList.Add(newRate);
                    }

                }
            }

            return retList;
        }
    }
}
