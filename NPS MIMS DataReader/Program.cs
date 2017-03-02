using NPS_MIMS_DataReader.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS_MIMS_DataReader
{
    class Res
    {
        public string Form { get; set; }
        public string Brand { get; set; }
        public string BrandName { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string ScheduleClassification { get; set; }
        public string Strength { get; set; }
        public string PerVolume { get; set; }
        public string ActiveIngredient { get; set; }
        public string UnitVolume { get; set; }
        public long FORMDATformcode { get; set; }
        public long FORMDATprodcode { get; set; }
        public long FORMDATcmpcode { get; set; }
        public long BrandNameVirtualformcode { get; set; }
        public long BrandNameVirtualprodcode { get; set; }
        public long PACKDATprodcode { get; set; }
        public long PACKDATformcode { get; set; }
        public long PRODDATprodcode { get; set; }
        public long PRODDATcmpcode { get; set; }
        public long CMPDATcmpcode { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Start();
        }

        void Start()
        {
            var brandNames = (new MIMSTextDataReader<VirtualNamespace.BrandNameVirtual>(VirtualFilePath("BrandName"))).Load();
            var linkItemVirtualItems = (new MIMSTextDataReader<VirtualNamespace.LinkItemVirtualItemVirtual>(VirtualFilePath("LinkItemVirtualItem"))).Load();
            var linkPackVirtualProducts = (new MIMSTextDataReader<VirtualNamespace.LinkPackVirtualProductVirtual>(VirtualFilePath("LinkPackVirtualProduct"))).Load();
            var packNames = (new MIMSTextDataReader<VirtualNamespace.PackNameVirtual>(VirtualFilePath("PackName"))).Load();
            var virtualGenericItems = (new MIMSTextDataReader<VirtualNamespace.VirtualGenericItemVirtual>(VirtualFilePath("VirtualGenericItem"))).Load();
            var virtualProducts = (new MIMSTextDataReader<VirtualNamespace.VirtualProductVirtual>(VirtualFilePath("VirtualProduct"))).Load();
            var virtualSpecificItems = (new MIMSTextDataReader<VirtualNamespace.VirtualSpecificItemVirtual>(VirtualFilePath("VirtualSpecificItem"))).Load();
            var virtualTherapeuticIntents = (new MIMSTextDataReader<VirtualNamespace.VirtualTherapeuticIntentVirtual>(VirtualFilePath("VirtualTherapeuticIntent"))).Load();

            var FORMDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.FORMDAT>(AbbreviatedFilePath("FORMDAT"))).Load();
            var AIDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.AIDAT>(AbbreviatedFilePath("AIDAT"))).Load();
            var AMDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.AMDAT>(AbbreviatedFilePath("AMDAT"))).Load();
            var SUBXDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.SUBXDAT>(AbbreviatedFilePath("SUBXDAT"))).Load();
            var SECTDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.SECTDAT>(AbbreviatedFilePath("SECTDAT"))).Load();
            var SUBDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.SUBDAT>(AbbreviatedFilePath("SUBDAT"))).Load();
            var SPORTDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.SPORTDAT>(AbbreviatedFilePath("SPORTDAT"))).Load();
            var PRODDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.PRODDAT>(AbbreviatedFilePath("PRODDAT"))).Load();
            var RECORDs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.RECORD>(AbbreviatedFilePath("RECORD"))).Load();
            var FOODDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.FOODDAT>(AbbreviatedFilePath("FOODDAT"))).Load();
            var CMPDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.CMPDAT>(AbbreviatedFilePath("CMPDAT"))).Load();
            var ANADATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.ANADAT>(AbbreviatedFilePath("ANADAT"))).Load();
            var GMDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.GMDAT>(AbbreviatedFilePath("GMDAT"))).Load();
            var GSMDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.GSMDAT>(AbbreviatedFilePath("GSMDAT"))).Load();
            var PACKDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.PACKDAT>(AbbreviatedFilePath("PACKDAT"))).Load();
            var CPYRGHTs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.CPYRGHT>(AbbreviatedFilePath("CPYRGHT"))).Load();
            var GENDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.GENDAT>(AbbreviatedFilePath("GENDAT"))).Load();
            var PPSDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.PPSDAT>(AbbreviatedFilePath("PPSDAT"))).Load();
            var EQUIVDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.EQUIVDAT>(AbbreviatedFilePath("EQUIVDAT"))).Load();
            var INDDATs = (new MIMSTextDataReader<AbbreviatedPocoNamespace.INDDAT>(AbbreviatedFilePath("INDDAT"))).Load();
            var result = (from formdat in FORMDATs select new Res { FORMDATformcode = formdat.formcode, PRODDATprodcode = formdat.prodcode, Form = formdat.form, Brand = formdat.brand, ScheduleClassification = formdat.rx_text, ActiveIngredient = formdat.GenericList }).
                            Union(from brandname in brandNames select new Res { BrandNameVirtualformcode = brandname.formcode, BrandNameVirtualprodcode = brandname.prodcode, BrandName = brandname.BrandName, Title = brandname.BrandName, Form = "" }).
                            Union(from packdat in PACKDATs select new Res { PACKDATprodcode = packdat.prodcode, PACKDATformcode = packdat.formcode, Strength = packdat.active + " " + packdat.active_units, PerVolume = packdat.per_volume + " " + packdat.per_vol_units, UnitVolume = packdat.unit_volume + " " + packdat.unit_vol_units }).
                            Union(from cmpdat in CMPDATs select new Res { CMPDATcmpcode = cmpdat.cmpcode, CompanyName = cmpdat.company }).
                            Union(from proddat in PRODDATs select new Res { PRODDATcmpcode = proddat.cmpcode, PRODDATprodcode = proddat.prodcode }).
                            Where(r =>
                            r.FORMDATformcode == r.BrandNameVirtualformcode &&
                            r.FORMDATprodcode == r.BrandNameVirtualprodcode &&
                            r.FORMDATprodcode == r.PACKDATprodcode &&
                            r.FORMDATformcode == r.PACKDATformcode &&
                            r.FORMDATprodcode == r.PRODDATprodcode &&
                            r.PRODDATcmpcode == r.CMPDATcmpcode
                            )
                            .ToList();

        }

        string VirtualFilePath(string name)
        {
            return $@"Z:\MSaravi\MIMS-Sample\VirtualEntities20170300\{name}.txt";
        }

        string AbbreviatedFilePath(string name)
        {
            return $@"Z:\MSaravi\MIMS-Sample\Abbreviated\Abbrev20170300\{name}.txt";
        }
    }
}
