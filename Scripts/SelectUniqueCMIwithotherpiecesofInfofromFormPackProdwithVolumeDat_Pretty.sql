SELECT Distinct 

dbFORMDAT.prodcode as ProdCode, 
CMICode, 
Convert(VarCHAR(Max), form) Form, 
Convert(VarCHAR(Max), brand) Brand, 
Convert(VarCHAR(Max), dbBrandNameVirtual.BrandName) BrandName, 
Convert(VarCHAR(Max), dbCMPDAT.company) CompanyName, 
Convert(VarCHAR(Max), dbBrandNameVirtual.BrandName) Title, 
Convert(VarCHAR(Max), rx_text) ScheduleClassification, 
Convert(VarCHAR(Max), dbPACKDAT.active + ' ' + dbPACKDAT.active_units) Strength, 
Convert(VarCHAR(Max), dbPACKDAT.per_volume + ' ' + dbPACKDAT.per_vol_units) as PerVolume, 
Convert(VarCHAR(Max), [GenericList]) as ActiveIngredient, 
Convert(VarCHAR(Max), dbPACKDAT.unit_volume + ' ' + dbPACKDAT.unit_vol_units) as UnitVolume

FROM 
[MIMS_PROD_Clone].[DBO].[FORMDAT] dbFORMDAT, 
[MIMS_PROD_Clone].[DBO].[BrandName_Virtual] dbBrandNameVirtual, 
[MIMS_PROD_Clone].[DBO].PACKDAT dbPACKDAT, 
[MIMS_PROD_Clone].[DBO].CMPDAT dbCMPDAT, 
[MIMS_PROD_Clone].[DBO].PRODDAT dbPRODDAT
			
WHERE 
dbFORMDAT.formcode = dbBrandNameVirtual.formcode AND 
dbFORMDAT.prodcode = dbBrandNameVirtual.prodcode and 
dbFORMDAT.prodcode = dbPACKDAT.prodcode AND 
dbFORMDAT.formcode = dbPACKDAT.formcode AND 
dbFORMDAT.prodcode = dbPRODDAT.prodcode AND 
dbPRODDAT.cmpcode = dbCMPDAT.cmpcode
ORDER BY BrandName

			
			