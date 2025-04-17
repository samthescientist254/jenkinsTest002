using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class Card
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string embName { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string templateCode { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string country { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string primaryCard { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string auth1TrxnLimit { get; set; }

        [XmlElement("extensions")]
        public Extensions extensions { get; set; }
    }
}
