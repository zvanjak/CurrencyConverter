using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace CurrencyWebScrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            ScrapingBrowser Browser = new ScrapingBrowser();
            Browser.AllowAutoRedirect = true; // Browser has settings you can access in setup
            Browser.AllowMetaRedirect = true;

            WebPage PageResult = Browser.NavigateToPage(new Uri("http://www.x-rates.com/historical/?from=USD&amount=1&date=2017-01-06"));
            //HtmlNode TitleNode = PageResult.Html.CssSelect(".navbar-brand").FirstOrDefault();
            //string PageTitle = TitleNode.InnerText;

            List<string> Names = new List<string>();
            var Table = PageResult.Html.CssSelect(".ratesTable");

            var myTable = Table.ElementAt(1);

            foreach (var row in myTable.SelectNodes("tbody/tr"))
            {
                foreach (var cell in row.SelectNodes("td"))
                {
                    Console.WriteLine(cell.InnerText);
                }
            }
        }

        private static void GetPageUsingStandardWebRequest()
        {
            string url = "http://www.x-rates.com/historical/?from=USD&amount=1&date=2017-01-06";
            string strResult = "";
            WebResponse objResponse;
            WebRequest objRequest = System.Net.HttpWebRequest.Create(url);

            objResponse = objRequest.GetResponse();

            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                strResult = sr.ReadToEnd();
                // Close and clean up the StreamReader
                sr.Close();
            }

            // Display results to a webpage
            Console.Write(strResult);
        }
    }
}
