using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{

    [XmlRoot(ElementName = "Person", Namespace = "http://schemas.tranzaxis.com/subjects-admin.xsd")]
    public class PersonNew
    {
        [XmlElement(ElementName = "Rid", Namespace = "http://schemas.tranzaxis.com/subjects-admin.xsd")]
        public string Rid { get; set; }
    }

    [XmlRoot(ElementName = "Subject", Namespace = "http://schemas.tranzaxis.com/tran.xsd")]
    public class Subject
    {

        [XmlElement(ElementName = "Person",Namespace = "http://schemas.tranzaxis.com/subjects-admin.xsd")]
        public PersonNew Person { get; set; }
    }

    [XmlRoot(ElementName = "Admin", Namespace = "http://schemas.tranzaxis.com/tran.xsd")]
    public class Admin
    {

        [XmlElement(ElementName = "Subject", Namespace = "http://schemas.tranzaxis.com/tran.xsd")]
        public Subject Subject { get; set; }
    }

    [XmlRoot(ElementName = "Specific", Namespace = "http://schemas.tranzaxis.com/tran.xsd")]
    public class Specific
    {

        [XmlElement(ElementName = "Admin")]
        public Admin Admin { get; set; }
    }

    [XmlRoot(ElementName = "Request", Namespace = "http://schemas.tranzaxis.com/tran.xsd")]
    public class Request
    {

        [XmlElement(ElementName = "Specific")]
        public Specific Specific { get; set; }

        [XmlAttribute(AttributeName = "InitiatorRid")]
        public string InitiatorRid { get; set; }

        [XmlAttribute(AttributeName = "ProcessorInstName")]
        public string ProcessorInstName { get; set; }

        [XmlAttribute(AttributeName = "LifePhase")]
        public string LifePhase { get; set; }

        [XmlAttribute(AttributeName = "Kind")]
        public string Kind { get; set; }

        [XmlAttribute(AttributeName = "CategoryText")]
        public string CategoryText { get; set; }


    }

    [XmlRoot(ElementName = "Tran")]
    public class Tran
    {

        [XmlElement(ElementName = "Request", Namespace = "http://schemas.tranzaxis.com/tran.xsd")]
        public Request Request { get; set; }
    }

    [XmlRoot(ElementName = "Body")]
    public class Body
    {

        [XmlElement(ElementName = "Tran", Namespace = "http://schemas.tranzaxis.com/tran.wsdl")]
        public Tran Tran { get; set; }
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/"),]
    public class CutomerValidation
    {

        [XmlElement(ElementName = "Header",Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public object Header { get; set; }

        [XmlElement(ElementName = "Body")]
        public Body Body { get; set; }

    
    }

}
