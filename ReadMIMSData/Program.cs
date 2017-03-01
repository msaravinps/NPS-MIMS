using ReadMIMSData.Entities;
using ReadMIMSData.Services;
using System;
using System.IO;

namespace ReadMIMSData
{
    class Program
    {
        static string FilePath(string fileName)
        {
            return $@"Z:\MSaravi\MIMS-Sample\Full\Full20170100\{fileName}";
        }

        static void Main(string[] args)
        {
            var AIMANData = (new MIMSTextDataReader<AIMAN>(FilePath("AIMAN.TXT"))).Load();
            var AMMANData = (new MIMSTextDataReader<AMMAN>(FilePath("AMMAN.TXT"))).Load();
            for (var i = 1; i < 100; i++)
            {
                var filePath = FilePath($"MAN{i.ToString().PadLeft(2, '0')}DAT.TXT");
                if (!File.Exists(filePath))
                    break;
                var mandatData = (new MIMSTextDataReader<MANDAT>(filePath)).Load();
            }

            var SECTMANData = (new MIMSTextDataReader<SECTMAN>(FilePath("SECTMAN.TXT"))).Load();
            var SUBMANData = (new MIMSTextDataReader<SUBMAN>(FilePath("SUBMAN.TXT"))).Load();
            var CMPMANData = (new MIMSTextDataReader<CMPMAN>(FilePath("CMPMAN.TXT"))).Load();
            var GSMMANData = (new MIMSTextDataReader<GSMMAN>(FilePath("GSMMAN.TXT"))).Load();
            var GMMANData = (new MIMSTextDataReader<GMMAN>(FilePath("GMMAN.TXT"))).Load();
            var GENMANData = (new MIMSTextDataReader<GENMAN>(FilePath("GENMAN.TXT"))).Load();
            var MANBMDATData = (new MIMSTextDataReader<MANBMDAT>(FilePath("MANBMDAT.TXT"))).Load();
            var MANIDDATData = (new MIMSTextDataReader<MANIDDAT>(FilePath("MANIDDAT.TXT"))).Load();

            ////var d1 = Type.GetType("MANIDDAT"); // GenericTest was my namespace, add yours
            ////Type[] typeArgs = { d1 };
            ////var makeme = d1.MakeGenericType(typeArgs);
            ////object o = Activator.CreateInstance(makeme);

            //Type generic = typeof(MIMSTextDataReader<>);
            //Type[] typeArgs = { Type.GetType("MANIDDAT") };
            //Type constructed = generic.MakeGenericType(typeArgs);
        }
    }
}
