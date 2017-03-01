namespace VirtualNamespace
{
    public class VirtualProductVirtual
    {
        public long VirtualProductID { get; set; }
        public string VirtualProductGUID { get; set; }
        public string VirtualProduct { get; set; }
        public string tfVirtualProduct { get; set; }
    }
    public class BrandNameVirtual
    {
        public long prodcode { get; set; }
        public long formcode { get; set; }
        public string BrandName { get; set; }
    }
    public class PackNameVirtual
    {
        public long prodcode { get; set; }
        public long formcode { get; set; }
        public long packcode { get; set; }
        public string PackName { get; set; }
    }
    public class LinkPackVirtualProductVirtual
    {
        public long prodcode { get; set; }
        public long formcode { get; set; }
        public long packcode { get; set; }
        public long VirtualProductID { get; set; }
    }

    public class LinkItemVirtualItemVirtual
    {
        public long prodcode { get; set; }
        public long formcode { get; set; }
        public long packcode { get; set; }
        public long itemcode { get; set; }
        public long VirtualTherapeuticIntentID { get; set; }
        public long VirtualGenericItemID { get; set; }
        public long VirtualSpecificItemID { get; set; }
    }
    public class VirtualGenericItemVirtual
    {
        public long VirtualGenericItemID { get; set; }
        public string VirtualGenericItemGUID { get; set; }
        public string VirtualGenericItem { get; set; }
        public long LongIntFormID { get; set; }
    }
    public class VirtualSpecificItemVirtual
    {
        public long VirtualSpecificItemID { get; set; }
    }
    public class VirtualEntitiesVirtual
    {
        public string VirtualSpecificItemGUID { get; set; }
        public string VirtualSpecificItem { get; set; }
    }
    public class VirtualTherapeuticIntentVirtual
    {
        public long VirtualTherapeuticIntentID { get; set; }
        public string VirtualTherapeuticIntent { get; set; }
        public bool isManyIngredients { get; set; }
    }
}
