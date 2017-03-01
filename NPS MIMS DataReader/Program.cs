using NPS_MIMS_DataReader.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS_MIMS_DataReader
{
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
