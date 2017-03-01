using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocoGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            GenGroup("Abbreviated", "AbbreviatedPocoNamespace");
            GenGroup("Virtual", "VirtualPocoNamespace");
        }

        static void GenGroup(string fileName, string nameSpace)
        {
            using (var writer = new StreamWriter($@"C:\Users\msaravi\Documents\Visual Studio 2015\Projects\MIMS\PocoGenerator\POCOs\{fileName}.cs"))
            {
                writer.WriteLine($"namespace {nameSpace}");
                writer.WriteLine("{");
                using (var reader = new StreamReader($@"C:\Users\msaravi\Documents\Visual Studio 2015\Projects\MIMS\PocoGenerator\{fileName}.txt"))
                {
                    var lines = new List<string>();
                    while (true)
                    {
                        var line = reader.ReadLine();
                        if (string.IsNullOrEmpty(line))
                            break;
                        if (line == "-")
                        {
                            POCO(lines, writer);
                            lines.Clear();
                        }
                        else
                        {
                            lines.Add(line);
                        }
                    }
                    reader.Close();
                }
                writer.WriteLine("}");
                writer.Close();
            }

        }

        static void POCO(List<string> lines, StreamWriter writer)
        {
            writer.WriteLine($"public class {lines.First()}");
            writer.WriteLine("{");
            foreach (var line in lines)
            {
                if (line == lines.First())
                    continue;
                var info = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var type = info[1] == "LongInt" ? "long" : "string";
                if (info[1] == "LongInt")
                {
                    type = "long";
                }
                else if (info[1] == "Yes/No")
                {
                    type = "bool";
                }
                else
                {
                    type = "string";
                }
                writer.WriteLine($"public {type} {info[0]} {{get; set;}}");
            }
            writer.WriteLine("}");
        }
    }
}
