using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMIMSData.Entities
{
    public class MANDAT
    {
        public long ManCode { get; set; } //LongInt
        public string Product { get; set; }//Text(100)
        public long Section { get; set; }//LongInt
        public string Subsection { get; set; }//Text(1)
        public string CmpCode { get; set; }//LongInt
        public string New { get; set; }//Text(3)
        public string Ri { get; set; }//Text(3)
        public string Co { get; set; }//Memo
        public string Des { get; set; }// Memo
        public string Ac { get; set; }//Memo
        public string Ind { get; set; }// Memo
        public string Ci { get; set; }//Memo
        public string Wa { get; set; }//Memo
        public string Pr { get; set; }//Memo
        public string Ar { get; set; }//Memo
        public string Ir { get; set; }//Memo
        public string Od { get; set; }//Memo
        public string Da { get; set; }//Memo
        public string Du { get; set; }//Memo
        public string Prn { get; set; }// Memo
        public string Str { get; set; }// Memo
        public string Ps { get; set; }//Memo
        public string Manpage { get; set; }//Text(20)
        public string Prodsort { get; set; }//Text(100)
        public string Ref { get; set; }//Text(50)
        public string Create_date { get; set; }//Text(20)
        public string Change_date { get; set; }//Text(20)
        public string Boxed_warn { get; set; }//Memo
        public string TFProduct { get; set; }//Text(100)
        public string ChemStruct { get; set; }//Text(255)
    }
}
