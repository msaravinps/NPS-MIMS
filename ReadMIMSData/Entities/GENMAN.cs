using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMIMSData.Entities
{
    public class GENMAN
    {
        public long GenCode { get; set; } //LongInt
        public string Generic { get; set; } //Text(100)
        public string Approved { get; set; } //LongInt
        public string MIMS { get; set; } //Text(2)
        public string TFGeneric { get; set; } //Text(100)    
    }
}
