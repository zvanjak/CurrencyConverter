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


PROJEKTI/BIBLIOTEKE

	1. BaseLib - klase za opis entiteta i osnovne konverzijske funkcije
	2. Data direktorij
		1. poddirektoriji za scrappane liste s razli�itih sajtova
		2. dodati lokalne balkanske valute

	3. SimpleCurrencyConverter - uklju�uje povijesne podatke za 7-8 najva�nijih valuta
		1. MMFovi podaci
		2. od 2000 svaki dan
		3. prije toga svakih 10 dana
		4. lako uklju�ivanje/dodavanje novih nizova vrijednosti
		5. mogu�nost u�itavanja definiranih formata
			1. ukoliko se �eli u�itati iz kompletnih lista (scrapanih s websiteova


	4. online scrappers - ciljaju to�no odre�eni datum
		1. projekt - CConv.OnlineDataScrappers
		2. definirati interface koji zadovoljavaju
			1. primaju to�no odre�eni datum i vrijeme
			2. i dva deskriptora valuta

		3. definirati i testove za svaki - s hardkodiranim vrijednostima koje s o�ekuju kod dobrog izvo�enja

	5. static scrappers - dovla�e liste povijesnih podataa
		1. staviti u projekt - CConv.SeriesDataScrappers
		2. serija razli�itih projekata za scrapping s razli�iitih stranica
		3. kod svih unificirati gdje se podaci spremaju nakon scrappanja
		4. unificirati format 
		5. MMF, ECB, FED,
			1. doma�e - HNB, Zaba, Privredna, Erste, Hypo


	6. utilities - produciraju .cs fajlove s hardkodiranim serijama
	7. CurrencyConversionManager
		1. za razliku do simple, njemu se uvijek mora re�i koji niz da koristi
		2. po default dizajniran za vi�e razli�itih izvora
		3. mogu�nost definiranja vi�e razli�itih vrsta te�aja
			1. srednji, kupovni, prodajni

		4. automatsko identificiranje arbitra�e? uz online scrappere

	8. Examples
		1. popis najve�ih dnevnih/tjednih/mjese�nih promjena (pad/rast) te�aja
		2. varijacije u razlici prodajnog i kupovnog te�aja kod doma�ih banaka




