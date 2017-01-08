# CurrencyConverter
Stand-alone, simple C# class library for performing currency conversions

TODO:

1. DONE - Define a list of 30 most common currencies
3. DONE - Find a referent source for getting conversion rates
3. DONE - Implement GetConversionRate()
4. DONE - Implement GetConvertedValue()
5. DONE - Add unit tests
6. Think about error handling - return values, exceptions?
7. Think through another converter - one with the base currency
8. Think through complex converter - that maintains multiple exchange rates
9. Implement OnlineConverter - uses internet to get rates from a list of websites
10. Find sources for currency rates and implement scrapping from their websites:
	1. IMF
	2. FED
	3. ECB
	4. UK Central Bank
	5. HNB
11. Organize downloaded data into separate folders
12. Organize scrapping code

Main Todo - get into Json historical monthly rates for main currencies, for some time in the past; and transform that Json into some kind of hardcoded values, available in code itself 

Sources:

1. XE - [http://www.xe.com/?](http://www.xe.com/?)
2. X-Rates [http://www.x-rates.com/historical](http://www.x-rates.com/historical)
3. UK Forex [http://www.ukforex.co.uk/forex-tools/historical-rate-tools/historical-exchange-rates](http://www.ukforex.co.uk/forex-tools/historical-rate-tools/historical-exchange-rates)
4. IMF - [https://www.imf.org/external/np/fin/data/param_rms_mth.aspx](https://www.imf.org/external/np/fin/data/param_rms_mth.aspx)
5. FRED - [https://fred.stlouisfed.org/categories/94](https://fred.stlouisfed.org/categories/94)
6. FED - [https://www.federalreserve.gov/releases/h10/hist/default.htm](https://www.federalreserve.gov/releases/h10/hist/default.htm)
7. 
