using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMIMSData.Entities
{
    public class SUBMAN
    {
        public long Section { get; set; }// LongInt
        public string Subsection { get; set; }//t(1)
        public string Subtitle { get; set; }//(100)
        public string Subtext { get; set; }//(255)
        public string Headnote1 { get; set; }//
        public string Headnote2 { get; set; }//
        public string Headnote3 { get; set; }//
        public string Headnote4 { get; set; }//Memo
    }
}
