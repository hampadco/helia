
using System;

public class DOICls
{
    public Datum[] data { get; set; }
    public Meta meta { get; set; }
    public Links links { get; set; }
}

public class Meta
{
    public int total { get; set; }
    public int totalPages { get; set; }
    public int page { get; set; }
    public State[] states { get; set; }
    public Resourcetype[] resourceTypes { get; set; }
    public Created[] created { get; set; }
    public Published[] published { get; set; }
    public Registered[] registered { get; set; }
    public Provider[] providers { get; set; }
    public Client[] clients { get; set; }
    public object[] affiliations { get; set; }
    public Prefix[] prefixes { get; set; }
    public object[] certificates { get; set; }
    public object[] licenses { get; set; }
    public Schemaversion[] schemaVersions { get; set; }
    public object[] linkChecksStatus { get; set; }
    public Subject[] subjects { get; set; }
    public object[] fieldsOfScience { get; set; }
    public object[] citations { get; set; }
    public object[] views { get; set; }
    public object[] downloads { get; set; }
}

public class State
{
    public string id { get; set; }
    public string title { get; set; }
    public int count { get; set; }
}

public class Resourcetype
{
    public string id { get; set; }
    public string title { get; set; }
    public int count { get; set; }
}

public class Created
{
    public string id { get; set; }
    public string title { get; set; }
    public int count { get; set; }
}

public class Published
{
    public string id { get; set; }
    public string title { get; set; }
    public int count { get; set; }
}

public class Registered
{
    public string id { get; set; }
    public string title { get; set; }
    public int count { get; set; }
}

public class Provider
{
    public string id { get; set; }
    public string title { get; set; }
    public int count { get; set; }
}

public class Client
{
    public string id { get; set; }
    public string title { get; set; }
    public int count { get; set; }
}

public class Prefix
{
    public string id { get; set; }
    public string title { get; set; }
    public int count { get; set; }
}

public class Schemaversion
{
    public string id { get; set; }
    public string title { get; set; }
    public int count { get; set; }
}

public class Subject
{
    public string id { get; set; }
    public string title { get; set; }
    public int count { get; set; }
}

public class Links
{
    public string self { get; set; }
}

public class Datum
{
    public string id { get; set; }
    public string type { get; set; }
    public Attributes attributes { get; set; }
    public Relationships relationships { get; set; }
}

public class Attributes
{
    public string doi { get; set; }
    public object[] identifiers { get; set; }
    public Creator[] creators { get; set; }
    public Title[] titles { get; set; }
    public string publisher { get; set; }
    public Container container { get; set; }
    public int publicationYear { get; set; }
    public Subject1[] subjects { get; set; }
    public object[] contributors { get; set; }
    public object[] dates { get; set; }
    public object language { get; set; }
    public Types types { get; set; }
    public Relatedidentifier[] relatedIdentifiers { get; set; }
    public object[] relatedItems { get; set; }
    public object[] sizes { get; set; }
    public object[] formats { get; set; }
    public string version { get; set; }
    public object[] rightsList { get; set; }
    public Description[] descriptions { get; set; }
    public Geolocation[] geoLocations { get; set; }
    public object[] fundingReferences { get; set; }
    public string url { get; set; }
    public object contentUrl { get; set; }
    public int metadataVersion { get; set; }
    public string schemaVersion { get; set; }
    public string source { get; set; }
    public bool isActive { get; set; }
    public string state { get; set; }
    public object reason { get; set; }
    public int viewCount { get; set; }
    public int downloadCount { get; set; }
    public int referenceCount { get; set; }
    public int citationCount { get; set; }
    public int partCount { get; set; }
    public int partOfCount { get; set; }
    public int versionCount { get; set; }
    public int versionOfCount { get; set; }
    public DateTime created { get; set; }
    public DateTime? registered { get; set; }
    public object published { get; set; }
    public DateTime updated { get; set; }
}

public class Container
{
    public string type { get; set; }
    public string title { get; set; }
    public string firstPage { get; set; }
}

public class Types
{
    public string ris { get; set; }
    public string bibtex { get; set; }
    public string citeproc { get; set; }
    public string schemaOrg { get; set; }
    public string resourceType { get; set; }
    public string resourceTypeGeneral { get; set; }
}

public class Creator
{
    public string name { get; set; }
    public string[] affiliation { get; set; }
    public object[] nameIdentifiers { get; set; }
    public string givenName { get; set; }
    public string familyName { get; set; }
    public string nameType { get; set; }
    public string lang { get; set; }
}

public class Title
{
    public string title { get; set; }
    public string lang { get; set; }
    public string titleType { get; set; }
}

public class Subject1
{
    public string lang { get; set; }
    public string subject { get; set; }
    public string valueUri { get; set; }
    public string schemeUri { get; set; }
    public string subjectScheme { get; set; }
}

public class Relatedidentifier
{
    public string relationType { get; set; }
    public string relatedIdentifier { get; set; }
    public string resourceTypeGeneral { get; set; }
    public string relatedIdentifierType { get; set; }
}

public class Description
{
    public string lang { get; set; }
    public string description { get; set; }
    public string descriptionType { get; set; }
}

public class Geolocation
{
    public Geolocationbox geoLocationBox { get; set; }
    public string geoLocationPlace { get; set; }
    public Geolocationpoint geoLocationPoint { get; set; }
}

public class Geolocationbox
{
    public string eastBoundLongitude { get; set; }
    public string northBoundLatitude { get; set; }
    public string southBoundLatitude { get; set; }
    public string westBoundLongitude { get; set; }
}

public class Geolocationpoint
{
    public string pointLatitude { get; set; }
    public string pointLongitude { get; set; }
}

public class Relationships
{
    public Client1 client { get; set; }
}

public class Client1
{
    public Data data { get; set; }
}

public class Data
{
    public string id { get; set; }
    public string type { get; set; }
}
