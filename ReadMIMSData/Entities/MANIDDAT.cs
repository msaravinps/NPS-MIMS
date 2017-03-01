using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMIMSData.Entities
{
    public class MANIDDAT
    {
        public long ManCode { get; set; }//LongInt
        public string Grid { get; set; }//LongInt
        public string Description { get; set; }//Text(255)
        public string Colour { get; set; }//Text(50)
        public string Alpha { get; set; }//Text(50)
        public string Image { get; set; }//Text(50)    
    }
}
