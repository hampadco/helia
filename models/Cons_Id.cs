
// // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
//     public class Attributes
//     {
//         public string name { get; set; }
//         public string displayName { get; set; }
//         public string symbol { get; set; }
//         public object website { get; set; }
//         public object description { get; set; }
//         public string region { get; set; }
//         public string country { get; set; }
//         public object logoUrl { get; set; }
//         public string memberType { get; set; }
//         public string organizationType { get; set; }
//         public string focusArea { get; set; }
//         public string nonProfitStatus { get; set; }
//         public bool isActive { get; set; }
//         public object joined { get; set; }
//         public string rorId { get; set; }
//         public DateTime created { get; set; }
//         public DateTime updated { get; set; }
//         public int doiEstimate { get; set; }
//     }

//     public class Clients
//     {
//         public List<Datum> data { get; set; }
//     }

//     public class Consortium
//     {
//         public Data data { get; set; }
//     }

//     public class Contacts
//     {
//         public List<Datum> data { get; set; }
//     }

//     public class Data
//     {
//         public string id { get; set; }
//         public string type { get; set; }
//         public Attributes attributes { get; set; }
//         public Relationships relationships { get; set; }
//     }

//     public class FocusArea
//     {
//         public string id { get; set; }
//         public string title { get; set; }
//         public int count { get; set; }
//     }

//     public class HasRequiredContact
//     {
//         public string id { get; set; }
//         public string title { get; set; }
//         public int count { get; set; }
//     }

//     public class Links
//     {
//         public string self { get; set; }
//     }

//     public class MemberType
//     {
//         public string id { get; set; }
//         public string title { get; set; }
//         public int count { get; set; }
//     }

//     public class Meta
//     {
//         public int total { get; set; }
//         public int totalPages { get; set; }
//         public int page { get; set; }
//         public List<Year> years { get; set; }
//         public List<Region> regions { get; set; }
//         public List<MemberType> memberTypes { get; set; }
//         public List<OrganizationType> organizationTypes { get; set; }
//         public List<FocusArea> focusAreas { get; set; }
//         public List<NonProfitStatus> nonProfitStatuses { get; set; }
//         public List<HasRequiredContact> hasRequiredContacts { get; set; }
//     }

//     public class NonProfitStatus
//     {
//         public string id { get; set; }
//         public string title { get; set; }
//         public int count { get; set; }
//     }

//     public class OrganizationType
//     {
//         public string id { get; set; }
//         public string title { get; set; }
//         public int count { get; set; }
//     }

//     public class Prefixes
//     {
//         public List<Datum> data { get; set; }
//     }

//     public class Region
//     {
//         public string id { get; set; }
//         public string title { get; set; }
//         public int count { get; set; }
//     }

//     public class Relationships
//     {
//         public Clients clients { get; set; }
//         public Prefixes prefixes { get; set; }
//         public Contacts contacts { get; set; }
//         public Consortium consortium { get; set; }
//     }

//     public class Root
//     {
//         public List<Datum> data { get; set; }
//         public Meta meta { get; set; }
//         public Links links { get; set; }
//     }

//     public class Year
//     {
//         public string id { get; set; }
//         public string title { get; set; }
//         public int count { get; set; }
//     }

