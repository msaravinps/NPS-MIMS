Update mims.mims_cmiandrelateddata_singletable_dec_v6 as m6
set m6.ScheduleClassification = 
(
	SELECT cmi.CMIcode FROM mims.cmixmldata_december as cmi
	
    where cmi.CMIxml like concat( '%<CMIname type="file">', 'Aranesp', '%') and cmi.CMICode = 8704
    LIMIT 1
)

WHERE mst.﻿ProdCode = '5910'


