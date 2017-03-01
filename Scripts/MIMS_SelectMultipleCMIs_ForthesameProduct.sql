SELECT * FROM mims.mims_cmiandrelateddata_singletable_dec_v6 as mst

Group By BrandName
Having Count(*) > 1 AND min(CMICode) != max(CMICode)
ORDER by mst.ProdCode