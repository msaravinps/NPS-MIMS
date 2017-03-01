Update mims.mims_cmiandrelateddata_singletable_dec_withvolumeinfo_new as mst
set mst.CMICode = 
(
	SELECT cmi.CMIcode FROM mims.cmixmldata_december as cmi
	
    where cmi.CMIxml like concat( '%<CMIname type="file">', mst.BrandName, '%') and cmi.CMIxml like concat( '%<CMIname type="file">', mst.Strength, '%')
    LIMIT 1
)