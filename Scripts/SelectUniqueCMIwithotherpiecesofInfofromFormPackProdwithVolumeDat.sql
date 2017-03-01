SELECT Distinct t.prodcode as ProdCode, CMICode, Convert(VarCHAR(Max), form) Form, Convert(VarCHAR(Max), brand) Brand, Convert(VarCHAR(Max), a.BrandName) BrandName, Convert(VarCHAR(Max), c.company) CompanyName, Convert(VarCHAR(Max), a.BrandName) Title, Convert(VarCHAR(Max), rx_text) ScheduleClassification, Convert(VarCHAR(Max), b.active + ' ' + b.active_units) Strength, Convert(VarCHAR(Max), b.per_volume + ' ' + b.per_vol_units) as PerVolume, Convert(VarCHAR(Max), [GenericList]) as ActiveIngredient, Convert(VarCHAR(Max), b.unit_volume + ' ' + b.unit_vol_units) as UnitVolume
		FROM (SELECT CMIcode,
             prodcode,
			 form,
			 formcode,
			 brand,			 		 
			 rx_text,
			 [GenericList],
			 Row_number() OVER(PARTITION BY CMIcode, prodcode ORDER BY CMiCode) rn
			FROM [MIMS_PROD_Clone].[DBO].[FORMDAT]) t, [MIMS_PROD_Clone].[DBO].[BrandName_Virtual] a, [MIMS_PROD_Clone].[DBO].PACKDAT b, [MIMS_PROD_Clone].[DBO].CMPDAT c, [MIMS_PROD_Clone].[DBO].PRODDAT p
			
			WHERE a.formcode = t.formcode AND t.prodcode = a.prodcode and t.prodcode = b.prodcode AND t.formcode = b.formcode AND t.prodcode = p.prodcode AND p.cmpcode = c.cmpcode
			
			ORDER BY BrandName

			
			