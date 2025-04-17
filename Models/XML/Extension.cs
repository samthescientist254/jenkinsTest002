using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class Extension
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fieldNo { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value { get; set; }


    }
}
