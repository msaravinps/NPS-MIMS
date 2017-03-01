
namespace ReadMIMSData.Entities
{
    public class CMPMAN
    {
        public long CmpCode { get; set; }// LongInt
        public string Company { get; set; } //Text(100)
        public string CmpAbbrev { get; set; } //Text(100)
        public string Address1 { get; set; } //Text(50)
        public string Address2 { get; set; } //Text(50)
        public string Address3 { get; set; } //Text(50)
        public string Postcode { get; set; } //Text(4)
        public string Phone { get; set; } //Text(20)
        public string Fax { get; set; } //Text(20)
        public string Toll_free { get; set; } //Text(20)
        public string Email { get; set; } //Text(50)
        public string WebSite { get; set; } //Text(50)
        public string MailOrder { get; set; } //Text(3)
    }
}
