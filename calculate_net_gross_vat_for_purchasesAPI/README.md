## Database relevant queries:

SELECT *
FROM countrydb.dbo.Countries as Countries
INNER JOIN countrydb.dbo.VATRates as VR on VR.CountryId = Countries.Id