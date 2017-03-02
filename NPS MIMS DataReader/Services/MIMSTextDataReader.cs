using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NPS_MIMS_DataReader.Services
{
    class MIMSTextDataReader<T> where T : new()
    {
        string _filePath;
        public MIMSTextDataReader(string filePath/*, IInterpreterService<T> interpreter*/)
        {
            //_interpreter = interpreter;
            _filePath = filePath;
        }

        public IEnumerable<T> Load()
        {
            var data = new List<T>();
            using (var input = new StreamReader(_filePath))
            {
                var count = 0;
                while (true)
                {
                    if (++count > 3) break;
                    var line = input.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        break;
                    data.Add(Interpret(line));
                }
                input.Close();
            }
            return data;
        }

        public T Interpret(string line)
        {
            var parts = line.Split(new char[] { '|' });
            var n = new T();
            var props = typeof(T).GetProperties().ToList();
            var i = 0;
            foreach (var prop in props)
            {
                var typeName = prop.PropertyType.Name;
                if (typeName == "Int64")
                {
                    if (string.IsNullOrEmpty(parts[i]))
                        prop.SetValue(n, -1);
                    else
                        prop.SetValue(n, Convert.ToInt64(parts[i]));
                }
                else if (typeName == "Boolean")
                {
                    prop.SetValue(n, parts[i] == "1" ? true : false);
                }
                else
                {
                    prop.SetValue(n, parts[i]);
                }
                i++;

            }
            return n;
        }

    }
}
