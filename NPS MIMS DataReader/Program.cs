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
            var brandNames = (new MIMSTextDataReader<VirtualNamespace.BrandNameVirtual>(VirtualFilePath("BrandName"))).Load();
            var linkItemVirtualItems = (new MIMSTextDataReader<VirtualNamespace.LinkItemVirtualItemVirtual>(VirtualFilePath("LinkItemVirtualItem"))).Load();
            var linkPackVirtualProducts = (new MIMSTextDataReader<VirtualNamespace.LinkPackVirtualProductVirtual>(VirtualFilePath("LinkPackVirtualProduct"))).Load();
            var packNames = (new MIMSTextDataReader<VirtualNamespace.PackNameVirtual>(VirtualFilePath("PackName"))).Load();
            //var virtualEntities = (new MIMSTextDataReader<VirtualNamespace.VirtualEntitiesVirtual>(VirtualFilePath("VirtualEntities"))).Load();
            var virtualGenericItems = (new MIMSTextDataReader<VirtualNamespace.VirtualGenericItemVirtual>(VirtualFilePath("VirtualGenericItem"))).Load();
            var virtualProducts = (new MIMSTextDataReader<VirtualNamespace.VirtualProductVirtual>(VirtualFilePath("VirtualProduct"))).Load();
            var virtualSpecificItems = (new MIMSTextDataReader<VirtualNamespace.VirtualSpecificItemVirtual>(VirtualFilePath("VirtualSpecificItem"))).Load();
            var virtualTherapeuticIntents = (new MIMSTextDataReader<VirtualNamespace.VirtualTherapeuticIntentVirtual>(VirtualFilePath("VirtualTherapeuticIntent"))).Load();
        }
        static string VirtualFilePath(string name)
        {
            return $@"Z:\MSaravi\MIMS-Sample\VirtualEntities20170300\{name}.txt";
        }
    }
}
