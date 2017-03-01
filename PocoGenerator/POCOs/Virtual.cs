namespace VirtualPocoNamespace
{
public class VirtualProduct
{
public long VirtualProductID {get; set;}
public string VirtualProductGUID {get; set;}
public string VirtualProduct {get; set;}
public string tfVirtualProduct {get; set;}
}
public class LinkPackVirtualProduct
{
public long prodcode {get; set;}
public long formcode {get; set;}
public long packcode {get; set;}
public long VirtualProductID {get; set;}
}
public class BrandName
{
public long prodcode {get; set;}
public long formcode {get; set;}
public string BrandName {get; set;}
}
public class PackName
{
public long prodcode {get; set;}
public long formcode {get; set;}
public long packcode {get; set;}
public string PackName {get; set;}
}
public class LinkPackVirtualProduct
{
public long prodcode {get; set;}
public long formcode {get; set;}
public long packcode {get; set;}
public long VirtualProductID {get; set;}
}
public class LinkItemVirtualItem
{
public long prodcode {get; set;}
public long formcode {get; set;}
public long packcode {get; set;}
public long itemcode {get; set;}
public long VirtualTherapeuticIntentID {get; set;}
public long VirtualGenericItemID {get; set;}
public long VirtualSpecificItemID {get; set;}
}
public class VirtualGenericItem
{
public long VirtualGenericItemID {get; set;}
public string VirtualGenericItemGUID {get; set;}
public string VirtualGenericItem {get; set;}
public long LongIntFormID {get; set;}
}
public class VirtualSpecificItem
{
public long VirtualSpecificItemID {get; set;}
}
public class VirtualEntities
{
public string VirtualSpecificItemGUID {get; set;}
public string VirtualSpecificItem {get; set;}
}
public class VirtualTherapeuticIntent
{
public long VirtualTherapeuticIntentID {get; set;}
public string VirtualTherapeuticIntent {get; set;}
public bool isManyIngredients {get; set;}
}
}
