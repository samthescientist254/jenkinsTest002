using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class Customer
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string productName { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string templateCode { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maxAggcl { get; set; }
        [XmlElement("accounts")]
        public Accounts accounts { get; set; }
        [XmlElement("people")]
        public People people { get; set; }
    }
}
