namespace TransactionDataApiSettlement.Models.XML
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class Address
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string addressType { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string location { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address1 { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address2 { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address3 { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address4 { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address5 { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string city { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string country { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mobile { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string email { get; set; }

    }
}
