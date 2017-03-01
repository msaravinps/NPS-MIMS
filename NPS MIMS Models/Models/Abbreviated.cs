namespace AbbreviatedPocoNamespace
{
    public class AIDAT
    {
        public long aicode { get; set; }
        public string action { get; set; }
        public string tfaction { get; set; }
    }
    public class AMDAT
    {
        public long prodcode { get; set; }
        public long aicode { get; set; }
    }
    public class SUBXDAT
    {
        public long prodcode { get; set; }
        public long section { get; set; }
        public string subsection { get; set; }
    }
    public class SECTDAT
    {
        public long section { get; set; }
        public string title { get; set; }
    }
    public class SUBDAT
    {
        public long section { get; set; }
        public string subsection { get; set; }
        public string subtitle { get; set; }
        public string subtext { get; set; }
        public string headnote1 { get; set; }
        public string headnote2 { get; set; }
        public string headnote3 { get; set; }
        public string headnote4 { get; set; }
    }
    public class SPORTDAT
    {
        public string sportcode { get; set; }
        public string sportcodetxt { get; set; }
    }
    public class PRODDAT
    {
        public long prodcode { get; set; }
        public string product { get; set; }
        public long section { get; set; }
        public string subsection { get; set; }
        public string pc { get; set; }
        public string p_text { get; set; }
        public long cmpcode { get; set; }
        public string dis { get; set; }
        public string cmi { get; set; }
        public string use { get; set; }
        public string ci { get; set; }
        public string pr { get; set; }
        public string ar { get; set; }
        public string ir { get; set; }
        public string wa { get; set; }
        public string manpage { get; set; }
        public string xref { get; set; }
        public string sportcode { get; set; }
        public string s11 { get; set; }
        public string prodsort { get; set; }
        public long mancode { get; set; }
        public string deleted { get; set; }
        public string tfproduct { get; set; }
    }
    public class RECORD
    {
        public string tablename { get; set; }
        public long num_records { get; set; }
    }
    public class FORMDAT
    {
        public long prodcode { get; set; }
        public long formcode { get; set; }
        public long formsort { get; set; }
        public string form { get; set; }
        public string rx { get; set; }
        public string rx_text { get; set; }
        public string co { get; set; }
        public string gf { get; set; }
        public string brand { get; set; }
        public string da { get; set; }
        public string foodcode { get; set; }
        public string drowsy { get; set; }
        public long CMIcode { get; set; }
        public string GenericList { get; set; }
        public string tfGenericList { get; set; }
    }
    public class FOODDAT
    {
        public string foodcode { get; set; }
        public string foodcodetxt { get; set; }
    }
    public class CMPDAT
    {
        public long cmpcode { get; set; }
        public string company { get; set; }
        public string cmpabbrev { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string postcode { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string toll_free { get; set; }
        public string email { get; set; }
        public string web_site { get; set; }
        public string mail_order { get; set; }
        public string subtitle { get; set; }
    }
    public class ANADAT
    {
        public string tabledefs { get; set; }
    }
    public class GMDAT
    {
        public long prodcode { get; set; }
        public long formcode { get; set; }
        public long gencode { get; set; }
        public long GenericSort { get; set; }
    }
    public class GSMDAT
    {
        public long prodcode { get; set; }
        public long formcode { get; set; }
        public long gencode { get; set; }
        public long approved { get; set; }
    }
    public class PACKDAT
    {
        public long prodcode { get; set; }
        public long formcode { get; set; }
        public long packcode { get; set; }
        public long packsort { get; set; }
        public string active { get; set; }
        public string active_units { get; set; }
        public string per_volume { get; set; }
        public string per_vol_units { get; set; }
        public string unit_volume { get; set; }
        public string unit_vol_units { get; set; }
        public string solvent { get; set; }
        public string misc { get; set; }
        public long units_per_pack { get; set; }
        public long no_of_packs { get; set; }
        public string pbs_code { get; set; }
        public string pbs { get; set; }
        public long rp { get; set; }
        public string equiv { get; set; }
        public long authcode { get; set; }
        public long restcode { get; set; }
        public string pbs_price { get; set; }
        public string bpp { get; set; }
        public string spec_contrib { get; set; }
        public string price { get; set; }
        public string disp_fee { get; set; }
        public string dd_fee { get; set; }
        public string s3r_fee { get; set; }
        public string tgp { get; set; }
        public long tgp_group { get; set; }
        public long sec100code { get; set; }
        public string MANcode { get; set; }
        public string DispFeeCode { get; set; }
    }
    public class CPYRGHT
    {
        public string copyright { get; set; }
    }
    public class GENDAT
    {
        public long gencode { get; set; }
        public string generic { get; set; }
        public long approved { get; set; }
        public string MIMS { get; set; }
        public string tfgeneric { get; set; }
    }
    public class PPSDAT
    {
        public long prodcode { get; set; }
        public long formcode { get; set; }
        public long packcode { get; set; }
        public string NSW { get; set; }
        public string VIC { get; set; }
        public string QLD { get; set; }
        public string WA { get; set; }
        public string SA { get; set; }
        public string TAS { get; set; }
        public string ACT { get; set; }
        public string NT { get; set; }
    }
    public class EQUIVDAT
    {
        public long prodcode1 { get; set; }
        public long formcode1 { get; set; }
        public long packcode1 { get; set; }
        public long prodcode2 { get; set; }
        public long formcode2 { get; set; }
        public long packcode2 { get; set; }
    }
    public class INDDAT
    {
        public long indcode { get; set; }
        public string indication { get; set; }
        public string note { get; set; }
        public string AbbrevIndication { get; set; }
    }
}
