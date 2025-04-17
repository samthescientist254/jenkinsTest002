using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class Person
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string relationship { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string title { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lastName { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string midName { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string firstName { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string motherName { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string organization { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dob { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sex { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ssnumber { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string custIdNumber { get; set; }
        [XmlElement("addresses")]
        public Addresses addresses { get; set; }

    }
}
